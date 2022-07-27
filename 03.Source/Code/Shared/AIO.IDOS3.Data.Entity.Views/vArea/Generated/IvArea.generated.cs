﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:35:40
// Description   : IvArea partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IvArea.cs'
//       up to one level of this file location inside 'vArea' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IvArea
    {                
        
        #region Properties
        
        int ID { get; set; }
        string Code { get; set; }
        string Name { get; set; }
        string Area { get; set; }
        int? RegionID { get; set; }
        string RegionCode { get; set; }
        string RegionName { get; set; }
        string Region { get; set; }
        int? TerritoryID { get; set; }
        string TerritoryCode { get; set; }
        string TerritoryName { get; set; }
        string Territory { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        string CreatedByUserName { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }
        string ModifiedByUserName { get; set; }
        bool IsDeleted { get; set; }

        #endregion

        #region Methods
        
        void CopyFrom(IvArea obj);
        
        #endregion
        
    }

}
