﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:28:01
// Description   : IStockLotCodeChanges partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IStockLotCodeChanges.cs'
//       up to one level of this file location inside 'StockLotCodeChanges' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IStockLotCodeChanges
    {                
        
        #region Properties
        
        System.Guid DocumentID { get; set; }
        string DocumentCode { get; set; }
        System.DateTime TransactionDate { get; set; }
        System.Guid WarehouseID { get; set; }
        string PIC { get; set; }
        string ReferenceNumber { get; set; }
        string AttachmentFile { get; set; }
        int DocumentStatusID { get; set; }
        System.DateTime? PostedDate { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(IStockLotCodeChanges obj);
        
        #endregion

    }

}
