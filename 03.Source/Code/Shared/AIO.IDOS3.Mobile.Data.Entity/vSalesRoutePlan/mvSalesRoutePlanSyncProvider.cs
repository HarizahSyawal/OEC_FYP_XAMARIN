// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 07:11:03
// Description   : mvSalesRoutePlanSyncProvider partial class.
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

    public partial class mvSalesRoutePlanSyncProvider : DataSyncProvider<mvSalesRoutePlan>
    {

        #region Properties
        
        public static string Selector = "CustomerID,CustomerCode,CustomerName,Customer,SalesmanID,WarehouseID,SiteID,CompanyID,AreaID,RegionID,TerritoryID,CustomerBillGroupID,CustomerBillGroupCode,CustomerBillGroupName,CustomerBillGroup,CustomerBillGroupHeadID,CustomerBillGroupHeadCode,CustomerBillGroupHeadName,CustomerBillGroupHead,CustomerContactPerson,CustomerAddress1,CustomerAddress2,CustomerAddress3,CustomerAddress,CustomerCityID,CustomerCity,CustomerStateProvinceID,CustomerStateProvince,CustomerCountryID,CustomerCountryName,CustomerZipCode,CustomerPhone1,CustomerPhone2,CustomerPhone3,CustomerFax,CustomerEmail,CustomerLongitude,CustomerLatitude,Week1,Week2,Week3,Week4,Day1,Day2,Day3,Day4,Day5,Day6,Day7,CreatedDate,ModifiedDate";

        #endregion

        #region Methods

        private async Task<Expression<Func<mvSalesRoutePlan, bool>>> GetFilter()
        {
            var salesmanIDs = await DbContext.GetDataTableProvider<mvSalesmanTableProvider>().GetData().Select(p => p.ID).ToListAsync();
            
            Expression filter = null;
            var type = typeof(mvSalesRoutePlan);
            var param = Expression.Parameter(type, "param");

            var propSalesmanID = Expression.Property(param, "SalesmanID");
            foreach (var id in salesmanIDs)
            {
                var expr = Expression.MakeBinary(ExpressionType.Equal, propSalesmanID, Expression.Constant(id, type.GetProperty("SalesmanID").PropertyType));
                filter = (filter == null) ? expr : Expression.MakeBinary(ExpressionType.Or, filter, expr);
            }

            return Expression.Lambda<Func<mvSalesRoutePlan, bool>>(filter, param);
        }



        protected override Exception OnDownloadAllData(bool continueOnError) { return OnDownloadAllDataAsync(continueOnError).Result; }
        protected override Exception OnUploadAllData(bool continueOnError) { return OnUploadAllDataAsync(continueOnError).Result; }
        protected override Exception OnDownloadData(mvSalesRoutePlan obj, bool useTransaction) { return OnDownloadDataAsync(obj, useTransaction).Result; }
        protected override Exception OnUploadData(mvSalesRoutePlan obj, bool useTransaction) { return OnUploadDataAsync(obj, useTransaction).Result; }


        protected override async Task<Exception> OnDownloadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var salesRoutePlanTableProvider = DbContext.GetDataTableProvider<mvSalesRoutePlanTableProvider>();
            var salesRoutePlanServiceProvider = DataServiceContext.GetDataServiceProvider<mvSalesRoutePlanServiceProvider>();

            DateTime? syncDate = null;

            List<mvSalesRoutePlan> serverDataList = null;

            var minSyncDate = (DateTimeOffset?)await salesRoutePlanTableProvider.GetData().MinAsync(p => p.SyncDate);

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    var query = salesRoutePlanServiceProvider.GetData().AddQueryOption("$select", Selector).Where(await GetFilter());

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
                        await ProcessLocalData(syncDate, 1, 1, serverData, null, salesRoutePlanTableProvider, true);
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

            return exception;
        }
        
        protected override async Task<Exception> OnUploadAllDataAsync(bool continueOnError)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }


        protected override async Task<Exception> OnDownloadDataAsync(mvSalesRoutePlan obj, bool useTransaction)
        {
            Exception exception = null;

            var salesRoutePlanTableProvider = DbContext.GetDataTableProvider<mvSalesRoutePlanTableProvider>();
            var salesRoutePlanServiceProvider = DataServiceContext.GetDataServiceProvider<mvSalesRoutePlanServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            mvSalesRoutePlan serverData = null;

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    serverData = salesRoutePlanServiceProvider.GetData().AddQueryOption("$select", Selector)
                        .Where(p => p.CustomerID.Equals(serverData.CustomerID)).SingleOrDefault();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, salesRoutePlanTableProvider, useTransaction);

            return exception;
        }

        protected override async Task<Exception> OnUploadDataAsync(mvSalesRoutePlan obj, bool useTransaction)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }



        private async Task ProcessLocalData(DateTime? syncDate, int status, int attempts, mvSalesRoutePlan serverData, mvSalesRoutePlan obj,
            mvSalesRoutePlanTableProvider tableProvider, bool useTransaction)
        {
            var localDate = (syncDate.HasValue) ? syncDate.Value : await DbContext.GetDatabaseUtcDateTimeAsync();
            mvSalesRoutePlan salesRoutePlan = null;

            if (serverData == null)
            {
                salesRoutePlan = new mvSalesRoutePlan();
                salesRoutePlan.CustomerID = obj.CustomerID;

                await tableProvider.DeleteDataAsync(salesRoutePlan, useTransaction);
            }
            else
            {
                var isInsert = false;
                salesRoutePlan = await tableProvider.GetDataAsync(serverData.CustomerID);
                if (salesRoutePlan == null)
                {
                    isInsert = true;
                    salesRoutePlan = new mvSalesRoutePlan();
                }                

                salesRoutePlan.CopyFrom(serverData);
                DbContext.SetSyncData(salesRoutePlan, syncDate, localDate, status, attempts);

                if (isInsert)
                    await tableProvider.InsertDataAsync(salesRoutePlan, useTransaction);
                else
                    await tableProvider.UpdateDataAsync(salesRoutePlan, useTransaction);

                if (obj != null)
                {
                    obj.CopyFrom(serverData);
                    DbContext.CopySyncData(obj, salesRoutePlan);
                }
            }
        }

        #endregion

    }

}
