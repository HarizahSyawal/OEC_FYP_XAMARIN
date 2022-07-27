using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.OData.Edm;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Wismapi.Data.Entity.Common;

namespace Wismapi.Data.Entity
{

    public abstract class CoreDbContext : DbContext
    {

        #region Database Specific Commands

        public static readonly Dictionary<string, string> SqlServerCommands = new Dictionary<string, string>()
        {
            { "GetDatabaseDateTime", "SELECT GETDATE() [Result]" },
            { "GetDatabaseUtcDateTime", "SELECT GETUTCDATE() [Result]" },
            { "UpdateAllSyncDate", "UPDATE [@TABLE_NAME] SET [SyncDate] = {0}, [LastSyncDate] = {0}, [LastSyncStatus] = 1, [LastSyncAttempts] = 1 WHERE ([SyncDate] IS NOT NULL) AND ([SyncDate] <> CAST(N'9999-12-31T23:59:59.997Z' AS datetime))"}
        };

        public static readonly Dictionary<string, string> SqliteCommands = new Dictionary<string, string>()
        {
            { "GetDatabaseDateTime", "SELECT STRFTIME('%Y-%m-%d %H:%M:%f', 'now', 'localtime') [Result]" },
            { "GetDatabaseUtcDateTime", "SELECT STRFTIME('%Y-%m-%d %H:%M:%f', 'now') [Result]" },
            { "UpdateAllSyncDate", "UPDATE [@TABLE_NAME] SET [SyncDate] = {0}, [LastSyncDate] = {0}, [LastSyncStatus] = 1, [LastSyncAttempts] = 1 WHERE ([SyncDate] IS NOT NULL) AND ([SyncDate] <> STRFTIME('%Y-%m-%d %H:%M:%f', '9999-12-31T23:59:59.997Z'))"}
        };

        #endregion

        #region Fields

        private static ConcurrentDictionary<string, object> dataTableProviders = new ConcurrentDictionary<string, object>();
        private static ConcurrentDictionary<string, object> dataViewProviders = new ConcurrentDictionary<string, object>();
        private static ConcurrentDictionary<string, object> dataSyncProviders = new ConcurrentDictionary<string, object>();

        #endregion

        #region Constructors

        public CoreDbContext(DbContextOptions<CoreDbContext> options)
            : this((DbContextOptions)options)
        {

        }



        protected CoreDbContext(DbContextOptions options)
            : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            SyncMaxAttempts = 3; // Maximum attempts to sync if failed
            SyncAttemptDelay = 1000; // Delay before retry to sync if failed
        }

        #endregion

        #region Properties

        public CoreDataServiceContext DataServiceContext { get; set; }
        public int SyncMaxAttempts { get; set; }
        public int SyncAttemptDelay { get; set; }



        protected Dictionary<string, string> Commands
        {
            get
            {
                if (IsSqlite()) return SqliteCommands;

                return SqlServerCommands;
            }
        }

        #endregion

        #region Methods

        protected static IEdmModel GetEdmModel<TDbContext>(ref IEdmModel edmModel)
        {
            if (edmModel == null)
            {
                var modelBuilder = new ModelBuilder(new ConventionSet());
                modelBuilder.ApplyConfigurationsFromAssembly(typeof(TDbContext).Assembly);

                var entities = modelBuilder.Model.GetEntityTypes();
                var odataModelBuilder = EdmModelBuilder.GetConventionEdmModelBuilder(entities);

                odataModelBuilder.Function("GetDatabaseServerDateTime").Returns<string>();
                odataModelBuilder.Function("GetDatabaseServerUtcDateTime").Returns<string>();

                edmModel = odataModelBuilder.GetEdmModel();
            }

            return edmModel;
        }



        public TDataTableProvider GetDataTableProvider<TDataTableProvider>()
        {
            var type = typeof(TDataTableProvider);

            return (TDataTableProvider)(((Func<CoreDbContext, object>)dataTableProviders.GetOrAdd(type.Name, (string key) =>
            {
                var ctorInfo = type.GetConstructor(new Type[] { typeof(CoreDbContext) });
                var param = Expression.Parameter(typeof(CoreDbContext), "p");
                var creatorExpr = Expression.Lambda<Func<CoreDbContext, object>>(Expression.New(ctorInfo, new Expression[] { param }), param);

                return creatorExpr.Compile();
            }))(this));
        }

