using System;
using System.Collections.Generic;
using System.Text;
using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    public partial class mvLoginServiceProvider : DataServiceProvider<mvLogin>
    {
        #region Constructors

        public mvLoginServiceProvider(CoreDataServiceContext dataServiceContext)
            : base(dataServiceContext)
        {

        }

        #endregion
    }
}
