using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    public partial class mvAnnouncementServiceProvider : DataServiceProvider<mvAnnouncement>
    {
        public mvAnnouncementServiceProvider(CoreDataServiceContext dataServiceContext)
    : base(dataServiceContext)
        {

        }
    }
}
