using Microsoft.OData.Client;
using AIO.IDOS3.Data;
using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    [SQLite.Table("vLogin")]
    public partial class mvLogin : BaseEntityType, ImvLogin
    {
        #region Implements ImvRegister

        [SQLiteNetExt.PrimaryKey]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        [IgnoreClientProperty]
        public System.DateTime? SyncDate { get; set; }

        [IgnoreClientProperty]
        public System.DateTime? LastSyncDate { get; set; }

        [IgnoreClientProperty]
        public int? LastSyncStatus { get; set; }

        [IgnoreClientProperty]
        public int? LastSyncAttempts { get; set; }


        public void CopyFrom(IvLogin obj)
        {
            ID = obj.ID;
            Username = obj.Username;
            Password = obj.Password;
        }

        #endregion
    }
}
