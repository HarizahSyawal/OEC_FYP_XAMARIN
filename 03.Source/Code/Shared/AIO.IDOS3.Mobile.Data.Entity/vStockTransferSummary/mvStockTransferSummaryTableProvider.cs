// ===================================================================================
// Author        : System
// Created date  : 09 Aug 2020 16:32:37
// Description   : mvStockTransferSummaryTableProvider partial class.
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

    public partial class mvStockTransferSummaryTableProvider : DataTableProvider<mvStockTransferSummary>
    {

        #region Methods

        public IList<mvStockTransferSummary> GetDataByDocumentID(Guid documentID)
        {
            return GetData().Where(p => p.DocumentID.Equals(documentID)).ToList();
        }



        protected override async Task OnEndInsertDataAsync(EndOperationDataEventArgs<mvStockTransferSummary> e)
        {
            if (!e.IsError)
            {
                if (e.Data.ChildDetails != null)
                {
                    var childTableProvider = DbContext.GetDataTableProvider<mvStockTransferDetailsTableProvider>();

                    await InsertChilds(childTableProvider, e.Data.DocumentID, e.Data.ProductID, e.Data.ChildDetails, e.UseTransaction);
                }
            }

            await base.OnEndInsertDataAsync(e);
        }

        protected override async Task OnEndUpdateDataAsync(EndOperationDataEventArgs<mvStockTransferSummary> e)
        {
            if (!e.IsError)
            {
                if (e.Data.ChildDetails != null)
                {
                    var childTableProvider = DbContext.GetDataTableProvider<mvStockTransferDetailsTableProvider>();

                    await DeleteChilds(childTableProvider, e.Data.DocumentID, e.Data.ProductID, e.UseTransaction);
                    await InsertChilds(childTableProvider, e.Data.DocumentID, e.Data.ProductID, e.Data.ChildDetails, e.UseTransaction);
                }
            }

            await base.OnEndUpdateDataAsync(e);
        }

        protected override async Task OnBeginDeleteDataAsync(BeginOperationDataEventArgs<mvStockTransferSummary> e)
        {
            var childTableProvider = DbContext.GetDataTableProvider<mvStockTransferDetailsTableProvider>();

            await DeleteChilds(childTableProvider, e.Data.DocumentID, e.Data.ProductID, e.UseTransaction);

            await base.OnBeginDeleteDataAsync(e);
        }



        private async Task InsertChilds(mvStockTransferDetailsTableProvider childTableProvider, Guid documentID, int productID, ICollection<mvStockTransferDetails> childs, bool useTransaction)
        {
            foreach (var child in childs)
            {
                child.DocumentID = documentID;
                child.ProductID = productID;
                await childTableProvider.InsertDataAsync(child, useTransaction);
            }                
        }

        private async Task DeleteChilds(mvStockTransferDetailsTableProvider childTableProvider, Guid documentID, int productID, bool useTransaction)
        {
            var deleteChilds = childTableProvider.GetDataByDocumentIDAndProductID(documentID, productID);
            foreach (var child in deleteChilds)
                await childTableProvider.DeleteDataAsync(child, useTransaction);
        }

        #endregion

    }

}
