using System;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{
    public partial class vUniversityServiceProvider : DataServiceProvider<vUniversity>
    {

        #region Constructors

        public vUniversityServiceProvider(CoreDataServiceContext dataServiceContext)
            : base(dataServiceContext)
        {

        }

        #endregion

    }
}
