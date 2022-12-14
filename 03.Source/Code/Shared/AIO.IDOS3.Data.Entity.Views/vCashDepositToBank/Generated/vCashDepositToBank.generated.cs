// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:35:46
// Description   : vCashDepositToBank partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vCashDepositToBank.cs'
//       up to one level of this file location inside 'vCashDepositToBank' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vCashDepositToBank : BaseEntityType, IvCashDepositToBank
    {                
        
        #region Implements IvCashDepositToBank

        public System.Guid DocumentID { get; set; }
        public string DocumentCode { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public bool IsCollectedByHeadOffice { get; set; }
        public System.Guid? CollectedBySiteID { get; set; }
        public string CollectedBySiteCode { get; set; }
        public string CollectedBySiteName { get; set; }
        public string CollectedBySite { get; set; }
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
        public int? CollectedByCompanyID { get; set; }
        public string CollectedByCompanyCode { get; set; }
        public string CollectedByCompanyName { get; set; }
        public string CollectedByCompany { get; set; }
        public int? CollectedBySiteDistributionTypeID { get; set; }
        public string CollectedBySiteDistributionTypeName { get; set; }
        public double RawTotalCollectedAmount { get; set; }
        public double? RawTotalDiffAmount { get; set; }
        public double TotalCollectedAmount { get; set; }
        public double TotalDepositAmount { get; set; }
        public double? TotalDiffAmount { get; set; }
        public int IncomingBankAccountID { get; set; }
        public string IncomingBankAccountCode { get; set; }
        public string IncomingBankAccountName { get; set; }
        public string IncomingBankAccount { get; set; }
        public int? IncomingBankID { get; set; }
        public string IncomingBankCode { get; set; }
        public string IncomingBankName { get; set; }
        public string IncomingBank { get; set; }
        public string IncomingBankShortName { get; set; }
        public System.Guid? BankStatementTransaction1ID { get; set; }
        public System.Guid? BankStatement1ID { get; set; }
        public string BankStatement1Code { get; set; }
        public string BankStatement1 { get; set; }
        public System.DateTime? BankStatement1ClearingDate { get; set; }
        public double? BankStatement1Amount { get; set; }
        public double? BankStatement1TransactionAmount { get; set; }
        public double? BankStatement1AvailableAmount { get; set; }
        public double? BankStatement1ReservedAmount { get; set; }
        public System.Guid? BankStatementTransaction2ID { get; set; }
        public System.Guid? BankStatement2ID { get; set; }
        public string BankStatement2Code { get; set; }
        public string BankStatement2 { get; set; }
        public System.DateTime? BankStatement2ClearingDate { get; set; }
        public double? BankStatement2Amount { get; set; }
        public double? BankStatement2TransactionAmount { get; set; }
        public double? BankStatement2AvailableAmount { get; set; }
        public double? BankStatement2ReservedAmount { get; set; }
        public System.Guid? BankStatementTransaction3ID { get; set; }
        public System.Guid? BankStatement3ID { get; set; }
        public string BankStatement3Code { get; set; }
        public string BankStatement3 { get; set; }
        public System.DateTime? BankStatement3ClearingDate { get; set; }
        public double? BankStatement3Amount { get; set; }
        public double? BankStatement3TransactionAmount { get; set; }
        public double? BankStatement3AvailableAmount { get; set; }
        public double? BankStatement3ReservedAmount { get; set; }
        public System.Guid? BankStatement4ID { get; set; }
        public string BankStatement4Code { get; set; }
        public string BankStatement4 { get; set; }
        public System.DateTime? BankStatement4ClearingDate { get; set; }
        public double? BankStatement4Amount { get; set; }
        public double? BankStatement4TransactionAmount { get; set; }
        public double? BankStatement4AvailableAmount { get; set; }
        public double? BankStatement4ReservedAmount { get; set; }
        public System.Guid? BankStatement5ID { get; set; }
        public string BankStatement5Code { get; set; }
        public string BankStatement5 { get; set; }
        public System.DateTime? BankStatement5ClearingDate { get; set; }
        public double? BankStatement5Amount { get; set; }
        public double? BankStatement5TransactionAmount { get; set; }
        public double? BankStatement5AvailableAmount { get; set; }
        public double? BankStatement5ReservedAmount { get; set; }
        public int PrintCount { get; set; }
        public System.DateTime? LastPrintedDate { get; set; }
        public int DocumentStatusID { get; set; }
        public string DocumentStatusName { get; set; }
        public System.DateTime? PostedDate { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int? CreatedByUserID { get; set; }
        public string CreatedByUserName { get; set; }
        public System.DateTime? ModifiedDate { get; set; }
        public int? ModifiedByUserID { get; set; }
        public string ModifiedByUserName { get; set; }
        
        
        
        public void CopyFrom(IvCashDepositToBank obj)
        {
            DocumentID = obj.DocumentID;
            DocumentCode = obj.DocumentCode;
            TransactionDate = obj.TransactionDate;
            IsCollectedByHeadOffice = obj.IsCollectedByHeadOffice;
            CollectedBySiteID = obj.CollectedBySiteID;
            CollectedBySiteCode = obj.CollectedBySiteCode;
            CollectedBySiteName = obj.CollectedBySiteName;
            CollectedBySite = obj.CollectedBySite;
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
            CollectedByCompanyID = obj.CollectedByCompanyID;
            CollectedByCompanyCode = obj.CollectedByCompanyCode;
            CollectedByCompanyName = obj.CollectedByCompanyName;
            CollectedByCompany = obj.CollectedByCompany;
            CollectedBySiteDistributionTypeID = obj.CollectedBySiteDistributionTypeID;
            CollectedBySiteDistributionTypeName = obj.CollectedBySiteDistributionTypeName;
            RawTotalCollectedAmount = obj.RawTotalCollectedAmount;
            RawTotalDiffAmount = obj.RawTotalDiffAmount;
            TotalCollectedAmount = obj.TotalCollectedAmount;
            TotalDepositAmount = obj.TotalDepositAmount;
            TotalDiffAmount = obj.TotalDiffAmount;
            IncomingBankAccountID = obj.IncomingBankAccountID;
            IncomingBankAccountCode = obj.IncomingBankAccountCode;
            IncomingBankAccountName = obj.IncomingBankAccountName;
            IncomingBankAccount = obj.IncomingBankAccount;
            IncomingBankID = obj.IncomingBankID;
            IncomingBankCode = obj.IncomingBankCode;
            IncomingBankName = obj.IncomingBankName;
            IncomingBank = obj.IncomingBank;
            IncomingBankShortName = obj.IncomingBankShortName;
            BankStatementTransaction1ID = obj.BankStatementTransaction1ID;
            BankStatement1ID = obj.BankStatement1ID;
            BankStatement1Code = obj.BankStatement1Code;
            BankStatement1 = obj.BankStatement1;
            BankStatement1ClearingDate = obj.BankStatement1ClearingDate;
            BankStatement1Amount = obj.BankStatement1Amount;
            BankStatement1TransactionAmount = obj.BankStatement1TransactionAmount;
            BankStatement1AvailableAmount = obj.BankStatement1AvailableAmount;
            BankStatement1ReservedAmount = obj.BankStatement1ReservedAmount;
            BankStatementTransaction2ID = obj.BankStatementTransaction2ID;
            BankStatement2ID = obj.BankStatement2ID;
            BankStatement2Code = obj.BankStatement2Code;
            BankStatement2 = obj.BankStatement2;
            BankStatement2ClearingDate = obj.BankStatement2ClearingDate;
            BankStatement2Amount = obj.BankStatement2Amount;
            BankStatement2TransactionAmount = obj.BankStatement2TransactionAmount;
            BankStatement2AvailableAmount = obj.BankStatement2AvailableAmount;
            BankStatement2ReservedAmount = obj.BankStatement2ReservedAmount;
            BankStatementTransaction3ID = obj.BankStatementTransaction3ID;
            BankStatement3ID = obj.BankStatement3ID;
            BankStatement3Code = obj.BankStatement3Code;
            BankStatement3 = obj.BankStatement3;
            BankStatement3ClearingDate = obj.BankStatement3ClearingDate;
            BankStatement3Amount = obj.BankStatement3Amount;
            BankStatement3TransactionAmount = obj.BankStatement3TransactionAmount;
            BankStatement3AvailableAmount = obj.BankStatement3AvailableAmount;
            BankStatement3ReservedAmount = obj.BankStatement3ReservedAmount;
            BankStatement4ID = obj.BankStatement4ID;
            BankStatement4Code = obj.BankStatement4Code;
            BankStatement4 = obj.BankStatement4;
            BankStatement4ClearingDate = obj.BankStatement4ClearingDate;
            BankStatement4Amount = obj.BankStatement4Amount;
            BankStatement4TransactionAmount = obj.BankStatement4TransactionAmount;
            BankStatement4AvailableAmount = obj.BankStatement4AvailableAmount;
            BankStatement4ReservedAmount = obj.BankStatement4ReservedAmount;
            BankStatement5ID = obj.BankStatement5ID;
            BankStatement5Code = obj.BankStatement5Code;
            BankStatement5 = obj.BankStatement5;
            BankStatement5ClearingDate = obj.BankStatement5ClearingDate;
            BankStatement5Amount = obj.BankStatement5Amount;
            BankStatement5TransactionAmount = obj.BankStatement5TransactionAmount;
            BankStatement5AvailableAmount = obj.BankStatement5AvailableAmount;
            BankStatement5ReservedAmount = obj.BankStatement5ReservedAmount;
            PrintCount = obj.PrintCount;
            LastPrintedDate = obj.LastPrintedDate;
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
