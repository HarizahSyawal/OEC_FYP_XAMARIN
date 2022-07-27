﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:10
// Description   : vOtherIncomeOutcome partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vOtherIncomeOutcome.cs'
//       up to one level of this file location inside 'vOtherIncomeOutcome' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vOtherIncomeOutcome : BaseEntityType, IvOtherIncomeOutcome
    {                
        
        #region Implements IvOtherIncomeOutcome

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
        public bool? IsIncome { get; set; }
        public System.Guid RefDocumentID { get; set; }
        public string RefDocumentCode { get; set; }
        public System.DateTime? RefTransactionDate { get; set; }
        public int RefTransactionTypeID { get; set; }
        public string RefTransactionTypeName { get; set; }
        public double RawAmount { get; set; }
        public double Amount { get; set; }
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
        
        
        
        public void CopyFrom(IvOtherIncomeOutcome obj)
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
            IsIncome = obj.IsIncome;
            RefDocumentID = obj.RefDocumentID;
            RefDocumentCode = obj.RefDocumentCode;
            RefTransactionDate = obj.RefTransactionDate;
            RefTransactionTypeID = obj.RefTransactionTypeID;
            RefTransactionTypeName = obj.RefTransactionTypeName;
            RawAmount = obj.RawAmount;
            Amount = obj.Amount;
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
