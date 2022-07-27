using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{
    public partial class UniversityTableProvider : DataTableProvider<University>
    {
        #region Constructors

        public UniversityTableProvider(CoreDbContext dbContext)
            : base(dbContext)
        {

        }

        #endregion
    }
}
