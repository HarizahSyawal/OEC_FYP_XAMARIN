﻿// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 07:11:04
// Description   : vSalesOrderSwap class.
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

    [Key("DocumentID")]
    public partial class vSalesOrderSwap : BaseEntityType, IvSalesOrderSwap
    {                
        
        #region Properties
                
        public Collection<vSalesOrderSwapSummary> ChildSummaries { get; set; }

        #endregion

    }

}