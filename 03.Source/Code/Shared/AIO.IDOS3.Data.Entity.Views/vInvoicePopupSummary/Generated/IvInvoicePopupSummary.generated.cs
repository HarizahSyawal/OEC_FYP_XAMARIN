﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:08
// Description   : IvInvoicePopupSummary partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IvInvoicePopupSummary.cs'
//       up to one level of this file location inside 'vInvoicePopupSummary' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IvInvoicePopupSummary
    {                
        
        #region Properties
        
        System.Guid DocumentID { get; set; }
        int ProductID { get; set; }
        string Product { get; set; }
        int ProductBrandID { get; set; }
        string ProductBrand { get; set; }
        double Weight { get; set; }
        int? DimensionL { get; set; }
        int? DimensionW { get; set; }
        int? DimensionH { get; set; }
        int? ConversionL { get; set; }
        int? ConversionM { get; set; }
        int ConversionS { get; set; }
        System.DateTime? PriceDate { get; set; }
        int QtyOnHand { get; set; }
        int QtyConvL { get; set; }
        int QtyConvM { get; set; }
        int QtyConvS { get; set; }
        int Qty { get; set; }
        string QtyOrderConv { get; set; }
        int? QtyOrder { get; set; }
        double UnitGrossPrice { get; set; }
        double UnitPrice { get; set; }
        double? DiscountStrata1Percentage { get; set; }
        double? DiscountStrata2Percentage { get; set; }
        double? DiscountStrata3Percentage { get; set; }
        double? DiscountStrata4Percentage { get; set; }
        double? DiscountStrata5Percentage { get; set; }
        double? AddDiscountStrataPercentage { get; set; }
        double TaxPercentage { get; set; }
        double SubtotalGrossPrice { get; set; }
        double SubtotalPrice { get; set; }
        double SubtotalDiscountStrata1 { get; set; }
        double DiscountStrata1Amount { get; set; }
        double SubtotalDiscountStrata2 { get; set; }
        double DiscountStrata2Amount { get; set; }
        double SubtotalDiscountStrata3 { get; set; }
        double DiscountStrata3Amount { get; set; }
        double SubtotalDiscountStrata4 { get; set; }
        double DiscountStrata4Amount { get; set; }
        double SubtotalDiscountStrata5 { get; set; }
        double DiscountStrata5Amount { get; set; }
        double AddDiscountStrataAmount { get; set; }
        double SubtotalGrossAmount { get; set; }
        double SubtotalTaxAmount { get; set; }
        double SubtotalAmount { get; set; }
        double SubtotalWeight { get; set; }
        int SubtotalDimension { get; set; }

        #endregion

        #region Methods
        
        void CopyFrom(IvInvoicePopupSummary obj);
        
        #endregion
        
    }

}