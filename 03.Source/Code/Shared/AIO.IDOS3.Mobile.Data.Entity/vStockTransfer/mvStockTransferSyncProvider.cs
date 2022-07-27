﻿// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 07:11:04
// Description   : mvStockTransferSyncProvider partial class.
//
// Modified by   :
// Modified date :
// Comments      :
//
// NOTE: This file is initially generated by system and can be modified following
//       the requirement.
// ===================================================================================

using AIO.IDOS3.Data.Entity;
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

    public partial class mvStockTransferSyncProvider : DataSyncProvider<mvStockTransfer>
    {

        #region Static Members

        public static int DaysToKeepHistory = 2;

        #endregion

        #region Fields

        public static string Selector = "DocumentID,DocumentCode,TransactionDate,SourceWarehouseID,SourceWarehouseCode,SourceWarehouseName,SourceWarehouse,SourceSiteID,SourceAreaID,SourceRegionID,SourceTerritoryID,SourceCompanyID,SourcePIC,DestinationWarehouseID,DestinationWarehouseCode,DestinationWarehouseName,DestinationWarehouse,DestinationSiteID,DestinationAreaID,DestinationRegionID,DestinationTerritoryID,DestinationCompanyID,DestinationPIC,ReferenceNumber,AttachmentFile,DODocumentID,DODocumentCode,DOShipmentDate,DODeliveredDate,DOPrintCount,DOLastPrintedDate,PrintCount,LastPrintedDate,DocumentStatusID,DocumentStatusName,MobileDocumentCode,PostedDate,CreatedDate,ModifiedDate,ChildSummaries";
        public static string Expand = "ChildSummaries($expand=ChildDetails)";

        #endregion

        #region Methods

        private async Task<Expression<Func<mvStockTransfer, bool>>> GetFilter()
        {
            var warehouseIDs = await DbContext.GetDataTableProvider<mvWarehouseTableProvider>().GetData().Where(p => (p.TypeID == 2)).Select(p => p.ID).ToListAsync();

            if (warehouseIDs.Count == 0)
                return (p => false);

            Expression filter = null;
            var type = typeof(mvStockTransfer);
            var param = Expression.Parameter(type, "param");

            var propSourceWarehouseID = Expression.Property(param, "SourceWarehouseID");
            foreach (var id in warehouseIDs)
            {
                var expr = Expression.MakeBinary(ExpressionType.Equal, propSourceWarehouseID, Expression.Constant(id, type.GetProperty("SourceWarehouseID").PropertyType));
                filter = (filter == null) ? expr : Expression.MakeBinary(ExpressionType.Or, filter, expr);
            }

            var propDestinationWarehouseID = Expression.Property(param, "DestinationWarehouseID");
            foreach (var id in warehouseIDs)
            {
                var expr = Expression.MakeBinary(ExpressionType.Equal, propDestinationWarehouseID, Expression.Constant(id, type.GetProperty("DestinationWarehouseID").PropertyType));
                filter = (filter == null) ? expr : Expression.MakeBinary(ExpressionType.Or, filter, expr);
            }

            return Expression.Lambda<Func<mvStockTransfer, bool>>(filter, param);
        }



        protected override Exception OnDownloadAllData(bool continueOnError) { return OnDownloadAllDataAsync(continueOnError).Result; }
        protected override Exception OnUploadAllData(bool continueOnError) { return OnUploadAllDataAsync(continueOnError).Result; }
        protected override Exception OnDownloadData(mvStockTransfer obj, bool useTransaction) { return OnDownloadDataAsync(obj, useTransaction).Result; }
        protected override Exception OnUploadData(mvStockTransfer obj, bool useTransaction) { return OnUploadDataAsync(obj, useTransaction).Result; }


        protected override async Task<Exception> OnDownloadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var stockTransferTableProvider = DbContext.GetDataTableProvider<mvStockTransferTableProvider>();
            var stockTransferServiceProvider = DataServiceContext.GetDataServiceProvider<mvStockTransferServiceProvider>();

            DateTime? syncDate = null;

            List<mvStockTransfer> serverDataList = null;

            var minTransactionDateOffset = (DateTimeOffset)DateTime.SpecifyKind(DateTime.Today.AddDays(DaysToKeepHistory * -1), DateTimeKind.Utc);

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    await PreDownloadAllData();

                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    var query = stockTransferServiceProvider.GetData().AddQueryOption("$select", Selector).AddQueryOption("$expand", Expand).Where(await GetFilter());
                                        
                    query = query.Where(p => (p.TransactionDate >= minTransactionDateOffset) || (p.DocumentStatusID == (int)MainDataUtility.StockTransferDocumentStatus.Shipment));

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
                        await ProcessLocalData(syncDate, 1, 1, serverData, null, stockTransferTableProvider, true);
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

                await DbContext.UpdateAllSyncDateAsync<mvStockTransfer>(syncDate.Value);
            }

            return exception;
        }

        protected override async Task<Exception> OnUploadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var stockTransferTableProvider = DbContext.GetDataTableProvider<mvStockTransferTableProvider>();
            var stockTransferSummaryTableProvider = DbContext.GetDataTableProvider<mvStockTransferSummaryTableProvider>();
            var stockTransferDetailsTableProvider = DbContext.GetDataTableProvider<mvStockTransferDetailsTableProvider>();
            var stockTransferServiceProvider = DataServiceContext.GetDataServiceProvider<mvStockTransferServiceProvider>();

            DateTime? syncDate = null;

            var localDataList = await stockTransferTableProvider.GetData().Where(p => (p.SyncDate == null)).Include(p => p.ChildSummaries).ThenInclude(q => q.ChildDetails).ToListAsync();

            int index = 0;
            foreach (var obj in localDataList)
            {
                obj.CopyFrom(await stockTransferTableProvider.GetDataAsync(obj.DocumentID));

                var lastStatus = 1;
                var serverData = new mvStockTransfer();

                serverData.CopyFrom(obj);
                serverData.ChildSummaries = new Collection<mvStockTransferSummary>();
                foreach (var summary in obj.ChildSummaries)
                {
                    var serverDataSummary = new mvStockTransferSummary();
                    serverDataSummary.CopyFrom(summary);
                    serverDataSummary.ChildDetails = new Collection<mvStockTransferDetails>();
                    if (summary.ChildDetails != null)
                    {
                        foreach (var details in summary.ChildDetails)
                        {
                            var serverDataDetails = new mvStockTransferDetails();
                            serverDataDetails.CopyFrom(details);

                            serverDataSummary.ChildDetails.Add(serverDataDetails);
                        }
                    }

                    serverData.ChildSummaries.Add(serverDataSummary);
                }

                if (serverData.DocumentStatusID == (int)MainDataUtility.StockTransferDocumentStatus.Draft)
                    serverData.DocumentCode = "";

                for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
                {
                    try
                    {
                        if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                        await stockTransferServiceProvider.InsertDataAsync(serverData, true);

                        syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                        await ProcessLocalData(syncDate, 1, (i + 1), serverData, obj, stockTransferTableProvider, true);
                        break;
                    }
                    catch (Exception ex)
                    {
                        if (i == (DbContext.SyncMaxAttempts - 1))
                        {
                            exception = ex;
                            lastStatus = 0;
                            try { await ProcessLocalData(syncDate, 0, (i + 1), serverData, obj, stockTransferTableProvider, true); } catch (Exception) { }
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


        protected override async Task<Exception> OnDownloadDataAsync(mvStockTransfer obj, bool useTransaction)
        {
            Exception exception = null;

            var stockTransferTableProvider = DbContext.GetDataTableProvider<mvStockTransferTableProvider>();
            var stockTransferServiceProvider = DataServiceContext.GetDataServiceProvider<mvStockTransferServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            mvStockTransfer serverData = null;

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    serverData = stockTransferServiceProvider.GetData().AddQueryOption("$select", Selector).AddQueryOption("$expand", Expand)
                        .Where(p => p.DocumentID.Equals(obj.DocumentID)).SingleOrDefault();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, stockTransferTableProvider, useTransaction);

            return exception;
        }

        protected override async Task<Exception> OnUploadDataAsync(mvStockTransfer obj, bool useTransaction)
        {
            Exception exception = null;

            var stockTransferTableProvider = DbContext.GetDataTableProvider<mvStockTransferTableProvider>();
            var stockTransferServiceProvider = DataServiceContext.GetDataServiceProvider<mvStockTransferServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            var serverData = new mvStockTransfer();
            serverData.CopyFrom(obj);
            serverData.ChildSummaries = new Collection<mvStockTransferSummary>();
            foreach (var summary in obj.ChildSummaries)
            {
                var serverDataSummary = new mvStockTransferSummary();
                serverDataSummary.CopyFrom(summary);
                serverDataSummary.ChildDetails = new Collection<mvStockTransferDetails>();
                if (summary.ChildDetails != null)
                {
                    foreach (var details in summary.ChildDetails)
                    {
                        var serverDataDetails = new mvStockTransferDetails();
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

                    await stockTransferServiceProvider.InsertDataAsync(serverData, useTransaction);

                    syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, stockTransferTableProvider, useTransaction);

            return exception;
        }



        private async Task ProcessLocalData(DateTime? syncDate, int status, int attempts, mvStockTransfer serverData, mvStockTransfer obj,
            mvStockTransferTableProvider tableProvider, bool useTransaction)
        {
            var localDate = (syncDate.HasValue) ? syncDate.Value : await DbContext.GetDatabaseUtcDateTimeAsync();
            mvStockTransfer stockTransfer = null;

            if (serverData == null)
            {
                stockTransfer = new mvStockTransfer();
                stockTransfer.DocumentID = obj.DocumentID;

                await tableProvider.DeleteDataAsync(stockTransfer, useTransaction);
            }
            else
            {
                var isInsert = false;
                stockTransfer = await tableProvider.GetDataAsync(serverData.DocumentID);
                if (stockTransfer == null)
                {
                    isInsert = true;
                    stockTransfer = new mvStockTransfer();
                }

                stockTransfer.CopyFrom(serverData);
                stockTransfer.ChildSummaries = serverData.ChildSummaries;
                DbContext.SetSyncData(stockTransfer, syncDate, localDate, status, attempts);

                if (isInsert)
                    await tableProvider.InsertDataAsync(stockTransfer, useTransaction);
                else
                    await tableProvider.UpdateDataAsync(stockTransfer, useTransaction);

                if (obj != null)
                {
                    obj.CopyFrom(serverData);
                    DbContext.CopySyncData(obj, stockTransfer);
                }
            }
        }

        private async Task<Exception> PreDownloadAllData()
        {
            Exception exception = null;

            var stockTransferTableProvider = DbContext.GetDataTableProvider<mvStockTransferTableProvider>();

            var minTransactionDate = DateTime.Today.AddDays(DaysToKeepHistory * -1).ToUniversalTime();
            var deletedDataList = await stockTransferTableProvider.GetData().Where(p => (p.SyncDate != null) &&
                (p.DocumentStatusID != (int)MainDataUtility.StockTransferDocumentStatus.Shipment) && (p.TransactionDate < minTransactionDate)).ToListAsync();

            foreach (var data in deletedDataList)
            {
                try
                {
                    await stockTransferTableProvider.DeleteDataAsync(data);
                }
                catch (Exception ex)
                {
                    exception = ex;
                    break;
                }

            }

            return exception;
        }

        #endregion

    }

}
