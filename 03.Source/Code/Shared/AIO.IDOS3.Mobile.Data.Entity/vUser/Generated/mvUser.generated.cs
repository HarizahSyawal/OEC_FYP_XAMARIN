﻿// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 01:01:52
// Description   : mvUser partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'mvUser.cs'
//       up to one level of this file location inside 'vUser' folder.
// ===================================================================================

using AIO.IDOS3.Data.Entity;
using Microsoft.OData.Client;

namespace AIO.IDOS3.Mobile.Data.Entity
{
    
    public partial class mvUser : vUser, ImvUser
    {

        #region Implements ImvUser

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