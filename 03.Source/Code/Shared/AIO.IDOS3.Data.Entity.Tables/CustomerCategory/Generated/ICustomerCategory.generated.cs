// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:48
// Description   : ICustomerCategory partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'ICustomerCategory.cs'
//       up to one level of this file location inside 'CustomerCategory' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface ICustomerCategory
    {                
        
        #region Properties
        
        int ID { get; set; }
        string Code { get; set; }
        string Name { get; set; }
        int? ParentID { get; set; }
        string Group { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }
        bool IsDeleted { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(ICustomerCategory obj);
        
        #endregion

    }

}
