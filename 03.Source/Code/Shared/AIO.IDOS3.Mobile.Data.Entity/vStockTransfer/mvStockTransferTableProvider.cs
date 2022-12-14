// ===================================================================================
// Author        : System
// Created date  : 09 Aug 2020 16:32:37
// Description   : mvStockTransferTableProvider partial class.
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
using System.Threading.Tasks;
using Wismapi.Data;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public partial class mvStockTransferTableProvider : DataTableProvider<mvStockTransfer>
    {
        
        #region Methods

        protected override async Task OnEndInsertDataAsync(EndOperationDataEventArgs<mvStockTransfer> e)
        {
            if (!e.IsError)
            {
                if (e.Data.ChildSummaries != null)
                {
                    var childTableProvider = DbContext.GetDataTableProvider<mvStockTransferSummaryTableProvider>();

                    await InsertChilds(childTableProvider, e.Data.DocumentID, e.Data.ChildSummaries, e.UseTransaction);
                }                
            }

            await base.OnEndInsertDataAsync(e);
        }

        protected override async Task OnEndUpdateDataAsync(EndOperationDataEventArgs<mvStockTransfer> e)
        {
            if (!e.IsError)
            {
                if (e.Data.ChildSummaries != null)
                {
                    var childTableProvider = DbContext.GetDataTableProvider<mvStockTransferSummaryTableProvider>();

                    await DeleteChilds(childTableProvider, e.Data.DocumentID, e.UseTransaction);
                    await InsertChilds(childTableProvider, e.Data.DocumentID, e.Data.ChildSummaries, e.UseTransaction);
                }
            }

            await base.OnEndUpdateDataAsync(e);
        }

        protected override async Task OnBeginDeleteDataAsync(BeginOperationDataEventArgs<mvStockTransfer> e)
        {
            var childTableProvider = DbContext.GetDataTableProvider<mvStockTransferSummaryTableProvider>();

            await DeleteChilds(childTableProvider, e.Data.DocumentID, e.UseTransaction);

            await base.OnBeginDeleteDataAsync(e);
        }



        private async Task InsertChilds(mvStockTransferSummaryTableProvider childTableProvider, Guid documentID, ICollection<mvStockTransferSummary> childs, bool useTransaction)
        {
            foreach (var child in childs)
            {
                child.DocumentID = documentID;
                await childTableProvider.InsertDataAsync(child, useTransaction);
            }                
        }

        private async Task DeleteChilds(mvStockTransferSummaryTableProvider childTableProvider, Guid documentID, bool useTransaction)
        {
            var deleteChilds = childTableProvider.GetDataByDocumentID(documentID);
            foreach (var child in deleteChilds)                
                await childTableProvider.DeleteDataAsync(child, useTransaction);
        }

        #endregion

    }

}
