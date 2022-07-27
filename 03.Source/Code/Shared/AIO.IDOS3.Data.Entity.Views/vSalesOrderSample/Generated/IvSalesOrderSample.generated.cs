﻿// ===================================================================================
// Author        : System
// Created date  : 24 Sep 2020 03:22:04
// Description   : IvSalesOrderSample partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IvSalesOrderSample.cs'
//       up to one level of this file location inside 'vSalesOrderSample' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IvSalesOrderSample
    {                
        
        #region Properties
        
        System.Guid DocumentID { get; set; }
        string DocumentCode { get; set; }
        System.Guid? PrevRevisionDocumentID { get; set; }
        string PrevRevisionDocumentCode { get; set; }
        int? RevisionNumber { get; set; }
        System.DateTime TransactionDate { get; set; }
        System.Guid? PODocumentID { get; set; }
        string PODocumentCode { get; set; }
        System.DateTime? POTransactionDate { get; set; }
        System.Guid SalesmanID { get; set; }
        string SalesmanCode { get; set; }
        string SalesmanName { get; set; }
        string Salesman { get; set; }
        System.Guid WarehouseID { get; set; }
        string WarehouseCode { get; set; }
        string WarehouseName { get; set; }
        string Warehouse { get; set; }
        System.Guid? SiteID { get; set; }
        string SiteCode { get; set; }
        string SiteName { get; set; }
        string Site { get; set; }
        int AreaID { get; set; }
        string AreaCode { get; set; }
        string AreaName { get; set; }
        string Area { get; set; }
        int? RegionID { get; set; }
        string RegionCode { get; set; }
        string RegionName { get; set; }
        string Region { get; set; }
        int? TerritoryID { get; set; }
        string TerritoryCode { get; set; }
        string TerritoryName { get; set; }
        string Territory { get; set; }
        int CompanyID { get; set; }
        string CompanyCode { get; set; }
        string CompanyName { get; set; }
        string Company { get; set; }
        int SiteDistributionTypeID { get; set; }
        string SiteDistributionTypeName { get; set; }
        bool IsSiteProductLotCodeEntryRequired { get; set; }
        int WarehouseTypeID { get; set; }
        string WarehouseTypeName { get; set; }
        System.Guid CustomerID { get; set; }
        string CustomerCode { get; set; }
        string CustomerName { get; set; }
        string Customer { get; set; }
        int PriceGroupID { get; set; }
        string PriceGroupName { get; set; }
        int DiscountGroupID { get; set; }
        string DiscountGroupCode { get; set; }
        string DiscountGroupName { get; set; }
        string DiscountGroup { get; set; }
        string DiscountGroupDescription { get; set; }
        int TermOfPaymentID { get; set; }
        string TermOfPaymentName { get; set; }
        string ReferenceNumber { get; set; }
        System.Guid DODocumentID { get; set; }
        string DODocumentCode { get; set; }
        System.DateTime DOTransactionDate { get; set; }
        System.DateTime? DOShipmentDate { get; set; }
        System.DateTime? DODeliveredDate { get; set; }
        int DOPrintCount { get; set; }
        System.DateTime? DOLastPrintedDate { get; set; }
        System.Guid? InvoiceDocumentID { get; set; }
        string InvoiceDocumentCode { get; set; }
        double TotalGrossPrice { get; set; }
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
        string DocumentStatusName { get; set; }
        string DocumentStatusReason { get; set; }
        string MobileDocumentCode { get; set; }
        System.DateTime? PostedDate { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        string CreatedByUserName { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }
        string ModifiedByUserName { get; set; }

        #endregion

        #region Methods
        
        void CopyFrom(IvSalesOrderSample obj);
        
        #endregion
        
    }

}
