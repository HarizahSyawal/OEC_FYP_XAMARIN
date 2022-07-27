﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:18
// Description   : vRolePermission partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vRolePermission.cs'
//       up to one level of this file location inside 'vRolePermission' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vRolePermission : BaseEntityType, IvRolePermission
    {                
        
        #region Implements IvRolePermission

        public int RoleID { get; set; }
        public string PermissionObjectID { get; set; }
        public string RoleName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int? CreatedByUserID { get; set; }
        public string CreatedByUserName { get; set; }
        
        
        
        public void CopyFrom(IvRolePermission obj)
        {
            RoleID = obj.RoleID;
            PermissionObjectID = obj.PermissionObjectID;
            RoleName = obj.RoleName;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
            CreatedByUserName = obj.CreatedByUserName;
        }
        
        #endregion

    }

}