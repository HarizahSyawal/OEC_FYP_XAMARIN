// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:35:48
// Description   : vCollector partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vCollector.cs'
//       up to one level of this file location inside 'vCollector' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vCollector : BaseEntityType, IvCollector
    {                
        
        #region Implements IvCollector

        public System.Guid ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Collector { get; set; }
        public bool IsHeadOffice { get; set; }
        public System.Guid? SiteID { get; set; }
        public string SiteCode { get; set; }
        public string SiteName { get; set; }
        public string Site { get; set; }
        public int? AreaID { get; set; }
        public string AreaCode { get; set; }
        public string AreaName { get; set; }
        public string Area { get; set; }
        public int? RegionID { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public string Region { get; set; }
        public int? TerritoryID { get; set; }
        public string TerritoryCode { get; set; }
        public string TerritoryName { get; set; }
        public string Territory { get; set; }
        public int? CompanyID { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string Company { get; set; }
        public int? SiteDistributionTypeID { get; set; }
        public string SiteDistributionTypeName { get; set; }
        public bool? IsSiteProductLotCodeEntryRequired { get; set; }
        public System.Guid? EmployeeID { get; set; }
        public string EmployeeCode { get; set; }
        public int StatusID { get; set; }
        public string StatusName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int? CreatedByUserID { get; set; }
        public string CreatedByUserName { get; set; }
        public System.DateTime? ModifiedDate { get; set; }
        public int? ModifiedByUserID { get; set; }
        public string ModifiedByUserName { get; set; }
        public bool IsDeleted { get; set; }
        
        
        
        public void CopyFrom(IvCollector obj)
        {
            ID = obj.ID;
            Code = obj.Code;
            Name = obj.Name;
            Collector = obj.Collector;
            IsHeadOffice = obj.IsHeadOffice;
            SiteID = obj.SiteID;
            SiteCode = obj.SiteCode;
            SiteName = obj.SiteName;
            Site = obj.Site;
            AreaID = obj.AreaID;
            AreaCode = obj.AreaCode;
            AreaName = obj.AreaName;
            Area = obj.Area;
            RegionID = obj.RegionID;
            RegionCode = obj.RegionCode;
            RegionName = obj.RegionName;
            Region = obj.Region;
            TerritoryID = obj.TerritoryID;
            TerritoryCode = obj.TerritoryCode;
            TerritoryName = obj.TerritoryName;
            Territory = obj.Territory;
            CompanyID = obj.CompanyID;
            CompanyCode = obj.CompanyCode;
            CompanyName = obj.CompanyName;
            Company = obj.Company;
            SiteDistributionTypeID = obj.SiteDistributionTypeID;
            SiteDistributionTypeName = obj.SiteDistributionTypeName;
            IsSiteProductLotCodeEntryRequired = obj.IsSiteProductLotCodeEntryRequired;
            EmployeeID = obj.EmployeeID;
            EmployeeCode = obj.EmployeeCode;
            StatusID = obj.StatusID;
            StatusName = obj.StatusName;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
            CreatedByUserName = obj.CreatedByUserName;
            ModifiedDate = obj.ModifiedDate;
            ModifiedByUserID = obj.ModifiedByUserID;
            ModifiedByUserName = obj.ModifiedByUserName;
            IsDeleted = obj.IsDeleted;
        }
        
        #endregion

    }

}
