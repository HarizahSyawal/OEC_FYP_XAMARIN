using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    public partial class mvLoginSyncProvider : DataSyncProvider<mvLogin>
    {
        #region Properties

        public static string Selector = "ID,Username,Password";

        #endregion

        #region Methods

        protected override Exception OnDownloadAllData(bool continueOnError) { return OnDownloadAllDataAsync(continueOnError).Result; }
        protected override Exception OnUploadAllData(bool continueOnError) { return OnUploadAllDataAsync(continueOnError).Result; }
        protected override Exception OnDownloadData(mvLogin obj, bool useTransaction) { return OnDownloadDataAsync(obj, useTransaction).Result; }
        protected override Exception OnUploadData(mvLogin obj, bool useTransaction) { return OnUploadDataAsync(obj, useTransaction).Result; }


        protected override async Task<Exception> OnDownloadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var loginTableProvider = DbContext.GetDataTableProvider<mvLoginTableProvider>();
            var loginServiceProvider = DataServiceContext.GetDataServiceProvider<mvLoginServiceProvider>();

            DateTime? syncDate = null;

            List<mvLogin> serverDataList = null;

            var minSyncDate = (DateTimeOffset?)await DbContext.GetMinSyncDateAsync<mvLogin>();

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    var query = (IQueryable<mvLogin>)loginServiceProvider.GetData().AddQueryOption("$select", Selector);

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
                            await ProcessLocalData(syncDate, 1, 1, serverData, null, loginTableProvider, true);
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

                await DbContext.UpdateAllSyncDateAsync<mvLogin>(syncDate.Value);
            }

            return exception;
        }

        protected override async Task<Exception> OnUploadAllDataAsync(bool continueOnError)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }


        protected override async Task<Exception> OnDownloadDataAsync(mvLogin obj, bool useTransaction)
        {
            Exception exception = null;

            var loginTableProvider = DbContext.GetDataTableProvider<mvLoginTableProvider>();
            var loginServiceProvider = DataServiceContext.GetDataServiceProvider<mvLoginServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            mvLogin serverData = null;

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    serverData = loginServiceProvider.GetData().AddQueryOption("$select", Selector)
                        .Where(p => (p.ID == obj.ID)).SingleOrDefault();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, loginTableProvider, useTransaction);

            return exception;
        }

        private async Task ProcessLocalData(DateTime? syncDate, int status, int attempts, mvLogin serverData, mvLogin obj,
            mvLoginTableProvider tableProvider, bool useTransaction)
        {
            var localDate = (syncDate.HasValue) ? syncDate.Value : await DbContext.GetDatabaseUtcDateTimeAsync();
            mvLogin login = null;

            if (serverData == null)
            {
                login = new mvLogin();
                login.ID = obj.ID;

                await tableProvider.DeleteDataAsync(login, useTransaction);
            }
            else
            {
                var isInsert = false;
                var isDelete = false;
                login = await tableProvider.GetDataAsync(serverData.ID);
                if (login == null)
                {
                    isInsert = true;
                    login = new mvLogin();
                }
                else

                    login.CopyFrom(serverData);
                DbContext.SetSyncData(login, syncDate, localDate, status, attempts);

                if (isInsert)
                    await tableProvider.InsertDataAsync(login, useTransaction);
                else if (isDelete)
                    await tableProvider.DeleteDataAsync(login, useTransaction);
                else
                    await tableProvider.UpdateDataAsync(login, useTransaction);

                if (obj != null)
                {
                    obj.CopyFrom(serverData);
                    DbContext.CopySyncData(obj, login);
                }
            }
        }

        protected override async Task<Exception> OnUploadDataAsync(mvLogin obj, bool useTransaction)
        {
            Exception exception = null;

            var loginTableProvider = DbContext.GetDataTableProvider<mvLoginTableProvider>();
            var loginServiceProvider = DataServiceContext.GetDataServiceProvider<mvLoginServiceProvider>();


            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            var serverData = new mvLogin();
            serverData.CopyFrom(obj);

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                    attempts++;

                    await loginServiceProvider.InsertDataAsync(serverData, useTransaction);

                    syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, loginTableProvider, useTransaction);

            return exception;
        }

        #endregion

    }
}
