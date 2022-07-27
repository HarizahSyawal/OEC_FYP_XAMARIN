﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:52
// Description   : IPaymentCollection partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IPaymentCollection.cs'
//       up to one level of this file location inside 'PaymentCollection' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IPaymentCollection
    {                
        
        #region Properties
        
        System.Guid DocumentID { get; set; }
        string DocumentCode { get; set; }
        System.DateTime TransactionDate { get; set; }
        System.Guid? PaidByCustomerBillGroupID { get; set; }
        System.Guid? PaidByCustomerID { get; set; }
        bool IsCash { get; set; }
        bool IsBalance { get; set; }
        int? MultiPaymentID { get; set; }
        string BankTransferTransactionCode { get; set; }
        string BankTransferProofOfTransferPhoto { get; set; }
        System.Guid? GiroID { get; set; }
        string VirtualAccountCode { get; set; }
        string MobilePaymentTransactionCode { get; set; }
        string CurrencyID { get; set; }
        double OriginAmount { get; set; }
        double RawAmount { get; set; }
        double Amount { get; set; }
        bool IsUsePartialBalance { get; set; }
        double PartialBalanceAmount { get; set; }
        double AvailableBalanceAmount { get; set; }
        double RawTotalAmount { get; set; }
        double RawTotalAllocationAmount { get; set; }
        double RawTotalAdditionalCostAllocationAmount { get; set; }
        double TotalAmount { get; set; }
        double TotalAllocationAmount { get; set; }
        double TotalAdditionalCostAmount { get; set; }
        double TotalAdditionalCostAllocationAmount { get; set; }
        string ReferenceNumber { get; set; }
        System.Guid? PRDocumentID { get; set; }
        int PrintCount { get; set; }
        System.DateTime? LastPrintedDate { get; set; }
        int DocumentStatusID { get; set; }
        string MobileDocumentCode { get; set; }
        System.DateTime? PostedDate { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(IPaymentCollection obj);
        
        #endregion

    }

}
