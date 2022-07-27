﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:28:04
// Description   : IStockReceiveAsSampleDetails partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IStockReceiveAsSampleDetails.cs'
//       up to one level of this file location inside 'StockReceiveAsSampleDetails' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IStockReceiveAsSampleDetails
    {                
        
        #region Properties
        
        System.Guid DocumentID { get; set; }
        int ProductID { get; set; }
        int ProductLotID { get; set; }
        int QtyOnHand { get; set; }
        int QtyConvL { get; set; }
        int QtyConvM { get; set; }
        int QtyConvS { get; set; }
        int Qty { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(IStockReceiveAsSampleDetails obj);
        
        #endregion

    }

}