// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 07:11:04
// Description   : mvSalesOrderSyncProvider partial class.
//
// Modified by   :
// Modified date :
// Comments      :
//
// NOTE: This file is initially generated by system and can be modified following
//       the requirement.
// ===================================================================================

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public partial class mvSalesOrderSyncProvider : DataSyncProvider<mvSalesOrder>
    {

        #region Fields

        public static string Selector = "DocumentID,DocumentCode,TransactionDate,PODocumentID,PODocumentCode,POTransactionDate,SalesmanID,SalesmanCode,SalesmanName,Salesman,WarehouseID,WarehouseCode,WarehouseName,Warehouse,SiteID,AreaID,RegionID,TerritoryID,CompanyID,CustomerID,CustomerCode,CustomerName,Customer,PriceGroupID,PriceGroupName,DiscountGroupID,DiscountGroupCode,DiscountGroupName,DiscountGroup,DiscountGroupDescription,TermOfPaymentID,TermOfPaymentName,ReferenceNumber,DODocumentID,DODocumentCode,DOTransactionDate,DOShipmentDate,DODeliveredDate,DOPrintCount,DOLastPrintedDate,InvoiceDocumentID,InvoiceDocumentCode,RawTotalGrossPrice,RawTotalPrice,RawTotalDiscountStrata1Amount,RawTotalDiscountStrata2Amount,RawTotalDiscountStrata3Amount,RawTotalDiscountStrata4Amount,RawTotalDiscountStrata5Amount  ,RawTotalSpecialDiscountStrata1Amount,RawTotalSpecialDiscountStrata2Amount,RawTotalSpecialDiscountStrata3Amount,RawTotalSpecialDiscountStrata4Amount,RawTotalSpecialDiscountStrata5Amount,RawTotalAddDiscountStrataAmount,RawTotalGrossAmount,RawTotalTaxAmount,RawTotalAmount,TotalGrossPrice,TotalPrice,TotalDiscountStrata1Amount,TotalDiscountStrata2Amount,TotalDiscountStrata3Amount,TotalDiscountStrata4Amount,TotalDiscountStrata5Amount,TotalSpecialDiscountStrata1Amount,TotalSpecialDiscountStrata2Amount,TotalSpecialDiscountStrata3Amount,TotalSpecialDiscountStrata4Amount,TotalSpecialDiscountStrata5Amount,TotalAddDiscountStrataAmount,TotalGrossAmount,TotalTaxAmount,TotalAmount,TotalWeight,TotalDimension,AddDiscountStrataReason,PrintCount,LastPrintedDate,DocumentStatusID,DocumentStatusName,MobileDocumentCode,PostedDate,CreatedDate,ModifiedDate,ChildSummaries";
        public static string Expand = "ChildSummaries($expand=ChildDetails)";

        #endregion

        #region Methods

        private async Task<Expression<Func<mvSalesOrder, bool>>> GetFilter()
        {
            var warehouseIDs = await DbContext.GetDataTableProvider<mvWarehouseTableProvider>().GetData().Where(p => (p.TypeID == 2)).Select(p => p.ID).ToListAsync();

            Expression filter = null;
            var type = typeof(mvSalesOrder);
            var param = Expression.Parameter(type, "param");

            var propWarehouseID = Expression.Property(param, "WarehouseID");
            foreach (var id in warehouseIDs)
            {
                var expr = Expression.MakeBinary(ExpressionType.Equal, propWarehouseID, Expression.Constant(id, type.GetProperty("WarehouseID").PropertyType));
                filter = (filter == null) ? expr : Expression.MakeBinary(ExpressionType.Or, filter, expr);
            }

            return Expression.Lambda<Func<mvSalesOrder, bool>>(filter, param);
        }



        protected override Exception OnDownloadAllData(bool continueOnError) { return OnDownloadAllDataAsync(continueOnError).Result; }
        protected override Exception OnUploadAllData(bool continueOnError) { return OnUploadAllDataAsync(continueOnError).Result; }
        protected override Exception OnDownloadData(mvSalesOrder obj, bool useTransaction) { return OnDownloadDataAsync(obj, useTransaction).Result; }
        protected override Exception OnUploadData(mvSalesOrder obj, bool useTransaction) { return OnUploadDataAsync(obj, useTransaction).Result; }


        protected override async Task<Exception> OnDownloadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var salesOrderTableProvider = DbContext.GetDataTableProvider<mvSalesOrderTableProvider>();
            var salesOrderServiceProvider = DataServiceContext.GetDataServiceProvider<mvSalesOrderServiceProvider>();

            DateTime? syncDate = null;

            List<mvSalesOrder> serverDataList = null;

            var minSyncDate = (DateTimeOffset?)await salesOrderTableProvider.GetData().MinAsync(p => p.SyncDate);

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    var query = salesOrderServiceProvider.GetData().AddQueryOption("$select", Selector).AddQueryOption("$expand", Expand).Where(await GetFilter());
                                        
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
                int index = 0;
                foreach (var serverData in serverDataList)
                {
                    try
                    {
                        await ProcessLocalData(syncDate, 1, 1, serverData, null, salesOrderTableProvider, true);
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

                await DbContext.UpdateAllSyncDateAsync<mvSalesOrder>(syncDate.Value);
            }

            return exception;
        }

        protected override async Task<Exception> OnUploadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var salesOrderTableProvider = DbContext.GetDataTableProvider<mvSalesOrderTableProvider>();
            var salesOrderSummaryTableProvider = DbContext.GetDataTableProvider<mvSalesOrderSummaryTableProvider>();
            var salesOrderDetailsTableProvider = DbContext.GetDataTableProvider<mvSalesOrderDetailsTableProvider>();
            var salesOrderServiceProvider = DataServiceContext.GetDataServiceProvider<mvSalesOrderServiceProvider>();

            DateTime? syncDate = null;

            var localDataList = await salesOrderTableProvider.GetData().Where(p => (p.SyncDate == null)).Include(p => p.ChildSummaries).ThenInclude(q => q.ChildDetails).ToListAsync();

            int index = 0;
            foreach (var obj in localDataList)
            {
                var lastStatus = 1;
                var serverData = new mvSalesOrder();

                serverData.CopyFrom(obj);
                serverData.ChildSummaries = new Collection<mvSalesOrderSummary>();
                foreach (var summary in obj.ChildSummaries)
                {
                    var serverDataSummary = new mvSalesOrderSummary();
                    serverDataSummary.CopyFrom(summary);
                    serverDataSummary.ChildDetails = new Collection<mvSalesOrderDetails>();
                    if (summary.ChildDetails != null)
                    {
                        foreach (var details in summary.ChildDetails)
                        {
                            var serverDataDetails = new mvSalesOrderDetails();
                            serverDataDetails.CopyFrom(details);

                            serverDataSummary.ChildDetails.Add(serverDataDetails);
                        }
                    }

                    serverData.ChildSummaries.Add(serverDataSummary);
                }

                serverData.DocumentCode = "";

                for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
                {
                    try
                    {
                        if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                        await salesOrderServiceProvider.InsertDataAsync(serverData, true);

                        syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                        await ProcessLocalData(syncDate, 1, (i + 1), serverData, obj, salesOrderTableProvider, true);
                        break;
                    }
                    catch (Exception ex)
                    {
                        if (i == (DbContext.SyncMaxAttempts - 1))
                        {
                            exception = ex;
                            lastStatus = 0;
                            try { await ProcessLocalData(syncDate, 0, (i + 1), serverData, obj, salesOrderTableProvider, true); } catch (Exception) { }
                        }
                        else
                            await Task.Delay(DbContext.SyncAttemptDelay);
                    }
                }

                if ((lastStatus != 1) && !continueOnError)
                    break;

                index++;
            }

            return exception;
        }


        protected override async Task<Exception> OnDownloadDataAsync(mvSalesOrder obj, bool useTransaction)
        {
            Exception exception = null;

            var salesOrderTableProvider = DbContext.GetDataTableProvider<mvSalesOrderTableProvider>();
            var salesOrderServiceProvider = DataServiceContext.GetDataServiceProvider<mvSalesOrderServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            mvSalesOrder serverData = null;

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    serverData = salesOrderServiceProvider.GetData().AddQueryOption("$select", Selector).AddQueryOption("$expand", Expand)
                        .Where(p => p.DocumentID.Equals(obj.DocumentID)).SingleOrDefault();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, salesOrderTableProvider, useTransaction);

            return exception;
        }

        protected override async Task<Exception> OnUploadDataAsync(mvSalesOrder obj, bool useTransaction)
        {
            Exception exception = null;

            var salesOrderTableProvider = DbContext.GetDataTableProvider<mvSalesOrderTableProvider>();
            var salesOrderServiceProvider = DataServiceContext.GetDataServiceProvider<mvSalesOrderServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            var serverData = new mvSalesOrder();
            serverData.CopyFrom(obj);
            serverData.ChildSummaries = new Collection<mvSalesOrderSummary>();
            foreach (var summary in obj.ChildSummaries)
            {
                var serverDataSummary = new mvSalesOrderSummary();
                serverDataSummary.CopyFrom(summary);
                serverDataSummary.ChildDetails = new Collection<mvSalesOrderDetails>();
                if (summary.ChildDetails != null)
                {
                    foreach (var details in summary.ChildDetails)
                    {
                        var serverDataDetails = new mvSalesOrderDetails();
                        serverDataDetails.CopyFrom(details);

                        serverDataSummary.ChildDetails.Add(serverDataDetails);
                    }
                }

                serverData.ChildSummaries.Add(serverDataSummary);
            }

            if (serverData.SyncDate == null)
                serverData.DocumentCode = "";

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                    attempts++;

                    await salesOrderServiceProvider.InsertDataAsync(serverData, useTransaction);

                    syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, salesOrderTableProvider, useTransaction);

            return exception;
        }



        private async Task ProcessLocalData(DateTime? syncDate, int status, int attempts, mvSalesOrder serverData, mvSalesOrder obj,
            mvSalesOrderTableProvider tableProvider, bool useTransaction)
        {
            var localDate = (syncDate.HasValue) ? syncDate.Value : await DbContext.GetDatabaseUtcDateTimeAsync();
            mvSalesOrder salesOrder = null;

            if (serverData == null)
            {
                salesOrder = new mvSalesOrder();
                salesOrder.DocumentID = obj.DocumentID;

                await tableProvider.DeleteDataAsync(salesOrder, useTransaction);
            }
            else
            {
                var isInsert = false;
                salesOrder = await tableProvider.GetDataAsync(serverData.DocumentID);
                if (salesOrder == null)
                {
                    isInsert = true;
                    salesOrder = new mvSalesOrder();
                }

                salesOrder.CopyFrom(serverData);
                salesOrder.ChildSummaries = serverData.ChildSummaries;
                DbContext.SetSyncData(salesOrder, syncDate, localDate, status, attempts);

                if (isInsert)
                    await tableProvider.InsertDataAsync(salesOrder, useTransaction);
                else
                    await tableProvider.UpdateDataAsync(salesOrder, useTransaction);

                if (obj != null)
                {
                    obj.CopyFrom(serverData);
                    DbContext.CopySyncData(obj, salesOrder);
                }
            }
        }

        #endregion

    }

}
