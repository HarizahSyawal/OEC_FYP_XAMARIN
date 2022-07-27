﻿// ===================================================================================
// Author        : System
// Created date  : 15 Sep 2020 03:26:58
// Description   : mvDiscountGroupSyncProvider partial class.
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

    public partial class mvDiscountGroupSyncProvider : DataSyncProvider<mvDiscountGroup>
    {

        #region Properties
        
        public static string Selector = "ID,Code,Name,DiscountGroup,Description,StatusID,StatusName,CreatedDate,ModifiedDate";

        #endregion

        #region Methods

        private async Task<Expression<Func<mvDiscountGroup, bool>>> GetFilter()
        {
            var discountGroupIDs = await DbContext.GetDataTableProvider<mvCustomerTableProvider>().GetData().Select(p => p.DiscountGroupID).Distinct().ToListAsync();

            Expression filter = null;
            var type = typeof(mvDiscountGroup);
            var param = Expression.Parameter(type, "param");

            var propID = Expression.Property(param, "ID");
            foreach (var id in discountGroupIDs)
            {
                var expr = Expression.MakeBinary(ExpressionType.Equal, propID, Expression.Constant(id, type.GetProperty("ID").PropertyType));
                filter = (filter == null) ? expr : Expression.MakeBinary(ExpressionType.Or, filter, expr);
            }

            var discountGroupRetailCode = "DiRTL"; ////////////////////////////////////////////////////////////

            var propCode = Expression.Property(param, "Code");
            var exprCode = Expression.MakeBinary(ExpressionType.Equal, propCode, Expression.Constant(discountGroupRetailCode, type.GetProperty("Code").PropertyType));
            filter = (filter == null) ? exprCode : Expression.MakeBinary(ExpressionType.Or, filter, exprCode);

            return Expression.Lambda<Func<mvDiscountGroup, bool>>(filter, param);
        }



        protected override Exception OnDownloadAllData(bool continueOnError) { return OnDownloadAllDataAsync(continueOnError).Result; }
        protected override Exception OnUploadAllData(bool continueOnError) { return OnUploadAllDataAsync(continueOnError).Result; }
        protected override Exception OnDownloadData(mvDiscountGroup obj, bool useTransaction) { return OnDownloadDataAsync(obj, useTransaction).Result; }
        protected override Exception OnUploadData(mvDiscountGroup obj, bool useTransaction) { return OnUploadDataAsync(obj, useTransaction).Result; }


        protected override async Task<Exception> OnDownloadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var discountGroupTableProvider = DbContext.GetDataTableProvider<mvDiscountGroupTableProvider>();
            var discountGroupServiceProvider = DataServiceContext.GetDataServiceProvider<mvDiscountGroupServiceProvider>();

            DateTime? syncDate = null;

            List<mvDiscountGroup> serverDataList = null;

            var minSyncDate = (DateTimeOffset?)await discountGroupTableProvider.GetData().MinAsync(p => p.SyncDate);

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    var query = discountGroupServiceProvider.GetData().AddQueryOption("$select", Selector).Where(await GetFilter());

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
                        await ProcessLocalData(syncDate, 1, 1, serverData, null, discountGroupTableProvider, true);
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
                
                await DbContext.UpdateAllSyncDateAsync<mvDiscountGroup>(syncDate.Value);
            }

            return exception;
        }
        
        protected override async Task<Exception> OnUploadAllDataAsync(bool continueOnError)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }


        protected override async Task<Exception> OnDownloadDataAsync(mvDiscountGroup obj, bool useTransaction)
        {
            Exception exception = null;

            var discountGroupTableProvider = DbContext.GetDataTableProvider<mvDiscountGroupTableProvider>();
            var discountGroupServiceProvider = DataServiceContext.GetDataServiceProvider<mvDiscountGroupServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            mvDiscountGroup serverData = null;

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    serverData = discountGroupServiceProvider.GetData().AddQueryOption("$select", Selector)
                        .Where(p => (p.Code.ToLower() == obj.Code.ToLower())).SingleOrDefault();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, discountGroupTableProvider, useTransaction);

            return exception;
        }

        protected override async Task<Exception> OnUploadDataAsync(mvDiscountGroup obj, bool useTransaction)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }



        private async Task ProcessLocalData(DateTime? syncDate, int status, int attempts, mvDiscountGroup serverData, mvDiscountGroup obj,
            mvDiscountGroupTableProvider tableProvider, bool useTransaction)
        {
            var localDate = (syncDate.HasValue) ? syncDate.Value : await DbContext.GetDatabaseUtcDateTimeAsync();
            mvDiscountGroup discountGroup = null;

            if (serverData == null)
            {
                discountGroup = new mvDiscountGroup();
                discountGroup.ID = obj.ID;

                await tableProvider.DeleteDataAsync(discountGroup, useTransaction);
            }
            else
            {
                var isInsert = false;
                var isDelete = false;
                discountGroup = await tableProvider.GetDataAsync(serverData.ID);
                if (discountGroup == null)
                {
                    isInsert = true;
                    discountGroup = new mvDiscountGroup();
                }                
                else if (discountGroup.IsDeleted)
                    isDelete = true;                    

                discountGroup.CopyFrom(serverData);
                DbContext.SetSyncData(discountGroup, syncDate, localDate, status, attempts);

                if (isInsert)
                    await tableProvider.InsertDataAsync(discountGroup, useTransaction);
                else if (isDelete)
                    await tableProvider.DeleteDataAsync(discountGroup, useTransaction);
                else
                    await tableProvider.UpdateDataAsync(discountGroup, useTransaction);

                if (obj != null)
                {
                    obj.CopyFrom(serverData);
                    DbContext.CopySyncData(obj, discountGroup);
                }
            }
        }

        #endregion

    }

}
