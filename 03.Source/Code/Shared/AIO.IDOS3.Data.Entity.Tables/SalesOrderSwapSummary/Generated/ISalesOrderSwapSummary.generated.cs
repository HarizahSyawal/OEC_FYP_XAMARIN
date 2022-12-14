// ===================================================================================
// Author        : System
// Created date  : 24 Sep 2020 03:19:44
// Description   : ISalesOrderSwapSummary partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'ISalesOrderSwapSummary.cs'
//       up to one level of this file location inside 'SalesOrderSwapSummary' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface ISalesOrderSwapSummary
    {                
        
        #region Properties
        
        System.Guid DocumentID { get; set; }
        int ProductID { get; set; }
        int QtyOnHandGood { get; set; }
        int QtyOnHandBad { get; set; }
        int QtyConvL { get; set; }
        int QtyConvM { get; set; }
        int QtyConvS { get; set; }
        int Qty { get; set; }
        int? ReasonID { get; set; }
        double SubtotalWeight { get; set; }
        int SubtotalDimension { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(ISalesOrderSwapSummary obj);
        
        #endregion

    }

}
