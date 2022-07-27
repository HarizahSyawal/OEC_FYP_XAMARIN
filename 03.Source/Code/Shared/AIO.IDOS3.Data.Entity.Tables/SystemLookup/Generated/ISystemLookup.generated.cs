﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:28:08
// Description   : ISystemLookup partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'ISystemLookup.cs'
//       up to one level of this file location inside 'SystemLookup' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface ISystemLookup
    {                
        
        #region Properties
        
        int ID { get; set; }
        string Name { get; set; }
        bool? Value_Boolean { get; set; }
        int? Value_Int32 { get; set; }
        double? Value_Double { get; set; }
        string Value_String { get; set; }
        System.Guid? Value_Guid { get; set; }
        System.DateTime? Value_DateTime { get; set; }
        int? ParentID { get; set; }
        string Group { get; set; }
        int SortIndex { get; set; }
        bool IsActive { get; set; }
        bool? IsAuthorization { get; set; }
        System.DateTime CreatedDate { get; set; }
        System.DateTime? ModifiedDate { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(ISystemLookup obj);
        
        #endregion

    }

}
