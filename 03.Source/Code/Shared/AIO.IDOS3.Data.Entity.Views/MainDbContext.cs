using Microsoft.EntityFrameworkCore;
using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{

    public class MainDbContext : CoreDbContext
    {

        #region Database Specific Commands

        public static readonly Dictionary<string, string> MainSqlServerCommands = new Dictionary<string, string>()
        {
            { "GetAutoNumberCounter", "EXEC [spGetAutoNumberCounter] {0}, {1}" },
            { "SalesOrderExt", "EXEC [spSalesOrderExt] {0}" },
            { "SalesOrderReturnExt", "EXEC [spSalesOrderReturnExt] {0}" },
            { "SalesOrderSwapExt", "EXEC [spSalesOrderSwapExt] {0}" },
            { "SalesOrderSampleExt", "EXEC [spSalesOrderSampleExt] {0}" },
            { "SalesOrderFOCExt", "EXEC [spSalesOrderFOCExt] {0}" },
            { "UpdateCustomerStatistic", "EXEC [spUpdateCustomerStatistic] {0}, {1}" },
            { "SAPInterfaceTransaction", "EXEC [spSAPInterfaceTransaction] {0}, {1}, {2}" }
        };

        public static readonly Dictionary<string, string> MainSqliteCommands = new Dictionary<string, string>()
        {
            { "GetAutoNumberCounter", "" },
            { "SalesOrderExt", "" },
            { "SalesOrderReturnExt", "" },
            { "SalesOrderSwapExt", "" },
            { "SalesOrderSampleExt", "" },
            { "SalesOrderFOCExt", "" },
            { "UpdateCustomerStatistic", "" },
            { "SAPInterfaceTransaction", "" }
        };

        #endregion

        #region Fields

        private static IEdmModel edmModel = null;

        #endregion

        #region Constructors

        public MainDbContext()
            : this(new DbContextOptionsBuilder<MainDbContext>().Options)
        {

        }

        public MainDbContext(DbContextOptions<MainDbContext> options)
            : this((DbContextOptions)options)
        {

        }



        protected MainDbContext(DbContextOptions options)
            : base(options)
        {
            Database.SetCommandTimeout(300);
        }

        #endregion

        #region Properties

        public static IEdmModel EdmModel { get { return GetEdmModel<MainDbContext>(ref edmModel); } }



        protected Dictionary<string, string> MainCommands
        {
            get
            {
                if (IsSqlite()) return MainSqliteCommands;

                return MainSqlServerCommands;
            }
        }

        #endregion

        #region Methods

        public int GetAutoNumberCounter(Guid siteID, int typeID) { return GetAutoNumberCounterAsync(siteID, typeID).Result; }
        public async Task<int> GetAutoNumberCounterAsync(Guid siteID, int typeID) { return (await DbCommandInts.FromSqlRaw(MainCommands["GetAutoNumberCounter"], siteID, typeID).ToListAsync())[0].Result; }


        public void SalesOrderExt(Guid documentID) { SalesOrderExtAsync(documentID).Wait(); }
        public async Task SalesOrderExtAsync(Guid documentID) { await Database.ExecuteSqlRawAsync(MainCommands["SalesOrderExt"], documentID); }

        public void SalesOrderReturnExt(Guid documentID) { SalesOrderReturnExtAsync(documentID).Wait(); }
        public async Task SalesOrderReturnExtAsync(Guid documentID) { await Database.ExecuteSqlRawAsync(MainCommands["SalesOrderReturnExt"], documentID); }

        public void SalesOrderSwapExt(Guid documentID) { SalesOrderSwapExtAsync(documentID).Wait(); }
        public async Task SalesOrderSwapExtAsync(Guid documentID) { await Database.ExecuteSqlRawAsync(MainCommands["SalesOrderSwapExt"], documentID); }

        public void SalesOrderSampleExt(Guid documentID) { SalesOrderSampleExtAsync(documentID).Wait(); }
        public async Task SalesOrderSampleExtAsync(Guid documentID) { await Database.ExecuteSqlRawAsync(MainCommands["SalesOrderSampleExt"], documentID); }

        public void SalesOrderFOCExt(Guid documentID) { SalesOrderFOCExtAsync(documentID).Wait(); }
        public async Task SalesOrderFOCExtAsync(Guid documentID) { await Database.ExecuteSqlRawAsync(MainCommands["SalesOrderFOCExt"], documentID); }


        public void UpdateCustomerStatistic(Guid customerID, int transactionTypeID) { UpdateCustomerStatisticAsync(customerID, transactionTypeID).Wait(); }
        public async Task UpdateCustomerStatisticAsync(Guid customerID, int transactionTypeID) { await Database.ExecuteSqlRawAsync(MainCommands["UpdateCustomerStatistic"], customerID, transactionTypeID); }


        public void SAPInterfaceTransaction(Guid documentID, int documentStatusID, int transactionTypeID) { SAPInterfaceTransactionAsync(documentID, documentStatusID, transactionTypeID).Wait(); }
        public async Task SAPInterfaceTransactionAsync(Guid documentID, int documentStatusID, int transactionTypeID) { await Database.ExecuteSqlRawAsync(MainCommands["SAPInterfaceTransaction"], documentID, documentStatusID, transactionTypeID); }

        #endregion

    }

}
