﻿// ===================================================================================
// Author        : System
// Created date  : 03 Sep 2020 02:32:39
// Description   : mvSystemLookup partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'mvSystemLookup.cs'
//       up to one level of this file location inside 'vSystemLookup' folder.
// ===================================================================================

using AIO.IDOS3.Data.Entity;
using Microsoft.OData.Client;

namespace AIO.IDOS3.Mobile.Data.Entity
{
    
    public partial class mvSystemLookup : vSystemLookup, ImvSystemLookup
    {                
        
        #region Implements ImvSystemLookup

        [IgnoreClientProperty]
        public System.DateTime? SyncDate { get; set; }

        [IgnoreClientProperty]
        public System.DateTime? LastSyncDate { get; set; }

        [IgnoreClientProperty]
        public int? LastSyncStatus { get; set; }

        [IgnoreClientProperty]
        public int? LastSyncAttempts { get; set; }

        #endregion

    }

}
