﻿// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 07:11:05
// Description   : mvUserDeviceHubConnectionSyncProvider partial class.
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

    public partial class mvUserDeviceHubConnectionSyncProvider : DataSyncProvider<mvUserDeviceHubConnection>
    {

        #region Properties
        
        public static string Selector = "ID,UserID,HubNameID,ConnectionID,EmployeeID,SalesmanID,CollectorID,CreatedDate,ModifiedDate";
        
        #endregion
        
        #region Methods
        
        protected override Exception OnDownloadAllData(bool continueOnError) { return OnDownloadAllDataAsync(continueOnError).Result; }
        protected override Exception OnUploadAllData(bool continueOnError) { return OnUploadAllDataAsync(continueOnError).Result; }
        protected override Exception OnDownloadData(mvUserDeviceHubConnection obj, bool useTransaction) { return OnDownloadDataAsync(obj, useTransaction).Result; }
        protected override Exception OnUploadData(mvUserDeviceHubConnection obj, bool useTransaction) { return OnUploadDataAsync(obj, useTransaction).Result; }


        protected override async Task<Exception> OnDownloadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var userDeviceHubConnectionTableProvider = DbContext.GetDataTableProvider<mvUserDeviceHubConnectionTableProvider>();
            var userDeviceHubConnectionServiceProvider = DataServiceContext.GetDataServiceProvider<mvUserDeviceHubConnectionServiceProvider>();

            DateTime? syncDate = null;

            List<mvUserDeviceHubConnection> serverDataList = null;

            var minSyncDate = (DateTimeOffset?)await DbContext.GetMinSyncDateAsync<mvUserDeviceHubConnection>();

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    var query = (IQueryable<mvUserDeviceHubConnection>)userDeviceHubConnectionServiceProvider.GetData().AddQueryOption("$select", Selector);

                    if (minSyncDate.HasValue)
                        query = query.Where(p => (p.CreatedDate > minSyncDate.Value) || (p.ModifiedDate > minSyncDate.Value));

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
                            await ProcessLocalData(syncDate, 1, 1, serverData, null, userDeviceHubConnectionTableProvider, true);
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

                await DbContext.UpdateAllSyncDateAsync<mvUserDeviceHubConnection>(syncDate.Value);
            }

            return exception;
        }
        
        protected override async Task<Exception> OnUploadAllDataAsync(bool continueOnError)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }


        protected override async Task<Exception> OnDownloadDataAsync(mvUserDeviceHubConnection obj, bool useTransaction)
        {
            Exception exception = null;

            var userDeviceHubConnectionTableProvider = DbContext.GetDataTableProvider<mvUserDeviceHubConnectionTableProvider>();
            var userDeviceHubConnectionServiceProvider = DataServiceContext.GetDataServiceProvider<mvUserDeviceHubConnectionServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            mvUserDeviceHubConnection serverData = null;

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    serverData = userDeviceHubConnectionServiceProvider.GetData().AddQueryOption("$select", Selector)
                        .Where(p => (p.ID == obj.ID)).SingleOrDefault();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, userDeviceHubConnectionTableProvider, useTransaction);

            return exception;
        }

        protected override async Task<Exception> OnUploadDataAsync(mvUserDeviceHubConnection obj, bool useTransaction)
        {
            Exception exception = null;

            var userDeviceHubConnectionTableProvider = DbContext.GetDataTableProvider<mvUserDeviceHubConnectionTableProvider>();
            var userDeviceHubConnectionServiceProvider = DataServiceContext.GetDataServiceProvider<mvUserDeviceHubConnectionServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            var serverData = new mvUserDeviceHubConnection();
            serverData.CopyFrom(obj);

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                    attempts++;

                    await userDeviceHubConnectionServiceProvider.InsertDataAsync(serverData, useTransaction);

                    syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, userDeviceHubConnectionTableProvider, useTransaction);

            return exception;
        }



        private async Task ProcessLocalData(DateTime? syncDate, int status, int attempts, mvUserDeviceHubConnection serverData, mvUserDeviceHubConnection obj,
            mvUserDeviceHubConnectionTableProvider tableProvider, bool useTransaction)
        {
            var localDate = (syncDate.HasValue) ? syncDate.Value : await DbContext.GetDatabaseUtcDateTimeAsync();
            mvUserDeviceHubConnection userDeviceHubConnection = null;

            if (serverData == null)
            {
                userDeviceHubConnection = new mvUserDeviceHubConnection();
                userDeviceHubConnection.ID = obj.ID;

                await tableProvider.DeleteDataAsync(userDeviceHubConnection, useTransaction);
            }
            else
            {
                var isInsert = false;
                var isDelete = false;
                userDeviceHubConnection = await tableProvider.GetDataAsync(serverData.ID);
                if (userDeviceHubConnection == null)
                {
                    isInsert = true;
                    userDeviceHubConnection = new mvUserDeviceHubConnection();
                }                 

                userDeviceHubConnection.CopyFrom(serverData);
                DbContext.SetSyncData(userDeviceHubConnection, syncDate, localDate, status, attempts);

                if (isInsert)
                    await tableProvider.InsertDataAsync(userDeviceHubConnection, useTransaction);
                else if (isDelete)
                    await tableProvider.DeleteDataAsync(userDeviceHubConnection, useTransaction);
                else
                    await tableProvider.UpdateDataAsync(userDeviceHubConnection, useTransaction);

                if (obj != null)
                {
                    obj.CopyFrom(serverData);
                    DbContext.CopySyncData(obj, userDeviceHubConnection);
                }
            }
        }

        #endregion

    }

}