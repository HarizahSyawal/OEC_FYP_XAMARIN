﻿// ===================================================================================
// Author        : System
// Created date  : 08 Oct 2020 05:23:04
// Description   : mvPaymentCollectionDetails partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'mvPaymentCollectionDetails.cs'
//       up to one level of this file location inside 'vPaymentCollectionDetails' folder.
// ===================================================================================

using AIO.IDOS3.Data.Entity;
using Microsoft.OData.Client;

namespace AIO.IDOS3.Mobile.Data.Entity
{
    
    public partial class mvPaymentCollectionDetails : vPaymentCollectionDetails, ImvPaymentCollectionDetails
    {                
        
        #region Implements ImvPaymentCollectionDetails

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
