using System;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{
    public partial class vUniversityViewProvider : DataViewProvider<vUniversity>
    {

        #region Constructors

        public vUniversityViewProvider(CoreDbContext dbContext)
            : base(dbContext)
        {

        }

        #endregion

    }
}
