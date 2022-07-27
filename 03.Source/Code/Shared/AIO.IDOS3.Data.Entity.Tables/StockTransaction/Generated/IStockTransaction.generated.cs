﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:28:07
// Description   : IStockTransaction partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IStockTransaction.cs'
//       up to one level of this file location inside 'StockTransaction' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IStockTransaction
    {                
        
        #region Properties
        
        System.Guid DocumentID { get; set; }
        int ProductID { get; set; }
        int ProductLotID { get; set; }
        int ExtID { get; set; }
        System.DateTime TransactionDate { get; set; }
        int TransactionTypeID { get; set; }
        System.Guid? RefVoidedDocumentID { get; set; }
        System.Guid SourceID { get; set; }
        System.Guid? DestinationID { get; set; }
        int QtyGood { get; set; }
        int QtyHold { get; set; }
        int QtyBad { get; set; }
        int StatusID { get; set; }
        System.DateTime? CommittedTransactionDate { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(IStockTransaction obj);
        
        #endregion

    }

}