        public TDataViewProvider GetDataViewProvider<TDataViewProvider>()
        {
            var type = typeof(TDataViewProvider);

            return (TDataViewProvider)(((Func<CoreDbContext, object>)dataViewProviders.GetOrAdd(type.Name, (string key) =>
            {
                var ctorInfo = type.GetConstructor(new Type[] { typeof(CoreDbContext) });
                var param = Expression.Parameter(typeof(CoreDbContext), "p");
                var creatorExpr = Expression.Lambda<Func<CoreDbContext, object>>(Expression.New(ctorInfo, new Expression[] { param }), param);

                return creatorExpr.Compile();
            }))(this));
        }

        public TDataSyncProvider GetDataSyncProvider<TDataSyncProvider>()
        {
            var type = typeof(TDataSyncProvider);

            return (TDataSyncProvider)(((Func<CoreDbContext, CoreDataServiceContext, object>)dataSyncProviders.GetOrAdd(type.Name, (string key) =>
            {
                var ctorInfo = type.GetConstructor(new Type[] { typeof(CoreDbContext), typeof(CoreDataServiceContext) });
                var paramCoreDbContext = Expression.Parameter(typeof(CoreDbContext), "p");
                var paramDataServiceContext = Expression.Parameter(typeof(CoreDataServiceContext), "q");
                var creatorExpr = Expression.Lambda<Func<CoreDbContext, CoreDataServiceContext, object>>(
                    Expression.New(ctorInfo, new Expression[] { paramCoreDbContext, paramDataServiceContext }), paramCoreDbContext, paramDataServiceContext);

                return creatorExpr.Compile();
            }))(this, DataServiceContext));
        }


        public void SetSyncData<TData>(TData data, DateTime? syncDate, DateTime localSyncDate, int status, int attempts) where TData : IDataSynchronizable
        {
            if (syncDate.HasValue && (status == 1))
                data.SyncDate = syncDate;

            data.LastSyncDate = localSyncDate;
            data.LastSyncStatus = status;
            data.LastSyncAttempts = attempts;
        }

        public void CopySyncData(IDataSynchronizable target, IDataSynchronizable source)
        {
            target.SyncDate = source.SyncDate;
            target.LastSyncDate = source.LastSyncDate;
            target.LastSyncStatus = source.LastSyncStatus;
            target.LastSyncAttempts = source.LastSyncAttempts;
        }

        public int UpdateAllSyncDate<TData>(DateTime syncDate) { return UpdateAllSyncDateAsync<TData>(syncDate).Result; }

        public async Task<int> UpdateAllSyncDateAsync<TData>(DateTime syncDate)
        {
            var status = 0;

            try
            {
                await Database.ExecuteSqlRawAsync(Commands["UpdateAllSyncDate"].Replace("@TABLE_NAME", Model.FindEntityType(typeof(TData)).GetTableName()), syncDate);

                status = 1;
            }
            catch { }

            return status;
        }


        public DbSet<DbCommandInt> DbCommandInts { get; set; }

        public DbSet<DbCommandDateTime> DbCommandDateTimes { get; set; }
        public DateTime GetDatabaseDateTime() { return GetDatabaseDateTimeAsync().Result; }
        public DateTime GetDatabaseUtcDateTime() { return GetDatabaseUtcDateTimeAsync().Result; }
        public async Task<DateTime> GetDatabaseDateTimeAsync() { return (await DbCommandDateTimes.FromSqlRaw(Commands["GetDatabaseDateTime"]).SingleAsync()).Result; }
        public async Task<DateTime> GetDatabaseUtcDateTimeAsync() { return DateTime.SpecifyKind((await DbCommandDateTimes.FromSqlRaw(Commands["GetDatabaseUtcDateTime"]).SingleAsync()).Result, DateTimeKind.Utc); }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CoreDbContext).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            base.OnModelCreating(modelBuilder);
        }



        protected bool IsSqlServer() { return (Database.ProviderName == "SqlConnection"); }
        protected bool IsSqlite() { return (Database.ProviderName == "SqliteConnection"); }

        #endregion

    }

}
