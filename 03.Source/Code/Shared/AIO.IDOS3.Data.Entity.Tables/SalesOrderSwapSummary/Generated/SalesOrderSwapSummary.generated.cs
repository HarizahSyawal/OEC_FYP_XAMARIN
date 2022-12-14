// ===================================================================================
// Author        : System
// Created date  : 24 Sep 2020 03:19:44
// Description   : SalesOrderSwapSummary partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'SalesOrderSwapSummary.cs'
//       up to one level of this file location inside 'SalesOrderSwapSummary' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class SalesOrderSwapSummary : ISalesOrderSwapSummary
    {                
        
        #region Implements ISalesOrderSwapSummary

        public System.Guid DocumentID { get; set; }            
        public int ProductID { get; set; }            
        public int QtyOnHandGood { get; set; }            
        public int QtyOnHandBad { get; set; }            
        public int QtyConvL { get; set; }            
        public int QtyConvM { get; set; }            
        public int QtyConvS { get; set; }            
        public int Qty { get; set; }
        public int? ReasonID { get; set; }
        public double SubtotalWeight { get; set; }            
        public int SubtotalDimension { get; set; }            
        
        
        
        public void CopyFrom(ISalesOrderSwapSummary obj)
        {
            DocumentID = obj.DocumentID;
            ProductID = obj.ProductID;
            QtyOnHandGood = obj.QtyOnHandGood;
            QtyOnHandBad = obj.QtyOnHandBad;
            QtyConvL = obj.QtyConvL;
            QtyConvM = obj.QtyConvM;
            QtyConvS = obj.QtyConvS;
            Qty = obj.Qty;
            ReasonID = obj.ReasonID;
            SubtotalWeight = obj.SubtotalWeight;
            SubtotalDimension = obj.SubtotalDimension;
        }
        
        #endregion
        
    }

}
