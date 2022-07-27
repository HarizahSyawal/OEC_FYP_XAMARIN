﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:45
// Description   : CompanyAdditionalInfo partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'CompanyAdditionalInfo.cs'
//       up to one level of this file location inside 'CompanyAdditionalInfo' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class CompanyAdditionalInfo : ICompanyAdditionalInfo
    {                
        
        #region Implements ICompanyAdditionalInfo

        public int CompanyID { get; set; }            
        public string Info1 { get; set; }            
        public string Info2 { get; set; }            
        public string Info3 { get; set; }            
        public string Info4 { get; set; }            
        public string Info5 { get; set; }            
        public string Info6 { get; set; }            
        public string Info7 { get; set; }            
        public string Info8 { get; set; }            
        public string Info9 { get; set; }            
        public string Info10 { get; set; }            

        
        
        public void CopyFrom(ICompanyAdditionalInfo obj)
        {
            CompanyID = obj.CompanyID;
            Info1 = obj.Info1;
            Info2 = obj.Info2;
            Info3 = obj.Info3;
            Info4 = obj.Info4;
            Info5 = obj.Info5;
            Info6 = obj.Info6;
            Info7 = obj.Info7;
            Info8 = obj.Info8;
            Info9 = obj.Info9;
            Info10 = obj.Info10;
        }
        
        #endregion
        
    }

}
