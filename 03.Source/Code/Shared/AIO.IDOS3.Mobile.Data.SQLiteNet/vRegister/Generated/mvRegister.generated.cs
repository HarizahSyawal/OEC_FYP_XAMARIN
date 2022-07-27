using Microsoft.OData.Client;
using AIO.IDOS3.Data;
using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    [SQLite.Table("vRegister")]
    public partial class mvRegister : BaseEntityType, ImvRegister
    {
        #region Implements ImvRegister

        [SQLiteNetExt.PrimaryKey]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        [IgnoreClientProperty]
        public System.DateTime? SyncDate { get; set; }

        [IgnoreClientProperty]
        public System.DateTime? LastSyncDate { get; set; }

        [IgnoreClientProperty]
        public int? LastSyncStatus { get; set; }

        [IgnoreClientProperty]
        public int? LastSyncAttempts { get; set; }


        public void CopyFrom(IvRegister obj)
        {
            ID = obj.ID;
            Username = obj.Username;
            Email = obj.Email;
            Password = obj.Password;
        }

        #endregion
    }
}
