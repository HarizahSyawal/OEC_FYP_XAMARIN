// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:20
// Description   : vSalesBySiteByBrandReport partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vSalesBySiteByBrandReport.cs'
//       up to one level of this file location inside 'vSalesBySiteByBrandReport' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vSalesBySiteByBrandReport : BaseEntityType, IvSalesBySiteByBrandReport
    {                
        
        #region Implements IvSalesBySiteByBrandReport

        public System.Guid? SiteID { get; set; }
        public int? ProductBrandID { get; set; }
        public string Site { get; set; }
        public string ProductBrand { get; set; }
        public double? TargetSalesOrderQty { get; set; }
        public double? TotalSalesOrderQty { get; set; }
        public double? TotalSalesOrderReturnQty { get; set; }
        public double? ActualSalesOrderQty { get; set; }
        public double? AchActualSalesOrderQty { get; set; }
        public double? LMTotalSalesOrderQty { get; set; }
        public double? LMTotalSalesOrderReturnQty { get; set; }
        public double? LMActualSalesOrderQty { get; set; }
        public double? LYTotalSalesOrderQty { get; set; }
        public double? LYTotalSalesOrderReturnQty { get; set; }
        public double? LYActualSalesOrderQty { get; set; }
        public double? GrowthLMActualSalesOrderQty { get; set; }
        public double? GrowthLYActualSalesOrderQty { get; set; }
        public double? GapTargetVsActualSalesOrderQty { get; set; }
        
        
        
        public void CopyFrom(IvSalesBySiteByBrandReport obj)
        {
            SiteID = obj.SiteID;
            ProductBrandID = obj.ProductBrandID;
            Site = obj.Site;
            ProductBrand = obj.ProductBrand;
            TargetSalesOrderQty = obj.TargetSalesOrderQty;
            TotalSalesOrderQty = obj.TotalSalesOrderQty;
            TotalSalesOrderReturnQty = obj.TotalSalesOrderReturnQty;
            ActualSalesOrderQty = obj.ActualSalesOrderQty;
            AchActualSalesOrderQty = obj.AchActualSalesOrderQty;
            LMTotalSalesOrderQty = obj.LMTotalSalesOrderQty;
            LMTotalSalesOrderReturnQty = obj.LMTotalSalesOrderReturnQty;
            LMActualSalesOrderQty = obj.LMActualSalesOrderQty;
            LYTotalSalesOrderQty = obj.LYTotalSalesOrderQty;
            LYTotalSalesOrderReturnQty = obj.LYTotalSalesOrderReturnQty;
            LYActualSalesOrderQty = obj.LYActualSalesOrderQty;
            GrowthLMActualSalesOrderQty = obj.GrowthLMActualSalesOrderQty;
            GrowthLYActualSalesOrderQty = obj.GrowthLYActualSalesOrderQty;
            GapTargetVsActualSalesOrderQty = obj.GapTargetVsActualSalesOrderQty;
        }
        
        #endregion

    }

}
