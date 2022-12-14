// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:28:04
// Description   : StockReceivalSummary partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'StockReceivalSummary.cs'
//       up to one level of this file location inside 'StockReceivalSummary' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class StockReceivalSummary : IStockReceivalSummary
    {                
        
        #region Implements IStockReceivalSummary

        public System.Guid DocumentID { get; set; }            
        public int ProductID { get; set; }            
        public int QtyOnHand { get; set; }            
        public int QtyConvL { get; set; }            
        public int QtyConvM { get; set; }            
        public int QtyConvS { get; set; }            
        public int Qty { get; set; }            

        
        
        public void CopyFrom(IStockReceivalSummary obj)
        {
            DocumentID = obj.DocumentID;
            ProductID = obj.ProductID;
            QtyOnHand = obj.QtyOnHand;
            QtyConvL = obj.QtyConvL;
            QtyConvM = obj.QtyConvM;
            QtyConvS = obj.QtyConvS;
            Qty = obj.Qty;
        }
        
        #endregion
        
    }

}
