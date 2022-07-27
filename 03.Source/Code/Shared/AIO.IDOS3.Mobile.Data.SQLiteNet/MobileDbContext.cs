using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{

    public class MobileDbContext : CoreDbContext
    {

        #region Static Members

        private static MobileDbContext dbContext = null;
        public static MobileDbContext Current
        {
            get
            {
                if (dbContext == null)
                    dbContext = new MobileDbContext();

                return dbContext;
            }

        }

        #endregion

        #region SQLite DB Commands

        public static readonly Dictionary<string, string> MobileSqliteCommands = new Dictionary<string, string>()
        {
            { "DeleteMobileActivityGrandChildCustomerStockRecords", "DELETE FROM [vCustomerStockRecord] WHERE [SalesCallID] IN (SELECT [ID] FROM [vSalesCall] WHERE [ActivityID] = ?)" },
            { "DeleteMobileActivityChildSalesCalls", "DELETE FROM [vSalesCall] WHERE [ActivityID] = ?" },
            { "DeleteMobileActivityChildCollectionCalls", "DELETE FROM [vCollectionCall] WHERE [ActivityID] = ?" },
            { "DeleteMobileActivityChildStockTransactions", "DELETE FROM [vMobileActivityStockTransaction] WHERE [ActivityID] = ?" },
            { "DeleteMobileActivityChildSalesOrders", "DELETE FROM [vSalesOrder] WHERE [MobileActivityID] = ?" },
            { "DeleteMobileActivityChildSalesOrderReturns", "DELETE FROM [vSalesOrderReturn] WHERE [MobileActivityID] = ?" },
            { "DeleteMobileActivityChildSalesOrderSwaps", "DELETE FROM [vSalesOrderSwap] WHERE [MobileActivityID] = ?" },
            { "DeleteMobileActivityChildStockTransfers", "DELETE FROM [vStockTransfer] WHERE [MobileActivityID] = ?" },
            { "DeleteMobileActivityChildInvoices", "DELETE FROM [vInvoice] WHERE [RefMobileActivityID] = ?" },
            { "DeleteMobileActivityChildPaymentCollections", "DELETE FROM [vPaymentCollection] WHERE [MobileActivityID] = ?" },
            { "DeleteUnlinkSalesCalls", "DELETE FROM [vSalesCall] WHERE [CustomerID] NOT IN (SELECT [ID] FROM [vCustomer])" },
            { "DeleteDuplicateSalesCalls", "DELETE FROM [vSalesCall] WHERE [ID] IN (SELECT [ID] FROM [vSalesCall] [SC] INNER JOIN (SELECT [CustomerID], MAX([CheckedInTime]) [CheckedInTime] FROM [vSalesCall] GROUP BY [CustomerID] HAVING (COUNT([CustomerID]) > 1)) [vSC] ON (([SC].[CustomerID] = [vSC].[CustomerID]) AND ([SC].[CheckedInTime] <> [vSC].[CheckedInTime])))" },
            { "DeleteDuplicateCollectionCalls", "DELETE FROM [vCollectionCall] WHERE [ID] IN (SELECT [ID] FROM [vCollectionCall] [CC] INNER JOIN (SELECT [IsReferenceCustomerID], [ReferenceID], MAX([CheckedInTime]) [CheckedInTime] FROM [vCollectionCall] GROUP BY [IsReferenceCustomerID], [ReferenceID] HAVING (COUNT([ReferenceID]) > 1)) [vCC] ON (([CC].[IsReferenceCustomerID] = [vCC].[IsReferenceCustomerID]) AND ([CC].[ReferenceID] = [vCC].[ReferenceID]) AND ([CC].[CheckedInTime] <> [vCC].[CheckedInTime])))" },
            { "DeleteDuplicateUnverifyBARSInvoices", "DELETE FROM [vInvoice] WHERE [DocumentID] IN (SELECT [BARSD].[InvoiceDocumentID] FROM [vBillAndReceiptStatement] [BARS] INNER JOIN [vBillAndReceiptStatementDetails] [BARSD] ON ([BARS].[DocumentID] = [BARSD].[DocumentID]) WHERE ([BARS].[DocumentStatusID] = 1) AND ([BARSD].[InvoiceDocumentID] NOT IN (SELECT [InvoiceDocumentID] FROM [vPaymentCollectionDetails])))" }
        };

        #endregion

        #region Constructors

        public MobileDbContext()
            : this(ConnectionString)
        {

        }

        public MobileDbContext(string connectionString)
            : this(connectionString, DataServiceServiceRoot)
        {

        }

        public MobileDbContext(string connectionString, Uri serviceRoot)
            : base(connectionString)
        {
            DataServiceContext = new MobileDataServiceContext(serviceRoot, this);

            SetBusyTimeoutAsync(new TimeSpan(0, 0, 300)); // Timeout 300 seconds
        }

        #endregion

        #region Properties

        public static Uri DataServiceServiceRoot
        {
            get { return MobileDataServiceContext.DataServiceRoot; }
            set { MobileDataServiceContext.DataServiceRoot = value; }
        }

        #endregion

        #region Methods

        public static void CloseCurrentConnection()
        {
            try
            {
                if (dbContext != null)
                {
                    dbContext.Dispose();
                    dbContext = null;
                }
            }
            catch { }
        }


        public void RaiseDataFileUpload(MobileDataFileEventArgs e) { OnDataFileUpload(e); }


        public void DeleteMobileActivityGrandChildCustomerStockRecords(Guid activityID) { DeleteMobileActivityGrandChildCustomerStockRecordsAsync(activityID).Wait(); }
        public async Task DeleteMobileActivityGrandChildCustomerStockRecordsAsync(Guid activityID) { await ExecuteAsync(MobileSqliteCommands["DeleteMobileActivityGrandChildCustomerStockRecords"], activityID); }

        public void DeleteMobileActivityChildSalesCalls(Guid activityID) { DeleteMobileActivityChildSalesCallsAsync(activityID).Wait(); }
        public async Task DeleteMobileActivityChildSalesCallsAsync(Guid activityID) { await ExecuteAsync(MobileSqliteCommands["DeleteMobileActivityChildSalesCalls"], activityID); }

        public void DeleteMobileActivityChildCollectionCalls(Guid activityID) { DeleteMobileActivityChildCollectionCallsAsync(activityID).Wait(); }
        public async Task DeleteMobileActivityChildCollectionCallsAsync(Guid activityID) { await ExecuteAsync(MobileSqliteCommands["DeleteMobileActivityChildCollectionCalls"], activityID); }

        public void DeleteMobileActivityChildStockTransactions(Guid activityID) { DeleteMobileActivityChildStockTransactionsAsync(activityID).Wait(); }
        public async Task DeleteMobileActivityChildStockTransactionsAsync(Guid activityID) { await ExecuteAsync(MobileSqliteCommands["DeleteMobileActivityChildStockTransactions"], activityID); }

        public void DeleteMobileActivityChildSalesOrders(Guid activityID) { DeleteMobileActivityChildSalesOrdersAsync(activityID).Wait(); }
        public async Task DeleteMobileActivityChildSalesOrdersAsync(Guid activityID) { await ExecuteAsync(MobileSqliteCommands["DeleteMobileActivityChildSalesOrders"], activityID); }

        public void DeleteMobileActivityChildSalesOrderReturns(Guid activityID) { DeleteMobileActivityChildSalesOrderReturnsAsync(activityID).Wait(); }
        public async Task DeleteMobileActivityChildSalesOrderReturnsAsync(Guid activityID) { await ExecuteAsync(MobileSqliteCommands["DeleteMobileActivityChildSalesOrderReturns"], activityID); }

        public void DeleteMobileActivityChildSalesOrderSwaps(Guid activityID) { DeleteMobileActivityChildSalesOrderSwapsAsync(activityID).Wait(); }
        public async Task DeleteMobileActivityChildSalesOrderSwapsAsync(Guid activityID) { await ExecuteAsync(MobileSqliteCommands["DeleteMobileActivityChildSalesOrderSwaps"], activityID); }

        public void DeleteMobileActivityChildStockTransfers(Guid activityID) { DeleteMobileActivityChildStockTransfersAsync(activityID).Wait(); }
        public async Task DeleteMobileActivityChildStockTransfersAsync(Guid activityID) { await ExecuteAsync(MobileSqliteCommands["DeleteMobileActivityChildStockTransfers"], activityID); }

        public void DeleteMobileActivityChildInvoices(Guid activityID) { DeleteMobileActivityChildInvoicesAsync(activityID).Wait(); }
        public async Task DeleteMobileActivityChildInvoicesAsync(Guid activityID) { await ExecuteAsync(MobileSqliteCommands["DeleteMobileActivityChildInvoices"], activityID); }

        public void DeleteMobileActivityChildPaymentCollections(Guid activityID) { DeleteMobileActivityChildPaymentCollectionsAsync(activityID).Wait(); }
        public async Task DeleteMobileActivityChildPaymentCollectionsAsync(Guid activityID) { await ExecuteAsync(MobileSqliteCommands["DeleteMobileActivityChildPaymentCollections"], activityID); }

        public void DeleteUnlinkSalesCalls() { DeleteUnlinkSalesCallsAsync().Wait(); }
        public async Task DeleteUnlinkSalesCallsAsync() { await ExecuteAsync(MobileSqliteCommands["DeleteUnlinkSalesCalls"]); }

        public void DeleteDuplicateSalesCalls() { DeleteDuplicateSalesCallsAsync().Wait(); }
        public async Task DeleteDuplicateSalesCallsAsync() { await ExecuteAsync(MobileSqliteCommands["DeleteDuplicateSalesCalls"]); }

        public void DeleteDuplicateCollectionCalls() { DeleteDuplicateCollectionCallsAsync().Wait(); }
        public async Task DeleteDuplicateCollectionCallsAsync() { await ExecuteAsync(MobileSqliteCommands["DeleteDuplicateCollectionCalls"]); }

        public void DeleteDuplicateUnverifyBARSInvoices() { DeleteDuplicateUnverifyBARSInvoicesAsync().Wait(); }
        public async Task DeleteDuplicateUnverifyBARSInvoicesAsync() { await ExecuteAsync(MobileSqliteCommands["DeleteDuplicateUnverifyBARSInvoices"]); }



        protected virtual void OnDataFileUpload(MobileDataFileEventArgs e)
        {
            if (DataFileUpload != null)
                DataFileUpload(this, e);
        }

        #endregion

        #region Events

        public static event EventHandler<MobileDataFileEventArgs> DataFileUpload;

        #endregion

    }

}
