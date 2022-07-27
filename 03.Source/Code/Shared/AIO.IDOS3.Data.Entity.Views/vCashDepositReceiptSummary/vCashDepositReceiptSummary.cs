﻿// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 07:11:04
// Description   : vCashDepositReceiptSummary class.
//
// Modified by   :
// Modified date :
// Comments      :
//
// NOTE: This file is initially generated by system and can be modified following
//       the requirement.
// ===================================================================================

using Microsoft.OData.Client;
using System.Collections.ObjectModel;

namespace AIO.IDOS3.Data.Entity
{

    [Key("DocumentID", "CollectorID")]
    public partial class vCashDepositReceiptSummary : BaseEntityType, IvCashDepositReceiptSummary
    {

        #region Properties

        public vCashDepositReceipt Parent { get; set; }
        public Collection<vCashDepositReceiptDetails> ChildDetails { get; set; }

        #endregion

    }

}
