﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:05
// Description   : vInvoiceCollectionRoutePlan partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vInvoiceCollectionRoutePlan.cs'
//       up to one level of this file location inside 'vInvoiceCollectionRoutePlan' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vInvoiceCollectionRoutePlan : BaseEntityType, IvInvoiceCollectionRoutePlan
    {                
        
        #region Implements IvInvoiceCollectionRoutePlan

        public System.Guid DocumentID { get; set; }
        public string DocumentCode { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public System.Guid RefDocumentID { get; set; }
        public string RefDocumentCode { get; set; }
        public System.DateTime? RefTransactionDate { get; set; }
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
        public bool? IsCollectedByHeadOffice { get; set; }
        public System.Guid? CollectedBySiteID { get; set; }
        public string CollectedBySiteCode { get; set; }
        public string CollectedBySiteName { get; set; }
        public string CollectedBySite { get; set; }
        public int? CollectedByCompanyID { get; set; }
        public string CollectedByCompanyCode { get; set; }
        public string CollectedByCompanyName { get; set; }
        public string CollectedByCompany { get; set; }
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
        public int? CollectedBySiteDistributionTypeID { get; set; }
        public string CollectedBySiteDistributionTypeName { get; set; }
        public bool? IsCollectedBySiteProductLotCodeEntryRequired { get; set; }
        public System.Guid? CollectorID { get; set; }
        public string CollectorCode { get; set; }
        public string CollectorName { get; set; }
        public string Collector { get; set; }
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
        public int? RefPrintCount { get; set; }
        public System.DateTime? RefLastPrintedDate { get; set; }
        public int? RefDocumentStatusID { get; set; }
        public string RefDocumentStatusName { get; set; }
        public string RefDocumentStatusReason { get; set; }
        public string RefMobileDocumentCode { get; set; }
        public System.DateTime? RefPostedDate { get; set; }
        public int RefTransactionTypeID { get; set; }
        public string RefTransactionTypeName { get; set; }
        public System.DateTime? DueDate { get; set; }
        public System.Guid? BARSDocumentID { get; set; }
        public string BARSDocumentCode { get; set; }
        public System.DateTime? BARSTransactionDate { get; set; }
        public System.Guid? OpnameDocumentID { get; set; }
        public string OpnameDocumentCode { get; set; }
        public System.DateTime? OpnameTransactionDate { get; set; }
        public int PrintCount { get; set; }
        public System.DateTime? LastPrintedDate { get; set; }
        public int DocumentStatusID { get; set; }
        public string DocumentStatusName { get; set; }
        public System.DateTime? PostedDate { get; set; }
        public double? ARRawTotalAmount { get; set; }
        public double? ARRawPaidAmount { get; set; }
        public double? ARRawOutstandingAmount { get; set; }
        public double? ARTotalAmount { get; set; }
        public double? ARPaidAmount { get; set; }
        public double? AROutstandingAmount { get; set; }
        public double? ARPendingPaymentAmount { get; set; }
        public double? ARPendingOutstandingAmount { get; set; }
        public int? ARStatusID { get; set; }
        public string ARStatusName { get; set; }
        public System.DateTime? ARSettledDate { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int? CreatedByUserID { get; set; }
        public string CreatedByUserName { get; set; }
        public System.DateTime? ModifiedDate { get; set; }
        public int? ModifiedByUserID { get; set; }
        public string ModifiedByUserName { get; set; }
        public bool RoutePlanWeek1 { get; set; }
        public bool RoutePlanWeek2 { get; set; }
        public bool RoutePlanWeek3 { get; set; }
        public bool RoutePlanWeek4 { get; set; }
        public bool RoutePlanDay1 { get; set; }
        public bool RoutePlanDay2 { get; set; }
        public bool RoutePlanDay3 { get; set; }
        public bool RoutePlanDay4 { get; set; }
        public bool RoutePlanDay5 { get; set; }
        public bool RoutePlanDay6 { get; set; }
        public bool RoutePlanDay7 { get; set; }
        
        
        
        public void CopyFrom(IvInvoiceCollectionRoutePlan obj)
        {
            DocumentID = obj.DocumentID;
            DocumentCode = obj.DocumentCode;
            TransactionDate = obj.TransactionDate;
            RefDocumentID = obj.RefDocumentID;
            RefDocumentCode = obj.RefDocumentCode;
            RefTransactionDate = obj.RefTransactionDate;
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
            IsCollectedByHeadOffice = obj.IsCollectedByHeadOffice;
            CollectedBySiteID = obj.CollectedBySiteID;
            CollectedBySiteCode = obj.CollectedBySiteCode;
            CollectedBySiteName = obj.CollectedBySiteName;
            CollectedBySite = obj.CollectedBySite;
            CollectedByCompanyID = obj.CollectedByCompanyID;
            CollectedByCompanyCode = obj.CollectedByCompanyCode;
            CollectedByCompanyName = obj.CollectedByCompanyName;
            CollectedByCompany = obj.CollectedByCompany;
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
            CollectedBySiteDistributionTypeID = obj.CollectedBySiteDistributionTypeID;
            CollectedBySiteDistributionTypeName = obj.CollectedBySiteDistributionTypeName;
            IsCollectedBySiteProductLotCodeEntryRequired = obj.IsCollectedBySiteProductLotCodeEntryRequired;
            CollectorID = obj.CollectorID;
            CollectorCode = obj.CollectorCode;
            CollectorName = obj.CollectorName;
            Collector = obj.Collector;
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
            RefPrintCount = obj.RefPrintCount;
            RefLastPrintedDate = obj.RefLastPrintedDate;
            RefDocumentStatusID = obj.RefDocumentStatusID;
            RefDocumentStatusName = obj.RefDocumentStatusName;
            RefDocumentStatusReason = obj.RefDocumentStatusReason;
            RefMobileDocumentCode = obj.RefMobileDocumentCode;
            RefPostedDate = obj.RefPostedDate;
            RefTransactionTypeID = obj.RefTransactionTypeID;
            RefTransactionTypeName = obj.RefTransactionTypeName;
            DueDate = obj.DueDate;
            BARSDocumentID = obj.BARSDocumentID;
            BARSDocumentCode = obj.BARSDocumentCode;
            BARSTransactionDate = obj.BARSTransactionDate;
            OpnameDocumentID = obj.OpnameDocumentID;
            OpnameDocumentCode = obj.OpnameDocumentCode;
            OpnameTransactionDate = obj.OpnameTransactionDate;
            PrintCount = obj.PrintCount;
            LastPrintedDate = obj.LastPrintedDate;
            DocumentStatusID = obj.DocumentStatusID;
            DocumentStatusName = obj.DocumentStatusName;
            PostedDate = obj.PostedDate;
            ARRawTotalAmount = obj.ARRawTotalAmount;
            ARRawPaidAmount = obj.ARRawPaidAmount;
            ARRawOutstandingAmount = obj.ARRawOutstandingAmount;
            ARTotalAmount = obj.ARTotalAmount;
            ARPaidAmount = obj.ARPaidAmount;
            AROutstandingAmount = obj.AROutstandingAmount;
            ARPendingPaymentAmount = obj.ARPendingPaymentAmount;
            ARPendingOutstandingAmount = obj.ARPendingOutstandingAmount;
            ARStatusID = obj.ARStatusID;
            ARStatusName = obj.ARStatusName;
            ARSettledDate = obj.ARSettledDate;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
            CreatedByUserName = obj.CreatedByUserName;
            ModifiedDate = obj.ModifiedDate;
            ModifiedByUserID = obj.ModifiedByUserID;
            ModifiedByUserName = obj.ModifiedByUserName;
            RoutePlanWeek1 = obj.RoutePlanWeek1;
            RoutePlanWeek2 = obj.RoutePlanWeek2;
            RoutePlanWeek3 = obj.RoutePlanWeek3;
            RoutePlanWeek4 = obj.RoutePlanWeek4;
            RoutePlanDay1 = obj.RoutePlanDay1;
            RoutePlanDay2 = obj.RoutePlanDay2;
            RoutePlanDay3 = obj.RoutePlanDay3;
            RoutePlanDay4 = obj.RoutePlanDay4;
            RoutePlanDay5 = obj.RoutePlanDay5;
            RoutePlanDay6 = obj.RoutePlanDay6;
            RoutePlanDay7 = obj.RoutePlanDay7;
        }
        
        #endregion

    }

}
