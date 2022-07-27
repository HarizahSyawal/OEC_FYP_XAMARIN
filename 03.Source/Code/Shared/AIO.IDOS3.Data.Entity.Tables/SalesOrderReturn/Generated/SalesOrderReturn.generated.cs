﻿// ===================================================================================
// Author        : System
// Created date  : 24 Sep 2020 03:19:41
// Description   : SalesOrderReturn partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'SalesOrderReturn.cs'
//       up to one level of this file location inside 'SalesOrderReturn' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class SalesOrderReturn : ISalesOrderReturn
    {                
        
        #region Implements ISalesOrderReturn

        public System.Guid DocumentID { get; set; }            
        public string DocumentCode { get; set; }            
        public System.Guid? PrevRevisionDocumentID { get; set; }            
        public int? RevisionNumber { get; set; }            
        public System.DateTime TransactionDate { get; set; }            
        public System.Guid SalesmanID { get; set; }            
        public System.Guid WarehouseID { get; set; }            
        public System.Guid CustomerID { get; set; }            
        public int PriceGroupID { get; set; }            
        public int DiscountGroupID { get; set; }            
        public int TermOfPaymentID { get; set; }            
        public string ReferenceNumber { get; set; }            
        public int ItemStatusID { get; set; }            
        public System.Guid DODocumentID { get; set; }            
        public System.Guid? InvoiceDocumentID { get; set; }            
        public double RawTotalGrossPrice { get; set; }            
        public double RawTotalPrice { get; set; }            
        public double RawTotalDiscountStrata1Amount { get; set; }            
        public double RawTotalDiscountStrata2Amount { get; set; }            
        public double RawTotalDiscountStrata3Amount { get; set; }            
        public double RawTotalDiscountStrata4Amount { get; set; }            
        public double RawTotalDiscountStrata5Amount { get; set; }            
        public double RawTotalAddDiscountStrataAmount { get; set; }            
        public double RawTotalGrossAmount { get; set; }            
        public double RawTotalTaxAmount { get; set; }            
        public double RawTotalAmount { get; set; }            
        public double TotalGrossPrice { get; set; }            
        public double TotalPrice { get; set; }            
        public double TotalDiscountStrata1Amount { get; set; }            
        public double TotalDiscountStrata2Amount { get; set; }            
        public double TotalDiscountStrata3Amount { get; set; }            
        public double TotalDiscountStrata4Amount { get; set; }            
        public double TotalDiscountStrata5Amount { get; set; }            
        public double TotalAddDiscountStrataAmount { get; set; }            
        public double TotalGrossAmount { get; set; }            
        public double TotalTaxAmount { get; set; }            
        public double TotalAmount { get; set; }            
        public double TotalWeight { get; set; }            
        public int TotalDimension { get; set; }            
        public string AddDiscountStrataReason { get; set; }            
        public int PrintCount { get; set; }            
        public System.DateTime? LastPrintedDate { get; set; }            
        public int DocumentStatusID { get; set; }            
        public string DocumentStatusReason { get; set; }            
        public string MobileDocumentCode { get; set; }            
        public System.DateTime? PostedDate { get; set; }            
        public System.DateTime CreatedDate { get; set; }            
        public int? CreatedByUserID { get; set; }            
        public System.DateTime? ModifiedDate { get; set; }            
        public int? ModifiedByUserID { get; set; }            
        
        
        
        public void CopyFrom(ISalesOrderReturn obj)
        {
            DocumentID = obj.DocumentID;
            DocumentCode = obj.DocumentCode;
            PrevRevisionDocumentID = obj.PrevRevisionDocumentID;
            RevisionNumber = obj.RevisionNumber;
            TransactionDate = obj.TransactionDate;
            SalesmanID = obj.SalesmanID;
            WarehouseID = obj.WarehouseID;
            CustomerID = obj.CustomerID;
            PriceGroupID = obj.PriceGroupID;
            DiscountGroupID = obj.DiscountGroupID;
            TermOfPaymentID = obj.TermOfPaymentID;
            ReferenceNumber = obj.ReferenceNumber;
            ItemStatusID = obj.ItemStatusID;
            DODocumentID = obj.DODocumentID;
            InvoiceDocumentID = obj.InvoiceDocumentID;
            RawTotalGrossPrice = obj.RawTotalGrossPrice;
            RawTotalPrice = obj.RawTotalPrice;
            RawTotalDiscountStrata1Amount = obj.RawTotalDiscountStrata1Amount;
            RawTotalDiscountStrata2Amount = obj.RawTotalDiscountStrata2Amount;
            RawTotalDiscountStrata3Amount = obj.RawTotalDiscountStrata3Amount;
            RawTotalDiscountStrata4Amount = obj.RawTotalDiscountStrata4Amount;
            RawTotalDiscountStrata5Amount = obj.RawTotalDiscountStrata5Amount;
            RawTotalAddDiscountStrataAmount = obj.RawTotalAddDiscountStrataAmount;
            RawTotalGrossAmount = obj.RawTotalGrossAmount;
            RawTotalTaxAmount = obj.RawTotalTaxAmount;
            RawTotalAmount = obj.RawTotalAmount;
            TotalGrossPrice = obj.TotalGrossPrice;
            TotalPrice = obj.TotalPrice;
            TotalDiscountStrata1Amount = obj.TotalDiscountStrata1Amount;
            TotalDiscountStrata2Amount = obj.TotalDiscountStrata2Amount;
            TotalDiscountStrata3Amount = obj.TotalDiscountStrata3Amount;
            TotalDiscountStrata4Amount = obj.TotalDiscountStrata4Amount;
            TotalDiscountStrata5Amount = obj.TotalDiscountStrata5Amount;
            TotalAddDiscountStrataAmount = obj.TotalAddDiscountStrataAmount;
            TotalGrossAmount = obj.TotalGrossAmount;
            TotalTaxAmount = obj.TotalTaxAmount;
            TotalAmount = obj.TotalAmount;
            TotalWeight = obj.TotalWeight;
            TotalDimension = obj.TotalDimension;
            AddDiscountStrataReason = obj.AddDiscountStrataReason;
            PrintCount = obj.PrintCount;
            LastPrintedDate = obj.LastPrintedDate;
            DocumentStatusID = obj.DocumentStatusID;
            DocumentStatusReason = obj.DocumentStatusReason;
            MobileDocumentCode = obj.MobileDocumentCode;
            PostedDate = obj.PostedDate;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
            ModifiedDate = obj.ModifiedDate;
            ModifiedByUserID = obj.ModifiedByUserID;
        }

        #endregion

    }

}
