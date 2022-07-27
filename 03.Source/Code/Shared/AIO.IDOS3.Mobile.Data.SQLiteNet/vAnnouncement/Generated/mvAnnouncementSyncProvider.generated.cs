using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    public partial class mvAnnouncementSyncProvider : DataSyncProvider<mvAnnouncement>
    {
        #region Constructors

        public mvAnnouncementSyncProvider(CoreDbContext dbContext, CoreDataServiceContext dataServiceContext)
            : base(dbContext, dataServiceContext)
        {

        }

        #endregion
    }
}
