using SQLite;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Wismapi.Data.SQLiteNet
{

    public class DataTableProvider<TData>
        where TData : class, new()
    {

        #region Constructors

        public DataTableProvider(CoreDbContext dbContext)
        {
            SuppressError = false;

            DbContext = dbContext;

            OnInitialized();
        }

        #endregion

        #region Properties

        public bool UseBulkSqlRaw { get; set; } = false;
        public string BulkSqlRaw { get; protected set; } = "";

        public CoreDbContext DbContext { get; }
        public bool SuppressError { get; set; }

        #endregion

        #region Methods

        public void ClearBulkSqlRaw() { BulkSqlRaw = ""; }
        public Exception ExecuteBulkSqlRaw() { return ExecuteBulkSqlRawAsync().Result; }

        public async Task<Exception> ExecuteBulkSqlRawAsync()
        {
            Exception exception = null;

            if (BulkSqlRaw.Length > 0)
            {
                try
                {
                    await DbContext.ExecuteAsync(BulkSqlRaw);
                }
                catch (Exception ex)
                {
                    exception = ex;
                    if (!SuppressError)
                        throw ex;
                }
            }

            return exception;
        }


        public virtual AsyncTableQuery<TData> GetData() { return DbContext.Table<TData>(); }

        public virtual TData GetData(params object[] primaryKeys) { return GetDataAsync(primaryKeys).Result; }

        public virtual async Task<TData> GetDataAsync(params object[] primaryKeys)
        {
            try
            {
                return (await DbContext.QueryAsync<TData>(DbContext.GetSelectCommand<TData>(), primaryKeys)).SingleOrDefault();
            }
            catch (Exception ex)
            {
                if (!SuppressError)
                    throw ex;
            }

            return null;
        }

        public virtual void InsertData(TData obj) { InsertData(obj, false); }
        public virtual void InsertData(TData obj, bool useTransaction) { InternalInsertDataAsync(obj, useTransaction).Wait(); }
        public virtual void UpdateData(TData obj) { UpdateData(obj, false); }
        public virtual void UpdateData(TData obj, bool useTransaction) { InternalUpdateDataAsync(obj, useTransaction).Wait(); }
        public virtual void DeleteData(TData obj) { DeleteData(obj, false); }
        public virtual void DeleteData(TData obj, bool useTransaction) { InternalDeleteDataAsync(obj, useTransaction).Wait(); }

        public virtual async Task InsertDataAsync(TData obj) { await InsertDataAsync(obj, false); }
        public virtual async Task InsertDataAsync(TData obj, bool useTransaction) { await InternalInsertDataAsync(obj, useTransaction); }
        public virtual async Task UpdateDataAsync(TData obj) { await UpdateDataAsync(obj, false); }
        public virtual async Task UpdateDataAsync(TData obj, bool useTransaction) { await InternalUpdateDataAsync(obj, useTransaction); }
        public virtual async Task DeleteDataAsync(TData obj) { await DeleteDataAsync(obj, false); }
        public virtual async Task DeleteDataAsync(TData obj, bool useTransaction) { await InternalDeleteDataAsync(obj, useTransaction); }



        protected virtual void OnInitialized() { }

        protected virtual void OnBeginInsertData(BeginOperationDataEventArgs<TData> e) { OnBeginInsertDataAsync(e).Wait(); }
        protected virtual void OnBeginUpdateData(BeginOperationDataEventArgs<TData> e) { OnBeginUpdateDataAsync(e).Wait(); }
        protected virtual void OnBeginDeleteData(BeginOperationDataEventArgs<TData> e) { OnBeginDeleteDataAsync(e).Wait(); }
        protected virtual void OnEndInsertData(EndOperationDataEventArgs<TData> e) { OnEndInsertDataAsync(e).Wait(); }
        protected virtual void OnEndUpdateData(EndOperationDataEventArgs<TData> e) { OnEndUpdateDataAsync(e).Wait(); }
        protected virtual void OnEndDeleteData(EndOperationDataEventArgs<TData> e) { OnEndDeleteDataAsync(e).Wait(); }

        protected virtual async Task OnBeginInsertDataAsync(BeginOperationDataEventArgs<TData> e) { BeginInsertData?.Invoke(this, e); await Task.CompletedTask; }
        protected virtual async Task OnBeginUpdateDataAsync(BeginOperationDataEventArgs<TData> e) { BeginUpdateData?.Invoke(this, e); await Task.CompletedTask; }
        protected virtual async Task OnBeginDeleteDataAsync(BeginOperationDataEventArgs<TData> e) { BeginDeleteData?.Invoke(this, e); await Task.CompletedTask; }
        protected virtual async Task OnEndInsertDataAsync(EndOperationDataEventArgs<TData> e) { EndInsertData?.Invoke(this, e); await Task.CompletedTask; }
        protected virtual async Task OnEndUpdateDataAsync(EndOperationDataEventArgs<TData> e) { EndUpdateData?.Invoke(this, e); await Task.CompletedTask; }
        protected virtual async Task OnEndDeleteDataAsync(EndOperationDataEventArgs<TData> e) { EndDeleteData?.Invoke(this, e); await Task.CompletedTask; }


        protected virtual async Task InternalInsertDataAsync(TData obj, bool useTransaction)
        {
            var beginOperationDataEventArgs = new BeginOperationDataEventArgs<TData>(obj, useTransaction);

            await OnBeginInsertDataAsync(beginOperationDataEventArgs);
            if (!beginOperationDataEventArgs.Cancel)
            {
                Exception exception = null;

                try
                {
                    if (!useTransaction)
                    {
                        var timeout = 30; // 30 seconds
                        while (DbContext.GetConnection().IsInTransaction && (timeout > 0))
                        {
                            await Task.Delay(1000);
                            timeout--;
                        }

                        if (timeout == 0)
                            throw new TimeoutException("Insert operation timeout");
                    }

                    await DbContext.ExecuteAsync(DbContext.GetInsertCommand<TData>(), DbContext.GetCommandParameters(obj, true, false));
                }
                catch (Exception ex)
                {
                    exception = ex;
                    if (!SuppressError)
                        throw ex;
                }

                await OnEndInsertDataAsync(new EndOperationDataEventArgs<TData>(obj, exception, useTransaction));
            }
            else
                await OnEndInsertDataAsync(new EndOperationDataEventArgs<TData>(obj, null, useTransaction, true));
        }

        protected virtual async Task InternalUpdateDataAsync(TData obj, bool useTransaction)
        {
            var beginOperationDataEventArgs = new BeginOperationDataEventArgs<TData>(obj, useTransaction);

            await OnBeginUpdateDataAsync(beginOperationDataEventArgs);
            if (!beginOperationDataEventArgs.Cancel)
            {
                Exception exception = null;

                try
                {
                    if (!useTransaction)
                    {
                        var timeout = 30; // 30 seconds
                        while (DbContext.GetConnection().IsInTransaction && (timeout > 0))
                        {
                            await Task.Delay(1000);
                            timeout--;
                        }

                        if (timeout == 0)
                            throw new TimeoutException("Update operation timeout");
                    }

                    await DbContext.ExecuteAsync(DbContext.GetUpdateCommand<TData>(), DbContext.GetCommandParameters(obj, true, true));
                }
                catch (Exception ex)
                {
                    exception = ex;
                    if (!SuppressError)
                        throw ex;
                }

                await OnEndUpdateDataAsync(new EndOperationDataEventArgs<TData>(obj, exception, useTransaction));
            }
            else
                await OnEndUpdateDataAsync(new EndOperationDataEventArgs<TData>(obj, null, useTransaction, true));
        }

        protected virtual async Task InternalDeleteDataAsync(TData obj, bool useTransaction)
        {
            var beginOperationDataEventArgs = new BeginOperationDataEventArgs<TData>(obj, useTransaction);

            await OnBeginDeleteDataAsync(beginOperationDataEventArgs);
            if (!beginOperationDataEventArgs.Cancel)
            {
                Exception exception = null;

                try
                {
                    if (!useTransaction)
                    {
                        var timeout = 30; // 30 seconds
                        while (DbContext.GetConnection().IsInTransaction && (timeout > 0))
                        {
                            await Task.Delay(1000);
                            timeout--;
                        }

                        if (timeout == 0)
                            throw new TimeoutException("Delete operation timeout");
                    }

                    await DbContext.ExecuteAsync(DbContext.GetDeleteCommand<TData>(), DbContext.GetCommandParameters(obj, false, true));
                }
                catch (Exception ex)
                {
                    exception = ex;
                    if (!SuppressError)
                        throw ex;
                }

                await OnEndDeleteDataAsync(new EndOperationDataEventArgs<TData>(obj, exception, useTransaction));
            }
            else
                await OnEndDeleteDataAsync(new EndOperationDataEventArgs<TData>(obj, null, useTransaction, true));
        }

        #endregion

        #region Events

        public event EventHandler<BeginOperationDataEventArgs<TData>> BeginInsertData;
        public event EventHandler<BeginOperationDataEventArgs<TData>> BeginUpdateData;
        public event EventHandler<BeginOperationDataEventArgs<TData>> BeginDeleteData;
        public event EventHandler<EndOperationDataEventArgs<TData>> EndInsertData;
        public event EventHandler<EndOperationDataEventArgs<TData>> EndUpdateData;
        public event EventHandler<EndOperationDataEventArgs<TData>> EndDeleteData;

        #endregion

    }

}
