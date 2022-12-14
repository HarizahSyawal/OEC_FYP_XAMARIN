// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:15
// Description   : IvPermissionObject partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IvPermissionObject.cs'
//       up to one level of this file location inside 'vPermissionObject' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IvPermissionObject
    {                
        
        #region Properties
        
        string ID { get; set; }
        string Description { get; set; }

        #endregion

        #region Methods
        
        void CopyFrom(IvPermissionObject obj);
        
        #endregion
        
    }

}
