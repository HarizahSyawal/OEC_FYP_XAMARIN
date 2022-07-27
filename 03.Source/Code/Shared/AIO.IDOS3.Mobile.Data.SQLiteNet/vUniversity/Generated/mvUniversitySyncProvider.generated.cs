using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    public partial class mvUniversitySyncProvider : DataSyncProvider<mvUniversity>
    {
        #region Constructors

        public mvUniversitySyncProvider(CoreDbContext dbContext, CoreDataServiceContext dataServiceContext)
            : base(dbContext, dataServiceContext)
        {

        }

        #endregion
    }
}
