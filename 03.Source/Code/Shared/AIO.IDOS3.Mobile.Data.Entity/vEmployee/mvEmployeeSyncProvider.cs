// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 07:11:02
// Description   : mvEmployeeSyncProvider partial class.
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

    public partial class mvEmployeeSyncProvider : DataSyncProvider<mvEmployee>
    {

        #region Properties
        
        public static string Selector = "ID,Code,FirstName,LastName,Employee,CompanyID,Gender,BirthPlace,BirthDate,CitizenIDCard,NationalityID,NationalityName,RegisteredDate,UserID,Address1,Address2,Address,City,StateProvince,CountryID,CountryName,ZipCode,Phone1,Phone2,Email,Photo,StatusID,StatusName,CreatedDate,ModifiedDate";

        #endregion

        #region Methods

        private async Task<Expression<Func<mvEmployee, bool>>> GetFilter()
        {
            var userID = await DbContext.GetDataTableProvider<mvUserTableProvider>().GetData().Select(p => p.ID).SingleAsync();

            Expression filter = null;
            var type = typeof(mvEmployee);
            var param = Expression.Parameter(type, "param");

            var propUserID = Expression.Property(param, "UserID");
            filter = Expression.MakeBinary(ExpressionType.Equal, propUserID, Expression.Constant(userID, type.GetProperty("UserID").PropertyType));

            return Expression.Lambda<Func<mvEmployee, bool>>(filter, param);
        }



        protected override Exception OnDownloadAllData(bool continueOnError) { return OnDownloadAllDataAsync(continueOnError).Result; }
        protected override Exception OnUploadAllData(bool continueOnError) { return OnUploadAllDataAsync(continueOnError).Result; }
        protected override Exception OnDownloadData(mvEmployee obj, bool useTransaction) { return OnDownloadDataAsync(obj, useTransaction).Result; }
        protected override Exception OnUploadData(mvEmployee obj, bool useTransaction) { return OnUploadDataAsync(obj, useTransaction).Result; }


        protected override async Task<Exception> OnDownloadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var employeeTableProvider = DbContext.GetDataTableProvider<mvEmployeeTableProvider>();
            var employeeServiceProvider = DataServiceContext.GetDataServiceProvider<mvEmployeeServiceProvider>();

            DateTime? syncDate = null;

            List<mvEmployee> serverDataList = null;

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


        protected override async Task<Exception> OnDownloadDataAsync(mvEmployee obj, bool useTransaction)
        {
            Exception exception = null;

            var employeeTableProvider = DbContext.GetDataTableProvider<mvEmployeeTableProvider>();
            var employeeServiceProvider = DataServiceContext.GetDataServiceProvider<mvEmployeeServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            mvEmployee serverData = null;

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

        protected override async Task<Exception> OnUploadDataAsync(mvEmployee obj, bool useTransaction)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }



        private async Task ProcessLocalData(DateTime? syncDate, int status, int attempts, mvEmployee serverData, mvEmployee obj,
            mvEmployeeTableProvider tableProvider, bool useTransaction)
        {
            var localDate = (syncDate.HasValue) ? syncDate.Value : await DbContext.GetDatabaseUtcDateTimeAsync();
            mvEmployee employee = null;

            if (serverData == null)
            {
                employee = new mvEmployee();
                employee.ID = obj.ID;

                await tableProvider.DeleteDataAsync(employee, useTransaction);
            }
            else
            {
                var isInsert = false;
                var isDelete = false;
                employee = await tableProvider.GetDataAsync(serverData.ID);
                if (employee == null)
                {
                    isInsert = true;
                    employee = new mvEmployee();
                }                
                else if (employee.IsDeleted)
                    isDelete = true;                    

                employee.CopyFrom(serverData);
                DbContext.SetSyncData(employee, syncDate, localDate, status, attempts);

                if (isInsert)
                    await tableProvider.InsertDataAsync(employee, useTransaction);
                else if (isDelete)
                    await tableProvider.DeleteDataAsync(employee, useTransaction);
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
