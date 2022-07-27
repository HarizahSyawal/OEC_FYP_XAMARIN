﻿// ===================================================================================
// Author        : System
// Created date  : 08 Oct 2020 05:23:03
// Description   : mvIncomingAccountSyncProvider partial class.
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
using System.Security.Permissions;
using System.Threading.Tasks;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public partial class mvIncomingAccountSyncProvider : DataSyncProvider<mvIncomingAccount>
    {

        #region Properties
        
        public static string Selector = "ID,Code,Name,IncomingAccount,IsHeadOffice,SiteID,Description,FinanceInstitutionID,StatusID,StatusName,CreatedDate,ModifiedDate,IsDeleted";
        
        #endregion
        
        #region Methods
        
        private async Task<Expression<Func<mvIncomingAccount, bool>>> GetFilter()
        {
            var siteIDs = await DbContext.GetDataTableProvider<mvSiteTableProvider>().GetData().Select(p => p.ID).ToListAsync();

            Expression filter = null;
            var type = typeof(mvIncomingAccount);
            var param = Expression.Parameter(type, "param");

            var propSiteID = Expression.Property(param, "SiteID");
            foreach (var id in siteIDs)
            {
                var expr = Expression.MakeBinary(ExpressionType.Equal, propSiteID, Expression.Constant(id, type.GetProperty("SiteID").PropertyType));
                filter = (filter == null) ? expr : Expression.MakeBinary(ExpressionType.Or, filter, expr);
            }

            return Expression.Lambda<Func<mvIncomingAccount, bool>>(filter, param);
        }
        
        
        
        protected override Exception OnDownloadAllData(bool continueOnError) { return OnDownloadAllDataAsync(continueOnError).Result; }
        protected override Exception OnUploadAllData(bool continueOnError) { return OnUploadAllDataAsync(continueOnError).Result; }
        protected override Exception OnDownloadData(mvIncomingAccount obj, bool useTransaction) { return OnDownloadDataAsync(obj, useTransaction).Result; }
        protected override Exception OnUploadData(mvIncomingAccount obj, bool useTransaction) { return OnUploadDataAsync(obj, useTransaction).Result; }


        protected override async Task<Exception> OnDownloadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var incomingAccountTableProvider = DbContext.GetDataTableProvider<mvIncomingAccountTableProvider>();
            var incomingAccountServiceProvider = DataServiceContext.GetDataServiceProvider<mvIncomingAccountServiceProvider>();

            DateTime? syncDate = null;

            List<mvIncomingAccount> serverDataList = null;

            var minSyncDate = (DateTimeOffset?)await incomingAccountTableProvider.GetData().MinAsync(p => p.SyncDate);

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    var query = incomingAccountServiceProvider.GetData().AddQueryOption("$select", Selector).Where(await GetFilter());

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
                    var financeInstitutions = await DbContext.GetDataTableProvider<mvFinanceInstitutionTableProvider>().GetData().ToListAsync();

                    int index = 0;
                    foreach (var serverData in serverDataList)
                    {
                        try
                        {
                            var site = (serverData.IsHeadOffice) ? null : sites.Where(p => p.ID.Equals(serverData.SiteID)).SingleOrDefault();
                            var financeInstitution = financeInstitutions.Where(p => (p.ID == serverData.FinanceInstitutionID)).SingleOrDefault();

                            AssignFromLocalData(serverData, site, financeInstitution);

                            await ProcessLocalData(syncDate, 1, 1, serverData, null, incomingAccountTableProvider, true);
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
                
                await DbContext.UpdateAllSyncDateAsync<mvIncomingAccount>(syncDate.Value);
            }

            return exception;
        }
        
        protected override async Task<Exception> OnUploadAllDataAsync(bool continueOnError)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }


        protected override async Task<Exception> OnDownloadDataAsync(mvIncomingAccount obj, bool useTransaction)
        {
            Exception exception = null;

            var incomingAccountTableProvider = DbContext.GetDataTableProvider<mvIncomingAccountTableProvider>();
            var incomingAccountServiceProvider = DataServiceContext.GetDataServiceProvider<mvIncomingAccountServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            mvIncomingAccount serverData = null;

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    serverData = incomingAccountServiceProvider.GetData().AddQueryOption("$select", Selector)
                        .Where(p => (p.Code.ToLower() == obj.Code.ToLower())).SingleOrDefault();
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
                var site = (serverData.IsHeadOffice) ? null : await DbContext.GetDataTableProvider<mvSiteTableProvider>().GetDataAsync(serverData.SiteID);
                var financeInstitution = await DbContext.GetDataTableProvider<mvFinanceInstitutionTableProvider>().GetDataAsync(serverData.FinanceInstitutionID);

                AssignFromLocalData(serverData, site, financeInstitution);
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, incomingAccountTableProvider, useTransaction);

            return exception;
        }

        protected override async Task<Exception> OnUploadDataAsync(mvIncomingAccount obj, bool useTransaction)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }



        private async Task ProcessLocalData(DateTime? syncDate, int status, int attempts, mvIncomingAccount serverData, mvIncomingAccount obj,
            mvIncomingAccountTableProvider tableProvider, bool useTransaction)
        {
            var localDate = (syncDate.HasValue) ? syncDate.Value : await DbContext.GetDatabaseUtcDateTimeAsync();
            mvIncomingAccount incomingAccount = null;

            if (serverData == null)
            {
                incomingAccount = new mvIncomingAccount();
                incomingAccount.ID = obj.ID;

                await tableProvider.DeleteDataAsync(incomingAccount, useTransaction);
            }
            else
            {
                var isInsert = false;
                var isDelete = false;
                incomingAccount = await tableProvider.GetDataAsync(serverData.ID);
                if (incomingAccount == null)
                {
                    isInsert = true;
                    incomingAccount = new mvIncomingAccount();
                }                
                else if (incomingAccount.IsDeleted)
                    isDelete = true;                    

                incomingAccount.CopyFrom(serverData);
                DbContext.SetSyncData(incomingAccount, syncDate, localDate, status, attempts);

                if (isInsert)
                    await tableProvider.InsertDataAsync(incomingAccount, useTransaction);
                else if (isDelete)
                    await tableProvider.DeleteDataAsync(incomingAccount, useTransaction);
                else
                    await tableProvider.UpdateDataAsync(incomingAccount, useTransaction);

                if (obj != null)
                {
                    obj.CopyFrom(serverData);
                    DbContext.CopySyncData(obj, incomingAccount);
                }
            }
        }

        private void AssignFromLocalData(mvIncomingAccount serverData, mvSite site, mvFinanceInstitution financeInstitution)
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
            }

            if (financeInstitution != null)
            {
                serverData.FinanceInstitutionCode = financeInstitution.Code;
                serverData.FinanceInstitutionName = financeInstitution.Name;
                serverData.FinanceInstitution = financeInstitution.FinanceInstitution;
                serverData.FinanceInstitutionShortName = financeInstitution.ShortName;
                serverData.FinanceInstitutionTypeID = financeInstitution.TypeID;
                serverData.FinanceInstitutionTypeName = financeInstitution.TypeName;
            }
        }

        #endregion

    }

}