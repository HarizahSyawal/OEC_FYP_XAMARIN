﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:11
// Description   : IvPaymentCollectionDetails partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IvPaymentCollectionDetails.cs'
//       up to one level of this file location inside 'vPaymentCollectionDetails' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IvPaymentCollectionDetails
    {                
        
        #region Properties
        
        System.Guid DocumentID { get; set; }
        System.Guid InvoiceDocumentID { get; set; }
        string InvoiceDocumentCode { get; set; }
        System.DateTime InvoiceTransactionDate { get; set; }
        System.Guid SODocumentID { get; set; }
        string SODocumentCode { get; set; }
        System.DateTime? SOTransactionDate { get; set; }
        System.Guid? SalesmanID { get; set; }
        string SalesmanCode { get; set; }
        string SalesmanName { get; set; }
        string Salesman { get; set; }
        System.Guid? WarehouseID { get; set; }
        string WarehouseCode { get; set; }
        string WarehouseName { get; set; }
        string Warehouse { get; set; }
        System.Guid? SiteID { get; set; }
        string SiteCode { get; set; }
        string SiteName { get; set; }
        string Site { get; set; }
        int? AreaID { get; set; }
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
        int? CompanyID { get; set; }
        string CompanyCode { get; set; }
        string CompanyName { get; set; }
        string Company { get; set; }
        int? SiteDistributionTypeID { get; set; }
        string SiteDistributionTypeName { get; set; }
        bool? IsSiteProductLotCodeEntryRequired { get; set; }
        int? WarehouseTypeID { get; set; }
        string WarehouseTypeName { get; set; }
        System.Guid? CustomerID { get; set; }
        string CustomerCode { get; set; }
        string CustomerName { get; set; }
        string Customer { get; set; }
        System.Guid? CustomerBillGroupID { get; set; }
        string CustomerBillGroupCode { get; set; }
        string CustomerBillGroupName { get; set; }
        string CustomerBillGroup { get; set; }
        int? CustomerBillGroupHeadID { get; set; }
        string CustomerBillGroupHeadCode { get; set; }
        string CustomerBillGroupHeadName { get; set; }
        string CustomerBillGroupHead { get; set; }
        System.Guid? CollectorID { get; set; }
        string CollectorCode { get; set; }
        string CollectorName { get; set; }
        string Collector { get; set; }
        bool? IsCollectedByHeadOffice { get; set; }
        System.Guid? CollectedBySiteID { get; set; }
        string CollectedBySiteCode { get; set; }
        string CollectedBySiteName { get; set; }
        string CollectedBySite { get; set; }
        int? CollectedByAreaID { get; set; }
        string CollectedByAreaCode { get; set; }
        string CollectedByAreaName { get; set; }
        string CollectedByArea { get; set; }
        int? CollectedByRegionID { get; set; }
        string CollectedByRegionCode { get; set; }
        string CollectedByRegionName { get; set; }
        string CollectedByRegion { get; set; }
        int? CollectedByTerritoryID { get; set; }
        string CollectedByTerritoryCode { get; set; }
        string CollectedByTerritoryName { get; set; }
        string CollectedByTerritory { get; set; }
        int? CollectedByCompanyID { get; set; }
        string CollectedByCompanyCode { get; set; }
        string CollectedByCompanyName { get; set; }
        string CollectedByCompany { get; set; }
        int? CollectedBySiteDistributionTypeID { get; set; }
        string CollectedBySiteDistributionTypeName { get; set; }
        bool? IsCollectedBySiteProductLotCodeEntryRequired { get; set; }
        bool? IsCustomerTaxIDAvailable { get; set; }
        string CustomerTaxIDNumber { get; set; }
        string CustomerTaxIDName { get; set; }
        string CustomerContactPerson { get; set; }
        string CustomerAddress1 { get; set; }
        string CustomerAddress2 { get; set; }
        string CustomerAddress3 { get; set; }
        string CustomerAddress { get; set; }
        int? CustomerCityID { get; set; }
        string CustomerCity { get; set; }
        int? CustomerStateProvinceID { get; set; }
        string CustomerStateProvince { get; set; }
        string CustomerCountryID { get; set; }
        string CustomerCountryName { get; set; }
        string CustomerZipCode { get; set; }
        string CustomerPhone1 { get; set; }
        string CustomerPhone2 { get; set; }
        string CustomerPhone3 { get; set; }
        string CustomerFax { get; set; }
        string CustomerEmail { get; set; }
        double? CustomerLongitude { get; set; }
        double? CustomerLatitude { get; set; }
        string CustomerBillContactPerson { get; set; }
        bool? IsCustomerBillAddressSameAsAddress { get; set; }
        string CustomerBillAddress1 { get; set; }
        string CustomerBillAddress2 { get; set; }
        string CustomerBillAddress3 { get; set; }
        string CustomerBillAddress { get; set; }
        int? CustomerBillCityID { get; set; }
        string CustomerBillCity { get; set; }
        int? CustomerBillStateProvinceID { get; set; }
        string CustomerBillStateProvince { get; set; }
        string CustomerBillCountryID { get; set; }
        string CustomerBillCountryName { get; set; }
        string CustomerBillZipCode { get; set; }
        string CustomerBillPhone1 { get; set; }
        string CustomerBillPhone2 { get; set; }
        string CustomerBillPhone3 { get; set; }
        string CustomerBillFax { get; set; }
        string CustomerBillEmail { get; set; }
        double? CustomerBillLongitude { get; set; }
        double? CustomerBillLatitude { get; set; }
        int? PriceGroupID { get; set; }
        string PriceGroupName { get; set; }
        int? DiscountGroupID { get; set; }
        string DiscountGroupCode { get; set; }
        string DiscountGroupName { get; set; }
        string DiscountGroup { get; set; }
        string DiscountGroupDescription { get; set; }
        int? TermOfPaymentID { get; set; }
        string TermOfPaymentName { get; set; }
        string ReferenceNumber { get; set; }
        System.Guid? DODocumentID { get; set; }
        string DODocumentCode { get; set; }
        System.DateTime? DOTransactionDate { get; set; }
        System.DateTime? DOShipmentDate { get; set; }
        System.DateTime? DODeliveredDate { get; set; }
        int? DOPrintCount { get; set; }
        System.DateTime? DOLastPrintedDate { get; set; }
        double? RawTotalGrossPrice { get; set; }
        double? RawTotalPrice { get; set; }
        double? RawTotalDiscountStrata1Amount { get; set; }
        double? RawTotalDiscountStrata2Amount { get; set; }
        double? RawTotalDiscountStrata3Amount { get; set; }
        double? RawTotalDiscountStrata4Amount { get; set; }
        double? RawTotalDiscountStrata5Amount { get; set; }
        double? RawTotalAddDiscountStrataAmount { get; set; }
        double? RawTotalGrossAmount { get; set; }
        double? RawTotalTaxAmount { get; set; }
        double? RawTotalAmount { get; set; }
        double? TotalGrossPrice { get; set; }
        double? TotalPrice { get; set; }
        double? TotalDiscountStrata1Amount { get; set; }
        double? TotalDiscountStrata2Amount { get; set; }
        double? TotalDiscountStrata3Amount { get; set; }
        double? TotalDiscountStrata4Amount { get; set; }
        double? TotalDiscountStrata5Amount { get; set; }
        double? TotalAddDiscountStrataAmount { get; set; }
        double? TotalGrossAmount { get; set; }
        double? TotalTaxAmount { get; set; }
        double? TotalAmount { get; set; }
        double? TotalWeight { get; set; }
        int? TotalDimension { get; set; }
        string AddDiscountStrataReason { get; set; }
        int? SOPrintCount { get; set; }
        System.DateTime? SOLastPrintedDate { get; set; }
        int? SODocumentStatusID { get; set; }
        string SODocumentStatusName { get; set; }
        string SODocumentStatusReason { get; set; }
        string SOMobileDocumentCode { get; set; }
        System.DateTime? SOPostedDate { get; set; }
        System.DateTime? InvoiceDueDate { get; set; }
        System.Guid? InvoiceOpnameDocumentID { get; set; }
        string InvoiceOpnameDocumentCode { get; set; }
        System.DateTime? InvoiceOpnameTransactionDate { get; set; }
        int InvoicePrintCount { get; set; }
        System.DateTime? InvoiceLastPrintedDate { get; set; }
        int InvoiceDocumentStatusID { get; set; }
        string InvoiceDocumentStatusName { get; set; }
        System.DateTime? InvoicePostedDate { get; set; }
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
        System.Guid? BARSDocumentID { get; set; }
        string BARSDocumentCode { get; set; }
        System.DateTime? BARSTransactionDate { get; set; }
        double RawAllocationAmount { get; set; }
        double RawAdditionalCostAllocationAmount { get; set; }
        double AllocationAmount { get; set; }
        double AdditionalCostAllocationAmount { get; set; }
        int? UnpaidReasonID { get; set; }
        string UnpaidReasonName { get; set; }

        #endregion

        #region Methods
        
        void CopyFrom(IvPaymentCollectionDetails obj);
        
        #endregion
        
    }

}
