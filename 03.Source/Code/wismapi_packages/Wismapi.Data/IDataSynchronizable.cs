using System;

namespace Wismapi.Data
{

    public interface IDataSynchronizable
    {

        #region Methods

        DateTime? SyncDate { get; set; }
        DateTime? LastSyncDate { get; set; }
        int? LastSyncStatus { get; set; }
        int? LastSyncAttempts { get; set; }                

        #endregion

    }

}
