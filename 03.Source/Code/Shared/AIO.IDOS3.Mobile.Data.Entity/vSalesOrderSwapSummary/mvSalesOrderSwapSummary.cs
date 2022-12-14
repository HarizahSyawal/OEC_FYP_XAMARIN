// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 07:11:04
// Description   : mvSalesOrderSwapSummary class.
//
// Modified by   :
// Modified date :
// Comments      :
//
// NOTE: This file is initially generated by system and can be modified following
//       the requirement.
// ===================================================================================

using AIO.IDOS3.Data.Entity;
using System.Collections.ObjectModel;

namespace AIO.IDOS3.Mobile.Data.Entity
{
    
    public partial class mvSalesOrderSwapSummary : vSalesOrderSwapSummary, ImvSalesOrderSwapSummary
    {

        #region Properties

        public new mvSalesOrderSwap Parent { get; set; }
        public new Collection<mvSalesOrderSwapDetails> ChildDetails { get; set; }

        #endregion

    }

}
