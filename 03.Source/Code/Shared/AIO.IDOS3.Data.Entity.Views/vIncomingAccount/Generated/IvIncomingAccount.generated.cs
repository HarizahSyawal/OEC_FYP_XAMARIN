﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:04
// Description   : IvIncomingAccount partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IvIncomingAccount.cs'
//       up to one level of this file location inside 'vIncomingAccount' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IvIncomingAccount
    {                
        
        #region Properties
        
        int ID { get; set; }
        string Code { get; set; }
        string Name { get; set; }
        string IncomingAccount { get; set; }
        bool IsHeadOffice { get; set; }
        System.Guid? SiteID { get; set; }
        string SiteCode { get; set; }
        string SiteName { get; set; }
        string Site { get; set; }
        int? AreaID { get; set; }
        string AreaCode { get; set; }
        string AreaName { get; set; }
        string Area { get; set; }
        int? RegionID { get; set; }
        string RegionCode { get; set; }
        string RegionName { get; set; }
        string Region { get; set; }
        int? TerritoryID { get; set; }
        string TerritoryCode { get; set; }
        string TerritoryName { get; set; }
        string Territory { get; set; }
        int? CompanyID { get; set; }
        string CompanyCode { get; set; }
        string CompanyName { get; set; }
        string Company { get; set; }
        int? SiteDistributionTypeID { get; set; }
        string SiteDistributionTypeName { get; set; }
        string Description { get; set; }
        int? FinanceInstitutionID { get; set; }
        string FinanceInstitutionCode { get; set; }
        string FinanceInstitutionName { get; set; }
        string FinanceInstitution { get; set; }
        string FinanceInstitutionShortName { get; set; }
        int FinanceInstitutionTypeID { get; set; }
        string FinanceInstitutionTypeName { get; set; }
        int StatusID { get; set; }
        string StatusName { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        string CreatedByUserName { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }
        string ModifiedByUserName { get; set; }
        bool IsDeleted { get; set; }

        #endregion

        #region Methods
        
        void CopyFrom(IvIncomingAccount obj);
        
        #endregion
        
    }

}