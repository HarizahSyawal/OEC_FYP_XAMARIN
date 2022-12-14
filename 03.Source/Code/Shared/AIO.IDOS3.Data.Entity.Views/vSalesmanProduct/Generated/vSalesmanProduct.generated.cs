// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:22
// Description   : vSalesmanProduct partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vSalesmanProduct.cs'
//       up to one level of this file location inside 'vSalesmanProduct' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vSalesmanProduct : BaseEntityType, IvSalesmanProduct
    {                
        
        #region Implements IvSalesmanProduct

        public System.Guid SalesmanID { get; set; }
        public int ProductID { get; set; }
        public string SalesmanCode { get; set; }
        public string SalesmanName { get; set; }
        public string Salesman { get; set; }
        public System.Guid SalesmanWarehouseID { get; set; }
        public string SalesmanWarehouseCode { get; set; }
        public string SalesmanWarehouseName { get; set; }
        public string SalesmanWarehouse { get; set; }
        public System.Guid? SiteID { get; set; }
        public string SiteCode { get; set; }
        public string SiteName { get; set; }
        public string Site { get; set; }
        public int AreaID { get; set; }
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
        public int CompanyID { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string Company { get; set; }
        public int SiteDistributionTypeID { get; set; }
        public string SiteDistributionTypeName { get; set; }
        public bool IsSiteProductLotCodeEntryRequired { get; set; }
        public int SalesmanWarehouseTypeID { get; set; }
        public string SalesmanWarehouseTypeName { get; set; }
        public int SalesmanGroupID { get; set; }
        public string SalesmanGroupName { get; set; }
        public int SalesmanCategoryID { get; set; }
        public string SalesmanCategoryName { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Product { get; set; }
        public int ProductBrandID { get; set; }
        public string ProductBrandCode { get; set; }
        public string ProductBrandName { get; set; }
        public string ProductBrand { get; set; }
        public string ProductShortName { get; set; }
        public int? ProductUOMLID { get; set; }
        public int? ProductUOMMID { get; set; }
        public int? ProductUOMSID { get; set; }
        public string ProductUOMLName { get; set; }
        public string ProductUOMMName { get; set; }
        public string ProductUOMSName { get; set; }
        public double ProductWeight { get; set; }
        public int? ProductDimensionL { get; set; }
        public int? ProductDimensionW { get; set; }
        public int? ProductDimensionH { get; set; }
        public int? ProductConversionL { get; set; }
        public int? ProductConversionM { get; set; }
        public int ProductConversionS { get; set; }
        
        
        
        public void CopyFrom(IvSalesmanProduct obj)
        {
            SalesmanID = obj.SalesmanID;
            ProductID = obj.ProductID;
            SalesmanCode = obj.SalesmanCode;
            SalesmanName = obj.SalesmanName;
            Salesman = obj.Salesman;
            SalesmanWarehouseID = obj.SalesmanWarehouseID;
            SalesmanWarehouseCode = obj.SalesmanWarehouseCode;
            SalesmanWarehouseName = obj.SalesmanWarehouseName;
            SalesmanWarehouse = obj.SalesmanWarehouse;
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
            SalesmanWarehouseTypeID = obj.SalesmanWarehouseTypeID;
            SalesmanWarehouseTypeName = obj.SalesmanWarehouseTypeName;
            SalesmanGroupID = obj.SalesmanGroupID;
            SalesmanGroupName = obj.SalesmanGroupName;
            SalesmanCategoryID = obj.SalesmanCategoryID;
            SalesmanCategoryName = obj.SalesmanCategoryName;
            ProductCode = obj.ProductCode;
            ProductName = obj.ProductName;
            Product = obj.Product;
            ProductBrandID = obj.ProductBrandID;
            ProductBrandCode = obj.ProductBrandCode;
            ProductBrandName = obj.ProductBrandName;
            ProductBrand = obj.ProductBrand;
            ProductShortName = obj.ProductShortName;
            ProductUOMLID = obj.ProductUOMLID;
            ProductUOMMID = obj.ProductUOMMID;
            ProductUOMSID = obj.ProductUOMSID;
            ProductUOMLName = obj.ProductUOMLName;
            ProductUOMMName = obj.ProductUOMMName;
            ProductUOMSName = obj.ProductUOMSName;
            ProductWeight = obj.ProductWeight;
            ProductDimensionL = obj.ProductDimensionL;
            ProductDimensionW = obj.ProductDimensionW;
            ProductDimensionH = obj.ProductDimensionH;
            ProductConversionL = obj.ProductConversionL;
            ProductConversionM = obj.ProductConversionM;
            ProductConversionS = obj.ProductConversionS;
        }
        
        #endregion

    }

}
