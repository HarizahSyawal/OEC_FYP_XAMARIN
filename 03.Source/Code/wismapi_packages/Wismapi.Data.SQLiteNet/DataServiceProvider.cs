using Microsoft.OData.Client;
using System;
using System.Threading.Tasks;

namespace Wismapi.Data.SQLiteNet
{

    public abstract class DataServiceProvider<TData> where TData : BaseEntityType
    {

        #region Constructors

        public DataServiceProvider(CoreDataServiceContext dataServiceContext)
        {
            DataServiceContext = dataServiceContext;

            DeepOperation = false;
            SuppressError = false;

            OnInitialized();
        }

        #endregion

        #region Properties

        public CoreDataServiceContext DataServiceContext { get; }
        public bool DeepOperation { get; set; }
        public bool SuppressError { get; set; }

        #endregion

        #region Methods

        public virtual DataServiceQuery<TData> GetData() { return DataServiceContext.CreateQuery<TData>(); }
        public virtual TData GetData(params object[] primaryKeys) { return DataServiceContext.CreateQuerySingle<TData>(primaryKeys).GetValue(); }
        public virtual async Task<TData> GetDataAsync(params object[] primaryKeys) { return await DataServiceContext.CreateQuerySingle<TData>(primaryKeys).GetValueAsync(); }

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
                EntityDescriptor descriptor = null;

                try
                {
                    if (DataServiceContext.MergeOption == MergeOption.NoTracking)
                    {
                        descriptor = DataServiceContext.GetEntityDescriptor(obj);
                        if (descriptor == null)
                        {
                            DataServiceContext.AddObject(obj);
                            descriptor = DataServiceContext.GetEntityDescriptor(obj);
                        }
                    }
                    else
                        DataServiceContext.AddObject(obj);

                    if (DeepOperation)
                        await DataServiceContext.SaveDeepChangesAsync();
                    else
                        await DataServiceContext.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    exception = ex;
                    if (!SuppressError)
                        throw ex;
                }
                finally
                {
                    if ((descriptor != null) && (descriptor.State != EntityStates.Detached))
                        DataServiceContext.Detach(obj);
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
                EntityDescriptor descriptor = null;

                try
                {                    
                    if (DataServiceContext.MergeOption == MergeOption.NoTracking)
                    {
                        descriptor = DataServiceContext.GetEntityDescriptor(obj);
                        if (descriptor == null)
                        {
                            DataServiceContext.AttachTo(obj);
                            DataServiceContext.UpdateObject(obj);
                            descriptor = DataServiceContext.GetEntityDescriptor(obj);
                        }
                    }

                    if (DeepOperation)
                        await DataServiceContext.SaveDeepChangesAsync();
                    else
                        await DataServiceContext.SaveChangesAsync();

                    if ((descriptor != null) && (descriptor.State != EntityStates.Detached))
                        DataServiceContext.Detach(obj);
                }
                catch (Exception ex)
                {
                    exception = ex;
                    if (!SuppressError)
                        throw ex;
                }
                finally
                {
                    if ((descriptor != null) && (descriptor.State != EntityStates.Detached))
                        DataServiceContext.Detach(obj);
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
                EntityDescriptor descriptor = null;

                try
                {
                    if (DataServiceContext.MergeOption == MergeOption.NoTracking)
                    {
                        descriptor = DataServiceContext.GetEntityDescriptor(obj);
                        if (descriptor == null)
                        {
                            DataServiceContext.AttachTo(obj);
                            DataServiceContext.DeleteObject(obj);
                            descriptor = DataServiceContext.GetEntityDescriptor(obj);
                        }
                    }
                    else
                        DataServiceContext.DeleteObject(obj);

                    if (DeepOperation)
                        await DataServiceContext.SaveDeepChangesAsync();
                    else
                        await DataServiceContext.SaveChangesAsync();

                    if ((descriptor != null) && (descriptor.State != EntityStates.Detached))
                        DataServiceContext.Detach(obj);
                }
                catch (Exception ex)
                {
                    exception = ex;
                    if (!SuppressError)
                        throw ex;
                }
                finally
                {
                    if ((descriptor != null) && (descriptor.State != EntityStates.Detached))
                        DataServiceContext.Detach(obj);
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
