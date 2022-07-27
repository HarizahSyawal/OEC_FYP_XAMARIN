using Microsoft.EntityFrameworkCore;
using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Wismapi.Data;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public class MobileDbContext : CoreDbContext
    {

        #region Database Specific Commands

        public static readonly Dictionary<string, string> MobileSqlServerCommands = new Dictionary<string, string>()
        {
            { "DeleteAll", "DELETE FROM [@TABLE_NAME]" }
        };

        public static readonly Dictionary<string, string> MobileSqliteCommands = new Dictionary<string, string>()
        {
            { "DeleteAll", "DELETE FROM [@TABLE_NAME]" }
        };

        #endregion

        #region Fields

        private static IEdmModel edmModel = null;

        #endregion

        #region Constructors

        public MobileDbContext()
            : this(new DbContextOptionsBuilder<MobileDbContext>().Options)
        {

        }

        public MobileDbContext(DbContextOptions<MobileDbContext> options)
            : this(options, DataServiceServiceRoot)
        {

        }

        public MobileDbContext(DbContextOptions<MobileDbContext> options, Uri serviceRoot)
            : this(options, serviceRoot, DataServiceUseEdmModelCsdl)
        {

        }

        public MobileDbContext(DbContextOptions<MobileDbContext> options, Uri serviceRoot, bool useEdmModelCsdl)
            : this((DbContextOptions)options, serviceRoot, useEdmModelCsdl)
        {

        }



        protected MobileDbContext(DbContextOptions options, Uri serviceRoot, bool useEdmModelCsdl)
            : base(options)
        {
            DataServiceContext = new MobileDataServiceContext(serviceRoot, this, useEdmModelCsdl);

            Database.SetCommandTimeout(300); // Timeout 300 seconds
        }

        #endregion

        #region Properties

        public static IEdmModel EdmModel { get { return GetEdmModel<MobileDbContext>(ref edmModel); } }


        public static Uri DataServiceServiceRoot
        {
            get { return MobileDataServiceContext.DataServiceRoot; }
            set { MobileDataServiceContext.DataServiceRoot = value; }
        }

        public static bool DataServiceUseEdmModelCsdl
        {
            get { return MobileDataServiceContext.DataServiceUseEdmModelCsdl; }
            set { MobileDataServiceContext.DataServiceUseEdmModelCsdl = value; }
        }

        public static Action<object, DbContextOptionsBuilder> ConfigureDbContext { get; set; } = null;



        protected Dictionary<string, string> MobileCommands
        {
            get
            {
                if (IsSqlite()) return MobileSqliteCommands;

                return MobileSqlServerCommands;
            }
        }

        #endregion

        #region Methods

        public int DeleteAll<TData>() { return DeleteAllAsync<TData>().Result; }

        public async Task<int> DeleteAllAsync<TData>()
        {
            var status = 0;

            try
            {
                await Database.ExecuteSqlRawAsync(MobileCommands["DeleteAll"].Replace("@TABLE_NAME", Model.FindEntityType(typeof(TData)).GetTableName()));

                status = 1;
            }
            catch { }

            return status;
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ConfigureDbContext?.Invoke(this, optionsBuilder);

            base.OnConfiguring(optionsBuilder);
        }

        #endregion

    }

}
