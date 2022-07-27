﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:46
// Description   : Country partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'Country.cs'
//       up to one level of this file location inside 'Country' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class Country : ICountry
    {                
        
        #region Implements ICountry

        public string ID { get; set; }            
        public string Name { get; set; }            
        public string Alpha3Code { get; set; }            
        public string DialCode { get; set; }            
        public int StatusID { get; set; }            
        public System.DateTime? ModifiedDate { get; set; }            
        public int? ModifiedByUserID { get; set; }            

        
        
        public void CopyFrom(ICountry obj)
        {
            ID = obj.ID;
            Name = obj.Name;
            Alpha3Code = obj.Alpha3Code;
            DialCode = obj.DialCode;
            StatusID = obj.StatusID;
            ModifiedDate = obj.ModifiedDate;
            ModifiedByUserID = obj.ModifiedByUserID;
        }
        
        #endregion
        
    }

}