// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:19
// Description   : IvSalesByChannelByBrandReport partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IvSalesByChannelByBrandReport.cs'
//       up to one level of this file location inside 'vSalesByChannelByBrandReport' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IvSalesByChannelByBrandReport
    {                
        
        #region Properties
        
        string CategoryChannelCode { get; set; }
        int? ProductBrandID { get; set; }
        string CategoryChannelName { get; set; }
        string CategoryChannel { get; set; }
        string ProductBrand { get; set; }
        double? TargetSalesOrderQty { get; set; }
        double? TotalSalesOrderQty { get; set; }
        double? TotalSalesOrderReturnQty { get; set; }
        double? ActualSalesOrderQty { get; set; }
        double? AchActualSalesOrderQty { get; set; }
        double? LMTotalSalesOrderQty { get; set; }
        double? LMTotalSalesOrderReturnQty { get; set; }
        double? LMActualSalesOrderQty { get; set; }
        double? LYTotalSalesOrderQty { get; set; }
        double? LYTotalSalesOrderReturnQty { get; set; }
        double? LYActualSalesOrderQty { get; set; }
        double? GrowthLMActualSalesOrderQty { get; set; }
        double? GrowthLYActualSalesOrderQty { get; set; }
        double? GapTargetVsActualSalesOrderQty { get; set; }

        #endregion

        #region Methods
        
        void CopyFrom(IvSalesByChannelByBrandReport obj);
        
        #endregion
        
    }

}
