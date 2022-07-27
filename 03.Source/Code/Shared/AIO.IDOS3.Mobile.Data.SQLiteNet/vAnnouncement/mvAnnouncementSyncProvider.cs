using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    public partial class mvAnnouncementSyncProvider : DataSyncProvider<mvAnnouncement>
    {
        #region Properties

        public static string Selector = "ID,Title,Photo,Description";

        #endregion

        #region Methods

        protected override Exception OnDownloadAllData(bool continueOnError) { return OnDownloadAllDataAsync(continueOnError).Result; }
        protected override Exception OnUploadAllData(bool continueOnError) { return OnUploadAllDataAsync(continueOnError).Result; }
        protected override Exception OnDownloadData(mvAnnouncement obj, bool useTransaction) { return OnDownloadDataAsync(obj, useTransaction).Result; }
        protected override Exception OnUploadData(mvAnnouncement obj, bool useTransaction) { return OnUploadDataAsync(obj, useTransaction).Result; }


        protected override async Task<Exception> OnDownloadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var announcementTableProvider = DbContext.GetDataTableProvider<mvAnnouncementTableProvider>();
            var announcementServiceProvider = DataServiceContext.GetDataServiceProvider<mvAnnouncementServiceProvider>();

            DateTime? syncDate = null;

            List<mvAnnouncement> serverDataList = null;

            var minSyncDate = (DateTimeOffset?)await DbContext.GetMinSyncDateAsync<mvAnnouncement>();

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    var query = (IQueryable<mvAnnouncement>)announcementServiceProvider.GetData().AddQueryOption("$select", Selector);

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
                            await ProcessLocalData(syncDate, 1, 1, serverData, null, announcementTableProvider, true);
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

                await DbContext.UpdateAllSyncDateAsync<mvAnnouncement>(syncDate.Value);
            }

            return exception;
        }

        protected override async Task<Exception> OnUploadAllDataAsync(bool continueOnError)
        {
            Exception exception = new NotImplementedException();

            return await Task.FromResult(exception);
        }


        protected override async Task<Exception> OnDownloadDataAsync(mvAnnouncement obj, bool useTransaction)
        {
            Exception exception = null;

            var announcementTableProvider = DbContext.GetDataTableProvider<mvAnnouncementTableProvider>();
            var announcementServiceProvider = DataServiceContext.GetDataServiceProvider<mvAnnouncementServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            mvAnnouncement serverData = null;

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    serverData = announcementServiceProvider.GetData().AddQueryOption("$select", Selector)
                        .Where(p => (p.ID == obj.ID)).SingleOrDefault();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, announcementTableProvider, useTransaction);

            return exception;
        }

        private async Task ProcessLocalData(DateTime? syncDate, int status, int attempts, mvAnnouncement serverData, mvAnnouncement obj,
            mvAnnouncementTableProvider tableProvider, bool useTransaction)
        {
            var localDate = (syncDate.HasValue) ? syncDate.Value : await DbContext.GetDatabaseUtcDateTimeAsync();
            mvAnnouncement announcement = null;

            if (serverData == null)
            {
                announcement = new mvAnnouncement();
                announcement.ID = obj.ID;

                await tableProvider.DeleteDataAsync(announcement, useTransaction);
            }
            else
            {
                var isInsert = false;
                var isDelete = false;
                announcement = await tableProvider.GetDataAsync(serverData.ID);
                if (announcement == null)
                {
                    isInsert = true;
                    announcement = new mvAnnouncement();
                }
                else

                    announcement.CopyFrom(serverData);
                DbContext.SetSyncData(announcement, syncDate, localDate, status, attempts);

                if (isInsert)
                    await tableProvider.InsertDataAsync(announcement, useTransaction);
                else if (isDelete)
                    await tableProvider.DeleteDataAsync(announcement, useTransaction);
                else
                    await tableProvider.UpdateDataAsync(announcement, useTransaction);

                if (obj != null)
                {
                    obj.CopyFrom(serverData);
                    DbContext.CopySyncData(obj, announcement);
                }
            }
        }

        protected override async Task<Exception> OnUploadDataAsync(mvAnnouncement obj, bool useTransaction)
        {
            Exception exception = null;

            var announcementTableProvider = DbContext.GetDataTableProvider<mvAnnouncementTableProvider>();
            var announcementServiceProvider = DataServiceContext.GetDataServiceProvider<mvAnnouncementServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            var serverData = new mvAnnouncement();
            serverData.CopyFrom(obj);

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                    attempts++;

                    await announcementServiceProvider.InsertDataAsync(serverData, useTransaction);

                    syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, announcementTableProvider, useTransaction);

            return exception;
        }

        #endregion

    }
}
