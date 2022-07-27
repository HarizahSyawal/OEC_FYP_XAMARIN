﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:28:10
// Description   : IUserSite partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IUserSite.cs'
//       up to one level of this file location inside 'UserSite' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IUserSite
    {                
        
        #region Properties
        
        int UserID { get; set; }
        System.Guid SiteID { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(IUserSite obj);
        
        #endregion

    }

}