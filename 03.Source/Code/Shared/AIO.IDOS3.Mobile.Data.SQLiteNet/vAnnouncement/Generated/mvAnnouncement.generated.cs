using Microsoft.OData.Client;
using AIO.IDOS3.Data;
using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    [SQLite.Table("vAnnouncement")]
    public partial class mvAnnouncement : BaseEntityType, ImvAnnouncement
    {
        #region Implements ImvRegister

        [SQLiteNetExt.PrimaryKey]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }

        [IgnoreClientProperty]
        public System.DateTime? SyncDate { get; set; }

        [IgnoreClientProperty]
        public System.DateTime? LastSyncDate { get; set; }

        [IgnoreClientProperty]
        public int? LastSyncStatus { get; set; }

        [IgnoreClientProperty]
        public int? LastSyncAttempts { get; set; }


        public void CopyFrom(IvAnnouncement obj)
        {
            ID = obj.ID;
            Title = obj.Title;
            Photo = obj.Photo;
            Description = obj.Description;
        }

        #endregion
    }
}
