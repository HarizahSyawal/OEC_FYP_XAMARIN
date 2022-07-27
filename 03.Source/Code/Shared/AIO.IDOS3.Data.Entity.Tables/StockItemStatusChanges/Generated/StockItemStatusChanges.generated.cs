﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:28:01
// Description   : StockItemStatusChanges partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'StockItemStatusChanges.cs'
//       up to one level of this file location inside 'StockItemStatusChanges' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class StockItemStatusChanges : IStockItemStatusChanges
    {                
        
        #region Implements IStockItemStatusChanges

        public System.Guid DocumentID { get; set; }            
        public string DocumentCode { get; set; }            
        public System.DateTime TransactionDate { get; set; }            
        public System.Guid WarehouseID { get; set; }            
        public string PIC { get; set; }            
        public int OldItemStatusID { get; set; }            
        public int NewItemStatusID { get; set; }            
        public string ReferenceNumber { get; set; }            
        public string AttachmentFile { get; set; }            
        public int DocumentStatusID { get; set; }            
        public System.DateTime? PostedDate { get; set; }            
        public System.DateTime CreatedDate { get; set; }            
        public int? CreatedByUserID { get; set; }            
        public System.DateTime? ModifiedDate { get; set; }            
        public int? ModifiedByUserID { get; set; }            

        
        
        public void CopyFrom(IStockItemStatusChanges obj)
        {
            DocumentID = obj.DocumentID;
            DocumentCode = obj.DocumentCode;
            TransactionDate = obj.TransactionDate;
            WarehouseID = obj.WarehouseID;
            PIC = obj.PIC;
            OldItemStatusID = obj.OldItemStatusID;
            NewItemStatusID = obj.NewItemStatusID;
            ReferenceNumber = obj.ReferenceNumber;
            AttachmentFile = obj.AttachmentFile;
            DocumentStatusID = obj.DocumentStatusID;
            PostedDate = obj.PostedDate;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
            ModifiedDate = obj.ModifiedDate;
            ModifiedByUserID = obj.ModifiedByUserID;
        }
        
        #endregion
        
    }

}
