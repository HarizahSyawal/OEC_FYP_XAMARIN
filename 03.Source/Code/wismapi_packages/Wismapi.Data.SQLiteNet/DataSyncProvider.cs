using System;
using System.Threading.Tasks;

namespace Wismapi.Data.SQLiteNet
{

    public class DataSyncProvider<TData>
    {

        #region Constructors

        public DataSyncProvider(CoreDbContext dbContext, CoreDataServiceContext dataServiceContext)
        {
            SuppressError = false;

            DbContext = dbContext;
            DataServiceContext = dataServiceContext;

            OnInitialized();
        }

        #endregion

        #region Properties

        public CoreDbContext DbContext { get; }
        public CoreDataServiceContext DataServiceContext { get; }
        public bool SuppressError { get; set; }

        #endregion

        #region Methods

        public virtual Exception DownloadAllData(bool continueOnError) { return InternalDownloadAllDataAsync(continueOnError).Result; }
        public virtual Exception UploadAllData(bool continueOnError) { return InternalUploadAllDataAsync(continueOnError).Result; }
        
        public virtual Exception DownloadData(TData obj) { return DownloadData(obj, false); }
        public virtual Exception DownloadData(TData obj, bool useTransaction) { return InternalDownloadDataAsync(obj, useTransaction).Result; }
        public virtual Exception UploadData(TData obj) { return UploadData(obj, false); }
        public virtual Exception UploadData(TData obj, bool useTransaction) { return InternalUploadDataAsync(obj, useTransaction).Result; }

        public virtual async Task<Exception> DownloadAllDataAsync(bool continueOnError) { return await InternalDownloadAllDataAsync(continueOnError); }
        public virtual async Task<Exception> UploadAllDataAsync(bool continueOnError) { return await InternalUploadAllDataAsync(continueOnError); }
        
        public virtual async Task<Exception> DownloadDataAsync(TData obj) { return await DownloadDataAsync(obj, false); }
        public virtual async Task<Exception> DownloadDataAsync(TData obj, bool useTransaction) { return await InternalDownloadDataAsync(obj, useTransaction); }
        public virtual async Task<Exception> UploadDataAsync(TData obj) { return await UploadDataAsync(obj, false); }
        public virtual async Task<Exception> UploadDataAsync(TData obj, bool useTransaction) { return await InternalUploadDataAsync(obj, useTransaction); }



        protected virtual void OnInitialized() { }

        protected virtual Exception OnDownloadAllData(bool continueOnError) { throw new NotImplementedException(); }
        protected virtual Exception OnUploadAllData(bool continueOnError) { throw new NotImplementedException(); }

        protected virtual Exception OnDownloadData(TData obj) { return OnDownloadData(obj, false); }
        protected virtual Exception OnDownloadData(TData obj, bool useTransaction) { throw new NotImplementedException(); }
        protected virtual Exception OnUploadData(TData obj) { return OnUploadData(obj, false); }
        protected virtual Exception OnUploadData(TData obj, bool useTransaction) { throw new NotImplementedException(); }

        protected virtual async Task<Exception> OnDownloadAllDataAsync(bool continueOnError) { await Task.CompletedTask; throw new NotImplementedException(); }
        protected virtual async Task<Exception> OnUploadAllDataAsync(bool continueOnError) { await Task.CompletedTask; throw new NotImplementedException(); }

        protected virtual async Task<Exception> OnDownloadDataAsync(TData obj) { return await OnDownloadDataAsync(obj, false); }
        protected virtual async Task<Exception> OnDownloadDataAsync(TData obj, bool useTransaction) { await Task.CompletedTask; throw new NotImplementedException(); }
        protected virtual async Task<Exception> OnUploadDataAsync(TData obj) { return await OnUploadDataAsync(obj, false); }
        protected virtual async Task<Exception> OnUploadDataAsync(TData obj, bool useTransaction) { await Task.CompletedTask; throw new NotImplementedException(); }


        protected virtual void OnBeginDownloadAllData(BeginOperationDataEventArgs<TData> e) { OnBeginDownloadAllDataAsync(e).Wait(); }
        protected virtual void OnBeginUploadAllData(BeginOperationDataEventArgs<TData> e) { OnBeginUploadAllDataAsync(e).Wait(); }
        protected virtual void OnEndDownloadAllData(EndOperationDataEventArgs<TData> e) { OnEndDownloadAllDataAsync(e).Wait(); }
        protected virtual void OnEndUploadAllData(EndOperationDataEventArgs<TData> e) { OnEndUploadAllDataAsync(e).Wait(); }

        protected virtual void OnBeginDownloadData(BeginOperationDataEventArgs<TData> e) { OnBeginDownloadDataAsync(e).Wait(); }
        protected virtual void OnBeginUploadData(BeginOperationDataEventArgs<TData> e) { OnBeginUploadDataAsync(e).Wait(); }
        protected virtual void OnEndDownloadData(EndOperationDataEventArgs<TData> e) { OnEndDownloadDataAsync(e).Wait(); }
        protected virtual void OnEndUploadData(EndOperationDataEventArgs<TData> e) { OnEndUploadDataAsync(e).Wait(); }

