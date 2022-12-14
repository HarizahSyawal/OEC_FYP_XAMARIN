// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:14
// Description   : vPaymentReconciliationPopup partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vPaymentReconciliationPopup.cs'
//       up to one level of this file location inside 'vPaymentReconciliationPopup' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vPaymentReconciliationPopup : BaseEntityType, IvPaymentReconciliationPopup
    {                
        
        #region Implements IvPaymentReconciliationPopup

        public System.Guid DocumentID { get; set; }
        public string DocumentCode { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public System.Guid PCDocumentID { get; set; }
        public string PCDocumentCode { get; set; }
        public System.DateTime PCTransactionDate { get; set; }
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
        public string PCCurrencyID { get; set; }
        public string PCCurrencyName { get; set; }
        public double PCAmount { get; set; }
        public bool IsUsePartialBalance { get; set; }
        public double PartialBalanceAmount { get; set; }
        public double? PCAdditionalCost1Amount { get; set; }
        public double? PCAdditionalCost2Amount { get; set; }
        public double? PCAdditionalCost3Amount { get; set; }
        public double? PCAdditionalCost4Amount { get; set; }
        public double? PCAdditionalCost5Amount { get; set; }
        public double? PCAdditionalCost6Amount { get; set; }
        public double? PCAdditionalCost7Amount { get; set; }
        public double? PCAdditionalCost8Amount { get; set; }
        public double? PCAdditionalCost9Amount { get; set; }
        public double? PCAdditionalCost10Amount { get; set; }
        public double PCTotalAmount { get; set; }
        public double PCTotalAllocationAmount { get; set; }
        public double? PCTotalDiffAmount { get; set; }
        public double PCTotalAdditionalCostAmount { get; set; }
        public double PCTotalAdditionalCostAllocationAmount { get; set; }
        public double? PCTotalDiffAdditionalCostAmount { get; set; }
        public string PCReferenceNumber { get; set; }
        public System.Guid? BankStatementTransactionID { get; set; }
        public System.Guid? BankStatementID { get; set; }
        public string BankStatementCode { get; set; }
        public string BankStatement { get; set; }
        public System.DateTime? BankStatementClearingDate { get; set; }
        public double? BankStatementAmount { get; set; }
        public double? BankStatementTransactionAmount { get; set; }
        public double? BankStatementAvailableAmount { get; set; }
        public double? BankStatementReservedAmount { get; set; }
        public double RawTotalAmount { get; set; }
        public double RawTotalAllocationAmount { get; set; }
        public double? RawTotalDiffAmount { get; set; }
        public double TotalAmount { get; set; }
        public double TotalAllocationAmount { get; set; }
        public double? TotalDiffAmount { get; set; }
        public double DepositAmount { get; set; }
        public System.Guid? CDRDocumentID { get; set; }
        public string CDRDocumentCode { get; set; }
        public System.DateTime? CDRTransactionDate { get; set; }
        public int DocumentStatusID { get; set; }
        public string DocumentStatusName { get; set; }
        public System.DateTime? PostedDate { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int? CreatedByUserID { get; set; }
        public string CreatedByUserName { get; set; }
        public System.DateTime? ModifiedDate { get; set; }
        public int? ModifiedByUserID { get; set; }
        public string ModifiedByUserName { get; set; }
        
        
        
        public void CopyFrom(IvPaymentReconciliationPopup obj)
        {
            DocumentID = obj.DocumentID;
            DocumentCode = obj.DocumentCode;
            TransactionDate = obj.TransactionDate;
            PCDocumentID = obj.PCDocumentID;
            PCDocumentCode = obj.PCDocumentCode;
            PCTransactionDate = obj.PCTransactionDate;
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
            PCCurrencyID = obj.PCCurrencyID;
            PCCurrencyName = obj.PCCurrencyName;
            PCAmount = obj.PCAmount;
            IsUsePartialBalance = obj.IsUsePartialBalance;
            PartialBalanceAmount = obj.PartialBalanceAmount;
            PCAdditionalCost1Amount = obj.PCAdditionalCost1Amount;
            PCAdditionalCost2Amount = obj.PCAdditionalCost2Amount;
            PCAdditionalCost3Amount = obj.PCAdditionalCost3Amount;
            PCAdditionalCost4Amount = obj.PCAdditionalCost4Amount;
            PCAdditionalCost5Amount = obj.PCAdditionalCost5Amount;
            PCAdditionalCost6Amount = obj.PCAdditionalCost6Amount;
            PCAdditionalCost7Amount = obj.PCAdditionalCost7Amount;
            PCAdditionalCost8Amount = obj.PCAdditionalCost8Amount;
            PCAdditionalCost9Amount = obj.PCAdditionalCost9Amount;
            PCAdditionalCost10Amount = obj.PCAdditionalCost10Amount;
            PCTotalAmount = obj.PCTotalAmount;
            PCTotalAllocationAmount = obj.PCTotalAllocationAmount;
            PCTotalDiffAmount = obj.PCTotalDiffAmount;
            PCTotalAdditionalCostAmount = obj.PCTotalAdditionalCostAmount;
            PCTotalAdditionalCostAllocationAmount = obj.PCTotalAdditionalCostAllocationAmount;
            PCTotalDiffAdditionalCostAmount = obj.PCTotalDiffAdditionalCostAmount;
            PCReferenceNumber = obj.PCReferenceNumber;
            BankStatementTransactionID = obj.BankStatementTransactionID;
            BankStatementID = obj.BankStatementID;
            BankStatementCode = obj.BankStatementCode;
            BankStatement = obj.BankStatement;
            BankStatementClearingDate = obj.BankStatementClearingDate;
            BankStatementAmount = obj.BankStatementAmount;
            BankStatementTransactionAmount = obj.BankStatementTransactionAmount;
            BankStatementAvailableAmount = obj.BankStatementAvailableAmount;
            BankStatementReservedAmount = obj.BankStatementReservedAmount;
            RawTotalAmount = obj.RawTotalAmount;
            RawTotalAllocationAmount = obj.RawTotalAllocationAmount;
            RawTotalDiffAmount = obj.RawTotalDiffAmount;
            TotalAmount = obj.TotalAmount;
            TotalAllocationAmount = obj.TotalAllocationAmount;
            TotalDiffAmount = obj.TotalDiffAmount;
            DepositAmount = obj.DepositAmount;
            CDRDocumentID = obj.CDRDocumentID;
            CDRDocumentCode = obj.CDRDocumentCode;
            CDRTransactionDate = obj.CDRTransactionDate;
            DocumentStatusID = obj.DocumentStatusID;
            DocumentStatusName = obj.DocumentStatusName;
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
