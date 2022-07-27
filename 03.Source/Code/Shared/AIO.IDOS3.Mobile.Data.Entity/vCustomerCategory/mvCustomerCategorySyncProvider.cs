﻿// ===================================================================================
// Author        : System
// Created date  : 19 Oct 2020 12:22:38
// Description   : mvCustomerCategorySyncProvider partial class.
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

    public partial class mvCustomerCategorySyncProvider : DataSyncProvider<mvCustomerCategory>
    {

        #region Properties
        
        public static string Selector = "ID,Code,Name,Category,ParentID,ParentCode,ParentName,Parent,Group,CreatedDate,CreatedByUserID,CreatedByUserName,ModifiedDate,ModifiedByUserID,ModifiedByUserName,IsDeleted";
        
        #endregion
        
        #region Methods
        
        protected override Exception OnDownloadAllData(bool continueOnError) { return OnDownloadAllDataAsync(continueOnError).Result; }
        protected override Exception OnUploadAllData(bool continueOnError) { return OnUploadAllDataAsync(continueOnError).Result; }
        protected override Exception OnDownloadData(mvCustomerCategory obj, bool useTransaction) { return OnDownloadDataAsync(obj, useTransaction).Result; }
        protected override Exception OnUploadData(mvCustomerCategory obj, bool useTransaction) { return OnUploadDataAsync(obj, useTransaction).Result; }


        protected override async Task<Exception> OnDownloadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var customerCategoryTableProvider = DbContext.GetDataTableProvider<mvCustomerCategoryTableProvider>();
            var customerCategoryServiceProvider = DataServiceContext.GetDataServiceProvider<mvCustomerCategoryServiceProvider>();

            DateTime? syncDate = null;

            List<mvCustomerCategory> serverDataList = null;

            var minSyncDate = (DateTimeOffset?)await customerCategoryTableProvider.GetData().MinAsync(p => p.SyncDate);

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    var query = (IQueryable<mvCustomerCategory>)customerCategoryServiceProvider.GetData().AddQueryOption("$select", Selector);

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
                        await ProcessLocalData(syncDate, 1, 1, serverData, null, customerCategoryTableProvider, true);
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
                
                await DbContext.UpdateAllSyncDateAsync<mvCustomerCategory>(syncDate.Value);
            }

            return exception;
        }
        
        protected override async Task<Exception> OnUploadAllDataAsync(bool continueOnError)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }


        protected override async Task<Exception> OnDownloadDataAsync(mvCustomerCategory obj, bool useTransaction)
        {
            Exception exception = null;

            var customerCategoryTableProvider = DbContext.GetDataTableProvider<mvCustomerCategoryTableProvider>();
            var customerCategoryServiceProvider = DataServiceContext.GetDataServiceProvider<mvCustomerCategoryServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            mvCustomerCategory serverData = null;

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    serverData = customerCategoryServiceProvider.GetData().AddQueryOption("$select", Selector)
                        .Where(p => (p.Code.ToLower() == obj.Code.ToLower())).SingleOrDefault();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, customerCategoryTableProvider, useTransaction);

            return exception;
        }

        protected override async Task<Exception> OnUploadDataAsync(mvCustomerCategory obj, bool useTransaction)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }



        private async Task ProcessLocalData(DateTime? syncDate, int status, int attempts, mvCustomerCategory serverData, mvCustomerCategory obj,
            mvCustomerCategoryTableProvider tableProvider, bool useTransaction)
        {
            var localDate = (syncDate.HasValue) ? syncDate.Value : await DbContext.GetDatabaseUtcDateTimeAsync();
            mvCustomerCategory customerCategory = null;

            if (serverData == null)
            {
                customerCategory = new mvCustomerCategory();
                customerCategory.ID = obj.ID;

                await tableProvider.DeleteDataAsync(customerCategory, useTransaction);
            }
            else
            {
                var isInsert = false;
                var isDelete = false;
                customerCategory = await tableProvider.GetDataAsync(serverData.ID);
                if (customerCategory == null)
                {
                    isInsert = true;
                    customerCategory = new mvCustomerCategory();
                }                
                else if (customerCategory.IsDeleted)
                    isDelete = true;                    

                customerCategory.CopyFrom(serverData);
                DbContext.SetSyncData(customerCategory, syncDate, localDate, status, attempts);

                if (isInsert)
                    await tableProvider.InsertDataAsync(customerCategory, useTransaction);
                else if (isDelete)
                    await tableProvider.DeleteDataAsync(customerCategory, useTransaction);
                else
                    await tableProvider.UpdateDataAsync(customerCategory, useTransaction);

                if (obj != null)
                {
                    obj.CopyFrom(serverData);
                    DbContext.CopySyncData(obj, customerCategory);
                }
            }
        }

        #endregion

    }

}
