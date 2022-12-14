// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:54
// Description   : IRole partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IRole.cs'
//       up to one level of this file location inside 'Role' folder.
// ===================================================================================

namespace AIO.IDOS3.Data
{

    public partial interface IRole
    {                
        
        #region Properties
        
        int ID { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        int StatusID { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }
        bool IsDeleted { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(IRole obj);
        
        #endregion

    }

}
