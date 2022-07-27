﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:35:46
// Description   : vCashDepositToBankDetails partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vCashDepositToBankDetails.cs'
//       up to one level of this file location inside 'vCashDepositToBankDetails' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vCashDepositToBankDetails : BaseEntityType, IvCashDepositToBankDetails
    {                
        
        #region Implements IvCashDepositToBankDetails

        public System.Guid DocumentID { get; set; }
        public System.Guid CDRDocumentID { get; set; }
        public string CDRDocumentCode { get; set; }
        public System.DateTime CDRTransactionDate { get; set; }
        public double CDRRawTotalCashSalesAmount { get; set; }
        public double CDRRawTotalCashInBARSAmount { get; set; }
        public double CDRRawTotalCashOutBARSAmount { get; set; }
        public double CDRRawTotalBalanceSalesAmount { get; set; }
        public double CDRRawTotalBalanceInBARSAmount { get; set; }
        public double CDRRawTotalBalanceOutBARSAmount { get; set; }
        public double CDRTotalCashSalesAmount { get; set; }
        public double CDRTotalCashInBARSAmount { get; set; }
        public double CDRTotalCashOutBARSAmount { get; set; }
        public double CDRRawTotalCashAmount { get; set; }
        public double CDRRawTotalBalanceAmount { get; set; }
        public double CDRRawTotalDiffAmount { get; set; }
        public double CDRTotalCashAmount { get; set; }
        public double CDRTotalBalanceAmount { get; set; }
        public double CDRTotalAmount { get; set; }
        public double CDRTotalDiffAmount { get; set; }
        public double RawCollectedAmount { get; set; }
        public double? RawDiffAmount { get; set; }
        public double CollectedAmount { get; set; }
        public double DepositAmount { get; set; }
        public double? DiffAmount { get; set; }
        
        
        
        public void CopyFrom(IvCashDepositToBankDetails obj)
        {
            DocumentID = obj.DocumentID;
            CDRDocumentID = obj.CDRDocumentID;
            CDRDocumentCode = obj.CDRDocumentCode;
            CDRTransactionDate = obj.CDRTransactionDate;
            CDRRawTotalCashSalesAmount = obj.CDRRawTotalCashSalesAmount;
            CDRRawTotalCashInBARSAmount = obj.CDRRawTotalCashInBARSAmount;
            CDRRawTotalCashOutBARSAmount = obj.CDRRawTotalCashOutBARSAmount;
            CDRRawTotalBalanceSalesAmount = obj.CDRRawTotalBalanceSalesAmount;
            CDRRawTotalBalanceInBARSAmount = obj.CDRRawTotalBalanceInBARSAmount;
            CDRRawTotalBalanceOutBARSAmount = obj.CDRRawTotalBalanceOutBARSAmount;
            CDRTotalCashSalesAmount = obj.CDRTotalCashSalesAmount;
            CDRTotalCashInBARSAmount = obj.CDRTotalCashInBARSAmount;
            CDRTotalCashOutBARSAmount = obj.CDRTotalCashOutBARSAmount;
            CDRRawTotalCashAmount = obj.CDRRawTotalCashAmount;
            CDRRawTotalBalanceAmount = obj.CDRRawTotalBalanceAmount;
            CDRRawTotalDiffAmount = obj.CDRRawTotalDiffAmount;
            CDRTotalCashAmount = obj.CDRTotalCashAmount;
            CDRTotalBalanceAmount = obj.CDRTotalBalanceAmount;
            CDRTotalAmount = obj.CDRTotalAmount;
            CDRTotalDiffAmount = obj.CDRTotalDiffAmount;
            RawCollectedAmount = obj.RawCollectedAmount;
            RawDiffAmount = obj.RawDiffAmount;
            CollectedAmount = obj.CollectedAmount;
            DepositAmount = obj.DepositAmount;
            DiffAmount = obj.DiffAmount;
        }
        
        #endregion

    }

}
