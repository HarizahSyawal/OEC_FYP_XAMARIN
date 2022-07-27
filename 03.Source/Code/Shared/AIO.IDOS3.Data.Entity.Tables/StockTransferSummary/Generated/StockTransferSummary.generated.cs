﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:28:08
// Description   : StockTransferSummary partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'StockTransferSummary.cs'
//       up to one level of this file location inside 'StockTransferSummary' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class StockTransferSummary : IStockTransferSummary
    {                
        
        #region Implements IStockTransferSummary

        public System.Guid DocumentID { get; set; }            
        public int ProductID { get; set; }            
        public int QtyOnHandGood { get; set; }            
        public int QtyOnHandHold { get; set; }            
        public int QtyOnHandBad { get; set; }            
        public int QtyConvLGood { get; set; }            
        public int QtyConvMGood { get; set; }            
        public int QtyConvSGood { get; set; }            
        public int QtyConvLHold { get; set; }            
        public int QtyConvMHold { get; set; }            
        public int QtyConvSHold { get; set; }            
        public int QtyConvLBad { get; set; }            
        public int QtyConvMBad { get; set; }            
        public int QtyConvSBad { get; set; }            
        public int QtyGood { get; set; }            
        public int QtyHold { get; set; }            
        public int QtyBad { get; set; }            

        
        
        public void CopyFrom(IStockTransferSummary obj)
        {
            DocumentID = obj.DocumentID;
            ProductID = obj.ProductID;
            QtyOnHandGood = obj.QtyOnHandGood;
            QtyOnHandHold = obj.QtyOnHandHold;
            QtyOnHandBad = obj.QtyOnHandBad;
            QtyConvLGood = obj.QtyConvLGood;
            QtyConvMGood = obj.QtyConvMGood;
            QtyConvSGood = obj.QtyConvSGood;
            QtyConvLHold = obj.QtyConvLHold;
            QtyConvMHold = obj.QtyConvMHold;
            QtyConvSHold = obj.QtyConvSHold;
            QtyConvLBad = obj.QtyConvLBad;
            QtyConvMBad = obj.QtyConvMBad;
            QtyConvSBad = obj.QtyConvSBad;
            QtyGood = obj.QtyGood;
            QtyHold = obj.QtyHold;
            QtyBad = obj.QtyBad;
        }
        
        #endregion
        
    }

}
