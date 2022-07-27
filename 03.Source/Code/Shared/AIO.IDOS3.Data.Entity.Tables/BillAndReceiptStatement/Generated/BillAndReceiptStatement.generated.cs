﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:44
// Description   : BillAndReceiptStatement partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'BillAndReceiptStatement.cs'
//       up to one level of this file location inside 'BillAndReceiptStatement' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class BillAndReceiptStatement : IBillAndReceiptStatement
    {                
        
        #region Implements IBillAndReceiptStatement

        public System.Guid DocumentID { get; set; }            
        public string DocumentCode { get; set; }            
        public System.Guid? PrevRevisionDocumentID { get; set; }            
        public int? RevisionNumber { get; set; }            
        public System.DateTime TransactionDate { get; set; }            
        public System.Guid CollectorID { get; set; }            
        public System.Guid? RefCollectorID { get; set; }            
        public int PrintCount { get; set; }            
        public System.DateTime? LastPrintedDate { get; set; }            
        public int DocumentStatusID { get; set; }            
        public System.DateTime? PostedDate { get; set; }            
        public System.DateTime CreatedDate { get; set; }            
        public int? CreatedByUserID { get; set; }            
        public System.DateTime? ModifiedDate { get; set; }            
        public int? ModifiedByUserID { get; set; }            

        
        
        public void CopyFrom(IBillAndReceiptStatement obj)
        {
            DocumentID = obj.DocumentID;
            DocumentCode = obj.DocumentCode;
            PrevRevisionDocumentID = obj.PrevRevisionDocumentID;
            RevisionNumber = obj.RevisionNumber;
            TransactionDate = obj.TransactionDate;
            CollectorID = obj.CollectorID;
            RefCollectorID = obj.RefCollectorID;
            PrintCount = obj.PrintCount;
            LastPrintedDate = obj.LastPrintedDate;
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