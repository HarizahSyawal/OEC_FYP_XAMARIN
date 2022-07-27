using System;
using System.Collections.Generic;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{

    public class MobileDataFileEventArgs : EventArgs
    {

        #region Constructors

        public MobileDataFileEventArgs(object data, Dictionary<string, string> filePaths)
        {
            Data = data;
            FilePaths = filePaths;
        }

        #endregion

        #region Properties

        public object Data { get; }
        public Dictionary<string, string> FilePaths { get; }

        #endregion

    }

}
