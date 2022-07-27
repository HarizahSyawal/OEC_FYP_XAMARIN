﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:09
// Description   : IvOrganizationPosition partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IvOrganizationPosition.cs'
//       up to one level of this file location inside 'vOrganizationPosition' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IvOrganizationPosition
    {                
        
        #region Properties
        
        int ID { get; set; }
        string Code { get; set; }
        string Name { get; set; }
        string Position { get; set; }
        int? UnitID { get; set; }
        string UnitCode { get; set; }
        string UnitName { get; set; }
        string Unit { get; set; }
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
        bool? IsSiteLotNumberEntryRequired { get; set; }
        int? UnitParentID { get; set; }
        string UnitParentCode { get; set; }
        string UnitParentName { get; set; }
        string UnitParent { get; set; }
        bool IsUnitHead { get; set; }
        int? Level { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        string CreatedByUserName { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }
        string ModifiedByUserName { get; set; }
        bool IsDeleted { get; set; }

        #endregion

        #region Methods
        
        void CopyFrom(IvOrganizationPosition obj);
        
        #endregion
        
    }

}
