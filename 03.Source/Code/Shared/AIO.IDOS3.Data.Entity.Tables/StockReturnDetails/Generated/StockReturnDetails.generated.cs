﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:28:06
// Description   : StockReturnDetails partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'StockReturnDetails.cs'
//       up to one level of this file location inside 'StockReturnDetails' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class StockReturnDetails : IStockReturnDetails
    {                
        
        #region Implements IStockReturnDetails

        public System.Guid DocumentID { get; set; }            
        public int ProductID { get; set; }            
        public int ProductLotID { get; set; }            
        public int QtyOnHand { get; set; }            
        public int QtyConvL { get; set; }            
        public int QtyConvM { get; set; }            
        public int QtyConvS { get; set; }            
        public int Qty { get; set; }            

        
        
        public void CopyFrom(IStockReturnDetails obj)
        {
            DocumentID = obj.DocumentID;
            ProductID = obj.ProductID;
            ProductLotID = obj.ProductLotID;
            QtyOnHand = obj.QtyOnHand;
            QtyConvL = obj.QtyConvL;
            QtyConvM = obj.QtyConvM;
            QtyConvS = obj.QtyConvS;
            Qty = obj.Qty;
        }
        
        #endregion
        
    }

}
