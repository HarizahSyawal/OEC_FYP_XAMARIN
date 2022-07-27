using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    public partial class mvRegisterTableProvider : DataTableProvider<mvRegister>
    {
        #region Constructors

        public mvRegisterTableProvider(CoreDbContext dbContext)
            : base(dbContext)
        {

        }

        #endregion
    }
}
