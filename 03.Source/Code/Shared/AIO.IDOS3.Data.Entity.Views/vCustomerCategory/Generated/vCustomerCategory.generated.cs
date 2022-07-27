﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:35:56
// Description   : vCustomerCategory partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vCustomerCategory.cs'
//       up to one level of this file location inside 'vCustomerCategory' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vCustomerCategory : BaseEntityType, IvCustomerCategory
    {                
        
        #region Implements IvCustomerCategory

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int? ParentID { get; set; }
        public string ParentCode { get; set; }
        public string ParentName { get; set; }
        public string Parent { get; set; }
        public string Group { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int? CreatedByUserID { get; set; }
        public string CreatedByUserName { get; set; }
        public System.DateTime? ModifiedDate { get; set; }
        public int? ModifiedByUserID { get; set; }
        public string ModifiedByUserName { get; set; }
        public bool IsDeleted { get; set; }
        
        
        
        public void CopyFrom(IvCustomerCategory obj)
        {
            ID = obj.ID;
            Code = obj.Code;
            Name = obj.Name;
            Category = obj.Category;
            ParentID = obj.ParentID;
            ParentCode = obj.ParentCode;
            ParentName = obj.ParentName;
            Parent = obj.Parent;
            Group = obj.Group;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
            CreatedByUserName = obj.CreatedByUserName;
            ModifiedDate = obj.ModifiedDate;
            ModifiedByUserID = obj.ModifiedByUserID;
            ModifiedByUserName = obj.ModifiedByUserName;
            IsDeleted = obj.IsDeleted;
        }
        
        #endregion

    }

}