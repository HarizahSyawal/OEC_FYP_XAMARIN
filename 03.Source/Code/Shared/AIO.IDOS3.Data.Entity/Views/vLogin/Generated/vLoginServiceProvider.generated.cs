using System;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{
    public partial class vLoginServiceProvider : DataServiceProvider<vLogin>
    {
        #region Constructors

        public vLoginServiceProvider(CoreDataServiceContext dataServiceContext)
            : base(dataServiceContext)
        {

        }

        #endregion
    }
}
