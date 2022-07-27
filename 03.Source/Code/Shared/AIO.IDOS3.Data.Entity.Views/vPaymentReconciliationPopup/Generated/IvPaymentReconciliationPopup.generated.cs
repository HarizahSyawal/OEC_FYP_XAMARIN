﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:14
// Description   : IvPaymentReconciliationPopup partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IvPaymentReconciliationPopup.cs'
//       up to one level of this file location inside 'vPaymentReconciliationPopup' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IvPaymentReconciliationPopup
    {                
        
        #region Properties
        
        System.Guid DocumentID { get; set; }
        string DocumentCode { get; set; }
        System.DateTime TransactionDate { get; set; }
        System.Guid PCDocumentID { get; set; }
        string PCDocumentCode { get; set; }
        System.DateTime PCTransactionDate { get; set; }
        bool? IsPaidByCustomer { get; set; }
        System.Guid? PaidByCustomerBillGroupID { get; set; }
        string PaidByCustomerBillGroup { get; set; }
        System.Guid? PaidByCustomerID { get; set; }
        string PaidByCustomer { get; set; }
        System.Guid? CollectorID { get; set; }
        string Collector { get; set; }
        bool IsCollectedByHeadOffice { get; set; }
        System.Guid? CollectedBySiteID { get; set; }
        string CollectedBySite { get; set; }
        int? CollectedByAreaID { get; set; }
        string CollectedByArea { get; set; }
        int? CollectedByRegionID { get; set; }
        string CollectedByRegion { get; set; }
        int? CollectedByTerritoryID { get; set; }
        string CollectedByTerritory { get; set; }
        int? CollectedByCompanyID { get; set; }
        string CollectedByCompany { get; set; }
        bool IsCash { get; set; }
        bool IsBalance { get; set; }
        int? MultiPaymentID { get; set; }
        string MultiPaymentCode { get; set; }
        string MultiPaymentName { get; set; }
        string MultiPayment { get; set; }
        int? MultiPaymentTypeID { get; set; }
        string MultiPaymentTypeName { get; set; }
        string BankTransferTransactionCode { get; set; }
        string BankTransferProofOfTransferPhoto { get; set; }
        System.Guid? GiroID { get; set; }
        string Giro { get; set; }
        string VirtualAccountCode { get; set; }
        string MobilePaymentTransactionCode { get; set; }
        string PCCurrencyID { get; set; }
        string PCCurrencyName { get; set; }
        double PCAmount { get; set; }
        bool IsUsePartialBalance { get; set; }
        double PartialBalanceAmount { get; set; }
        double? PCAdditionalCost1Amount { get; set; }
        double? PCAdditionalCost2Amount { get; set; }
        double? PCAdditionalCost3Amount { get; set; }
        double? PCAdditionalCost4Amount { get; set; }
        double? PCAdditionalCost5Amount { get; set; }
        double? PCAdditionalCost6Amount { get; set; }
        double? PCAdditionalCost7Amount { get; set; }
        double? PCAdditionalCost8Amount { get; set; }
        double? PCAdditionalCost9Amount { get; set; }
        double? PCAdditionalCost10Amount { get; set; }
        double PCTotalAmount { get; set; }
        double PCTotalAllocationAmount { get; set; }
        double? PCTotalDiffAmount { get; set; }
        double PCTotalAdditionalCostAmount { get; set; }
        double PCTotalAdditionalCostAllocationAmount { get; set; }
        double? PCTotalDiffAdditionalCostAmount { get; set; }
        string PCReferenceNumber { get; set; }
        System.Guid? BankStatementTransactionID { get; set; }
        System.Guid? BankStatementID { get; set; }
        string BankStatementCode { get; set; }
        string BankStatement { get; set; }
        System.DateTime? BankStatementClearingDate { get; set; }
        double? BankStatementAmount { get; set; }
        double? BankStatementTransactionAmount { get; set; }
        double? BankStatementAvailableAmount { get; set; }
        double? BankStatementReservedAmount { get; set; }
        double RawTotalAmount { get; set; }
        double RawTotalAllocationAmount { get; set; }
        double? RawTotalDiffAmount { get; set; }
        double TotalAmount { get; set; }
        double TotalAllocationAmount { get; set; }
        double? TotalDiffAmount { get; set; }
        double DepositAmount { get; set; }
        System.Guid? CDRDocumentID { get; set; }
        string CDRDocumentCode { get; set; }
        System.DateTime? CDRTransactionDate { get; set; }
        int DocumentStatusID { get; set; }
        string DocumentStatusName { get; set; }
        System.DateTime? PostedDate { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        string CreatedByUserName { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }
        string ModifiedByUserName { get; set; }

        #endregion

        #region Methods
        
        void CopyFrom(IvPaymentReconciliationPopup obj);
        
        #endregion
        
    }

}
