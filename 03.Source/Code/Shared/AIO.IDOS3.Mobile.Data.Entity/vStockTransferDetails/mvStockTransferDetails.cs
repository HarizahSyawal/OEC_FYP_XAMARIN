﻿// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 07:11:04
// Description   : mvStockTransferDetails class.
//
// Modified by   :
// Modified date :
// Comments      :
//
// NOTE: This file is initially generated by system and can be modified following
//       the requirement.
// ===================================================================================

using AIO.IDOS3.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{
    
    public partial class mvStockTransferDetails : vStockTransferDetails, ImvStockTransferDetails
    {

        #region Properties

        public new mvStockTransferSummary Parent { get; set; }

        #endregion

    }

}
