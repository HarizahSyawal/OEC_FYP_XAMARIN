﻿// ===================================================================================
// Author        : System
// Created date  : 20 Oct 2020 11:50:49
// Description   : mvBillAndReceiptStatement partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'mvBillAndReceiptStatement.cs'
//       up to one level of this file location inside 'vBillAndReceiptStatement' folder.
// ===================================================================================

using AIO.IDOS3.Data.Entity;
using Microsoft.OData.Client;

namespace AIO.IDOS3.Mobile.Data.Entity
{
    
    public partial class mvBillAndReceiptStatement : vBillAndReceiptStatement, ImvBillAndReceiptStatement
    {                
        
        #region Implements ImvBillAndReceiptStatement

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