        protected virtual async Task OnBeginDownloadAllDataAsync(BeginOperationDataEventArgs<TData> e) { BeginDownloadAllData?.Invoke(this, e); await Task.CompletedTask; }
        protected virtual async Task OnBeginUploadAllDataAsync(BeginOperationDataEventArgs<TData> e) { BeginUploadAllData?.Invoke(this, e); await Task.CompletedTask; }
        protected virtual async Task OnEndDownloadAllDataAsync(EndOperationDataEventArgs<TData> e) { EndDownloadAllData?.Invoke(this, e); await Task.CompletedTask; }
        protected virtual async Task OnEndUploadAllDataAsync(EndOperationDataEventArgs<TData> e) { EndUploadAllData?.Invoke(this, e); await Task.CompletedTask; }

        protected virtual async Task OnBeginDownloadDataAsync(BeginOperationDataEventArgs<TData> e) { BeginDownloadData?.Invoke(this, e); await Task.CompletedTask; }
        protected virtual async Task OnBeginUploadDataAsync(BeginOperationDataEventArgs<TData> e) { BeginUploadData?.Invoke(this, e); await Task.CompletedTask; }
        protected virtual async Task OnEndDownloadDataAsync(EndOperationDataEventArgs<TData> e) { EndDownloadData?.Invoke(this, e); await Task.CompletedTask; }
        protected virtual async Task OnEndUploadDataAsync(EndOperationDataEventArgs<TData> e) { EndUploadData?.Invoke(this, e); await Task.CompletedTask; }



        protected virtual async Task<Exception> InternalDownloadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var beginOperationDataEventArgs = new BeginOperationDataEventArgs<TData>();

            await OnBeginDownloadAllDataAsync(beginOperationDataEventArgs);
            if (!beginOperationDataEventArgs.Cancel)
            {
                try
                {
                    exception = await OnDownloadAllDataAsync(continueOnError);
                }
                catch (Exception ex)
                {
                    exception = ex;
                    if (!SuppressError)
                        throw ex;
                }

                await OnEndDownloadAllDataAsync(new EndOperationDataEventArgs<TData>(exception, true));
            }
            else
                await OnEndDownloadAllDataAsync(new EndOperationDataEventArgs<TData>(null, true, true));

            return exception;
        }

        protected virtual async Task<Exception> InternalUploadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var beginOperationDataEventArgs = new BeginOperationDataEventArgs<TData>();

            await OnBeginUploadAllDataAsync(beginOperationDataEventArgs);
            if (!beginOperationDataEventArgs.Cancel)
            {
                try
                {
                    exception = await OnUploadAllDataAsync(continueOnError);
                }
                catch (Exception ex)
                {
                    exception = ex;
                    if (!SuppressError)
                        throw ex;
                }

                await OnEndUploadAllDataAsync(new EndOperationDataEventArgs<TData>(exception, true));
            }
            else
                await OnEndUploadAllDataAsync(new EndOperationDataEventArgs<TData>(null, true, true));

            return exception;
        }


        protected virtual async Task<Exception> InternalDownloadDataAsync(TData obj, bool useTransaction)
        {
            Exception exception = null;

            var beginOperationDataEventArgs = new BeginOperationDataEventArgs<TData>(obj, useTransaction);

            await OnBeginDownloadDataAsync(beginOperationDataEventArgs);
            if (!beginOperationDataEventArgs.Cancel)
            {
                try
                {
                    if (!useTransaction)
                        exception = await OnDownloadDataAsync(obj);
                    else
                        exception = await OnDownloadDataAsync(obj, useTransaction);
                }
                catch (Exception ex)
                {
                    exception = ex;
                    if (!SuppressError)
                        throw ex;
                }

                await OnEndDownloadDataAsync(new EndOperationDataEventArgs<TData>(obj, exception, useTransaction));
            }
            else
                await OnEndDownloadDataAsync(new EndOperationDataEventArgs<TData>(null, useTransaction, true));

            return exception;
        }

        protected virtual async Task<Exception> InternalUploadDataAsync(TData obj, bool useTransaction)
        {
            Exception exception = null;

            var beginOperationDataEventArgs = new BeginOperationDataEventArgs<TData>(obj, useTransaction);

            await OnBeginUploadDataAsync(beginOperationDataEventArgs);
            if (!beginOperationDataEventArgs.Cancel)
            {
                try
                {
                    if (!useTransaction)
                        exception = await OnUploadDataAsync(obj);
                    else
                        exception = await OnUploadDataAsync(obj, useTransaction);
                }
                catch (Exception ex)
                {
                    exception = ex;
                    if (!SuppressError)
                        throw ex;
                }

                await OnEndUploadDataAsync(new EndOperationDataEventArgs<TData>(obj, exception, useTransaction));
            }
            else
                await OnEndUploadDataAsync(new EndOperationDataEventArgs<TData>(null, useTransaction, true));

            return exception;
        }

        #endregion

        #region Events

        public event EventHandler<BeginOperationDataEventArgs<TData>> BeginDownloadAllData;
        public event EventHandler<BeginOperationDataEventArgs<TData>> BeginUploadAllData;
        public event EventHandler<EndOperationDataEventArgs<TData>> EndDownloadAllData;
        public event EventHandler<EndOperationDataEventArgs<TData>> EndUploadAllData;


        public event EventHandler<BeginOperationDataEventArgs<TData>> BeginDownloadData;
        public event EventHandler<BeginOperationDataEventArgs<TData>> BeginUploadData;
        public event EventHandler<EndOperationDataEventArgs<TData>> EndDownloadData;
        public event EventHandler<EndOperationDataEventArgs<TData>> EndUploadData;

        #endregion

    }

}
