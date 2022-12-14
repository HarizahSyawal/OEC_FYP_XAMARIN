// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 07:11:04
// Description   : mvStockTransferSummary class.
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
    
    public partial class mvStockTransferSummary : vStockTransferSummary, ImvStockTransferSummary
    {

        #region Properties

        public new mvStockTransfer Parent { get; set; }
        public new Collection<mvStockTransferDetails> ChildDetails { get; set; }

        #endregion

    }

}
