﻿// ===================================================================================
// Author        : System
// Created date  : 24 Sep 2020 03:21:59
// Description   : vSalesOrderFOC partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vSalesOrderFOC.cs'
//       up to one level of this file location inside 'vSalesOrderFOC' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vSalesOrderFOC : BaseEntityType, IvSalesOrderFOC
    {                
        
        #region Implements IvSalesOrderFOC

        public System.Guid DocumentID { get; set; }
        public string DocumentCode { get; set; }
        public System.Guid? PrevRevisionDocumentID { get; set; }
        public string PrevRevisionDocumentCode { get; set; }
        public int? RevisionNumber { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public System.Guid? PODocumentID { get; set; }
        public string PODocumentCode { get; set; }
        public System.DateTime? POTransactionDate { get; set; }
        public System.Guid SalesmanID { get; set; }
        public string SalesmanCode { get; set; }
        public string SalesmanName { get; set; }
        public string Salesman { get; set; }
        public System.Guid WarehouseID { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseName { get; set; }
        public string Warehouse { get; set; }
        public System.Guid? SiteID { get; set; }
        public string SiteCode { get; set; }
        public string SiteName { get; set; }
        public string Site { get; set; }
        public int AreaID { get; set; }
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
        public int CompanyID { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string Company { get; set; }
        public int SiteDistributionTypeID { get; set; }
        public string SiteDistributionTypeName { get; set; }
        public bool IsSiteProductLotCodeEntryRequired { get; set; }
        public int WarehouseTypeID { get; set; }
        public string WarehouseTypeName { get; set; }
        public System.Guid CustomerID { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string Customer { get; set; }
        public int PriceGroupID { get; set; }
        public string PriceGroupName { get; set; }
        public int DiscountGroupID { get; set; }
        public string DiscountGroupCode { get; set; }
        public string DiscountGroupName { get; set; }
        public string DiscountGroup { get; set; }
        public string DiscountGroupDescription { get; set; }
        public int TermOfPaymentID { get; set; }
        public string TermOfPaymentName { get; set; }
        public string ReferenceNumber { get; set; }
        public System.Guid DODocumentID { get; set; }
        public string DODocumentCode { get; set; }
        public System.DateTime DOTransactionDate { get; set; }
        public System.DateTime? DOShipmentDate { get; set; }
        public System.DateTime? DODeliveredDate { get; set; }
        public int DOPrintCount { get; set; }
        public System.DateTime? DOLastPrintedDate { get; set; }
        public System.Guid? InvoiceDocumentID { get; set; }
        public string InvoiceDocumentCode { get; set; }
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
        public string DocumentStatusName { get; set; }
        public string DocumentStatusReason { get; set; }
        public string MobileDocumentCode { get; set; }
        public System.DateTime? PostedDate { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int? CreatedByUserID { get; set; }
        public string CreatedByUserName { get; set; }
        public System.DateTime? ModifiedDate { get; set; }
        public int? ModifiedByUserID { get; set; }
        public string ModifiedByUserName { get; set; }
        
        
        
        public void CopyFrom(IvSalesOrderFOC obj)
        {
            DocumentID = obj.DocumentID;
            DocumentCode = obj.DocumentCode;
            PrevRevisionDocumentID = obj.PrevRevisionDocumentID;
            PrevRevisionDocumentCode = obj.PrevRevisionDocumentCode;
            RevisionNumber = obj.RevisionNumber;
            TransactionDate = obj.TransactionDate;
            PODocumentID = obj.PODocumentID;
            PODocumentCode = obj.PODocumentCode;
            POTransactionDate = obj.POTransactionDate;
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
            InvoiceDocumentID = obj.InvoiceDocumentID;
            InvoiceDocumentCode = obj.InvoiceDocumentCode;
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
            DocumentStatusName = obj.DocumentStatusName;
            DocumentStatusReason = obj.DocumentStatusReason;
            MobileDocumentCode = obj.MobileDocumentCode;
            PostedDate = obj.PostedDate;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
            CreatedByUserName = obj.CreatedByUserName;
            ModifiedDate = obj.ModifiedDate;
            ModifiedByUserID = obj.ModifiedByUserID;
            ModifiedByUserName = obj.ModifiedByUserName;
        }
        
        #endregion

    }

}
