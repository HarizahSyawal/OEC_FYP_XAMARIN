using System;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{
    public partial class vLoginViewProvider : DataViewProvider<vLogin>
    {
        #region Constructors

        public vLoginViewProvider(CoreDbContext dbContext)
            : base(dbContext)
        {

        }

        #endregion
    }
}
