﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:44
// Description   : CashDepositToBank partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'CashDepositToBank.cs'
//       up to one level of this file location inside 'CashDepositToBank' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class CashDepositToBank : ICashDepositToBank
    {                
        
        #region Implements ICashDepositToBank

        public System.Guid DocumentID { get; set; }            
        public string DocumentCode { get; set; }            
        public System.DateTime TransactionDate { get; set; }            
        public bool IsCollectedByHeadOffice { get; set; }            
        public System.Guid? CollectedBySiteID { get; set; }            
        public double RawTotalCollectedAmount { get; set; }            
        public double TotalCollectedAmount { get; set; }            
        public double TotalDepositAmount { get; set; }            
        public int IncomingBankAccountID { get; set; }            
        public System.Guid? BankStatementTransaction1ID { get; set; }            
        public System.Guid? BankStatementTransaction2ID { get; set; }            
        public System.Guid? BankStatementTransaction3ID { get; set; }            
        public System.Guid? BankStatementTransaction4ID { get; set; }            
        public System.Guid? BankStatementTransaction5ID { get; set; }            
        public int PrintCount { get; set; }            
        public System.DateTime? LastPrintedDate { get; set; }            
        public int DocumentStatusID { get; set; }            
        public System.DateTime? PostedDate { get; set; }            
        public System.DateTime CreatedDate { get; set; }            
        public int? CreatedByUserID { get; set; }            
        public System.DateTime? ModifiedDate { get; set; }            
        public int? ModifiedByUserID { get; set; }            

        
        
        public void CopyFrom(ICashDepositToBank obj)
        {
            DocumentID = obj.DocumentID;
            DocumentCode = obj.DocumentCode;
            TransactionDate = obj.TransactionDate;
            IsCollectedByHeadOffice = obj.IsCollectedByHeadOffice;
            CollectedBySiteID = obj.CollectedBySiteID;
            RawTotalCollectedAmount = obj.RawTotalCollectedAmount;
            TotalCollectedAmount = obj.TotalCollectedAmount;
            TotalDepositAmount = obj.TotalDepositAmount;
            IncomingBankAccountID = obj.IncomingBankAccountID;
            BankStatementTransaction1ID = obj.BankStatementTransaction1ID;
            BankStatementTransaction2ID = obj.BankStatementTransaction2ID;
            BankStatementTransaction3ID = obj.BankStatementTransaction3ID;
            BankStatementTransaction4ID = obj.BankStatementTransaction4ID;
            BankStatementTransaction5ID = obj.BankStatementTransaction5ID;
            PrintCount = obj.PrintCount;
            LastPrintedDate = obj.LastPrintedDate;
            DocumentStatusID = obj.DocumentStatusID;
            PostedDate = obj.PostedDate;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
            ModifiedDate = obj.ModifiedDate;
            ModifiedByUserID = obj.ModifiedByUserID;
        }
        
        #endregion
        
    }

}