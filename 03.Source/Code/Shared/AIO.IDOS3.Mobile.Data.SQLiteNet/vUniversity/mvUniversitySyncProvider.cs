using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    public partial class mvUniversitySyncProvider : DataSyncProvider<mvUniversity>
    {
        #region Properties

        public static string Selector = "ID,UnivName,UnivPhoto,UnivAddress,UnivDetails";

        #endregion

        #region Methods

        protected override Exception OnDownloadAllData(bool continueOnError) { return OnDownloadAllDataAsync(continueOnError).Result; }
        protected override Exception OnUploadAllData(bool continueOnError) { return OnUploadAllDataAsync(continueOnError).Result; }
        protected override Exception OnDownloadData(mvUniversity obj, bool useTransaction) { return OnDownloadDataAsync(obj, useTransaction).Result; }
        protected override Exception OnUploadData(mvUniversity obj, bool useTransaction) { return OnUploadDataAsync(obj, useTransaction).Result; }


        protected override async Task<Exception> OnDownloadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var universityTableProvider = DbContext.GetDataTableProvider<mvUniversityTableProvider>();
            var universityServiceProvider = DataServiceContext.GetDataServiceProvider<mvUniversityServiceProvider>();

            DateTime? syncDate = null;

            List<mvUniversity> serverDataList = null;

            var minSyncDate = (DateTimeOffset?)await DbContext.GetMinSyncDateAsync<mvUniversity>();

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    var query = (IQueryable<mvUniversity>)universityServiceProvider.GetData().AddQueryOption("$select", Selector);

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
                            await ProcessLocalData(syncDate, 1, 1, serverData, null, universityTableProvider, true);
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

                await DbContext.UpdateAllSyncDateAsync<mvUniversity>(syncDate.Value);
            }

            return exception;
        }

        protected override async Task<Exception> OnUploadAllDataAsync(bool continueOnError)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }


        protected override async Task<Exception> OnDownloadDataAsync(mvUniversity obj, bool useTransaction)
        {
            Exception exception = null;

            var universityTableProvider = DbContext.GetDataTableProvider<mvUniversityTableProvider>();
            var universityServiceProvider = DataServiceContext.GetDataServiceProvider<mvUniversityServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            mvUniversity serverData = null;

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    serverData = universityServiceProvider.GetData().AddQueryOption("$select", Selector)
                        .Where(p => (p.ID == obj.ID)).SingleOrDefault();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, universityTableProvider, useTransaction);

            return exception;
        }

        private async Task ProcessLocalData(DateTime? syncDate, int status, int attempts, mvUniversity serverData, mvUniversity obj,
            mvUniversityTableProvider tableProvider, bool useTransaction)
        {
            var localDate = (syncDate.HasValue) ? syncDate.Value : await DbContext.GetDatabaseUtcDateTimeAsync();
            mvUniversity university = null;

            if (serverData == null)
            {
                university = new mvUniversity();
                university.ID = obj.ID;

                await tableProvider.DeleteDataAsync(university, useTransaction);
            }
            else
            {
                var isInsert = false;
                var isDelete = false;
                university = await tableProvider.GetDataAsync(serverData.ID);
                if (university == null)
                {
                    isInsert = true;
                    university = new mvUniversity();
                }
                else

                    university.CopyFrom(serverData);
                DbContext.SetSyncData(university, syncDate, localDate, status, attempts);

                if (isInsert)
                    await tableProvider.InsertDataAsync(university, useTransaction);
                else if (isDelete)
                    await tableProvider.DeleteDataAsync(university, useTransaction);
                else
                    await tableProvider.UpdateDataAsync(university, useTransaction);

                if (obj != null)
                {
                    obj.CopyFrom(serverData);
                    DbContext.CopySyncData(obj, university);
                }
            }
        }

        protected override async Task<Exception> OnUploadDataAsync(mvUniversity obj, bool useTransaction)
        {
            Exception exception = null;

            var universityTableProvider = DbContext.GetDataTableProvider<mvUniversityTableProvider>();
            var universityServiceProvider = DataServiceContext.GetDataServiceProvider<mvUniversityServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            var serverData = new mvUniversity();
            serverData.CopyFrom(obj);

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                    attempts++;

                    await universityServiceProvider.InsertDataAsync(serverData, useTransaction);

                    syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, universityTableProvider, useTransaction);

            return exception;
        }

        #endregion

    }
}
