﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:54
// Description   : Salesman partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'Salesman.cs'
//       up to one level of this file location inside 'Salesman' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class Salesman : ISalesman
    {                
        
        #region Implements ISalesman

        public System.Guid ID { get; set; }            
        public string Code { get; set; }            
        public string Name { get; set; }            
        public System.Guid WarehouseID { get; set; }            
        public int GroupID { get; set; }            
        public int CategoryID { get; set; }            
        public System.Guid? EmployeeID { get; set; }            
        public string Phone { get; set; }            
        public bool? IsSFAMobile { get; set; }            
        public string SFAMobilePassword { get; set; }            
        public int StatusID { get; set; }            
        public System.DateTime CreatedDate { get; set; }            
        public int? CreatedByUserID { get; set; }            
        public System.DateTime? ModifiedDate { get; set; }            
        public int? ModifiedByUserID { get; set; }            
        public bool IsDeleted { get; set; }            

        
        
        public void CopyFrom(ISalesman obj)
        {
            ID = obj.ID;
            Code = obj.Code;
            Name = obj.Name;
            WarehouseID = obj.WarehouseID;
            GroupID = obj.GroupID;
            CategoryID = obj.CategoryID;
            EmployeeID = obj.EmployeeID;
            Phone = obj.Phone;
            IsSFAMobile = obj.IsSFAMobile;
            SFAMobilePassword = obj.SFAMobilePassword;
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
