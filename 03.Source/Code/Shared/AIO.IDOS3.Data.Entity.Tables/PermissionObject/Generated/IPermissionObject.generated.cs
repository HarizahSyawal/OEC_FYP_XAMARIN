// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:52
// Description   : IPermissionObject partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IPermissionObject.cs'
//       up to one level of this file location inside 'PermissionObject' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IPermissionObject
    {                
        
        #region Properties
        
        string ID { get; set; }
        string Description { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(IPermissionObject obj);
        
        #endregion

    }

}
