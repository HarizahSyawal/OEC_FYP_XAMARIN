﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:55
// Description   : ISalesmanTarget partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'ISalesmanTarget.cs'
//       up to one level of this file location inside 'SalesmanTarget' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface ISalesmanTarget
    {                
        
        #region Properties
        
        System.Guid SalesmanID { get; set; }
        System.DateTime PeriodID { get; set; }
        double SalesOrderAmount { get; set; }
        int NewCustomer { get; set; }
        int Visibility { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(ISalesmanTarget obj);
        
        #endregion

    }

}
