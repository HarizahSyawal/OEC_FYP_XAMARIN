﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:51
// Description   : IOrganizationUnit partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IOrganizationUnit.cs'
//       up to one level of this file location inside 'OrganizationUnit' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IOrganizationUnit
    {                
        
        #region Properties
        
        int ID { get; set; }
        string Code { get; set; }
        string Name { get; set; }
        bool IsHeadOffice { get; set; }
        System.Guid? SiteID { get; set; }
        int? ParentID { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }
        bool IsDeleted { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(IOrganizationUnit obj);
        
        #endregion

    }

}