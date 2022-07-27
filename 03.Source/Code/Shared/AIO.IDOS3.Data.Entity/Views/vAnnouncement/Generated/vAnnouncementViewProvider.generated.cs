using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{
    public partial class vAnnouncementViewProvider : DataViewProvider<vAnnouncement>
    {
        public vAnnouncementViewProvider(CoreDbContext dbContext)
    : base(dbContext)
        {

        }
    }
}
