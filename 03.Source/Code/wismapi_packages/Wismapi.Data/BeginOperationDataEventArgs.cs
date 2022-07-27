using System;

namespace Wismapi.Data
{

    public class BeginOperationDataEventArgs<TData> : EventArgs
    {

        #region Constructors

        public BeginOperationDataEventArgs()
        {
            UseTransaction = false;
        }

        public BeginOperationDataEventArgs(TData data)
            : this(data, false)
        {
            
        }

        public BeginOperationDataEventArgs(TData data, bool useTransaction)
        {
            Data = data;
            UseTransaction = useTransaction;
        }

        #endregion

        #region Properties

        public TData Data { get; }
        public bool UseTransaction { get; set; }
        public bool Cancel { get; set; } = false;

        #endregion

    }

}
