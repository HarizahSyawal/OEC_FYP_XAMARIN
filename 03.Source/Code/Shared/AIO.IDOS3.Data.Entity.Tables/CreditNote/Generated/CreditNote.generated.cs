﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:46
// Description   : CreditNote partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'CreditNote.cs'
//       up to one level of this file location inside 'CreditNote' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class CreditNote : ICreditNote
    {                
        
        #region Implements ICreditNote

        public System.Guid DocumentID { get; set; }            
        public string DocumentCode { get; set; }            
        public System.DateTime TransactionDate { get; set; }            
        public int TypeID { get; set; }            
        public System.Guid? CreditForCustomerBillGroupID { get; set; }            
        public System.Guid? CreditForCustomerID { get; set; }            
        public System.Guid? PRDocumentID { get; set; }            
        public int? ReasonID { get; set; }            
        public double TotalAmount { get; set; }            
        public double TotalAllocationAmount { get; set; }            
        public int PrintCount { get; set; }            
        public System.DateTime? LastPrintedDate { get; set; }            
        public int DocumentStatusID { get; set; }            
        public System.DateTime? PostedDate { get; set; }            
        public System.DateTime CreatedDate { get; set; }            
        public int? CreatedByUserID { get; set; }            
        public System.DateTime? ModifiedDate { get; set; }            
        public int? ModifiedByUserID { get; set; }            

        
        
        public void CopyFrom(ICreditNote obj)
        {
            DocumentID = obj.DocumentID;
            DocumentCode = obj.DocumentCode;
            TransactionDate = obj.TransactionDate;
            TypeID = obj.TypeID;
            CreditForCustomerBillGroupID = obj.CreditForCustomerBillGroupID;
            CreditForCustomerID = obj.CreditForCustomerID;
            PRDocumentID = obj.PRDocumentID;
            ReasonID = obj.ReasonID;
            TotalAmount = obj.TotalAmount;
            TotalAllocationAmount = obj.TotalAllocationAmount;
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