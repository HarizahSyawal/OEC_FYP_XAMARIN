﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:46
// Description   : Currency partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'Currency.cs'
//       up to one level of this file location inside 'Currency' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class Currency : ICurrency
    {                
        
        #region Implements ICurrency

        public string ID { get; set; }            
        public string Name { get; set; }            
        public string Numeric3Code { get; set; }            
        public int DecimalDigit { get; set; }            
        public int StatusID { get; set; }            
        public System.DateTime? ModifiedDate { get; set; }            
        public int? ModifiedByUserID { get; set; }            

        
        
        public void CopyFrom(ICurrency obj)
        {
            ID = obj.ID;
            Name = obj.Name;
            Numeric3Code = obj.Numeric3Code;
            DecimalDigit = obj.DecimalDigit;
            StatusID = obj.StatusID;
            ModifiedDate = obj.ModifiedDate;
            ModifiedByUserID = obj.ModifiedByUserID;
        }
        
        #endregion
        
    }

}
