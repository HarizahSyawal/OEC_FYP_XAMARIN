﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:35:44
// Description   : IvBillAndReceiptStatementPopupDetails partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IvBillAndReceiptStatementPopupDetails.cs'
//       up to one level of this file location inside 'vBillAndReceiptStatementPopupDetails' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IvBillAndReceiptStatementPopupDetails
    {                
        
        #region Properties
        
        System.Guid DocumentID { get; set; }
        System.Guid InvoiceDocumentID { get; set; }
        string InvoiceDocumentCode { get; set; }
        System.DateTime InvoiceTransactionDate { get; set; }
        System.Guid SODocumentID { get; set; }
        string SODocumentCode { get; set; }
        System.DateTime SOTransactionDate { get; set; }
        System.Guid SalesmanID { get; set; }
        string Salesman { get; set; }
        System.Guid WarehouseID { get; set; }
        string Warehouse { get; set; }
        System.Guid? SiteID { get; set; }
        string Site { get; set; }
        int AreaID { get; set; }
        string Area { get; set; }
        int? RegionID { get; set; }
        string Region { get; set; }
        int? TerritoryID { get; set; }
        string Territory { get; set; }
        int CompanyID { get; set; }
        string Company { get; set; }
        int WarehouseTypeID { get; set; }
        string WarehouseTypeName { get; set; }
        System.Guid CustomerID { get; set; }
        string Customer { get; set; }
        System.Guid? CustomerBillGroupID { get; set; }
        string CustomerBillGroup { get; set; }
        int TermOfPaymentID { get; set; }
        string TermOfPaymentName { get; set; }
        string ReferenceNumber { get; set; }
        System.Guid DODocumentID { get; set; }
        string DODocumentCode { get; set; }
        System.DateTime DOTransactionDate { get; set; }
        System.DateTime? DOShipmentDate { get; set; }
        System.DateTime? DODeliveredDate { get; set; }
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
        System.DateTime? InvoiceDueDate { get; set; }
        System.Guid? BARSDocumentID { get; set; }
        string BARSDocumentCode { get; set; }
        System.DateTime? BARSTransactionDate { get; set; }
        double? InvoiceARRawTotalAmount { get; set; }
        double? InvoiceARRawPaidAmount { get; set; }
        double? InvoiceARRawOutstandingAmount { get; set; }
        double? InvoiceARTotalAmount { get; set; }
        double? InvoiceARPaidAmount { get; set; }
        double? InvoiceAROutstandingAmount { get; set; }
        double? InvoiceARPendingPaymentAmount { get; set; }
        double? InvoiceARPendingOutstandingAmount { get; set; }
        int? InvoiceARStatusID { get; set; }
        string InvoiceARStatusName { get; set; }
        System.DateTime? InvoiceARSettledDate { get; set; }
        bool IsPrintReceipt { get; set; }
        double? PaymentAmount { get; set; }
        int? UnpaidReasonID { get; set; }
        string UnpaidReasonName { get; set; }
        bool? IsReleased { get; set; }
        int? UnreleasedReasonID { get; set; }
        string UnreleasedReasonName { get; set; }

        #endregion

        #region Methods
        
        void CopyFrom(IvBillAndReceiptStatementPopupDetails obj);
        
        #endregion
        
    }

}