﻿// ===================================================================================
// Author        : System
// Created date  : 24 Sep 2020 03:19:41
// Description   : ISalesOrderReturn partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'ISalesOrderReturn.cs'
//       up to one level of this file location inside 'SalesOrderReturn' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface ISalesOrderReturn
    {                
        
        #region Properties
        
        System.Guid DocumentID { get; set; }
        string DocumentCode { get; set; }
        System.Guid? PrevRevisionDocumentID { get; set; }
        int? RevisionNumber { get; set; }
        System.DateTime TransactionDate { get; set; }
        System.Guid SalesmanID { get; set; }
        System.Guid WarehouseID { get; set; }
        System.Guid CustomerID { get; set; }
        int PriceGroupID { get; set; }
        int DiscountGroupID { get; set; }
        int TermOfPaymentID { get; set; }
        string ReferenceNumber { get; set; }
        int ItemStatusID { get; set; }
        System.Guid DODocumentID { get; set; }
        System.Guid? InvoiceDocumentID { get; set; }
        double RawTotalGrossPrice { get; set; }
        double RawTotalPrice { get; set; }
        double RawTotalDiscountStrata1Amount { get; set; }
        double RawTotalDiscountStrata2Amount { get; set; }
        double RawTotalDiscountStrata3Amount { get; set; }
        double RawTotalDiscountStrata4Amount { get; set; }
        double RawTotalDiscountStrata5Amount { get; set; }
        double RawTotalAddDiscountStrataAmount { get; set; }
        double RawTotalGrossAmount { get; set; }
        double RawTotalTaxAmount { get; set; }
        double RawTotalAmount { get; set; }
        double TotalGrossPrice { get; set; }
        double TotalPrice { get; set; }
        double TotalDiscountStrata1Amount { get; set; }
        double TotalDiscountStrata2Amount { get; set; }
        double TotalDiscountStrata3Amount { get; set; }
        double TotalDiscountStrata4Amount { get; set; }
        double TotalDiscountStrata5Amount { get; set; }
        double TotalAddDiscountStrataAmount { get; set; }
        double TotalGrossAmount { get; set; }
        double TotalTaxAmount { get; set; }
        double TotalAmount { get; set; }
        double TotalWeight { get; set; }
        int TotalDimension { get; set; }
        string AddDiscountStrataReason { get; set; }
        int PrintCount { get; set; }
        System.DateTime? LastPrintedDate { get; set; }
        int DocumentStatusID { get; set; }
        string DocumentStatusReason { get; set; }
        string MobileDocumentCode { get; set; }
        System.DateTime? PostedDate { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(ISalesOrderReturn obj);
        
        #endregion

    }

}