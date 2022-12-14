// ===================================================================================
// Author        : System
// Created date  : 24 Sep 2020 03:19:41
// Description   : SalesOrderFOCSummary partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'SalesOrderFOCSummary.cs'
//       up to one level of this file location inside 'SalesOrderFOCSummary' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class SalesOrderFOCSummary : ISalesOrderFOCSummary
    {                
        
        #region Implements ISalesOrderFOCSummary

        public System.Guid DocumentID { get; set; }            
        public int ProductID { get; set; }            
        public System.DateTime? PriceDate { get; set; }            
        public int QtyOnHand { get; set; }            
        public int QtyConvL { get; set; }            
        public int QtyConvM { get; set; }            
        public int QtyConvS { get; set; }            
        public int Qty { get; set; }            
        public double UnitGrossPrice { get; set; }            
        public double UnitPrice { get; set; }            
        public double? DiscountStrata1Percentage { get; set; }            
        public double? DiscountStrata2Percentage { get; set; }            
        public double? DiscountStrata3Percentage { get; set; }            
        public double? DiscountStrata4Percentage { get; set; }            
        public double? DiscountStrata5Percentage { get; set; }            
        public double? AddDiscountStrataPercentage { get; set; }            
        public double TaxPercentage { get; set; }            
        public double RawSubtotalGrossPrice { get; set; }            
        public double RawSubtotalPrice { get; set; }            
        public double RawSubtotalDiscountStrata1 { get; set; }            
        public double RawSubtotalDiscountStrata2 { get; set; }            
        public double RawSubtotalDiscountStrata3 { get; set; }            
        public double RawSubtotalDiscountStrata4 { get; set; }            
        public double RawSubtotalDiscountStrata5 { get; set; }            
        public double RawSubtotalGrossAmount { get; set; }            
        public double RawSubtotalTaxAmount { get; set; }            
        public double RawSubtotalAmount { get; set; }            
        public double SubtotalGrossPrice { get; set; }            
        public double SubtotalPrice { get; set; }            
        public double SubtotalDiscountStrata1 { get; set; }            
        public double SubtotalDiscountStrata2 { get; set; }            
        public double SubtotalDiscountStrata3 { get; set; }            
        public double SubtotalDiscountStrata4 { get; set; }            
        public double SubtotalDiscountStrata5 { get; set; }            
        public double SubtotalGrossAmount { get; set; }            
        public double SubtotalTaxAmount { get; set; }            
        public double SubtotalAmount { get; set; }            
        public double SubtotalWeight { get; set; }            
        public int SubtotalDimension { get; set; }            
        
        
        
        public void CopyFrom(ISalesOrderFOCSummary obj)
        {
            DocumentID = obj.DocumentID;
            ProductID = obj.ProductID;
            PriceDate = obj.PriceDate;
            QtyOnHand = obj.QtyOnHand;
            QtyConvL = obj.QtyConvL;
            QtyConvM = obj.QtyConvM;
            QtyConvS = obj.QtyConvS;
            Qty = obj.Qty;
            UnitGrossPrice = obj.UnitGrossPrice;
            UnitPrice = obj.UnitPrice;
            DiscountStrata1Percentage = obj.DiscountStrata1Percentage;
            DiscountStrata2Percentage = obj.DiscountStrata2Percentage;
            DiscountStrata3Percentage = obj.DiscountStrata3Percentage;
            DiscountStrata4Percentage = obj.DiscountStrata4Percentage;
            DiscountStrata5Percentage = obj.DiscountStrata5Percentage;
            AddDiscountStrataPercentage = obj.AddDiscountStrataPercentage;
            TaxPercentage = obj.TaxPercentage;
            RawSubtotalGrossPrice = obj.RawSubtotalGrossPrice;
            RawSubtotalPrice = obj.RawSubtotalPrice;
            RawSubtotalDiscountStrata1 = obj.RawSubtotalDiscountStrata1;
            RawSubtotalDiscountStrata2 = obj.RawSubtotalDiscountStrata2;
            RawSubtotalDiscountStrata3 = obj.RawSubtotalDiscountStrata3;
            RawSubtotalDiscountStrata4 = obj.RawSubtotalDiscountStrata4;
            RawSubtotalDiscountStrata5 = obj.RawSubtotalDiscountStrata5;
            RawSubtotalGrossAmount = obj.RawSubtotalGrossAmount;
            RawSubtotalTaxAmount = obj.RawSubtotalTaxAmount;
            RawSubtotalAmount = obj.RawSubtotalAmount;
            SubtotalGrossPrice = obj.SubtotalGrossPrice;
            SubtotalPrice = obj.SubtotalPrice;
            SubtotalDiscountStrata1 = obj.SubtotalDiscountStrata1;
            SubtotalDiscountStrata2 = obj.SubtotalDiscountStrata2;
            SubtotalDiscountStrata3 = obj.SubtotalDiscountStrata3;
            SubtotalDiscountStrata4 = obj.SubtotalDiscountStrata4;
            SubtotalDiscountStrata5 = obj.SubtotalDiscountStrata5;
            SubtotalGrossAmount = obj.SubtotalGrossAmount;
            SubtotalTaxAmount = obj.SubtotalTaxAmount;
            SubtotalAmount = obj.SubtotalAmount;
            SubtotalWeight = obj.SubtotalWeight;
            SubtotalDimension = obj.SubtotalDimension;
        }
        
        #endregion
        
    }

}
