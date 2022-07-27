using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    public partial class mvRegisterSyncProvider : DataSyncProvider<mvRegister>
    {
        #region Properties

        public static string Selector = "ID,Username,Email,Password";

        #endregion

        #region Methods

        protected override Exception OnDownloadAllData(bool continueOnError) { return OnDownloadAllDataAsync(continueOnError).Result; }
        protected override Exception OnUploadAllData(bool continueOnError) { return OnUploadAllDataAsync(continueOnError).Result; }
        protected override Exception OnDownloadData(mvRegister obj, bool useTransaction) { return OnDownloadDataAsync(obj, useTransaction).Result; }
        protected override Exception OnUploadData(mvRegister obj, bool useTransaction) { return OnUploadDataAsync(obj, useTransaction).Result; }


        protected override async Task<Exception> OnDownloadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var registerTableProvider = DbContext.GetDataTableProvider<mvRegisterTableProvider>();
            var registerServiceProvider = DataServiceContext.GetDataServiceProvider<mvRegisterServiceProvider>();

            DateTime? syncDate = null;

            List<mvRegister> serverDataList = null;

            var minSyncDate = (DateTimeOffset?)await DbContext.GetMinSyncDateAsync<mvRegister>();

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    var query = (IQueryable<mvRegister>)registerServiceProvider.GetData().AddQueryOption("$select", Selector);

                    if (minSyncDate.HasValue)
                       // query = query.Where(p => (p.CreatedDate > minSyncDate.Value) || ((p.ModifiedDate != null) && (p.ModifiedDate.Value > minSyncDate.Value)));

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
                            await ProcessLocalData(syncDate, 1, 1, serverData, null, registerTableProvider, true);
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

                await DbContext.UpdateAllSyncDateAsync<mvRegister>(syncDate.Value);
            }

            return exception;
        }

        protected override async Task<Exception> OnUploadAllDataAsync(bool continueOnError)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }


        protected override async Task<Exception> OnDownloadDataAsync(mvRegister obj, bool useTransaction)
        {
            Exception exception = null;

            var registerTableProvider = DbContext.GetDataTableProvider<mvRegisterTableProvider>();
            var registerServiceProvider = DataServiceContext.GetDataServiceProvider<mvRegisterServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            mvRegister serverData = null;

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    serverData = registerServiceProvider.GetData().AddQueryOption("$select", Selector)
                        .Where(p => (p.ID == obj.ID)).SingleOrDefault();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, registerTableProvider, useTransaction);

            return exception;
        }

        private async Task ProcessLocalData(DateTime? syncDate, int status, int attempts, mvRegister serverData, mvRegister obj,
            mvRegisterTableProvider tableProvider, bool useTransaction)
        {
            var localDate = (syncDate.HasValue) ? syncDate.Value : await DbContext.GetDatabaseUtcDateTimeAsync();
            mvRegister register = null;

            if (serverData == null)
            {
                register = new mvRegister();
                register.ID = obj.ID;

                await tableProvider.DeleteDataAsync(register, useTransaction);
            }
            else
            {
                var isInsert = false;
                var isDelete = false;
                register = await tableProvider.GetDataAsync(serverData.ID);
                if (register == null)
                {
                    isInsert = true;
                    register = new mvRegister();
                }
                else

                    register.CopyFrom(serverData);
                DbContext.SetSyncData(register, syncDate, localDate, status, attempts);

                if (isInsert)
                    await tableProvider.InsertDataAsync(register, useTransaction);
                else if (isDelete)
                    await tableProvider.DeleteDataAsync(register, useTransaction);
                else
                    await tableProvider.UpdateDataAsync(register, useTransaction);

                if (obj != null)
                {
                    obj.CopyFrom(serverData);
                    DbContext.CopySyncData(obj, register);
                }
            }
        }

        protected override async Task<Exception> OnUploadDataAsync(mvRegister obj, bool useTransaction)
        {
            Exception exception = null;

            var registerTableProvider = DbContext.GetDataTableProvider<mvRegisterTableProvider>();
            var registerServiceProvider = DataServiceContext.GetDataServiceProvider<mvRegisterServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            var serverData = new mvRegister();
            serverData.CopyFrom(obj);

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                    attempts++;

                    await registerServiceProvider.InsertDataAsync(serverData, useTransaction);

                    syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, registerTableProvider, useTransaction);

            return exception;
        }

        #endregion

    }
}
