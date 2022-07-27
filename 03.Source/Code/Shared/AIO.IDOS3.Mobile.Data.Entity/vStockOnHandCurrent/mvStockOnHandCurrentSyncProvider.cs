﻿// ===================================================================================
// Author        : System
// Created date  : 03 Sep 2020 04:13:38
// Description   : mvStockOnHandCurrentSyncProvider partial class.
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
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public partial class mvStockOnHandCurrentSyncProvider : DataSyncProvider<mvStockOnHandCurrent>
    {

        #region Properties
        
        public static string Selector = "ID,WarehouseID,ProductID,ProductLotID,QtyOnHandGood,QtyOnHandHold,QtyOnHandBad,QtyReservedGood,QtyReservedHold,QtyReservedBad,QtyInTransitGood,QtyInTransitHold,QtyInTransitBad,ExtendProductLot";
        public static string Expand = "ExtendProductLot($select=" + mvProductLotSyncProvider.Selector + ")";

        #endregion

        #region Methods

        private async Task<Expression<Func<mvStockOnHandCurrent, bool>>> GetFilter()
        {
            var warehouseIDs = await DbContext.GetDataTableProvider<mvSalesmanTableProvider>().GetData().Select(p => p.WarehouseID).ToListAsync();

            Expression filter = null;
            var type = typeof(mvStockOnHandCurrent);
            var param = Expression.Parameter(type, "param");

            var propWarehouseID = Expression.Property(param, "WarehouseID");
            foreach (var id in warehouseIDs)
            {
                var expr = Expression.MakeBinary(ExpressionType.Equal, propWarehouseID, Expression.Constant(id, type.GetProperty("WarehouseID").PropertyType));
                filter = (filter == null) ? expr : Expression.MakeBinary(ExpressionType.Or, filter, expr);
            }

            return Expression.Lambda<Func<mvStockOnHandCurrent, bool>>(filter, param);
        }
        
        
        
        protected override Exception OnDownloadAllData(bool continueOnError) { return OnDownloadAllDataAsync(continueOnError).Result; }
        protected override Exception OnUploadAllData(bool continueOnError) { return OnUploadAllDataAsync(continueOnError).Result; }
        protected override Exception OnDownloadData(mvStockOnHandCurrent obj, bool useTransaction) { return OnDownloadDataAsync(obj, useTransaction).Result; }
        protected override Exception OnUploadData(mvStockOnHandCurrent obj, bool useTransaction) { return OnUploadDataAsync(obj, useTransaction).Result; }


        protected override async Task<Exception> OnDownloadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var stockOnHandCurrentTableProvider = DbContext.GetDataTableProvider<mvStockOnHandCurrentTableProvider>();
            var stockOnHandCurrentServiceProvider = DataServiceContext.GetDataServiceProvider<mvStockOnHandCurrentServiceProvider>();

            DateTime? syncDate = null;

            List<mvStockOnHandCurrent> serverDataList = null;

            var minSyncDate = (DateTimeOffset?)await stockOnHandCurrentTableProvider.GetData().MinAsync(p => p.SyncDate);

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    var query = stockOnHandCurrentServiceProvider.GetData().AddQueryOption("$select", Selector).AddQueryOption("$expand", Expand).Where(await GetFilter());

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
                        await ProcessLocalData(syncDate, 1, 1, serverData, null, stockOnHandCurrentTableProvider, true);
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
                
                await DbContext.UpdateAllSyncDateAsync<mvStockOnHandCurrent>(syncDate.Value);
            }

            return exception;
        }
        
        protected override async Task<Exception> OnUploadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            return await Task.FromResult(exception);
        }


        protected override async Task<Exception> OnDownloadDataAsync(mvStockOnHandCurrent obj, bool useTransaction)
        {
            Exception exception = null;

            var stockOnHandCurrentTableProvider = DbContext.GetDataTableProvider<mvStockOnHandCurrentTableProvider>();
            var stockOnHandCurrentServiceProvider = DataServiceContext.GetDataServiceProvider<mvStockOnHandCurrentServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            mvStockOnHandCurrent serverData = null;

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    serverData = stockOnHandCurrentServiceProvider.GetData().AddQueryOption("$select", Selector).AddQueryOption("$expand", Expand)
                        .Where(p => (p.ID == obj.ID)).SingleOrDefault();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, stockOnHandCurrentTableProvider, useTransaction);

            return exception;
        }

        protected override async Task<Exception> OnUploadDataAsync(mvStockOnHandCurrent obj, bool useTransaction)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }



        private async Task ProcessLocalData(DateTime? syncDate, int status, int attempts, mvStockOnHandCurrent serverData, mvStockOnHandCurrent obj,
            mvStockOnHandCurrentTableProvider tableProvider, bool useTransaction)
        {
            var localDate = (syncDate.HasValue) ? syncDate.Value : await DbContext.GetDatabaseUtcDateTimeAsync();
            mvStockOnHandCurrent stockOnHandCurrent = null;

            if (serverData == null)
            {
                stockOnHandCurrent = new mvStockOnHandCurrent();
                stockOnHandCurrent.ID = obj.ID;

                await tableProvider.DeleteDataAsync(stockOnHandCurrent, useTransaction);
            }
            else
            {
                var isInsert = false;
                stockOnHandCurrent = await tableProvider.GetDataAsync(serverData.ID);
                if (stockOnHandCurrent == null)
                {
                    isInsert = true;
                    stockOnHandCurrent = new mvStockOnHandCurrent();
                }                

                stockOnHandCurrent.CopyFrom(serverData);
                stockOnHandCurrent.ExtendProductLot = serverData.ExtendProductLot;
                DbContext.SetSyncData(stockOnHandCurrent, syncDate, localDate, status, attempts);

                if (stockOnHandCurrent.ExtendProductLot != null)
                    DbContext.SetSyncData(stockOnHandCurrent.ExtendProductLot, syncDate, localDate, status, attempts);

                if (isInsert)
                    await tableProvider.InsertDataAsync(stockOnHandCurrent, useTransaction);
                else
                    await tableProvider.UpdateDataAsync(stockOnHandCurrent, useTransaction);

                if (obj != null)
                {
                    obj.CopyFrom(serverData);
                    DbContext.CopySyncData(obj, stockOnHandCurrent);
                }
            }
        }

        #endregion

    }

}
