using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    public partial class mvAnnouncementTableProvider : DataTableProvider<mvAnnouncement>
    {
        #region Constructors

        public mvAnnouncementTableProvider(CoreDbContext dbContext)
            : base(dbContext)
        {

        }

        #endregion
    }
}
