﻿// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 07:11:05
// Description   : mvUserSyncProvider partial class.
//
// Modified by   :
// Modified date :
// Comments      :
//
// NOTE: This file is initially generated by system and can be modified following
//       the requirement.
// ===================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{

    public partial class mvUserSyncProvider : DataSyncProvider<mvUser>
    {

        #region Properties
        
        public static string Selector = "ID,Name,Password,IsHeadOffice,SiteID,AreaID,RegionID,TerritoryID,CompanyID,StatusID,StatusName,CreatedDate,ModifiedDate";
        
        #endregion
        
        #region Methods
        
        protected override Exception OnDownloadAllData(bool continueOnError) { return OnDownloadAllDataAsync(continueOnError).Result; }
        protected override Exception OnUploadAllData(bool continueOnError) { return OnUploadAllDataAsync(continueOnError).Result; }
        protected override Exception OnDownloadData(mvUser obj, bool useTransaction) { return OnDownloadDataAsync(obj, useTransaction).Result; }
        protected override Exception OnUploadData(mvUser obj, bool useTransaction) { return OnUploadDataAsync(obj, useTransaction).Result; }


        protected override async Task<Exception> OnDownloadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var userTableProvider = DbContext.GetDataTableProvider<mvUserTableProvider>();
            var userServiceProvider = DataServiceContext.GetDataServiceProvider<mvUserServiceProvider>();

            DateTime? syncDate = null;

            List<mvUser> serverDataList = null;

            var minSyncDate = (DateTimeOffset?)await DbContext.GetMinSyncDateAsync<mvUser>();

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    var query = (IQueryable<mvUser>)userServiceProvider.GetData().AddQueryOption("$select", Selector);

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
                    int index = 0;
                    foreach (var serverData in serverDataList)
                    {
                        try
                        {
                            await ProcessLocalData(syncDate, 1, 1, serverData, null, userTableProvider, true);
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

                await DbContext.UpdateAllSyncDateAsync<mvUser>(syncDate.Value);
            }

            return exception;
        }
        
        protected override async Task<Exception> OnUploadAllDataAsync(bool continueOnError)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }


        protected override async Task<Exception> OnDownloadDataAsync(mvUser obj, bool useTransaction)
        {
            Exception exception = null;

            var userTableProvider = DbContext.GetDataTableProvider<mvUserTableProvider>();
            var userServiceProvider = DataServiceContext.GetDataServiceProvider<mvUserServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            mvUser serverData = null;

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    serverData = userServiceProvider.GetData().AddQueryOption("$select", Selector)
                        .Where(p => (p.ID == obj.ID)).SingleOrDefault();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, userTableProvider, useTransaction);

            return exception;
        }

        protected override async Task<Exception> OnUploadDataAsync(mvUser obj, bool useTransaction)
        {
            Exception exception = null;

            var userTableProvider = DbContext.GetDataTableProvider<mvUserTableProvider>();
            var userServiceProvider = DataServiceContext.GetDataServiceProvider<mvUserServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            var serverData = new mvUser();
            serverData.CopyFrom(obj);

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                    attempts++;

                    await userServiceProvider.InsertDataAsync(serverData, useTransaction);

                    syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, userTableProvider, useTransaction);

            return exception;
        }



        private async Task ProcessLocalData(DateTime? syncDate, int status, int attempts, mvUser serverData, mvUser obj,
            mvUserTableProvider tableProvider, bool useTransaction)
        {
            var localDate = (syncDate.HasValue) ? syncDate.Value : await DbContext.GetDatabaseUtcDateTimeAsync();
            mvUser user = null;

            if (serverData == null)
            {
                user = new mvUser();
                user.ID = obj.ID;

                await tableProvider.DeleteDataAsync(user, useTransaction);
            }
            else
            {
                var isInsert = false;
                var isDelete = false;
                user = await tableProvider.GetDataAsync(serverData.ID);
                if (user == null)
                {
                    isInsert = true;
                    user = new mvUser();
                }                
                else if (user.IsDeleted)
                    isDelete = true;                    

                user.CopyFrom(serverData);
                DbContext.SetSyncData(user, syncDate, localDate, status, attempts);

                if (isInsert)
                    await tableProvider.InsertDataAsync(user, useTransaction);
                else if (isDelete)
                    await tableProvider.DeleteDataAsync(user, useTransaction);
                else
                    await tableProvider.UpdateDataAsync(user, useTransaction);

                if (obj != null)
                {
                    obj.CopyFrom(serverData);
                    DbContext.CopySyncData(obj, user);
                }
            }
        }

        #endregion

    }

}