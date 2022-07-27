using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{
    public partial class vRegisterViewProvider : DataViewProvider<vRegister>
    {
        #region Constructors

        public vRegisterViewProvider(CoreDbContext dbContext)
            : base(dbContext)
        {

        }

        #endregion
    }
}
