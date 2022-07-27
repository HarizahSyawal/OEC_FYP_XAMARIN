using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    public class mvAnnouncementEntityTypeConfig : IEdmEntityConfiguration<mvAnnouncement>
    {
        #region Implements IEdmEntityConfiguration<mvAnnouncement>

        public string EntitySetName { get; } = "vAnnouncements";

        #endregion
    }
}