﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:33
// Description   : IvStockItemStatusChangesSummary partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IvStockItemStatusChangesSummary.cs'
//       up to one level of this file location inside 'vStockItemStatusChangesSummary' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IvStockItemStatusChangesSummary
    {                
        
        #region Properties
        
        System.Guid DocumentID { get; set; }
        int ProductID { get; set; }
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
        int? QtyOnHand { get; set; }
        int QtyConvL { get; set; }
        int QtyConvM { get; set; }
        int QtyConvS { get; set; }
        int Qty { get; set; }
        string QtyChangesConv { get; set; }
        int? QtyChanges { get; set; }

        #endregion

        #region Methods
        
        void CopyFrom(IvStockItemStatusChangesSummary obj);
        
        #endregion
        
    }

}
