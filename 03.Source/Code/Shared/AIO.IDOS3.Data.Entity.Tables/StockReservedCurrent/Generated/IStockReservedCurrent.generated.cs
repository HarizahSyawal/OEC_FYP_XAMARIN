﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:28:05
// Description   : IStockReservedCurrent partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IStockReservedCurrent.cs'
//       up to one level of this file location inside 'StockReservedCurrent' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IStockReservedCurrent
    {                
        
        #region Properties
        
        System.Guid WarehouseID { get; set; }
        int ProductID { get; set; }
        int QtyReservedGood { get; set; }
        int QtyReservedHold { get; set; }
        int QtyReservedBad { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(IStockReservedCurrent obj);
        
        #endregion

    }

}