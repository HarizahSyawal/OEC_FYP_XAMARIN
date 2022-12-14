// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 07:11:04
// Description   : vSalesCall class.
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

    [Key("ID")]
    public partial class vSalesCall : BaseEntityType, IvSalesCall
    {

        #region Properties

        public vMobileSalesActivity ParentActivity { get; set; }
        public Collection<vCustomerStockRecord> ChildCustomerStockRecords { get; set; }

        #endregion

    }

}
