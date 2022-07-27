﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:54
// Description   : Role partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'Role.cs'
//       up to one level of this file location inside 'Role' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class Role : IRole
    {                
        
        #region Implements IRole

        public int ID { get; set; }            
        public string Name { get; set; }            
        public string Description { get; set; }            
        public int StatusID { get; set; }            
        public System.DateTime CreatedDate { get; set; }            
        public int? CreatedByUserID { get; set; }            
        public System.DateTime? ModifiedDate { get; set; }            
        public int? ModifiedByUserID { get; set; }            
        public bool IsDeleted { get; set; }            

        
        
        public void CopyFrom(IRole obj)
        {
            ID = obj.ID;
            Name = obj.Name;
            Description = obj.Description;
            StatusID = obj.StatusID;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
            ModifiedDate = obj.ModifiedDate;
            ModifiedByUserID = obj.ModifiedByUserID;
            IsDeleted = obj.IsDeleted;
        }
        
        #endregion
        
    }

}