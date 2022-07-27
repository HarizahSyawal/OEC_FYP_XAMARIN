﻿// ===================================================================================
// Author        : System
// Created date  : 03 Sep 2020 02:32:40
// Description   : mvSystemLookupSyncProvider partial class.
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
using System.Threading.Tasks;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public partial class mvSystemLookupSyncProvider : DataSyncProvider<mvSystemLookup>
    {

        #region Fields
        
        public static string Selector = "ID,Name,Value_Boolean,Value_Int32,Value_Double,Value_String,Value_Guid,Value_DateTime,ParentID,Group,SortIndex,IsActive,IsAuthorization,CreatedDate,ModifiedDate";

        #endregion

        #region Methods

        protected override Exception OnDownloadAllData(bool continueOnError) { return OnDownloadAllDataAsync(continueOnError).Result; }
        protected override Exception OnUploadAllData(bool continueOnError) { return OnUploadAllDataAsync(continueOnError).Result; }
        protected override Exception OnDownloadData(mvSystemLookup obj, bool useTransaction) { return OnDownloadDataAsync(obj, useTransaction).Result; }
        protected override Exception OnUploadData(mvSystemLookup obj, bool useTransaction) { return OnUploadDataAsync(obj, useTransaction).Result; }


        protected override async Task<Exception> OnDownloadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var systemLookupTableProvider = DbContext.GetDataTableProvider<mvSystemLookupTableProvider>();
            var systemLookupServiceProvider = DataServiceContext.GetDataServiceProvider<mvSystemLookupServiceProvider>();

            DateTime? syncDate = null;

            List<mvSystemLookup> serverDataList = null;

            var minSyncDate = (DateTimeOffset?)await systemLookupTableProvider.GetData().MinAsync(p => p.SyncDate);

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    var query = (IQueryable<mvSystemLookup>)systemLookupServiceProvider.GetData().AddQueryOption("$select", Selector);

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
                        await ProcessLocalData(syncDate, 1, 1, serverData, null, systemLookupTableProvider, true);
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
                
                await DbContext.UpdateAllSyncDateAsync<mvSystemLookup>(syncDate.Value);
            }

            return exception;
        }
        
        protected override async Task<Exception> OnUploadAllDataAsync(bool continueOnError)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }


        protected override async Task<Exception> OnDownloadDataAsync(mvSystemLookup obj, bool useTransaction)
        {
            Exception exception = null;

            var systemLookupTableProvider = DbContext.GetDataTableProvider<mvSystemLookupTableProvider>();
            var systemLookupServiceProvider = DataServiceContext.GetDataServiceProvider<mvSystemLookupServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            mvSystemLookup serverData = null;

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    serverData = systemLookupServiceProvider.GetData().AddQueryOption("$select", Selector).Where(p => (p.ID == obj.ID)).SingleOrDefault();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, systemLookupTableProvider, useTransaction);

            return exception;
        }

        protected override async Task<Exception> OnUploadDataAsync(mvSystemLookup obj, bool useTransaction)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }



        private async Task ProcessLocalData(DateTime? syncDate, int status, int attempts, mvSystemLookup serverData, mvSystemLookup obj,
            mvSystemLookupTableProvider tableProvider, bool useTransaction)
        {
            var localDate = (syncDate.HasValue) ? syncDate.Value : await DbContext.GetDatabaseUtcDateTimeAsync();
            mvSystemLookup systemLookup = null;

            if (serverData == null)
            {
                systemLookup = new mvSystemLookup();
                systemLookup.ID = obj.ID;

                await tableProvider.DeleteDataAsync(systemLookup, useTransaction);
            }
            else
            {
                var isInsert = false;
                systemLookup = await tableProvider.GetDataAsync(serverData.ID);
                if (systemLookup == null)
                {
                    isInsert = true;
                    systemLookup = new mvSystemLookup();
                }                

                systemLookup.CopyFrom(serverData);
                DbContext.SetSyncData(systemLookup, syncDate, localDate, status, attempts);

                if (isInsert)
                    await tableProvider.InsertDataAsync(systemLookup, useTransaction);
                else
                    await tableProvider.UpdateDataAsync(systemLookup, useTransaction);

                if (obj != null)
                {
                    obj.CopyFrom(serverData);
                    DbContext.CopySyncData(obj, systemLookup);
                }
            }
        }

        #endregion

    }

}
