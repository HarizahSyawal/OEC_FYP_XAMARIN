﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:52
// Description   : PermissionObject partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'PermissionObject.cs'
//       up to one level of this file location inside 'PermissionObject' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class PermissionObject : IPermissionObject
    {                
        
        #region Implements IPermissionObject

        public string ID { get; set; }            
        public string Description { get; set; }            

        
        
        public void CopyFrom(IPermissionObject obj)
        {
            ID = obj.ID;
            Description = obj.Description;
        }
        
        #endregion
        
    }

}