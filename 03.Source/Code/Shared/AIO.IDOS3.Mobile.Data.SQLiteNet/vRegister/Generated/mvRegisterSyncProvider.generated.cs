using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    public partial class mvRegisterSyncProvider : DataSyncProvider<mvRegister>
    {
        #region Constructors

        public mvRegisterSyncProvider(CoreDbContext dbContext, CoreDataServiceContext dataServiceContext)
            : base(dbContext, dataServiceContext)
        {

        }

        #endregion
    }
}
