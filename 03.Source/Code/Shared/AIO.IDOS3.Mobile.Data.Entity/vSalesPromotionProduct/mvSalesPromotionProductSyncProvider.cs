﻿// ===================================================================================
// Author        : System
// Created date  : 24 Sep 2020 05:09:04
// Description   : mvSalesPromotionProductSyncProvider partial class.
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

    public partial class mvSalesPromotionProductSyncProvider : DataSyncProvider<mvSalesPromotionProduct>
    {

        #region Properties

        public static string Selector = "SalesPromotionID,ProductID";

        #endregion

        #region Methods

        protected override Exception OnDownloadAllData(bool continueOnError) { return OnDownloadAllDataAsync(continueOnError).Result; }
        protected override Exception OnUploadAllData(bool continueOnError) { return OnUploadAllDataAsync(continueOnError).Result; }
        protected override Exception OnDownloadData(mvSalesPromotionProduct obj, bool useTransaction) { return OnDownloadDataAsync(obj, useTransaction).Result; }
        protected override Exception OnUploadData(mvSalesPromotionProduct obj, bool useTransaction) { return OnUploadDataAsync(obj, useTransaction).Result; }


        protected override async Task<Exception> OnDownloadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var salesPromotionProductTableProvider = DbContext.GetDataTableProvider<mvSalesPromotionProductTableProvider>();
            var salesPromotionProductServiceProvider = DataServiceContext.GetDataServiceProvider<mvSalesPromotionProductServiceProvider>();

            DateTime? syncDate = null;

            List<mvSalesPromotionProduct> serverDataList = null;

            var minSyncDate = (DateTimeOffset?)await salesPromotionProductTableProvider.GetData().MinAsync(p => p.SyncDate);

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    var query = (IQueryable<mvSalesPromotionProduct>)salesPromotionProductServiceProvider.GetData().AddQueryOption("$select", Selector);

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
                        await ProcessLocalData(syncDate, 1, 1, serverData, null, salesPromotionProductTableProvider, true);
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

                await DbContext.UpdateAllSyncDateAsync<mvSalesPromotionProduct>(syncDate.Value);
            }

            return exception;
        }

        protected override async Task<Exception> OnUploadAllDataAsync(bool continueOnError)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }


        protected override async Task<Exception> OnDownloadDataAsync(mvSalesPromotionProduct obj, bool useTransaction)
        {
            Exception exception = null;

            var salesPromotionProductTableProvider = DbContext.GetDataTableProvider<mvSalesPromotionProductTableProvider>();
            var salesPromotionProductServiceProvider = DataServiceContext.GetDataServiceProvider<mvSalesPromotionProductServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            mvSalesPromotionProduct serverData = null;

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    serverData = salesPromotionProductServiceProvider.GetData().AddQueryOption("$select", Selector)
                        .Where(p => p.SalesPromotionID.Equals(serverData.SalesPromotionID) && p.ProductID.Equals(serverData.ProductID)).SingleOrDefault();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, salesPromotionProductTableProvider, useTransaction);

            return exception;
        }

        protected override async Task<Exception> OnUploadDataAsync(mvSalesPromotionProduct obj, bool useTransaction)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }



        private async Task ProcessLocalData(DateTime? syncDate, int status, int attempts, mvSalesPromotionProduct serverData, mvSalesPromotionProduct obj,
            mvSalesPromotionProductTableProvider tableProvider, bool useTransaction)
        {
            var localDate = (syncDate.HasValue) ? syncDate.Value : await DbContext.GetDatabaseUtcDateTimeAsync();
            mvSalesPromotionProduct salesPromotionProduct = null;

            if (serverData == null)
            {
                salesPromotionProduct = new mvSalesPromotionProduct();
                salesPromotionProduct.SalesPromotionID = obj.SalesPromotionID;
                salesPromotionProduct.ProductID = obj.ProductID;

                await tableProvider.DeleteDataAsync(salesPromotionProduct, useTransaction);
            }
            else
            {
                var isInsert = false;
                salesPromotionProduct = await tableProvider.GetDataAsync(serverData.SalesPromotionID, serverData.ProductID);
                if (salesPromotionProduct == null)
                {
                    isInsert = true;
                    salesPromotionProduct = new mvSalesPromotionProduct();
                }

                salesPromotionProduct.CopyFrom(serverData);
                DbContext.SetSyncData(salesPromotionProduct, syncDate, localDate, status, attempts);

                if (isInsert)
                    await tableProvider.InsertDataAsync(salesPromotionProduct, useTransaction);
                else
                    await tableProvider.UpdateDataAsync(salesPromotionProduct, useTransaction);

                if (obj != null)
                {
                    obj.CopyFrom(serverData);
                    DbContext.CopySyncData(obj, salesPromotionProduct);
                }
            }
        }

        #endregion

    }

}
