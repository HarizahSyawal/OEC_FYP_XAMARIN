﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:28:08
// Description   : IStockTransferDetails partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IStockTransferDetails.cs'
//       up to one level of this file location inside 'StockTransferDetails' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IStockTransferDetails
    {                
        
        #region Properties
        
        System.Guid DocumentID { get; set; }
        int ProductID { get; set; }
        int ProductLotID { get; set; }
        int QtyOnHandGood { get; set; }
        int QtyOnHandHold { get; set; }
        int QtyOnHandBad { get; set; }
        int QtyConvLGood { get; set; }
        int QtyConvMGood { get; set; }
        int QtyConvSGood { get; set; }
        int QtyConvLHold { get; set; }
        int QtyConvMHold { get; set; }
        int QtyConvSHold { get; set; }
        int QtyConvLBad { get; set; }
        int QtyConvMBad { get; set; }
        int QtyConvSBad { get; set; }
        int QtyGood { get; set; }
        int QtyHold { get; set; }
        int QtyBad { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(IStockTransferDetails obj);
        
        #endregion

    }

}
