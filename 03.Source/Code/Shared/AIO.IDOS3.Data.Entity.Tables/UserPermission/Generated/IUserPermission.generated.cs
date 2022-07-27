﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:28:09
// Description   : IUserPermission partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IUserPermission.cs'
//       up to one level of this file location inside 'UserPermission' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IUserPermission
    {                
        
        #region Properties
        
        int UserID { get; set; }
        string PermissionObjectID { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(IUserPermission obj);
        
        #endregion

    }

}
