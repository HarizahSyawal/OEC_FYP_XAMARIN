﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:45
// Description   : City partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'City.cs'
//       up to one level of this file location inside 'City' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class City : ICity
    {                
        
        #region Implements ICity

        public int ID { get; set; }            
        public string Code { get; set; }            
        public string Name { get; set; }            
        public int StateProvinceID { get; set; }            
        public int StatusID { get; set; }            
        public System.DateTime CreatedDate { get; set; }            
        public int? CreatedByUserID { get; set; }            
        public System.DateTime? ModifiedDate { get; set; }            
        public int? ModifiedByUserID { get; set; }            
        public bool IsDeleted { get; set; }            

        
        
        public void CopyFrom(ICity obj)
        {
            ID = obj.ID;
            Code = obj.Code;
            Name = obj.Name;
            StateProvinceID = obj.StateProvinceID;
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
