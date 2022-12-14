// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:31
// Description   : IvSiteProduct partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IvSiteProduct.cs'
//       up to one level of this file location inside 'vSiteProduct' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IvSiteProduct
    {                
        
        #region Properties
        
        System.Guid SiteID { get; set; }
        int ProductID { get; set; }
        string SiteCode { get; set; }
        string SiteName { get; set; }
        string Site { get; set; }
        int AreaID { get; set; }
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
        int CompanyID { get; set; }
        string CompanyCode { get; set; }
        string CompanyName { get; set; }
        string Company { get; set; }
        int SiteDistributionTypeID { get; set; }
        string SiteDistributionTypeName { get; set; }
        bool IsSiteProductLotCodeEntryRequired { get; set; }
        string ProductCode { get; set; }
        string ProductName { get; set; }
        string Product { get; set; }
        int ProductBrandID { get; set; }
        string ProductBrandCode { get; set; }
        string ProductBrandName { get; set; }
        string ProductBrand { get; set; }
        string ProductShortName { get; set; }
        int? ProductUOMLID { get; set; }
        int? ProductUOMMID { get; set; }
        int? ProductUOMSID { get; set; }
        string ProductUOMLName { get; set; }
        string ProductUOMMName { get; set; }
        string ProductUOMSName { get; set; }
        double ProductWeight { get; set; }
        int? ProductDimensionL { get; set; }
        int? ProductDimensionW { get; set; }
        int? ProductDimensionH { get; set; }
        int? ProductConversionL { get; set; }
        int? ProductConversionM { get; set; }
        int ProductConversionS { get; set; }

        #endregion

        #region Methods
        
        void CopyFrom(IvSiteProduct obj);
        
        #endregion
        
    }

}
