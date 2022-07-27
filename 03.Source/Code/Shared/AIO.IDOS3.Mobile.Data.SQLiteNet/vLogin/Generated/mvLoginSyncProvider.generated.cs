using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    public partial class mvLoginSyncProvider : DataSyncProvider<mvLogin>
    {
        #region Constructors

        public mvLoginSyncProvider(CoreDbContext dbContext, CoreDataServiceContext dataServiceContext)
            : base(dbContext, dataServiceContext)
        {

        }

        #endregion
    }
}
