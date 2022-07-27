﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:53
// Description   : Region partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'Region.cs'
//       up to one level of this file location inside 'Region' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class Region : IRegion
    {                
        
        #region Implements IRegion

        public int ID { get; set; }            
        public string Code { get; set; }            
        public string Name { get; set; }            
        public int? TerritoryID { get; set; }            
        public System.DateTime CreatedDate { get; set; }            
        public int? CreatedByUserID { get; set; }            
        public System.DateTime? ModifiedDate { get; set; }            
        public int? ModifiedByUserID { get; set; }            
        public bool IsDeleted { get; set; }            

        
        
        public void CopyFrom(IRegion obj)
        {
            ID = obj.ID;
            Code = obj.Code;
            Name = obj.Name;
            TerritoryID = obj.TerritoryID;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
            ModifiedDate = obj.ModifiedDate;
            ModifiedByUserID = obj.ModifiedByUserID;
            IsDeleted = obj.IsDeleted;
        }
        
        #endregion
        
    }

}