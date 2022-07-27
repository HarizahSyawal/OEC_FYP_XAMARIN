﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:12
// Description   : vPaymentCollectionPopup partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vPaymentCollectionPopup.cs'
//       up to one level of this file location inside 'vPaymentCollectionPopup' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vPaymentCollectionPopup : BaseEntityType, IvPaymentCollectionPopup
    {                
        
        #region Implements IvPaymentCollectionPopup

        public System.Guid DocumentID { get; set; }
        public string DocumentCode { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public bool? IsPaidByCustomer { get; set; }
        public System.Guid? PaidByCustomerBillGroupID { get; set; }
        public string PaidByCustomerBillGroup { get; set; }
        public System.Guid? PaidByCustomerID { get; set; }
        public string PaidByCustomer { get; set; }
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
        public bool IsCash { get; set; }
        public bool IsBalance { get; set; }
        public int? MultiPaymentID { get; set; }
        public string MultiPaymentCode { get; set; }
        public string MultiPaymentName { get; set; }
        public string MultiPayment { get; set; }
        public int? MultiPaymentTypeID { get; set; }
        public string MultiPaymentTypeName { get; set; }
        public string BankTransferTransactionCode { get; set; }
        public string BankTransferProofOfTransferPhoto { get; set; }
        public System.Guid? GiroID { get; set; }
        public string Giro { get; set; }
        public string VirtualAccountCode { get; set; }
        public string MobilePaymentTransactionCode { get; set; }
        public string CurrencyID { get; set; }
        public string CurrencyName { get; set; }
        public double OriginAmount { get; set; }
        public double RawAmount { get; set; }
        public double Amount { get; set; }
        public bool IsUsePartialBalance { get; set; }
        public double PartialBalanceAmount { get; set; }
        public double? AvailableBalanceAmount { get; set; }
        public double? AdditionalCost1Amount { get; set; }
        public double? AdditionalCost2Amount { get; set; }
        public double? AdditionalCost3Amount { get; set; }
        public double? AdditionalCost4Amount { get; set; }
        public double? AdditionalCost5Amount { get; set; }
        public double? AdditionalCost6Amount { get; set; }
        public double? AdditionalCost7Amount { get; set; }
        public double? AdditionalCost8Amount { get; set; }
        public double? AdditionalCost9Amount { get; set; }
        public double? AdditionalCost10Amount { get; set; }
        public double RawTotalAmount { get; set; }
        public double RawTotalAllocationAmount { get; set; }
        public double? RawTotalDiffAmount { get; set; }
        public double RawTotalAdditionalCostAllocationAmount { get; set; }
        public double? RawTotalDiffAdditionalCostAmount { get; set; }
        public double TotalAmount { get; set; }
        public double TotalAllocationAmount { get; set; }
        public double? TotalDiffAmount { get; set; }
        public double TotalAdditionalCostAmount { get; set; }
        public double TotalAdditionalCostAllocationAmount { get; set; }
        public double? TotalDiffAdditionalCostAmount { get; set; }
        public string ReferenceNumber { get; set; }
        public System.Guid? PRDocumentID { get; set; }
        public string PRDocumentCode { get; set; }
        public System.DateTime? PRTransactionDate { get; set; }
        public int PrintCount { get; set; }
        public System.DateTime? LastPrintedDate { get; set; }
        public int DocumentStatusID { get; set; }
        public string DocumentStatusName { get; set; }
        public string MobileDocumentCode { get; set; }
        public System.DateTime? PostedDate { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int? CreatedByUserID { get; set; }
        public string CreatedByUserName { get; set; }
        public System.DateTime? ModifiedDate { get; set; }
        public int? ModifiedByUserID { get; set; }
        public string ModifiedByUserName { get; set; }
        
        
        
        public void CopyFrom(IvPaymentCollectionPopup obj)
        {
            DocumentID = obj.DocumentID;
            DocumentCode = obj.DocumentCode;
            TransactionDate = obj.TransactionDate;
            IsPaidByCustomer = obj.IsPaidByCustomer;
            PaidByCustomerBillGroupID = obj.PaidByCustomerBillGroupID;
            PaidByCustomerBillGroup = obj.PaidByCustomerBillGroup;
            PaidByCustomerID = obj.PaidByCustomerID;
            PaidByCustomer = obj.PaidByCustomer;
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
            IsCash = obj.IsCash;
            IsBalance = obj.IsBalance;
            MultiPaymentID = obj.MultiPaymentID;
            MultiPaymentCode = obj.MultiPaymentCode;
            MultiPaymentName = obj.MultiPaymentName;
            MultiPayment = obj.MultiPayment;
            MultiPaymentTypeID = obj.MultiPaymentTypeID;
            MultiPaymentTypeName = obj.MultiPaymentTypeName;
            BankTransferTransactionCode = obj.BankTransferTransactionCode;
            BankTransferProofOfTransferPhoto = obj.BankTransferProofOfTransferPhoto;
            GiroID = obj.GiroID;
            Giro = obj.Giro;
            VirtualAccountCode = obj.VirtualAccountCode;
            MobilePaymentTransactionCode = obj.MobilePaymentTransactionCode;
            CurrencyID = obj.CurrencyID;
            CurrencyName = obj.CurrencyName;
            OriginAmount = obj.OriginAmount;
            RawAmount = obj.RawAmount;
            Amount = obj.Amount;
            IsUsePartialBalance = obj.IsUsePartialBalance;
            PartialBalanceAmount = obj.PartialBalanceAmount;
            AvailableBalanceAmount = obj.AvailableBalanceAmount;
            AdditionalCost1Amount = obj.AdditionalCost1Amount;
            AdditionalCost2Amount = obj.AdditionalCost2Amount;
            AdditionalCost3Amount = obj.AdditionalCost3Amount;
            AdditionalCost4Amount = obj.AdditionalCost4Amount;
            AdditionalCost5Amount = obj.AdditionalCost5Amount;
            AdditionalCost6Amount = obj.AdditionalCost6Amount;
            AdditionalCost7Amount = obj.AdditionalCost7Amount;
            AdditionalCost8Amount = obj.AdditionalCost8Amount;
            AdditionalCost9Amount = obj.AdditionalCost9Amount;
            AdditionalCost10Amount = obj.AdditionalCost10Amount;
            RawTotalAmount = obj.RawTotalAmount;
            RawTotalAllocationAmount = obj.RawTotalAllocationAmount;
            RawTotalDiffAmount = obj.RawTotalDiffAmount;
            RawTotalAdditionalCostAllocationAmount = obj.RawTotalAdditionalCostAllocationAmount;
            RawTotalDiffAdditionalCostAmount = obj.RawTotalDiffAdditionalCostAmount;
            TotalAmount = obj.TotalAmount;
            TotalAllocationAmount = obj.TotalAllocationAmount;
            TotalDiffAmount = obj.TotalDiffAmount;
            TotalAdditionalCostAmount = obj.TotalAdditionalCostAmount;
            TotalAdditionalCostAllocationAmount = obj.TotalAdditionalCostAllocationAmount;
            TotalDiffAdditionalCostAmount = obj.TotalDiffAdditionalCostAmount;
            ReferenceNumber = obj.ReferenceNumber;
            PRDocumentID = obj.PRDocumentID;
            PRDocumentCode = obj.PRDocumentCode;
            PRTransactionDate = obj.PRTransactionDate;
            PrintCount = obj.PrintCount;
            LastPrintedDate = obj.LastPrintedDate;
            DocumentStatusID = obj.DocumentStatusID;
            DocumentStatusName = obj.DocumentStatusName;
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