// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:56
// Description   : ISalesOrderFOCExt partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'ISalesOrderFOCExt.cs'
//       up to one level of this file location inside 'SalesOrderFOCExt' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface ISalesOrderFOCExt
    {                
        
        #region Properties
        
        System.Guid DocumentID { get; set; }
        string DocumentCode { get; set; }
        System.DateTime TransactionDate { get; set; }
        string TerritoryCode { get; set; }
        string TerritoryName { get; set; }
        string RegionCode { get; set; }
        string RegionName { get; set; }
        string AreaCode { get; set; }
        string AreaName { get; set; }
        string CompanyCode { get; set; }
        string CompanyName { get; set; }
        string SiteCode { get; set; }
        string SiteName { get; set; }
        string WarehouseCode { get; set; }
        string WarehouseName { get; set; }
        string WarehouseTypeName { get; set; }
        string SalesmanCode { get; set; }
        string SalesmanName { get; set; }
        string SalesmanGroupName { get; set; }
        string SalesmanCategoryName { get; set; }
        string TermOfPaymentName { get; set; }
        string CustomerCode { get; set; }
        string CustomerName { get; set; }
        string CustomerTerritoryCode { get; set; }
        string CustomerTerritoryName { get; set; }
        string CustomerRegionCode { get; set; }
        string CustomerRegionName { get; set; }
        string CustomerAreaCode { get; set; }
        string CustomerAreaName { get; set; }
        string CustomerCompanyCode { get; set; }
        string CustomerCompanyName { get; set; }
        string CustomerSiteCode { get; set; }
        string CustomerSiteName { get; set; }
        string CustomerSalesmanCode { get; set; }
        string CustomerSalesmanName { get; set; }
        string CustomerSalesmanGroupName { get; set; }
        string CustomerSalesmanCategoryName { get; set; }
        string CustomerTermOfPaymentName { get; set; }
        string CustomerCategory1 { get; set; }
        string CustomerCategory2 { get; set; }
        string CustomerCategory3 { get; set; }
        string CustomerCategory4 { get; set; }
        string CustomerCategory5 { get; set; }
        string CustomerCategory6 { get; set; }
        string CustomerCategory7 { get; set; }
        string CustomerCategory8 { get; set; }
        string CustomerCategory9 { get; set; }
        string CustomerCategory10 { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(ISalesOrderFOCExt obj);
        
        #endregion

    }

}
