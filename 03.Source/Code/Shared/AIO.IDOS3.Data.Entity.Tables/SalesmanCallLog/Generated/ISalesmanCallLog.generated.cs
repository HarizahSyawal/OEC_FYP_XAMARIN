﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:54
// Description   : ISalesmanCallLog partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'ISalesmanCallLog.cs'
//       up to one level of this file location inside 'SalesmanCallLog' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface ISalesmanCallLog
    {                
        
        #region Properties
        
        System.Guid ID { get; set; }
        System.Guid SalesmanCallID { get; set; }
        System.DateTime CheckedDate { get; set; }
        double? CheckedLongitude { get; set; }
        double? CheckedLatitude { get; set; }
        bool? IsCheckedIn { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(ISalesmanCallLog obj);
        
        #endregion

    }

}
