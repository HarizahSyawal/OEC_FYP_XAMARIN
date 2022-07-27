﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:08
// Description   : vInvoicePopup partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vInvoicePopup.cs'
//       up to one level of this file location inside 'vInvoicePopup' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vInvoicePopup : BaseEntityType, IvInvoicePopup
    {                
        
        #region Implements IvInvoicePopup

        public System.Guid DocumentID { get; set; }
        public string DocumentCode { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public System.Guid RefDocumentID { get; set; }
        public string RefDocumentCode { get; set; }
        public System.DateTime RefTransactionDate { get; set; }
        public System.Guid SalesmanID { get; set; }
        public string Salesman { get; set; }
        public System.Guid WarehouseID { get; set; }
        public string Warehouse { get; set; }
        public System.Guid? SiteID { get; set; }
        public string Site { get; set; }
        public int AreaID { get; set; }
        public string Area { get; set; }
        public int? RegionID { get; set; }
        public string Region { get; set; }
        public int? TerritoryID { get; set; }
        public string Territory { get; set; }
        public int CompanyID { get; set; }
        public string Company { get; set; }
        public int WarehouseTypeID { get; set; }
        public string WarehouseTypeName { get; set; }
        public System.Guid CustomerID { get; set; }
        public string Customer { get; set; }
        public System.Guid? CustomerBillGroupID { get; set; }
        public string CustomerBillGroup { get; set; }
        public System.Guid? CollectorID { get; set; }
        public string Collector { get; set; }
        public bool IsCollectedByHeadOffice { get; set; }
        public System.Guid? CollectedBySiteID { get; set; }
        public string CollectedBySite { get; set; }
        public int? CollectedByAreaID { get; set; }
        public string CollectedByArea { get; set; }
        public int? CollectedByRegionID { get; set; }
        public string CollectedByRegion { get; set; }
        public int? CollectedByTerritoryID { get; set; }
        public string CollectedByTerritory { get; set; }
        public int? CollectedByCompanyID { get; set; }
        public string CollectedByCompany { get; set; }
        public int TermOfPaymentID { get; set; }
        public string TermOfPaymentName { get; set; }
        public string ReferenceNumber { get; set; }
        public System.Guid DODocumentID { get; set; }
        public string DODocumentCode { get; set; }
        public System.DateTime DOTransactionDate { get; set; }
        public System.DateTime? DOShipmentDate { get; set; }
        public System.DateTime? DODeliveredDate { get; set; }
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
        public int RefTransactionTypeID { get; set; }
        public string RefTransactionTypeName { get; set; }
        public System.DateTime? DueDate { get; set; }
        public System.Guid? BARSDocumentID { get; set; }
        public string BARSDocumentCode { get; set; }
        public System.DateTime? BARSTransactionDate { get; set; }
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
        
        
        
        public void CopyFrom(IvInvoicePopup obj)
        {
            DocumentID = obj.DocumentID;
            DocumentCode = obj.DocumentCode;
            TransactionDate = obj.TransactionDate;
            RefDocumentID = obj.RefDocumentID;
            RefDocumentCode = obj.RefDocumentCode;
            RefTransactionDate = obj.RefTransactionDate;
            SalesmanID = obj.SalesmanID;
            Salesman = obj.Salesman;
            WarehouseID = obj.WarehouseID;
            Warehouse = obj.Warehouse;
            SiteID = obj.SiteID;
            Site = obj.Site;
            AreaID = obj.AreaID;
            Area = obj.Area;
            RegionID = obj.RegionID;
            Region = obj.Region;
            TerritoryID = obj.TerritoryID;
            Territory = obj.Territory;
            CompanyID = obj.CompanyID;
            Company = obj.Company;
            WarehouseTypeID = obj.WarehouseTypeID;
            WarehouseTypeName = obj.WarehouseTypeName;
            CustomerID = obj.CustomerID;
            Customer = obj.Customer;
            CustomerBillGroupID = obj.CustomerBillGroupID;
            CustomerBillGroup = obj.CustomerBillGroup;
            CollectorID = obj.CollectorID;
            Collector = obj.Collector;
            IsCollectedByHeadOffice = obj.IsCollectedByHeadOffice;
            CollectedBySiteID = obj.CollectedBySiteID;
            CollectedBySite = obj.CollectedBySite;
            CollectedByAreaID = obj.CollectedByAreaID;
            CollectedByArea = obj.CollectedByArea;
            CollectedByRegionID = obj.CollectedByRegionID;
            CollectedByRegion = obj.CollectedByRegion;
            CollectedByTerritoryID = obj.CollectedByTerritoryID;
            CollectedByTerritory = obj.CollectedByTerritory;
            CollectedByCompanyID = obj.CollectedByCompanyID;
            CollectedByCompany = obj.CollectedByCompany;
            TermOfPaymentID = obj.TermOfPaymentID;
            TermOfPaymentName = obj.TermOfPaymentName;
            ReferenceNumber = obj.ReferenceNumber;
            DODocumentID = obj.DODocumentID;
            DODocumentCode = obj.DODocumentCode;
            DOTransactionDate = obj.DOTransactionDate;
            DOShipmentDate = obj.DOShipmentDate;
            DODeliveredDate = obj.DODeliveredDate;
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
            RefTransactionTypeID = obj.RefTransactionTypeID;
            RefTransactionTypeName = obj.RefTransactionTypeName;
            DueDate = obj.DueDate;
            BARSDocumentID = obj.BARSDocumentID;
            BARSDocumentCode = obj.BARSDocumentCode;
            BARSTransactionDate = obj.BARSTransactionDate;
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
        }
        
        #endregion

    }

}
