﻿// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 07:11:04
// Description   : vCashDepositToBankDetails class.
//
// Modified by   :
// Modified date :
// Comments      :
//
// NOTE: This file is initially generated by system and can be modified following
//       the requirement.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{

    [Key("DocumentID", "CDRDocumentID")]
    public partial class vCashDepositToBankDetails : BaseEntityType, IvCashDepositToBankDetails
    {

        #region Properties

        public vCashDepositToBank Parent { get; set; }

        #endregion

    }

}
