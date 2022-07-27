﻿// ===================================================================================
// Author        : System
// Created date  : 15 Sep 2020 03:26:59
// Description   : mvSalesOrderReturnDetails partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'mvSalesOrderReturnDetails.cs'
//       up to one level of this file location inside 'vSalesOrderReturnDetails' folder.
// ===================================================================================

using AIO.IDOS3.Data.Entity;
using Microsoft.OData.Client;

namespace AIO.IDOS3.Mobile.Data.Entity
{
    
    public partial class mvSalesOrderReturnDetails : vSalesOrderReturnDetails, ImvSalesOrderReturnDetails
    {                
        
        #region Implements ImvSalesOrderReturnDetails

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
