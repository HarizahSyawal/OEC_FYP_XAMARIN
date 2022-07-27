﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:54
// Description   : RolePermission partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'RolePermission.cs'
//       up to one level of this file location inside 'RolePermission' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class RolePermission : IRolePermission
    {                
        
        #region Implements IRolePermission

        public int RoleID { get; set; }            
        public string PermissionObjectID { get; set; }            
        public System.DateTime CreatedDate { get; set; }            
        public int? CreatedByUserID { get; set; }            

        
        
        public void CopyFrom(IRolePermission obj)
        {
            RoleID = obj.RoleID;
            PermissionObjectID = obj.PermissionObjectID;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
        }
        
        #endregion
        
    }

}