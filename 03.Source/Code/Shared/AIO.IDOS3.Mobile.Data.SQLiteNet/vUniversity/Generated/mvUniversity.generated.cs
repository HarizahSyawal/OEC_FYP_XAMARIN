using Microsoft.OData.Client;
using AIO.IDOS3.Data;
using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    [SQLite.Table("vUniversity")]
    public partial class mvUniversity : BaseEntityType, ImvUniversity
    {
        #region Implements ImvLogin

        [SQLiteNetExt.PrimaryKey]
        public int ID { get; set; }
        public string UnivName { get; set; }
        public string UnivPhoto { get; set; }
        public string UnivAddress { get; set; }
        public string UnivDetails { get; set; }

        [IgnoreClientProperty]
        public System.DateTime? SyncDate { get; set; }

        [IgnoreClientProperty]
        public System.DateTime? LastSyncDate { get; set; }

        [IgnoreClientProperty]
        public int? LastSyncStatus { get; set; }

        [IgnoreClientProperty]
        public int? LastSyncAttempts { get; set; }


        public void CopyFrom(IvUniversity obj)
        {
            ID = obj.ID;
            UnivName = obj.UnivName;
            UnivPhoto = obj.UnivPhoto;
            UnivAddress = obj.UnivAddress;
            UnivDetails = obj.UnivDetails;
        }

        #endregion
    }
}
