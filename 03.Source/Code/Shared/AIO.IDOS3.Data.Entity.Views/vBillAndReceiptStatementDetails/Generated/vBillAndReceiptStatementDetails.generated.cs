﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:35:43
// Description   : vBillAndReceiptStatementDetails partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vBillAndReceiptStatementDetails.cs'
//       up to one level of this file location inside 'vBillAndReceiptStatementDetails' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vBillAndReceiptStatementDetails : BaseEntityType, IvBillAndReceiptStatementDetails
    {                
        
        #region Implements IvBillAndReceiptStatementDetails

        public System.Guid DocumentID { get; set; }
        public System.Guid InvoiceDocumentID { get; set; }
        public string InvoiceDocumentCode { get; set; }
        public System.DateTime InvoiceTransactionDate { get; set; }
        public System.Guid SODocumentID { get; set; }
        public string SODocumentCode { get; set; }
        public System.DateTime? SOTransactionDate { get; set; }
        public System.Guid? SalesmanID { get; set; }
        public string SalesmanCode { get; set; }
        public string SalesmanName { get; set; }
        public string Salesman { get; set; }
        public System.Guid? WarehouseID { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseName { get; set; }
        public string Warehouse { get; set; }
        public System.Guid? SiteID { get; set; }
        public string SiteCode { get; set; }
        public string SiteName { get; set; }
        public string Site { get; set; }
        public int? AreaID { get; set; }
        public string AreaCode { get; set; }
        public string AreaName { get; set; }
        public string Area { get; set; }
        public int? RegionID { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public string Region { get; set; }
        public int? TerritoryID { get; set; }
        public string TerritoryCode { get; set; }
        public string TerritoryName { get; set; }
        public string Territory { get; set; }
        public int? CompanyID { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string Company { get; set; }
        public int? SiteDistributionTypeID { get; set; }
        public string SiteDistributionTypeName { get; set; }
        public bool? IsSiteProductLotCodeEntryRequired { get; set; }
        public int? WarehouseTypeID { get; set; }
        public string WarehouseTypeName { get; set; }
        public System.Guid? CustomerID { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string Customer { get; set; }
        public System.Guid? CustomerBillGroupID { get; set; }
        public string CustomerBillGroupCode { get; set; }
        public string CustomerBillGroupName { get; set; }
        public string CustomerBillGroup { get; set; }
        public int? CustomerBillGroupHeadID { get; set; }
        public string CustomerBillGroupHeadCode { get; set; }
        public string CustomerBillGroupHeadName { get; set; }
        public string CustomerBillGroupHead { get; set; }
        public System.Guid? CollectorID { get; set; }
        public string CollectorCode { get; set; }
        public string CollectorName { get; set; }
        public string Collector { get; set; }
        public bool? IsCollectedByHeadOffice { get; set; }
        public System.Guid? CollectedBySiteID { get; set; }
        public string CollectedBySiteCode { get; set; }
        public string CollectedBySiteName { get; set; }
        public string CollectedBySite { get; set; }
        public int? CollectedByAreaID { get; set; }
        public string CollectedByAreaCode { get; set; }
        public string CollectedByAreaName { get; set; }
        public string CollectedByArea { get; set; }
        public int? CollectedByRegionID { get; set; }
        public string CollectedByRegionCode { get; set; }
        public string CollectedByRegionName { get; set; }
        public string CollectedByRegion { get; set; }
        public int? CollectedByTerritoryID { get; set; }
        public string CollectedByTerritoryCode { get; set; }
        public string CollectedByTerritoryName { get; set; }
        public string CollectedByTerritory { get; set; }
        public int? CollectedByCompanyID { get; set; }
        public string CollectedByCompanyCode { get; set; }
        public string CollectedByCompanyName { get; set; }
        public string CollectedByCompany { get; set; }
        public int? CollectedBySiteDistributionTypeID { get; set; }
        public string CollectedBySiteDistributionTypeName { get; set; }
        public bool? IsCollectedBySiteProductLotCodeEntryRequired { get; set; }
        public bool? IsCustomerTaxIDAvailable { get; set; }
        public string CustomerTaxIDNumber { get; set; }
        public string CustomerTaxIDName { get; set; }
        public string CustomerContactPerson { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerAddress2 { get; set; }
        public string CustomerAddress3 { get; set; }
        public string CustomerAddress { get; set; }
        public int? CustomerCityID { get; set; }
        public string CustomerCity { get; set; }
        public int? CustomerStateProvinceID { get; set; }
        public string CustomerStateProvince { get; set; }
        public string CustomerCountryID { get; set; }
        public string CustomerCountryName { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerPhone1 { get; set; }
        public string CustomerPhone2 { get; set; }
        public string CustomerPhone3 { get; set; }
        public string CustomerFax { get; set; }
        public string CustomerEmail { get; set; }
        public double? CustomerLongitude { get; set; }
        public double? CustomerLatitude { get; set; }
        public string CustomerBillContactPerson { get; set; }
        public bool? IsCustomerBillAddressSameAsAddress { get; set; }
        public string CustomerBillAddress1 { get; set; }
        public string CustomerBillAddress2 { get; set; }
        public string CustomerBillAddress3 { get; set; }
        public string CustomerBillAddress { get; set; }
        public int? CustomerBillCityID { get; set; }
        public string CustomerBillCity { get; set; }
        public int? CustomerBillStateProvinceID { get; set; }
        public string CustomerBillStateProvince { get; set; }
        public string CustomerBillCountryID { get; set; }
        public string CustomerBillCountryName { get; set; }
        public string CustomerBillZipCode { get; set; }
        public string CustomerBillPhone1 { get; set; }
        public string CustomerBillPhone2 { get; set; }
        public string CustomerBillPhone3 { get; set; }
        public string CustomerBillFax { get; set; }
        public string CustomerBillEmail { get; set; }
        public double? CustomerBillLongitude { get; set; }
        public double? CustomerBillLatitude { get; set; }
        public int? PriceGroupID { get; set; }
        public string PriceGroupName { get; set; }
        public int? DiscountGroupID { get; set; }
        public string DiscountGroupCode { get; set; }
        public string DiscountGroupName { get; set; }
        public string DiscountGroup { get; set; }
        public string DiscountGroupDescription { get; set; }
        public int? TermOfPaymentID { get; set; }
        public string TermOfPaymentName { get; set; }
        public string ReferenceNumber { get; set; }
        public System.Guid? DODocumentID { get; set; }
        public string DODocumentCode { get; set; }
        public System.DateTime? DOTransactionDate { get; set; }
        public System.DateTime? DOShipmentDate { get; set; }
        public System.DateTime? DODeliveredDate { get; set; }
        public int? DOPrintCount { get; set; }
        public System.DateTime? DOLastPrintedDate { get; set; }
        public double? RawTotalGrossPrice { get; set; }
        public double? RawTotalPrice { get; set; }
        public double? RawTotalDiscountStrata1Amount { get; set; }
        public double? RawTotalDiscountStrata2Amount { get; set; }
        public double? RawTotalDiscountStrata3Amount { get; set; }
        public double? RawTotalDiscountStrata4Amount { get; set; }
        public double? RawTotalDiscountStrata5Amount { get; set; }
        public double? RawTotalAddDiscountStrataAmount { get; set; }
        public double? RawTotalGrossAmount { get; set; }
        public double? RawTotalTaxAmount { get; set; }
        public double? RawTotalAmount { get; set; }
        public double? TotalGrossPrice { get; set; }
        public double? TotalPrice { get; set; }
        public double? TotalDiscountStrata1Amount { get; set; }
        public double? TotalDiscountStrata2Amount { get; set; }
        public double? TotalDiscountStrata3Amount { get; set; }
        public double? TotalDiscountStrata4Amount { get; set; }
        public double? TotalDiscountStrata5Amount { get; set; }
        public double? TotalAddDiscountStrataAmount { get; set; }
        public double? TotalGrossAmount { get; set; }
        public double? TotalTaxAmount { get; set; }
        public double? TotalAmount { get; set; }
        public double? TotalWeight { get; set; }
        public int? TotalDimension { get; set; }
        public string AddDiscountStrataReason { get; set; }
        public int? SOPrintCount { get; set; }
        public System.DateTime? SOLastPrintedDate { get; set; }
        public int? SODocumentStatusID { get; set; }
        public string SODocumentStatusName { get; set; }
        public string SODocumentStatusReason { get; set; }
        public string SOMobileDocumentCode { get; set; }
        public System.DateTime? SOPostedDate { get; set; }
        public System.DateTime? InvoiceDueDate { get; set; }
        public System.Guid? BARSDocumentID { get; set; }
        public string BARSDocumentCode { get; set; }
        public System.DateTime? BARSTransactionDate { get; set; }
        public System.Guid? InvoiceOpnameDocumentID { get; set; }
        public string InvoiceOpnameDocumentCode { get; set; }
        public System.DateTime? InvoiceOpnameTransactionDate { get; set; }
        public int InvoicePrintCount { get; set; }
        public System.DateTime? InvoiceLastPrintedDate { get; set; }
        public int InvoiceDocumentStatusID { get; set; }
        public string InvoiceDocumentStatusName { get; set; }
        public System.DateTime? InvoicePostedDate { get; set; }
        public double? InvoiceARRawTotalAmount { get; set; }
        public double? InvoiceARRawPaidAmount { get; set; }
        public double? InvoiceARRawOutstandingAmount { get; set; }
        public double? InvoiceARTotalAmount { get; set; }
        public double? InvoiceARPaidAmount { get; set; }
        public double? InvoiceAROutstandingAmount { get; set; }
        public double? InvoiceARPendingPaymentAmount { get; set; }
        public double? InvoiceARPendingOutstandingAmount { get; set; }
        public int? InvoiceARStatusID { get; set; }
        public string InvoiceARStatusName { get; set; }
        public System.DateTime? InvoiceARSettledDate { get; set; }
        public bool IsPrintReceipt { get; set; }
        public double? PaymentAmount { get; set; }
        public int? UnpaidReasonID { get; set; }
        public string UnpaidReasonName { get; set; }
        public bool? IsReleased { get; set; }
        public int? UnreleasedReasonID { get; set; }
        public string UnreleasedReasonName { get; set; }
        
        
        
        public void CopyFrom(IvBillAndReceiptStatementDetails obj)
        {
            DocumentID = obj.DocumentID;
            InvoiceDocumentID = obj.InvoiceDocumentID;
            InvoiceDocumentCode = obj.InvoiceDocumentCode;
            InvoiceTransactionDate = obj.InvoiceTransactionDate;
            SODocumentID = obj.SODocumentID;
            SODocumentCode = obj.SODocumentCode;
            SOTransactionDate = obj.SOTransactionDate;
            SalesmanID = obj.SalesmanID;
            SalesmanCode = obj.SalesmanCode;
            SalesmanName = obj.SalesmanName;
            Salesman = obj.Salesman;
            WarehouseID = obj.WarehouseID;
            WarehouseCode = obj.WarehouseCode;
            WarehouseName = obj.WarehouseName;
            Warehouse = obj.Warehouse;
            SiteID = obj.SiteID;
            SiteCode = obj.SiteCode;
            SiteName = obj.SiteName;
            Site = obj.Site;
            AreaID = obj.AreaID;
            AreaCode = obj.AreaCode;
            AreaName = obj.AreaName;
            Area = obj.Area;
            RegionID = obj.RegionID;
            RegionCode = obj.RegionCode;
            RegionName = obj.RegionName;
            Region = obj.Region;
            TerritoryID = obj.TerritoryID;
            TerritoryCode = obj.TerritoryCode;
            TerritoryName = obj.TerritoryName;
            Territory = obj.Territory;
            CompanyID = obj.CompanyID;
            CompanyCode = obj.CompanyCode;
            CompanyName = obj.CompanyName;
            Company = obj.Company;
            SiteDistributionTypeID = obj.SiteDistributionTypeID;
            SiteDistributionTypeName = obj.SiteDistributionTypeName;
            IsSiteProductLotCodeEntryRequired = obj.IsSiteProductLotCodeEntryRequired;
            WarehouseTypeID = obj.WarehouseTypeID;
            WarehouseTypeName = obj.WarehouseTypeName;
            CustomerID = obj.CustomerID;
            CustomerCode = obj.CustomerCode;
            CustomerName = obj.CustomerName;
            Customer = obj.Customer;
            CustomerBillGroupID = obj.CustomerBillGroupID;
            CustomerBillGroupCode = obj.CustomerBillGroupCode;
            CustomerBillGroupName = obj.CustomerBillGroupName;
            CustomerBillGroup = obj.CustomerBillGroup;
            CustomerBillGroupHeadID = obj.CustomerBillGroupHeadID;
            CustomerBillGroupHeadCode = obj.CustomerBillGroupHeadCode;
            CustomerBillGroupHeadName = obj.CustomerBillGroupHeadName;
            CustomerBillGroupHead = obj.CustomerBillGroupHead;
            CollectorID = obj.CollectorID;
            CollectorCode = obj.CollectorCode;
            CollectorName = obj.CollectorName;
            Collector = obj.Collector;
            IsCollectedByHeadOffice = obj.IsCollectedByHeadOffice;
            CollectedBySiteID = obj.CollectedBySiteID;
            CollectedBySiteCode = obj.CollectedBySiteCode;
            CollectedBySiteName = obj.CollectedBySiteName;
            CollectedBySite = obj.CollectedBySite;
            CollectedByAreaID = obj.CollectedByAreaID;
            CollectedByAreaCode = obj.CollectedByAreaCode;
            CollectedByAreaName = obj.CollectedByAreaName;
            CollectedByArea = obj.CollectedByArea;
            CollectedByRegionID = obj.CollectedByRegionID;
            CollectedByRegionCode = obj.CollectedByRegionCode;
            CollectedByRegionName = obj.CollectedByRegionName;
            CollectedByRegion = obj.CollectedByRegion;
            CollectedByTerritoryID = obj.CollectedByTerritoryID;
            CollectedByTerritoryCode = obj.CollectedByTerritoryCode;
            CollectedByTerritoryName = obj.CollectedByTerritoryName;
            CollectedByTerritory = obj.CollectedByTerritory;
            CollectedByCompanyID = obj.CollectedByCompanyID;
            CollectedByCompanyCode = obj.CollectedByCompanyCode;
            CollectedByCompanyName = obj.CollectedByCompanyName;
            CollectedByCompany = obj.CollectedByCompany;
            CollectedBySiteDistributionTypeID = obj.CollectedBySiteDistributionTypeID;
            CollectedBySiteDistributionTypeName = obj.CollectedBySiteDistributionTypeName;
            IsCollectedBySiteProductLotCodeEntryRequired = obj.IsCollectedBySiteProductLotCodeEntryRequired;
            IsCustomerTaxIDAvailable = obj.IsCustomerTaxIDAvailable;
            CustomerTaxIDNumber = obj.CustomerTaxIDNumber;
            CustomerTaxIDName = obj.CustomerTaxIDName;
            CustomerContactPerson = obj.CustomerContactPerson;
            CustomerAddress1 = obj.CustomerAddress1;
            CustomerAddress2 = obj.CustomerAddress2;
            CustomerAddress3 = obj.CustomerAddress3;
            CustomerAddress = obj.CustomerAddress;
            CustomerCityID = obj.CustomerCityID;
            CustomerCity = obj.CustomerCity;
            CustomerStateProvinceID = obj.CustomerStateProvinceID;
            CustomerStateProvince = obj.CustomerStateProvince;
            CustomerCountryID = obj.CustomerCountryID;
            CustomerCountryName = obj.CustomerCountryName;
            CustomerZipCode = obj.CustomerZipCode;
            CustomerPhone1 = obj.CustomerPhone1;
            CustomerPhone2 = obj.CustomerPhone2;
            CustomerPhone3 = obj.CustomerPhone3;
            CustomerFax = obj.CustomerFax;
            CustomerEmail = obj.CustomerEmail;
            CustomerLongitude = obj.CustomerLongitude;
            CustomerLatitude = obj.CustomerLatitude;
            CustomerBillContactPerson = obj.CustomerBillContactPerson;
            IsCustomerBillAddressSameAsAddress = obj.IsCustomerBillAddressSameAsAddress;
            CustomerBillAddress1 = obj.CustomerBillAddress1;
            CustomerBillAddress2 = obj.CustomerBillAddress2;
            CustomerBillAddress3 = obj.CustomerBillAddress3;
            CustomerBillAddress = obj.CustomerBillAddress;
            CustomerBillCityID = obj.CustomerBillCityID;
            CustomerBillCity = obj.CustomerBillCity;
            CustomerBillStateProvinceID = obj.CustomerBillStateProvinceID;
            CustomerBillStateProvince = obj.CustomerBillStateProvince;
            CustomerBillCountryID = obj.CustomerBillCountryID;
            CustomerBillCountryName = obj.CustomerBillCountryName;
            CustomerBillZipCode = obj.CustomerBillZipCode;
            CustomerBillPhone1 = obj.CustomerBillPhone1;
            CustomerBillPhone2 = obj.CustomerBillPhone2;
            CustomerBillPhone3 = obj.CustomerBillPhone3;
            CustomerBillFax = obj.CustomerBillFax;
            CustomerBillEmail = obj.CustomerBillEmail;
            CustomerBillLongitude = obj.CustomerBillLongitude;
            CustomerBillLatitude = obj.CustomerBillLatitude;
            PriceGroupID = obj.PriceGroupID;
            PriceGroupName = obj.PriceGroupName;
            DiscountGroupID = obj.DiscountGroupID;
            DiscountGroupCode = obj.DiscountGroupCode;
            DiscountGroupName = obj.DiscountGroupName;
            DiscountGroup = obj.DiscountGroup;
            DiscountGroupDescription = obj.DiscountGroupDescription;
            TermOfPaymentID = obj.TermOfPaymentID;
            TermOfPaymentName = obj.TermOfPaymentName;
            ReferenceNumber = obj.ReferenceNumber;
            DODocumentID = obj.DODocumentID;
            DODocumentCode = obj.DODocumentCode;
            DOTransactionDate = obj.DOTransactionDate;
            DOShipmentDate = obj.DOShipmentDate;
            DODeliveredDate = obj.DODeliveredDate;
            DOPrintCount = obj.DOPrintCount;
            DOLastPrintedDate = obj.DOLastPrintedDate;
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
            SOPrintCount = obj.SOPrintCount;
            SOLastPrintedDate = obj.SOLastPrintedDate;
            SODocumentStatusID = obj.SODocumentStatusID;
            SODocumentStatusName = obj.SODocumentStatusName;
            SODocumentStatusReason = obj.SODocumentStatusReason;
            SOMobileDocumentCode = obj.SOMobileDocumentCode;
            SOPostedDate = obj.SOPostedDate;
            InvoiceDueDate = obj.InvoiceDueDate;
            BARSDocumentID = obj.BARSDocumentID;
            BARSDocumentCode = obj.BARSDocumentCode;
            BARSTransactionDate = obj.BARSTransactionDate;
            InvoiceOpnameDocumentID = obj.InvoiceOpnameDocumentID;
            InvoiceOpnameDocumentCode = obj.InvoiceOpnameDocumentCode;
            InvoiceOpnameTransactionDate = obj.InvoiceOpnameTransactionDate;
            InvoicePrintCount = obj.InvoicePrintCount;
            InvoiceLastPrintedDate = obj.InvoiceLastPrintedDate;
            InvoiceDocumentStatusID = obj.InvoiceDocumentStatusID;
            InvoiceDocumentStatusName = obj.InvoiceDocumentStatusName;
            InvoicePostedDate = obj.InvoicePostedDate;
            InvoiceARRawTotalAmount = obj.InvoiceARRawTotalAmount;
            InvoiceARRawPaidAmount = obj.InvoiceARRawPaidAmount;
            InvoiceARRawOutstandingAmount = obj.InvoiceARRawOutstandingAmount;
            InvoiceARTotalAmount = obj.InvoiceARTotalAmount;
            InvoiceARPaidAmount = obj.InvoiceARPaidAmount;
            InvoiceAROutstandingAmount = obj.InvoiceAROutstandingAmount;
            InvoiceARPendingPaymentAmount = obj.InvoiceARPendingPaymentAmount;
            InvoiceARPendingOutstandingAmount = obj.InvoiceARPendingOutstandingAmount;
            InvoiceARStatusID = obj.InvoiceARStatusID;
            InvoiceARStatusName = obj.InvoiceARStatusName;
            InvoiceARSettledDate = obj.InvoiceARSettledDate;
            IsPrintReceipt = obj.IsPrintReceipt;
            PaymentAmount = obj.PaymentAmount;
            UnpaidReasonID = obj.UnpaidReasonID;
            UnpaidReasonName = obj.UnpaidReasonName;
            IsReleased = obj.IsReleased;
            UnreleasedReasonID = obj.UnreleasedReasonID;
            UnreleasedReasonName = obj.UnreleasedReasonName;
        }
        
        #endregion

    }

}
