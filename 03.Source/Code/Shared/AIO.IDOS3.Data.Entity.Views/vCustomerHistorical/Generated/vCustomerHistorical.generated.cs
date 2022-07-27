﻿// ===================================================================================
// Author        : System
// Created date  : 08 Sep 2021 14:09:34
// Description   : vCustomerHistorical partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vCustomerHistorical.cs'
//       up to one level of this file location inside 'vCustomerHistorical' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{

    public partial class vCustomerHistorical : BaseEntityType, IvCustomerHistorical
    {

        #region Implements IvCustomerHistorical

        public System.Guid CustomerID { get; set; }
        public System.DateTime PeriodDateID { get; set; }
        public int ProductID { get; set; }
        public int QtyConvL { get; set; }
        public int? QtyConvM { get; set; }
        public int QtyConvS { get; set; }
        public int Qty { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int? CreatedByUserID { get; set; }



        public void CopyFrom(IvCustomerHistorical obj)
        {
            CustomerID = obj.CustomerID;
            PeriodDateID = obj.PeriodDateID;
            ProductID = obj.ProductID;
            QtyConvL = obj.QtyConvL;
            QtyConvM = obj.QtyConvM;
            QtyConvS = obj.QtyConvS;
            Qty = obj.Qty;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
        }

        #endregion

    }

}
