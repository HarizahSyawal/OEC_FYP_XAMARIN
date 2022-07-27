﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:44
// Description   : ICashDepositReceiptSummary partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'ICashDepositReceiptSummary.cs'
//       up to one level of this file location inside 'CashDepositReceiptSummary' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface ICashDepositReceiptSummary
    {                
        
        #region Properties
        
        System.Guid DocumentID { get; set; }
        System.Guid CollectorID { get; set; }
        double RawSubtotalCashSalesAmount { get; set; }
        double RawSubtotalCashInBARSAmount { get; set; }
        double RawSubtotalCashOutBARSAmount { get; set; }
        double RawSubtotalBalanceSalesAmount { get; set; }
        double RawSubtotalBalanceInBARSAmount { get; set; }
        double RawSubtotalBalanceOutBARSAmount { get; set; }
        double SubtotalCashSalesAmount { get; set; }
        double SubtotalCashInBARSAmount { get; set; }
        double SubtotalCashOutBARSAmount { get; set; }
        double SubtotalBalanceSalesAmount { get; set; }
        double SubtotalBalanceInBARSAmount { get; set; }
        double SubtotalBalanceOutBARSAmount { get; set; }
        int BanknoteValue1Count { get; set; }
        double BanknoteValue1Amount { get; set; }
        int BanknoteValue2Count { get; set; }
        double BanknoteValue2Amount { get; set; }
        int BanknoteValue3Count { get; set; }
        double BanknoteValue3Amount { get; set; }
        int BanknoteValue4Count { get; set; }
        double BanknoteValue4Amount { get; set; }
        int BanknoteValue5Count { get; set; }
        double BanknoteValue5Amount { get; set; }
        int BanknoteValue6Count { get; set; }
        double BanknoteValue6Amount { get; set; }
        int BanknoteValue7Count { get; set; }
        double BanknoteValue7Amount { get; set; }
        int BanknoteValue8Count { get; set; }
        double BanknoteValue8Amount { get; set; }
        int BanknoteValue9Count { get; set; }
        double BanknoteValue9Amount { get; set; }
        int BanknoteValue10Count { get; set; }
        double BanknoteValue10Amount { get; set; }
        int BanknoteValue11Count { get; set; }
        double BanknoteValue11Amount { get; set; }
        int BanknoteValue12Count { get; set; }
        double BanknoteValue12Amount { get; set; }
        int BanknoteValue13Count { get; set; }
        double BanknoteValue13Amount { get; set; }
        int BanknoteValue14Count { get; set; }
        double BanknoteValue14Amount { get; set; }
        int BanknoteValue15Count { get; set; }
        double BanknoteValue15Amount { get; set; }
        int CoinValue1Count { get; set; }
        double CoinValue1Amount { get; set; }
        int CoinValue2Count { get; set; }
        double CoinValue2Amount { get; set; }
        int CoinValue3Count { get; set; }
        double CoinValue3Amount { get; set; }
        int CoinValue4Count { get; set; }
        double CoinValue4Amount { get; set; }
        int CoinValue5Count { get; set; }
        double CoinValue5Amount { get; set; }
        int CoinValue6Count { get; set; }
        double CoinValue6Amount { get; set; }
        int CoinValue7Count { get; set; }
        double CoinValue7Amount { get; set; }
        int CoinValue8Count { get; set; }
        double CoinValue8Amount { get; set; }
        int CoinValue9Count { get; set; }
        double CoinValue9Amount { get; set; }
        int CoinValue10Count { get; set; }
        double CoinValue10Amount { get; set; }
        int CoinValue11Count { get; set; }
        double CoinValue11Amount { get; set; }
        int CoinValue12Count { get; set; }
        double CoinValue12Amount { get; set; }
        int CoinValue13Count { get; set; }
        double CoinValue13Amount { get; set; }
        int CoinValue14Count { get; set; }
        double CoinValue14Amount { get; set; }
        int CoinValue15Count { get; set; }
        double CoinValue15Amount { get; set; }
        int SubtotalBankTransferCount { get; set; }
        double SubtotalBankTransferAmount { get; set; }
        int SubtotalGiroCount { get; set; }
        double SubtotalGiroAmount { get; set; }
        int SubtotalVirtualAccountCount { get; set; }
        double SubtotalVirtualAccountAmount { get; set; }
        int SubtotalMobilePaymentCount { get; set; }
        double SubtotalMobilePaymentAmount { get; set; }
        double RawSubtotalCashAmount { get; set; }
        double RawSubtotalBalanceAmount { get; set; }
        double SubtotalCashAmount { get; set; }
        double SubtotalBalanceAmount { get; set; }
        double SubtotalAmount { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(ICashDepositReceiptSummary obj);
        
        #endregion

    }

}
