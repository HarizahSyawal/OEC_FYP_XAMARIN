using SQLite;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Wismapi.Data.SQLiteNet
{

    public abstract class CoreDbContext : SQLiteAsyncConnection, IDisposable
    {

        #region Static Members

        public static string ConnectionString = "";

        public static string AuthenticationUserName = "";
        public static string AuthenticationPassword = "";

        #endregion

        #region Database Commands

        public static readonly Dictionary<string, string> SqlCommands = new Dictionary<string, string>()
        {
            { "Select", "SELECT @COLUMN_NAMES FROM [@TABLE_NAME] WHERE @PRIMARY_KEY_CONDITIONS" },
            { "Insert", "INSERT INTO [@TABLE_NAME] (@COLUMN_NAMES) VALUES (@VALUES)" },
            { "Update", "UPDATE [@TABLE_NAME] SET @COLUMN_SETS WHERE @PRIMARY_KEY_CONDITIONS" },
            { "Delete", "DELETE FROM [@TABLE_NAME] WHERE @PRIMARY_KEY_CONDITIONS" },
            { "GetTableNames", "SELECT [name] FROM [sqlite_master] WHERE [type] = 'table'" },
            { "DeleteAll", "DELETE FROM [@TABLE_NAME]" },
            { "GetDatabaseDateTime", "SELECT STRFTIME('%Y-%m-%d %H:%M:%f', 'now', 'localtime') [Result]" },
            { "GetDatabaseUtcDateTime", "SELECT STRFTIME('%Y-%m-%d %H:%M:%f', 'now') [Result]" },
            { "GetMinSyncDate", "SELECT MIN([SyncDate]) FROM [@TABLE_NAME]" },
            { "GetMinValue", "SELECT MIN([@COLUMN_NAME]) FROM [@TABLE_NAME] WHERE @CONDITIONS" },
            { "GetMaxValue", "SELECT MAX([@COLUMN_NAME]) FROM [@TABLE_NAME] WHERE @CONDITIONS" },
            { "GetDistinct", "SELECT DISTINCT [@COLUMN_NAME] FROM [@TABLE_NAME] WHERE @CONDITIONS" },
            { "UpdateAllSyncDate", "UPDATE [@TABLE_NAME] SET [SyncDate] = {0}, [LastSyncDate] = {0}, [LastSyncStatus] = 1, [LastSyncAttempts] = 1 WHERE ([SyncDate] IS NOT NULL) AND ([SyncDate] <> STRFTIME('%Y-%m-%d %H:%M:%f', '9999-12-31T23:59:59.997Z'))"}
        };

        #endregion

        #region Fields

        private static ConcurrentDictionary<string, object> dataTableProviders = new ConcurrentDictionary<string, object>();
        private static ConcurrentDictionary<string, object> dataSyncProviders = new ConcurrentDictionary<string, object>();

        private static ConcurrentDictionary<string, string> selectCommands = new ConcurrentDictionary<string, string>();
        private static ConcurrentDictionary<string, string> insertCommands = new ConcurrentDictionary<string, string>();
        private static ConcurrentDictionary<string, string> updateCommands = new ConcurrentDictionary<string, string>();
        private static ConcurrentDictionary<string, string> deleteCommands = new ConcurrentDictionary<string, string>();

        #endregion

        #region Constructors

        public CoreDbContext()
            : this(ConnectionString)
        {

        }

        public CoreDbContext(string connectionString)
            : base(connectionString, SQLiteOpenFlags.FullMutex | SQLiteOpenFlags.ReadWrite)
        {
            SyncMaxAttempts = 3; // Maximum attempts to sync if failed
            SyncAttemptDelay = 1000; // Delay before retry to sync if failed
        }

        #endregion

        #region Properties

        public CoreDataServiceContext DataServiceContext { get; set; }
        public int SyncMaxAttempts { get; set; }
        public int SyncAttemptDelay { get; set; }

        
        
        protected Dictionary<string, string> Commands { get { return SqlCommands; } }

        #endregion

        #region Methods

        public static void ResetAuthentication()
        {
            AuthenticationUserName = "";
            AuthenticationPassword = "";
        }

        public static void SetAuthentication(string userName, string password)
        {
            AuthenticationUserName = userName;
            AuthenticationPassword = password;
        }


        public int DeleteAll<TData>() { return DeleteAllAsync<TData>().Result; }

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

        public string GetSelectCommand<TData>()
        {
            var type = typeof(TData);

            return selectCommands.GetOrAdd(type.Name, (string key) =>
            {
                var columnNames = "";
                var primaryKeyConditions = "";

                foreach (var propertyInfo in type.GetProperties(BindingFlags.Instance | BindingFlags.Public))
                {
                    if (propertyInfo.GetCustomAttributes(typeof(SQLiteNetExt.IgnoreAttribute)).ToList().Count > 0)
                        continue;

                    if (propertyInfo.GetCustomAttributes(typeof(SQLiteNetExt.PrimaryKeyAttribute)).ToList().Count > 0)
                    {
                        if (primaryKeyConditions.Length > 0)
                            primaryKeyConditions += " AND ";

                        primaryKeyConditions += string.Format("[{0}] = ?", propertyInfo.Name);
                    }

                    if (columnNames.Length > 0)
                        columnNames += ", ";

                    columnNames += string.Format("[{0}]", propertyInfo.Name);
                }

                return Commands["Select"].Replace("@TABLE_NAME", GetTableName<TData>()).Replace("@COLUMN_NAMES", columnNames)
                    .Replace("@PRIMARY_KEY_CONDITIONS", primaryKeyConditions);
            });
        }

        public string GetInsertCommand<TData>()
        {
            var type = typeof(TData);

            return insertCommands.GetOrAdd(type.Name, (string key) =>
            {
                var columnNames = "";
                var values = "";

                foreach (var propertyInfo in type.GetProperties(BindingFlags.Instance | BindingFlags.Public))
                {
                    if (propertyInfo.GetCustomAttributes(typeof(SQLiteNetExt.IgnoreAttribute)).ToList().Count > 0)
                        continue;

                    if (columnNames.Length > 0)
                    {
                        columnNames += ", ";
                        values += ", ";
                    }

                    columnNames += string.Format("[{0}]", propertyInfo.Name);
                    values += "?";
                }

                return Commands["Insert"].Replace("@TABLE_NAME", GetTableName<TData>()).Replace("@COLUMN_NAMES", columnNames).Replace("@VALUES", values);
            });
        }

        public string GetUpdateCommand<TData>()
        {
            var type = typeof(TData);

            return updateCommands.GetOrAdd(type.Name, (string key) =>
            {
                var columnSets = "";
                var primaryKeyConditions = "";

                foreach (var propertyInfo in type.GetProperties(BindingFlags.Instance | BindingFlags.Public))
                {
                    if (propertyInfo.GetCustomAttributes(typeof(SQLiteNetExt.IgnoreAttribute)).ToList().Count > 0)
                        continue;

                    if (propertyInfo.GetCustomAttributes(typeof(SQLiteNetExt.PrimaryKeyAttribute)).ToList().Count > 0)
                    {
                        if (primaryKeyConditions.Length > 0)
                            primaryKeyConditions += " AND ";

                        primaryKeyConditions += string.Format("[{0}] = ?", propertyInfo.Name);
                    }

                    if (columnSets.Length > 0)
                        columnSets += ", ";

                    columnSets += string.Format("[{0}] = ?", propertyInfo.Name);
                }

                return Commands["Update"].Replace("@TABLE_NAME", GetTableName<TData>()).Replace("@COLUMN_SETS", columnSets).Replace("@PRIMARY_KEY_CONDITIONS", primaryKeyConditions);
            });
        }

        public string GetDeleteCommand<TData>()
        {
            var type = typeof(TData);

            return deleteCommands.GetOrAdd(type.Name, (string key) =>
            {
                var primaryKeyConditions = "";

                foreach (var propertyInfo in type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .Where(p => p.GetCustomAttributes(typeof(SQLiteNetExt.PrimaryKeyAttribute)).ToList().Count > 0).ToList())
                {
                    if (propertyInfo.GetCustomAttributes(typeof(SQLiteNetExt.IgnoreAttribute)).ToList().Count > 0)
                        continue;

                    if (primaryKeyConditions.Length > 0)
                        primaryKeyConditions += " AND ";

                    primaryKeyConditions += string.Format("[{0}] = ?", propertyInfo.Name);
                }

                return Commands["Delete"].Replace("@TABLE_NAME", GetTableName<TData>()).Replace("@PRIMARY_KEY_CONDITIONS", primaryKeyConditions);
            });
        }

        public object[] GetCommandParameters(object obj, bool includeAllParams, bool includeKeyConditions)
        {
            var parameters = new List<object>();
            var keyConditionParams = new List<object>();

            var type = obj.GetType();

            foreach (var propertyInfo in type.GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                if (propertyInfo.GetCustomAttributes(typeof(SQLiteNetExt.IgnoreAttribute)).ToList().Count > 0)
                    continue;

                var value = (propertyInfo.GetValue(obj));

                if (propertyInfo.GetCustomAttributes(typeof(SQLiteNetExt.PrimaryKeyAttribute)).ToList().Count > 0)
                    keyConditionParams.Add(value);

                if (includeAllParams)
                    parameters.Add(value);
            }

            if (includeKeyConditions && (keyConditionParams.Count > 0))
                parameters.AddRange(keyConditionParams);

            return parameters.ToArray();
        }


        public void SetSyncData<TData>(TData data, DateTime? syncDate, DateTime localSyncDate, int status, int attempts) where TData : IDataSynchronizable
        {
            if (syncDate.HasValue && (status == 1)) // Succeeded
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


        public void DeleteAll() { DeleteAllAsync().Wait(); }

        public async Task DeleteAllAsync()
        {
            try
            {
                var tableNames = await GetTableNamesAsync();
                foreach (var tableName in tableNames)
                    await ExecuteAsync(Commands["DeleteAll"].Replace("@TABLE_NAME", tableName));
            }
            catch { }
        }


        public KeyValuePair<string, string> GetAuthenticationHeader()
        {
            var headerPrefix = "Basic ";

            return new KeyValuePair<string, string>("Authorization", headerPrefix + Convert.ToBase64String(Encoding.ASCII.GetBytes(AuthenticationUserName + ":" + AuthenticationPassword)));
        }


        public List<string> GetTableNames() { return GetTableNamesAsync().Result; }
        public async Task<List<string>> GetTableNamesAsync() { return await QueryScalarsAsync<string>(Commands["GetTableNames"]); }


        public DateTime GetDatabaseDateTime() { return GetDatabaseDateTimeAsync().Result; }        
        public async Task<DateTime> GetDatabaseDateTimeAsync() { return (await ExecuteScalarAsync<DateTime>(Commands["GetDatabaseDateTime"])); }

        public DateTime GetDatabaseUtcDateTime() { return GetDatabaseUtcDateTimeAsync().Result; }
        public async Task<DateTime> GetDatabaseUtcDateTimeAsync() { return DateTime.SpecifyKind((await ExecuteScalarAsync<DateTime>(Commands["GetDatabaseUtcDateTime"])), DateTimeKind.Utc); }


        public DateTime? GetMinSyncDate<TData>() { return GetMinSyncDateAsync<TData>().Result; }
        public async Task<DateTime?> GetMinSyncDateAsync<TData>() { return await ExecuteScalarAsync<DateTime?>(Commands["GetMinSyncDate"].Replace("@TABLE_NAME", GetTableName<TData>())); }

        public TValue GetMinValue<TData, TValue>(string columnName, string conditions) { return GetMinValueAsync<TData, TValue>(columnName, conditions).Result; }
        public async Task<TValue> GetMinValueAsync<TData, TValue>(string columnName, string conditions) { return await ExecuteScalarAsync<TValue>(Commands["GetMinValue"].Replace("@TABLE_NAME", GetTableName<TData>()).Replace("@COLUMN_NAME", columnName).Replace("@CONDITIONS", conditions)); }

        public TValue GetMaxValue<TData, TValue>(string columnName, string conditions) { return GetMaxValueAsync<TData, TValue>(columnName, conditions).Result; }
        public async Task<TValue> GetMaxValueAsync<TData, TValue>(string columnName, string conditions) { return await ExecuteScalarAsync<TValue>(Commands["GetMaxValue"].Replace("@TABLE_NAME", GetTableName<TData>()).Replace("@COLUMN_NAME", columnName).Replace("@CONDITIONS", conditions)); }

        public List<TValue> GetDistinct<TData, TValue>(string columnName, string conditions) { return GetDistinctAsync<TData, TValue>(columnName, conditions).Result; }
        public async Task<List<TValue>> GetDistinctAsync<TData, TValue>(string columnName, string conditions) { return await QueryScalarsAsync<TValue>(Commands["GetDistinct"].Replace("@TABLE_NAME", GetTableName<TData>()).Replace("@COLUMN_NAME", columnName).Replace("@CONDITIONS", conditions)); }


        public int UpdateAllSyncDate<TData>(DateTime syncDate) { return UpdateAllSyncDateAsync<TData>(syncDate).Result; }

        public async Task<int> UpdateAllSyncDateAsync<TData>(DateTime syncDate)
        {
            var status = 0;

            try
            {
                await ExecuteAsync(Commands["UpdateAllSyncDate"].Replace("@TABLE_NAME", GetTableName<TData>()), syncDate);

                status = 1;
            }
            catch { }

            return status;
        }



        protected string GetTableName<TData>()
        {
            var tableAttr = (TableAttribute)(typeof(TData).GetCustomAttributes(typeof(TableAttribute), true).FirstOrDefault());

            return (tableAttr != null) ? tableAttr.Name : nameof(TData);
        }

        #endregion

        #region Implements IDisposable

        public void Dispose()
        {
            CloseAsync();
            GC.SuppressFinalize(this);
        }

        #endregion

    }

}
