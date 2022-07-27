﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:51
// Description   : InvoiceOpname partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'InvoiceOpname.cs'
//       up to one level of this file location inside 'InvoiceOpname' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class InvoiceOpname : IInvoiceOpname
    {                
        
        #region Implements IInvoiceOpname

        public System.Guid DocumentID { get; set; }            
        public string DocumentCode { get; set; }            
        public System.DateTime TransactionDate { get; set; }            
        public System.Guid CollectorID { get; set; }            
        public int TotalInvoiceARPhysicalAvailable { get; set; }            
        public int TotalInvoiceARAvailable { get; set; }            
        public double TotalInvoiceARPhysicalOutstandingAmount { get; set; }            
        public double TotalInvoiceAROutstandingAmount { get; set; }            
        public int PrintCount { get; set; }            
        public System.DateTime? LastPrintedDate { get; set; }            
        public int DocumentStatusID { get; set; }            
        public System.DateTime? PostedDate { get; set; }            
        public System.DateTime CreatedDate { get; set; }            
        public int? CreatedByUserID { get; set; }            
        public System.DateTime? ModifiedDate { get; set; }            
        public int? ModifiedByUserID { get; set; }            

        
        
        public void CopyFrom(IInvoiceOpname obj)
        {
            DocumentID = obj.DocumentID;
            DocumentCode = obj.DocumentCode;
            TransactionDate = obj.TransactionDate;
            CollectorID = obj.CollectorID;
            TotalInvoiceARPhysicalAvailable = obj.TotalInvoiceARPhysicalAvailable;
            TotalInvoiceARAvailable = obj.TotalInvoiceARAvailable;
            TotalInvoiceARPhysicalOutstandingAmount = obj.TotalInvoiceARPhysicalOutstandingAmount;
            TotalInvoiceAROutstandingAmount = obj.TotalInvoiceAROutstandingAmount;
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