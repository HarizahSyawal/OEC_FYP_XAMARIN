using Microsoft.EntityFrameworkCore;
using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Wismapi.Data;
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
            { "UpdateOnHandStock", "EXEC [spUpdateOnHandStock] {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}" },
            { "UpdateReservedStock", "EXEC [spUpdateReservedStock] {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}" },
            { "UpdateInTransitStock", "EXEC [spUpdateInTransitStock] {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}" },
            { "UpdateCustomerStatistic", "EXEC [spUpdateCustomerStatistic] {0}, {1}" },
            { "SAPInterfaceMaster", "EXEC [spSAPInterfaceMaster] {0}, {1}, {2}, {3}, {4}, {5}, {6}" },
            { "SAPInterfaceTransaction", "EXEC [spSAPInterfaceTransaction] {0}, {1}, {2}" },
            { "DeleteSalesCallChildCustomerStockRecords", "DELETE FROM [CustomerStockRecord] WHERE [SalesCallID] = {0}" },
            { "DeleteMobileActivityGrandChildCustomerStockRecords", "DELETE FROM [CustomerStockRecord] WHERE [SalesCallID] IN (SELECT [ID] FROM [SalesCall] WHERE [ActivityID] = {0})" },
            { "DeleteMobileActivityChildSalesCalls", "DELETE FROM [SalesCall] WHERE [ActivityID] = {0}" },
            { "DeleteMobileActivityChildCollectionCalls", "DELETE FROM [CollectionCall] WHERE [ActivityID] = {0}" },
            { "DeleteMobileActivityChildStockTransactions", "DELETE FROM [MobileActivityStockTransaction] WHERE [ActivityID] = {0}" }
        };

        public static readonly Dictionary<string, string> MainSqliteCommands = new Dictionary<string, string>()
        {
            { "GetAutoNumberCounter", "" },
            { "SalesOrderExt", "" },
            { "SalesOrderReturnExt", "" },
            { "SalesOrderSwapExt", "" },
            { "SalesOrderSampleExt", "" },
            { "SalesOrderFOCExt", "" },
            { "UpdateOnHandStock", "" },
            { "UpdateReservedStock", "" },
            { "UpdateInTransitStock", "" },
            { "UpdateCustomerStatistic", "" },
            { "SAPInterfaceMaster", "" },
            { "SAPInterfaceTransaction", "" },
            { "DeleteSalesCallChildCustomerStockRecords", "" },
            { "DeleteMobileActivityGrandChildCustomerStockRecords", "" },
            { "DeleteMobileActivityChildSalesCalls", "" },
            { "DeleteMobileActivityChildCollectionCalls", "" },
            { "DeleteMobileActivityChildStockTransactions", "" }
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

        public static Action<object, DbContextOptionsBuilder> ConfigureDbContext { get; set; } = null;


        public Func<vUser> DelegateGetAuthenticatedUser { get; set; } = null;
        public vUser GetAuthenticatedUser() { return DelegateGetAuthenticatedUser?.Invoke(); }



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


        public void SAPInterfaceMaster(string id, string param1, int masterTypeID) { SAPInterfaceMaster(id, null, null, param1, null, null, masterTypeID); }
        public void SAPInterfaceMaster(string id, string id2, string id3, string param1, string param2, string param3, int masterTypeID) { SAPInterfaceMasterAsync(id, id2, id3, param1, param2, param3, masterTypeID).Wait(); }
        public async Task SAPInterfaceMasterAsync(string id, string param1, int masterTypeID) { await SAPInterfaceMasterAsync(id, null, null, param1, null, null, masterTypeID); }
        public async Task SAPInterfaceMasterAsync(string id, string id2, string id3, string param1, string param2, string param3, int masterTypeID) { await Database.ExecuteSqlRawAsync(MainCommands["SAPInterfaceMaster"], id, id2, id3, param1, param2, param3, masterTypeID); }


        public void SAPInterfaceTransaction(Guid documentID, int documentStatusID, int transactionTypeID) { SAPInterfaceTransactionAsync(documentID, documentStatusID, transactionTypeID).Wait(); }
        public async Task SAPInterfaceTransactionAsync(Guid documentID, int documentStatusID, int transactionTypeID) { await Database.ExecuteSqlRawAsync(MainCommands["SAPInterfaceTransaction"], documentID, documentStatusID, transactionTypeID); }


        public void DeleteSalesCallChildCustomerStockRecords(Guid salesCallID) { DeleteSalesCallChildCustomerStockRecordsAsync(salesCallID).Wait(); }
        public async Task DeleteSalesCallChildCustomerStockRecordsAsync(Guid salesCallID) { await Database.ExecuteSqlRawAsync(MainCommands["DeleteSalesCallChildCustomerStockRecords"], salesCallID); }


        public void DeleteMobileActivityGrandChildCustomerStockRecords(Guid activityID) { DeleteMobileActivityGrandChildCustomerStockRecordsAsync(activityID).Wait(); }
        public async Task DeleteMobileActivityGrandChildCustomerStockRecordsAsync(Guid activityID) { await Database.ExecuteSqlRawAsync(MainCommands["DeleteMobileActivityGrandChildCustomerStockRecords"], activityID); }

        public void DeleteMobileActivityChildSalesCalls(Guid activityID) { DeleteMobileActivityChildSalesCallsAsync(activityID).Wait(); }
        public async Task DeleteMobileActivityChildSalesCallsAsync(Guid activityID) { await Database.ExecuteSqlRawAsync(MainCommands["DeleteMobileActivityChildSalesCalls"], activityID); }

        public void DeleteMobileActivityChildCollectionCalls(Guid activityID) { DeleteMobileActivityChildCollectionCallsAsync(activityID).Wait(); }
        public async Task DeleteMobileActivityChildCollectionCallsAsync(Guid activityID) { await Database.ExecuteSqlRawAsync(MainCommands["DeleteMobileActivityChildCollectionCalls"], activityID); }

        public void DeleteMobileActivityChildStockTransactions(Guid activityID) { DeleteMobileActivityChildStockTransactionsAsync(activityID).Wait(); }
        public async Task DeleteMobileActivityChildStockTransactionsAsync(Guid activityID) { await Database.ExecuteSqlRawAsync(MainCommands["DeleteMobileActivityChildStockTransactions"], activityID); }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ConfigureDbContext?.Invoke(this, optionsBuilder);

            base.OnConfiguring(optionsBuilder);
        }

        #endregion

    }

}
