// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 07:11:04
// Description   : vSalesOrder class.
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
    public partial class vSalesOrder : BaseEntityType, IvSalesOrder
    {                
        
        #region Properties
                
        public Collection<vSalesOrderSummary> ChildSummaries { get; set; }

        #endregion

    }

}
