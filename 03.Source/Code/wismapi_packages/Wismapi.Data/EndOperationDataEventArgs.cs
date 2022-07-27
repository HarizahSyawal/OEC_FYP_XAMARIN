using System;

namespace Wismapi.Data
{

    public class EndOperationDataEventArgs<TData> : EventArgs
    {

        #region Constructors

        public EndOperationDataEventArgs()
            : this((Exception)null)
        {
            
        }

        public EndOperationDataEventArgs(TData data)
            : this(data, null)
        {

        }

        public EndOperationDataEventArgs(TData data, Exception error)
            : this(data, error, false)
        {

        }

        public EndOperationDataEventArgs(TData data, Exception error, bool useTransaction)
            : this(data, error, useTransaction, false)
        {
        }

        public EndOperationDataEventArgs(TData data, Exception error, bool useTransaction, bool cancel)
        {
            Data = data;
            UseTransaction = useTransaction;
            Cancel = cancel;
            Error = error;
        }

        public EndOperationDataEventArgs(Exception error)
            : this(error, false)
        {

        }

        public EndOperationDataEventArgs(Exception error, bool useTransaction)
            : this(error, useTransaction, false)
        {
        }

        public EndOperationDataEventArgs(Exception error, bool useTransaction, bool cancel)
        {            
            UseTransaction = useTransaction;
            Cancel = cancel;
            Error = error;
        }

        #endregion

        #region Properties

        public TData Data { get; }
        public bool UseTransaction { get; } = false;
        public bool Cancel { get; } = false;
        public Exception Error { get; } = null;

        public bool IsError { get { return (Error != null); } }

        #endregion

    }

}
