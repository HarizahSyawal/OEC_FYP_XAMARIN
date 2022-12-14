// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 07:11:02
// Description   : mvMobileDeviceSyncProvider partial class.
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

    public partial class mvMobileDeviceSyncProvider : DataSyncProvider<mvMobileDevice>
    {

        #region Properties

        public static string Selector = "ID,IMEI,CreatedDate,ModifiedDate";

        #endregion

        #region Methods

        private async Task<Expression<Func<mvMobileDevice, bool>>> GetFilter()
        {
            var imei = "123"; ///////////////////////////////////////////

            Expression filter = null;
            var type = typeof(mvMobileDevice);
            var param = Expression.Parameter(type, "param");

            var propIMEI = Expression.Property(param, "IMEI");
            filter = Expression.MakeBinary(ExpressionType.Equal, propIMEI, Expression.Constant(imei, type.GetProperty("IMEI").PropertyType));

            return Expression.Lambda<Func<mvMobileDevice, bool>>(filter, param);
        }



        protected override Exception OnDownloadAllData(bool continueOnError) { return OnDownloadAllDataAsync(continueOnError).Result; }
        protected override Exception OnUploadAllData(bool continueOnError) { return OnUploadAllDataAsync(continueOnError).Result; }
        protected override Exception OnDownloadData(mvMobileDevice obj, bool useTransaction) { return OnDownloadDataAsync(obj, useTransaction).Result; }
        protected override Exception OnUploadData(mvMobileDevice obj, bool useTransaction) { return OnUploadDataAsync(obj, useTransaction).Result; }


        protected override async Task<Exception> OnDownloadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var employeeTableProvider = DbContext.GetDataTableProvider<mvMobileDeviceTableProvider>();
            var employeeServiceProvider = DataServiceContext.GetDataServiceProvider<mvMobileDeviceServiceProvider>();

            DateTime? syncDate = null;

            List<mvMobileDevice> serverDataList = null;

            var minSyncDate = (DateTimeOffset?)await employeeTableProvider.GetData().MinAsync(p => p.SyncDate);

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    var query = employeeServiceProvider.GetData().AddQueryOption("$select", Selector).Where(await GetFilter());

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
                        await ProcessLocalData(syncDate, 1, 1, serverData, null, employeeTableProvider, true);
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


        protected override async Task<Exception> OnDownloadDataAsync(mvMobileDevice obj, bool useTransaction)
        {
            Exception exception = null;

            var employeeTableProvider = DbContext.GetDataTableProvider<mvMobileDeviceTableProvider>();
            var employeeServiceProvider = DataServiceContext.GetDataServiceProvider<mvMobileDeviceServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            mvMobileDevice serverData = null;

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    serverData = employeeServiceProvider.GetData().AddQueryOption("$select", Selector)
                        .Where(p => p.ID.Equals(obj.ID)).SingleOrDefault();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, employeeTableProvider, useTransaction);

            return exception;
        }

        protected override async Task<Exception> OnUploadDataAsync(mvMobileDevice obj, bool useTransaction)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }



        private async Task ProcessLocalData(DateTime? syncDate, int status, int attempts, mvMobileDevice serverData, mvMobileDevice obj,
            mvMobileDeviceTableProvider tableProvider, bool useTransaction)
        {
            var localDate = (syncDate.HasValue) ? syncDate.Value : await DbContext.GetDatabaseUtcDateTimeAsync();
            mvMobileDevice employee = null;

            if (serverData == null)
            {
                employee = new mvMobileDevice();
                employee.ID = obj.ID;

                await tableProvider.DeleteDataAsync(employee, useTransaction);
            }
            else
            {
                var isInsert = false;
                employee = await tableProvider.GetDataAsync(serverData.ID);
                if (employee == null)
                {
                    isInsert = true;
                    employee = new mvMobileDevice();
                }

                employee.CopyFrom(serverData);
                DbContext.SetSyncData(employee, syncDate, localDate, status, attempts);

                if (isInsert)
                    await tableProvider.InsertDataAsync(employee, useTransaction);
                else
                    await tableProvider.UpdateDataAsync(employee, useTransaction);

                if (obj != null)
                {
                    obj.CopyFrom(serverData);
                    DbContext.CopySyncData(obj, employee);
                }
            }
        }

        #endregion

    }

}
