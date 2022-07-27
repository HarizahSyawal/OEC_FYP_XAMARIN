using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{
    public partial class vAnnouncementServiceProvider : DataServiceProvider<vAnnouncement>
    {
        public vAnnouncementServiceProvider(CoreDataServiceContext dataServiceContext)
    : base(dataServiceContext)
        {

        }

    }
}
