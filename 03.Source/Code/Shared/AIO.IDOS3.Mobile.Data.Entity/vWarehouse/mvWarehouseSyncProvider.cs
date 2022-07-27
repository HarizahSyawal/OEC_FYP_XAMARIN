﻿// ===================================================================================
// Author        : System
// Created date  : 02 Sep 2020 21:21:57
// Description   : mvWarehouseSyncProvider partial class.
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

    public partial class mvWarehouseSyncProvider : DataSyncProvider<mvWarehouse>
    {

        #region Properties
        
        public static string Selector = "ID,Code,Name,Warehouse,SiteID,TypeID,TypeName,IsSalesTransactionAllowed,StatusID,StatusName,SAPCode,CreatedDate,ModifiedDate,IsDeleted";

        #endregion

        #region Methods

        private async Task<Expression<Func<mvWarehouse, bool>>> GetFilter()
        {
            var salesmans = await DbContext.GetDataTableProvider<mvSalesmanTableProvider>().GetData().ToListAsync();

            Expression filter = null;
            var type = typeof(mvWarehouse);
            var param = Expression.Parameter(type, "param");

            var propID = Expression.Property(param, "ID");
            var propSiteID = Expression.Property(param, "SiteID");
            var propTypeID = Expression.Property(param, "TypeID");
            foreach (var data in salesmans)
            {
                var expr1 = Expression.MakeBinary(ExpressionType.And,
                    Expression.MakeBinary(ExpressionType.Equal, propID, Expression.Constant(data.WarehouseID, type.GetProperty("ID").PropertyType)),
                    Expression.MakeBinary(ExpressionType.Equal, propTypeID, Expression.Constant(2, type.GetProperty("TypeID").PropertyType))); // Canvas Warehouse
                var expr2 = Expression.MakeBinary(ExpressionType.And,
                    Expression.MakeBinary(ExpressionType.Equal, propSiteID, Expression.Constant(data.SiteID, type.GetProperty("SiteID").PropertyType)),
                    Expression.MakeBinary(ExpressionType.Equal, propTypeID, Expression.Constant(1, type.GetProperty("TypeID").PropertyType))); // Main Warehouse

                var expr = Expression.MakeBinary(ExpressionType.Or, expr1, expr2);
                filter = (filter == null) ? expr : Expression.MakeBinary(ExpressionType.Or, filter, expr);
            }

            return Expression.Lambda<Func<mvWarehouse, bool>>(filter, param);
        }



        protected override Exception OnDownloadAllData(bool continueOnError) { return OnDownloadAllDataAsync(continueOnError).Result; }
        protected override Exception OnUploadAllData(bool continueOnError) { return OnUploadAllDataAsync(continueOnError).Result; }
        protected override Exception OnDownloadData(mvWarehouse obj, bool useTransaction) { return OnDownloadDataAsync(obj, useTransaction).Result; }
        protected override Exception OnUploadData(mvWarehouse obj, bool useTransaction) { return OnUploadDataAsync(obj, useTransaction).Result; }


        protected override async Task<Exception> OnDownloadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var warehouseTableProvider = DbContext.GetDataTableProvider<mvWarehouseTableProvider>();
            var warehouseServiceProvider = DataServiceContext.GetDataServiceProvider<mvWarehouseServiceProvider>();

            DateTime? syncDate = null;

            List<mvWarehouse> serverDataList = null;

            var minSyncDate = (DateTimeOffset?)await warehouseTableProvider.GetData().MinAsync(p => p.SyncDate);

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    var query = warehouseServiceProvider.GetData().AddQueryOption("$select", Selector).Where(await GetFilter());

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
                    var sites = await DbContext.GetDataTableProvider<mvSiteTableProvider>().GetData().ToListAsync();

                    int index = 0;
                    foreach (var serverData in serverDataList)
                    {
                        try
                        {
                            var site = sites.Where(p => p.ID.Equals(serverData.SiteID)).SingleOrDefault();

                            AssignFromLocalData(serverData, site);

                            await ProcessLocalData(syncDate, 1, 1, serverData, null, warehouseTableProvider, true);
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
                
                await DbContext.UpdateAllSyncDateAsync<mvWarehouse>(syncDate.Value);
            }

            return exception;
        }
        
        protected override async Task<Exception> OnUploadAllDataAsync(bool continueOnError)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }


        protected override async Task<Exception> OnDownloadDataAsync(mvWarehouse obj, bool useTransaction)
        {
            Exception exception = null;

            var warehouseTableProvider = DbContext.GetDataTableProvider<mvWarehouseTableProvider>();
            var warehouseServiceProvider = DataServiceContext.GetDataServiceProvider<mvWarehouseServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            mvWarehouse serverData = null;

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    serverData = warehouseServiceProvider.GetData().AddQueryOption("$select", Selector)
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
                var site = await DbContext.GetDataTableProvider<mvSiteTableProvider>().GetDataAsync(serverData.SiteID);

                AssignFromLocalData(serverData, site);
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, warehouseTableProvider, useTransaction);

            return exception;
        }

        protected override async Task<Exception> OnUploadDataAsync(mvWarehouse obj, bool useTransaction)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }



        private async Task ProcessLocalData(DateTime? syncDate, int status, int attempts, mvWarehouse serverData, mvWarehouse obj,
            mvWarehouseTableProvider tableProvider, bool useTransaction)
        {
            var localDate = (syncDate.HasValue) ? syncDate.Value : await DbContext.GetDatabaseUtcDateTimeAsync();
            mvWarehouse warehouse = null;

            if (serverData == null)
            {
                warehouse = new mvWarehouse();
                warehouse.ID = obj.ID;

                await tableProvider.DeleteDataAsync(warehouse, useTransaction);
            }
            else
            {
                var isInsert = false;
                var isDelete = false;
                warehouse = await tableProvider.GetDataAsync(serverData.ID);
                if (warehouse == null)
                {
                    isInsert = true;
                    warehouse = new mvWarehouse();
                }                
                else if (warehouse.IsDeleted)
                    isDelete = true;                    

                warehouse.CopyFrom(serverData);
                DbContext.SetSyncData(warehouse, syncDate, localDate, status, attempts);

                if (isInsert)
                    await tableProvider.InsertDataAsync(warehouse, useTransaction);
                else if (isDelete)
                    await tableProvider.DeleteDataAsync(warehouse, useTransaction);
                else
                    await tableProvider.UpdateDataAsync(warehouse, useTransaction);

                if (obj != null)
                {
                    obj.CopyFrom(serverData);
                    DbContext.CopySyncData(obj, warehouse);
                }
            }
        }

        private void AssignFromLocalData(mvWarehouse serverData, mvSite site)
        {
            if (site != null)
            {
                serverData.SiteCode = site.Code;
                serverData.SiteName = site.Name;
                serverData.Site = site.Site;
                serverData.AreaID = site.AreaID;
                serverData.AreaCode = site.AreaCode;
                serverData.AreaName = site.AreaName;
                serverData.Area = site.Area;
                serverData.RegionID = site.RegionID;
                serverData.RegionCode = site.RegionCode;
                serverData.RegionName = site.RegionName;
                serverData.Region = site.Region;
                serverData.TerritoryID = site.TerritoryID;
                serverData.TerritoryCode = site.TerritoryCode;
                serverData.TerritoryName = site.TerritoryName;
                serverData.Territory = site.Territory;
                serverData.CompanyID = site.CompanyID;
                serverData.CompanyCode = site.CompanyCode;
                serverData.CompanyName = site.CompanyName;
                serverData.Company = site.Company;
                serverData.SiteDistributionTypeID = site.DistributionTypeID;
                serverData.SiteDistributionTypeName = site.DistributionTypeName;
                serverData.IsSiteProductLotCodeEntryRequired = site.IsProductLotCodeEntryRequired;
            }
        }

        #endregion

    }

}
