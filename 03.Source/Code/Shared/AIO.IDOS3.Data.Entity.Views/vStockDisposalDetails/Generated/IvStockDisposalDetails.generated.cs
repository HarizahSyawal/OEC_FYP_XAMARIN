﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:32
// Description   : IvStockDisposalDetails partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IvStockDisposalDetails.cs'
//       up to one level of this file location inside 'vStockDisposalDetails' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IvStockDisposalDetails
    {                
        
        #region Properties
        
        System.Guid DocumentID { get; set; }
        int ProductID { get; set; }
        int ProductLotID { get; set; }
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
        string ProductLotCode { get; set; }
        System.DateTime? ProductLotExpiredDate { get; set; }
        string ProductLot { get; set; }
        int? QtyOnHand { get; set; }
        int QtyConvL { get; set; }
        int QtyConvM { get; set; }
        int QtyConvS { get; set; }
        int Qty { get; set; }
        string QtyDisposalConv { get; set; }
        int? QtyDisposal { get; set; }

        #endregion

        #region Methods
        
        void CopyFrom(IvStockDisposalDetails obj);
        
        #endregion
        
    }

}
