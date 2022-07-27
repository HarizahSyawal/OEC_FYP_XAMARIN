﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:15
// Description   : vPermissionObject partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vPermissionObject.cs'
//       up to one level of this file location inside 'vPermissionObject' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vPermissionObject : BaseEntityType, IvPermissionObject
    {                
        
        #region Implements IvPermissionObject

        public string ID { get; set; }
        public string Description { get; set; }
        
        
        
        public void CopyFrom(IvPermissionObject obj)
        {
            ID = obj.ID;
            Description = obj.Description;
        }
        
        #endregion

    }

}
