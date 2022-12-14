// ===================================================================================
// Author        : System
// Created date  : 09 Aug 2020 16:32:37
// Description   : mvInvoiceSummaryTableProvider partial class.
//
// Modified by   :
// Modified date :
// Comments      :
//
// NOTE: This file is initially generated by system and can be modified following
//       the requirement.
// ===================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wismapi.Data;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public partial class mvInvoiceSummaryTableProvider : DataTableProvider<mvInvoiceSummary>
    {

        #region Methods

        public IList<mvInvoiceSummary> GetDataByDocumentID(Guid documentID)
        {
            return GetData().Where(p => p.DocumentID.Equals(documentID)).ToList();
        }

        #endregion

    }

}
