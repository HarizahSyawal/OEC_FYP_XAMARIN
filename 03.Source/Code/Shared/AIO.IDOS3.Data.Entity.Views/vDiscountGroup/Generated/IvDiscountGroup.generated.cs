﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:00
// Description   : IvDiscountGroup partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IvDiscountGroup.cs'
//       up to one level of this file location inside 'vDiscountGroup' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IvDiscountGroup
    {                
        
        #region Properties
        
        int ID { get; set; }
        string Code { get; set; }
        string Name { get; set; }
        string DiscountGroup { get; set; }
        string Description { get; set; }
        int StatusID { get; set; }
        string StatusName { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        string CreatedByUserName { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }
        string ModifiedByUserName { get; set; }
        bool IsDeleted { get; set; }

        #endregion

        #region Methods
        
        void CopyFrom(IvDiscountGroup obj);
        
        #endregion
        
    }

}
