using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Threading.Tasks;

namespace Wismapi.Data.Entity
{

    public abstract class DataViewProvider<TData> : DataTableProvider<TData>
        where TData : class
    {

        #region Constructors

        public DataViewProvider(CoreDbContext dbContext)
            : base(dbContext)
        {

        }

        #endregion

        #region Methods

        protected virtual void OnInsertData(TData obj) { OnInsertData(obj, false); }
        protected virtual void OnInsertData(TData obj, bool useTransaction) { throw new NotImplementedException(); }
        protected virtual void OnUpdateData(TData obj) { OnUpdateData(obj, false); }
        protected virtual void OnUpdateData(TData obj, bool useTransaction) { throw new NotImplementedException(); }
        protected virtual void OnDeleteData(TData obj) { OnDeleteData(obj, false); }
        protected virtual void OnDeleteData(TData obj, bool useTransaction) { throw new NotImplementedException(); }

        protected virtual async Task OnInsertDataAsync(TData obj) { await OnInsertDataAsync(obj, false); }
        protected virtual async Task OnInsertDataAsync(TData obj, bool useTransaction) { await Task.CompletedTask; throw new NotImplementedException(); }
        protected virtual async Task OnUpdateDataAsync(TData obj) { await OnUpdateDataAsync(obj, false); }
        protected virtual async Task OnUpdateDataAsync(TData obj, bool useTransaction) { await Task.CompletedTask; throw new NotImplementedException(); }
        protected virtual async Task OnDeleteDataAsync(TData obj) { await OnDeleteDataAsync(obj, false); }
        protected virtual async Task OnDeleteDataAsync(TData obj, bool useTransaction) { await Task.CompletedTask; throw new NotImplementedException(); }


        protected override async Task InternalInsertDataAsync(TData obj, bool useTransaction)
        {
            var beginOperationDataEventArgs = new BeginOperationDataEventArgs<TData>(obj, useTransaction);

            OnBeginInsertData(beginOperationDataEventArgs);
            if (!beginOperationDataEventArgs.Cancel)
            {
                Exception exception = null;
                EntityEntry entry = null;

                try
                {
                    entry = DbContext.Entry(obj);
                    if (entry.State != EntityState.Detached)
                        entry.State = EntityState.Detached;

                    if (!useTransaction)
                        await OnInsertDataAsync(obj);
                    else
                        await OnInsertDataAsync(obj, useTransaction);

                    await entry.ReloadAsync();
                }
                catch (Exception ex)
                {
                    exception = ex;
                    if (!SuppressError)
                        throw ex;
                }
                finally
                {
                    if ((entry != null) || (entry.State != EntityState.Detached))
                        entry.State = EntityState.Detached;
                }

                OnEndInsertData(new EndOperationDataEventArgs<TData>(obj, exception, useTransaction));
            }
        }

        protected override async Task InternalUpdateDataAsync(TData obj, bool useTransaction)
        {
            var beginOperationDataEventArgs = new BeginOperationDataEventArgs<TData>(obj, useTransaction);

            OnBeginUpdateData(beginOperationDataEventArgs);
            if (!beginOperationDataEventArgs.Cancel)
            {
                Exception exception = null;
                EntityEntry entry = null;

                try
                {
                    entry = DbContext.Entry(obj);
                    if (entry.State != EntityState.Detached)
                        entry.State = EntityState.Detached;

                    if (!useTransaction)
                        await OnUpdateDataAsync(obj);
                    else
                        await OnUpdateDataAsync(obj, useTransaction);

                    await entry.ReloadAsync();
                }
                catch (Exception ex)
                {
                    exception = ex;
                    if (!SuppressError)
                        throw ex;
                }
                finally
                {
                    if ((entry != null) || (entry.State != EntityState.Detached))
                        entry.State = EntityState.Detached;
                }

                OnEndUpdateData(new EndOperationDataEventArgs<TData>(obj, exception, useTransaction));
            }
        }

        protected override async Task InternalDeleteDataAsync(TData obj, bool useTransaction)
        {
            var beginOperationDataEventArgs = new BeginOperationDataEventArgs<TData>(obj, useTransaction);

            OnBeginDeleteData(beginOperationDataEventArgs);
            if (!beginOperationDataEventArgs.Cancel)
            {
                Exception exception = null;
                EntityEntry entry = null;

                try
                {
                    entry = DbContext.Entry(obj);
                    if (entry.State != EntityState.Detached)
                        entry.State = EntityState.Detached;

                    if (!useTransaction)
                        await OnDeleteDataAsync(obj);
                    else
                        await OnDeleteDataAsync(obj, useTransaction);

                    await entry.ReloadAsync();

                    if (entry.State != EntityState.Detached)
                        entry.State = EntityState.Detached;
                }
                catch (Exception ex)
                {
                    exception = ex;
                    if (!SuppressError)
                        throw ex;
                }
                finally
                {
                    if ((entry != null) || (entry.State != EntityState.Detached))
                        entry.State = EntityState.Detached;
                }

                OnEndDeleteData(new EndOperationDataEventArgs<TData>(obj, exception, useTransaction));
            }
        }

        #endregion

    }

}
