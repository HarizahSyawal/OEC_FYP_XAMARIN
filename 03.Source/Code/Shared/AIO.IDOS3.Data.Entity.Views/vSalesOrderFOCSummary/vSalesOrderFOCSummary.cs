﻿// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 07:11:04
// Description   : vSalesOrderFOCSummary class.
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

    [Key("DocumentID", "ProductID")]
    public partial class vSalesOrderFOCSummary : BaseEntityType, IvSalesOrderFOCSummary
    {

        #region Properties

        public vSalesOrderFOC Parent { get; set; }
        public Collection<vSalesOrderFOCDetails> ChildDetails { get; set; }

        #endregion

    }

}
