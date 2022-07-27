/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{

    public partial class mvCustomerHistoricalSyncProvider : DataSyncProvider<mvCustomerHistorical>
    {

        #region Properties

        public static string Selector = "CustomerID, PeriodDateID, QtyConvL, QtyConvM, QtyConvS, Qty, CreateDate, CreatedByUserID";

        #endregion

        #region Methods

        private async Task<Expression<Func<mvCustomerHistorical, bool>>> GetFilter()
        {
            var costumerIDs = (await DbContext.GetDataTableProvider<mvCostumerTableProvider>().GetData().ToListAsync()).Select(p => p.ID).ToList();
            var productIDs = (await DbContext.GetDataTableProvider<mvProductTableProvider>().GetData().ToListAsync()).Select(p => p.ID).ToList();

            Expression filter = null;
            var type = typeof(mvCustomerHistorical);
            var param = Expression.Parameter(type, "param");

            var propCostumerID = Expression.Property(param, "CostumerID");
            foreach (var id in costumerIDs)
            {
                var expr = Expression.MakeBinary(ExpressionType.Equal, propCostumerID, Expression.Constant(id, type.GetProperty("CostumerID").PropertyType));
                filter = (filter == null) ? expr : Expression.MakeBinary(ExpressionType.Or, filter, expr);
            }

            var propProductID = Expression.Property(param, "ProductID");
            foreach (var id in productIDs)
            {
                var expr = Expression.MakeBinary(ExpressionType.Equal, propProductID, Expression.Constant(id, type.GetProperty("ProductID").PropertyType));
                filter = (filter == null) ? expr : Expression.MakeBinary(ExpressionType.Or, filter, expr);
            }

            var propCreatedByUserID = Expression.Property(param, "CreatedByUserID");
            var addExpr = Expression.MakeBinary(ExpressionType.Equal, propCreatedByUserID, Expression.Constant(1, type.GetProperty("CreatedByUserID").PropertyType)); // Active
            filter = (filter == null) ? addExpr : Expression.MakeBinary(ExpressionType.And, filter, addExpr);

            return Expression.Lambda<Func<mvCustomerHistorical, bool>>(filter, param);
        }



        protected override Exception OnDownloadAllData(bool continueOnError) { return OnDownloadAllDataAsync(continueOnError).Result; }
        protected override Exception OnUploadAllData(bool continueOnError) { return OnUploadAllDataAsync(continueOnError).Result; }
        protected override Exception OnDownloadData(mvCustomerHistorical obj, bool useTransaction) { return OnDownloadDataAsync(obj, useTransaction).Result; }
        protected override Exception OnUploadData(mvCustomerHistorical obj, bool useTransaction) { return OnUploadDataAsync(obj, useTransaction).Result; }


        protected override async Task<Exception> OnDownloadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var customerHistoricalTableProvider = DbContext.GetDataTableProvider<mvCustomerHistoricalTableProvider>();
            var customerHistoricalServiceProvider = DataServiceContext.GetDataServiceProvider<mvCustomerHistoricalServiceProvider>();

            DateTime? syncDate = null;

            List<mvCustomerHistorical> serverDataList = null;

            var minSyncDate = (DateTimeOffset?)await DbContext.GetMinSyncDateAsync<mvCustomerHistorical>();

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    var serverCustomerIDs = customerHistoricalServiceProvider.GetData().AddQueryOption("$select", "ID").Where(await GetFilter()).ToList().Select(p => p.ID).ToList();
                    await ValidateServerAndLocalData(serverCustomerIDs);

                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    var query = customerHistoricalServiceProvider.GetData().AddQueryOption("$select", Selector).Where(await GetFilter());

                    if (minSyncDate.HasValue)
                        query = query.Where(p => (p.CreatedDate > minSyncDate.Value) || ((p.ModifiedDate != null) && (p.ModifiedDate.Value > minSyncDate.Value)));

                    serverDataList = query.ToList();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) exception = ex;
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            if (serverDataList != null)
            {
                if (serverDataList.Count > 0)
                {
                    var salesmans = await DbContext.GetDataTableProvider<mvCostumerTableProvider>().GetData().ToListAsync();
                    var collectors = await DbContext.GetDataTableProvider<mvCollectorTableProvider>().GetData().ToListAsync();

                    int index = 0;
                    foreach (var serverData in serverDataList)
                    {
                        try
                        {
                            var customer = customers.Where(p => p.ID.Equals(serverData.CustomerID)).SingleOrDefault();
                            var product = products.Where(p => p.ID.Equals(serverData.ProductID)).SingleOrDefault();

                            AssignFromLocalData(serverData, customer, product);

                            await ProcessLocalData(syncDate, 1, 1, serverData, null, customerHistoricalTableProvider, true);
                        }
                        catch (Exception ex)
                        {
                            if (!continueOnError)
                            {
                                exception = ex;
                                break;
                            }
                        }

                        index++;
                    }
                }

                await DbContext.UpdateAllSyncDateAsync<mvCustomer>(syncDate.Value);
            }

            return exception;
        }

        protected override async Task<Exception> OnUploadAllDataAsync(bool continueOnError)
        {
            var mobileDbContext = (MobileDbContext)DbContext;

            Exception exception = null;

            var customerHistoricalTableProvider = DbContext.GetDataTableProvider<mvCustomerTableProvider>();
            var customerServiceProvider = DataServiceContext.GetDataServiceProvider<mvCustomerServiceProvider>();

            var localDataList = await customerHistoricalTableProvider.GetData().Where(p => (p.SyncDate == null) && !p.IsDeleted).ToListAsync();

            int index = 0;
            foreach (var obj in localDataList)
            {
                DateTime? syncDate = null;
                var lastStatus = 1;
                var lastAttempts = 0;

                var serverData = new mvCustomerHistorical();
                serverData.CopyFrom(obj);

                var filePaths = new Dictionary<string, string>();
                await PreUploadProcessServerData(serverData, filePaths);

                if (serverData.SyncDate == null)
                    serverData.Code = "";

                for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
                {
                    try
                    {
                        if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                        lastAttempts++;

                        await customerServiceProvider.InsertDataAsync(serverData, true);

                        syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                        break;
                    }
                    catch (Exception ex)
                    {
                        if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; lastStatus = 0; }
                        else await Task.Delay(DbContext.SyncAttemptDelay);
                    }
                }

                await ProcessLocalData(syncDate, lastStatus, lastAttempts, serverData, obj, customerHistoricalTableProvider, true);

                if ((lastStatus == 1) && (filePaths.Count > 0))
                    mobileDbContext.RaiseDataFileUpload(new MobileDataFileEventArgs(serverData, filePaths));

                if ((lastStatus != 1) && !continueOnError)
                    break;

                index++;
            }

            return exception;
        }


        protected override async Task<Exception> OnDownloadDataAsync(mvCustomerHistorical obj, bool useTransaction)
        {
            Exception exception = null;

            var customerTableProvider = DbContext.GetDataTableProvider<mvCustomerTableProvider>();
            var customerServiceProvider = DataServiceContext.GetDataServiceProvider<mvCustomerServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            mvCustomer serverData = null;

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    serverData = customerServiceProvider.GetData().AddQueryOption("$select", Selector)
                        .Where(p => p.ID.Equals(obj.ID)).SingleOrDefault();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            if (serverData != null)
            {
                var salesman = await DbContext.GetDataTableProvider<mvCostumerTableProvider>().GetDataAsync(serverData.SalesmanID);
                var collector = (serverData.CollectorID.HasValue) ? await DbContext.GetDataTableProvider<mvCollectorTableProvider>().GetDataAsync(serverData.CollectorID) : null;

                AssignFromLocalData(serverData, salesman, collector);
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, customerTableProvider, useTransaction);

            return exception;
        }

        protected override async Task<Exception> OnUploadDataAsync(mvCustomerHistorical obj, bool useTransaction)
        {
            var mobileDbContext = (MobileDbContext)DbContext;

            Exception exception = null;

            var customerTableProvider = DbContext.GetDataTableProvider<mvCustomerTableProvider>();
            var customerServiceProvider = DataServiceContext.GetDataServiceProvider<mvCustomerServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            var serverData = new mvCustomer();
            serverData.CopyFrom(obj);

            var filePaths = new Dictionary<string, string>();
            await PreUploadProcessServerData(serverData, filePaths);

            if (serverData.SyncDate == null)
                serverData.Code = "";

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                    attempts++;

                    await customerServiceProvider.InsertDataAsync(serverData, useTransaction);

                    syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, customerTableProvider, useTransaction);

            if ((status == 1) && (filePaths.Count > 0))
                mobileDbContext.RaiseDataFileUpload(new MobileDataFileEventArgs(serverData, filePaths));

            return exception;
        }



        private async Task ProcessLocalData(DateTime? syncDate, int status, int attempts, mvCustomer serverData, mvCustomer obj,
            mvCustomerTableProvider tableProvider, bool useTransaction)
        {
            var localDate = (syncDate.HasValue) ? syncDate.Value : await DbContext.GetDatabaseUtcDateTimeAsync();
            mvCustomer customer = null;

            if (serverData == null)
            {
                customer = new mvCustomer();
                customer.ID = obj.ID;

                await tableProvider.DeleteDataAsync(customer, useTransaction);
            }
            else
            {
                var isInsert = false;
                var isDelete = false;
                customer = await tableProvider.GetDataAsync(serverData.ID);
                if (customer == null)
                {
                    isInsert = true;
                    customer = new mvCustomer();
                }
                else if (customer.IsDeleted)
                    isDelete = true;

                customer.CopyFrom(serverData);
                DbContext.SetSyncData(customer, syncDate, localDate, status, attempts);

                if (isInsert)
                {
                    await tableProvider.InsertDataAsync(customer, useTransaction);

                    await PostProcessLocalData(customer, syncDate, false, useTransaction);
                }
                else if (isDelete)
                {
                    await tableProvider.DeleteDataAsync(customer, useTransaction);

                    await PostProcessLocalData(customer, syncDate, true, useTransaction);
                }
                else
                {
                    await tableProvider.UpdateDataAsync(customer, useTransaction);

                    await PostProcessLocalData(customer, syncDate, false, useTransaction);
                }

                if (obj != null)
                {
                    obj.CopyFrom(serverData);
                    DbContext.CopySyncData(obj, customer);
                }
            }
        }

        private void AssignFromLocalData(mvCustomer serverData, mvCustomer customer, mvProduct product)
        {
            if (customer != null)
            {
                serverData.SalesmanCode = salesman.Code;
          
            }

            if (collector != null)
            {
                serverData.CollectorCode = collector.Code;
         
            }
        }

        private async Task ValidateServerAndLocalData(List<Guid> serverCustomerIDs)
        {
            var customerTableProvider = DbContext.GetDataTableProvider<mvCustomerTableProvider>();
            var salesRoutePlanTableProvider = DbContext.GetDataTableProvider<mvSalesRoutePlanTableProvider>();
            var collectionRoutePlanTableProvider = DbContext.GetDataTableProvider<mvCollectionRoutePlanTableProvider>();

            var localCustomerIDs = await customerTableProvider.GetData().Where(p => (p.StatusID == 1)).ToListAsync(); // Active
            foreach (var customer in localCustomerIDs)
            {
                if (!serverCustomerIDs.Contains(customer.ID))
                {
                    await customerTableProvider.DeleteDataAsync(customer, true);

                    var localSalesRoutePlan = await salesRoutePlanTableProvider.GetDataAsync(customer.ID);
                    if (localSalesRoutePlan != null)
                        await salesRoutePlanTableProvider.DeleteDataAsync(localSalesRoutePlan, true);

                    var localCollectionRoutePlan = await collectionRoutePlanTableProvider.GetDataAsync(customer.ID);
                    if (localCollectionRoutePlan != null)
                        await collectionRoutePlanTableProvider.DeleteDataAsync(localCollectionRoutePlan, true);
                }
            }
        }

        private async Task PreUploadProcessServerData(mvCustomer serverData, Dictionary<string, string> filePaths)
        {
            if (!string.IsNullOrEmpty(serverData.Photo) && serverData.Photo.StartsWith("LOCAL:"))
            {
                var filePath = serverData.Photo.Replace("LOCAL:", "");
                serverData.Photo = MobileDataUtility.GetFileName(filePath);

                filePaths.Add("Photo", filePath);
            }

            if (!string.IsNullOrEmpty(serverData.NOOPhoto) && serverData.NOOPhoto.StartsWith("LOCAL:"))
            {
                var filePath = serverData.NOOPhoto.Replace("LOCAL:", "");
                serverData.NOOPhoto = MobileDataUtility.GetFileName(filePath);

                filePaths.Add("NOOPhoto", filePath);
            }

            if (!string.IsNullOrEmpty(serverData.ClosedPhoto) && serverData.ClosedPhoto.StartsWith("LOCAL:"))
            {
                var filePath = serverData.ClosedPhoto.Replace("LOCAL:", "");
                serverData.ClosedPhoto = MobileDataUtility.GetFileName(filePath);

                filePaths.Add("ClosedPhoto", filePath);
            }

            await Task.CompletedTask;
        }

        private async Task<Exception> PostProcessLocalData(mvCustomer serverData, DateTime? syncDate, bool isDelete, bool useTransaction)
        {
            Exception exception = null;

            if (serverData != null)
            {
                var salesRoutePlanTableProvider = DbContext.GetDataTableProvider<mvSalesRoutePlanTableProvider>();
                var deletedSalesRoutePlan = await salesRoutePlanTableProvider.GetDataAsync(serverData.ID);

                try
                {
                    if (deletedSalesRoutePlan != null)
                        await salesRoutePlanTableProvider.DeleteDataAsync(deletedSalesRoutePlan, useTransaction);

                    var salesRoutePlan = new mvSalesRoutePlan();

                    salesRoutePlan.CustomerID = serverData.ID;
                 

                    salesRoutePlan.SyncDate = syncDate;

                    if (!isDelete)
                        await salesRoutePlanTableProvider.InsertDataAsync(salesRoutePlan, useTransaction);
                }
                catch (Exception ex)
                {
                    exception = ex;
                }
            }

            return exception;
        }

        #endregion

    }

}
*/