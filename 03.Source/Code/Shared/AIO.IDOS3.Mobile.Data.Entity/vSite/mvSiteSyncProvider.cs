﻿// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 07:11:04
// Description   : mvSiteSyncProvider partial class.
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

    public partial class mvSiteSyncProvider : DataSyncProvider<mvSite>
    {

        #region Properties
        
        public static string Selector = "ID,Code,Name,Site,AreaID,AreaCode,AreaName,Area,RegionID,RegionCode,RegionName,Region,TerritoryID,TerritoryCode,TerritoryName,Territory,CompanyID,CompanyCode,CompanyName,Company,DistributionTypeID,DistributionTypeName,IsProductLotCodeEntryRequired,TaxIDNumber,TaxIDName,IsVATEnterpriseRegistered,VATEnterpriseRegistrationNumber,VATEnterpriseRegisteredDate,ContactPerson,Address1,Address2,Address3,Address,CityID,City,StateProvinceID,StateProvince,CountryID,CountryName,ZipCode,Phone1,Phone2,Phone3,Fax,Email,Longitude,Latitude,TaxContactPerson,IsTaxAddressSameAsAddress,TaxAddress1,TaxAddress2,TaxAddress3,TaxAddress,TaxCityID,TaxCity,TaxStateProvinceID,TaxStateProvince,TaxCountryID,TaxCountryName,TaxZipCode,TaxPhone1,TaxPhone2,TaxPhone3,TaxFax,TaxEmail,TaxLongitude,TaxLatitude,StatusID,StatusName,SAPCode,GLAccountCode,ProfitCenterCode,CostCenterCode,AdditionalInfo1,AdditionalInfo2,AdditionalInfo3,AdditionalInfo4,AdditionalInfo5,AdditionalInfo6,AdditionalInfo7,AdditionalInfo8,AdditionalInfo9,AdditionalInfo10,CreatedDate,ModifiedDate,IsDeleted";

        #endregion

        #region Methods

        private async Task<Expression<Func<mvSite, bool>>> GetFilter()
        {
            var siteIDs = await DbContext.GetDataTableProvider<mvUserSiteTableProvider>().GetData().Select(p => p.SiteID).ToListAsync();

            Expression filter = null;
            var type = typeof(mvSite);
            var param = Expression.Parameter(type, "param");

            var propID = Expression.Property(param, "ID");
            foreach (var id in siteIDs)
            {
                var expr = Expression.MakeBinary(ExpressionType.Equal, propID, Expression.Constant(id, type.GetProperty("ID").PropertyType));
                filter = (filter == null) ? expr : Expression.MakeBinary(ExpressionType.Or, filter, expr);
            }

            return Expression.Lambda<Func<mvSite, bool>>(filter, param);
        }



        protected override Exception OnDownloadAllData(bool continueOnError) { return OnDownloadAllDataAsync(continueOnError).Result; }
        protected override Exception OnUploadAllData(bool continueOnError) { return OnUploadAllDataAsync(continueOnError).Result; }
        protected override Exception OnDownloadData(mvSite obj, bool useTransaction) { return OnDownloadDataAsync(obj, useTransaction).Result; }
        protected override Exception OnUploadData(mvSite obj, bool useTransaction) { return OnUploadDataAsync(obj, useTransaction).Result; }


        protected override async Task<Exception> OnDownloadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var siteTableProvider = DbContext.GetDataTableProvider<mvSiteTableProvider>();
            var siteServiceProvider = DataServiceContext.GetDataServiceProvider<mvSiteServiceProvider>();

            DateTime? syncDate = null;

            List<mvSite> serverDataList = null;

            var minSyncDate = (DateTimeOffset?)await siteTableProvider.GetData().MinAsync(p => p.SyncDate);

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    var query = siteServiceProvider.GetData().AddQueryOption("$select", Selector).Where(await GetFilter());

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
                        await ProcessLocalData(syncDate, 1, 1, serverData, null, siteTableProvider, true);
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


        protected override async Task<Exception> OnDownloadDataAsync(mvSite obj, bool useTransaction)
        {
            Exception exception = null;

            var siteTableProvider = DbContext.GetDataTableProvider<mvSiteTableProvider>();
            var siteServiceProvider = DataServiceContext.GetDataServiceProvider<mvSiteServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            mvSite serverData = null;

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    serverData = siteServiceProvider.GetData().AddQueryOption("$select", Selector)
                        .Where(p => p.ID.Equals(obj.ID)).SingleOrDefault();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, siteTableProvider, useTransaction);

            return exception;
        }

        protected override async Task<Exception> OnUploadDataAsync(mvSite obj, bool useTransaction)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }



        private async Task ProcessLocalData(DateTime? syncDate, int status, int attempts, mvSite serverData, mvSite obj,
            mvSiteTableProvider tableProvider, bool useTransaction)
        {
            var localDate = (syncDate.HasValue) ? syncDate.Value : await DbContext.GetDatabaseUtcDateTimeAsync();
            mvSite site = null;

            if (serverData == null)
            {
                site = new mvSite();
                site.ID = obj.ID;

                await tableProvider.DeleteDataAsync(site, useTransaction);
            }
            else
            {
                var isInsert = false;
                var isDelete = false;
                site = await tableProvider.GetDataAsync(serverData.ID);
                if (site == null)
                {
                    isInsert = true;
                    site = new mvSite();
                }                
                else if (site.IsDeleted)
                    isDelete = true;                    

                site.CopyFrom(serverData);
                DbContext.SetSyncData(site, syncDate, localDate, status, attempts);

                if (isInsert)
                    await tableProvider.InsertDataAsync(site, useTransaction);
                else if (isDelete)
                    await tableProvider.DeleteDataAsync(site, useTransaction);
                else
                    await tableProvider.UpdateDataAsync(site, useTransaction);

                if (obj != null)
                {
                    obj.CopyFrom(serverData);
                    DbContext.CopySyncData(obj, site);
                }
            }
        }

        #endregion

    }

}
