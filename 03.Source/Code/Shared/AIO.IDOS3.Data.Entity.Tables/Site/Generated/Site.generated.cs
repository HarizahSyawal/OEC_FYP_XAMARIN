﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:59
// Description   : Site partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'Site.cs'
//       up to one level of this file location inside 'Site' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class Site : ISite
    {                
        
        #region Implements ISite

        public System.Guid ID { get; set; }            
        public string Code { get; set; }            
        public string Name { get; set; }            
        public int AreaID { get; set; }            
        public int CompanyID { get; set; }            
        public int DistributionTypeID { get; set; }            
        public bool IsProductLotCodeEntryRequired { get; set; }            
        public string TaxIDNumber { get; set; }            
        public string TaxIDName { get; set; }            
        public bool IsVATEnterpriseRegistered { get; set; }            
        public string VATEnterpriseRegistrationNumber { get; set; }            
        public System.DateTime? VATEnterpriseRegisteredDate { get; set; }            
        public bool IsTaxAddressSameAsAddress { get; set; }            
        public int StatusID { get; set; }            
        public string SAPCode { get; set; }            
        public System.DateTime CreatedDate { get; set; }            
        public int? CreatedByUserID { get; set; }            
        public System.DateTime? ModifiedDate { get; set; }            
        public int? ModifiedByUserID { get; set; }            
        public bool IsDeleted { get; set; }            

        
        
        public void CopyFrom(ISite obj)
        {
            ID = obj.ID;
            Code = obj.Code;
            Name = obj.Name;
            AreaID = obj.AreaID;
            CompanyID = obj.CompanyID;
            DistributionTypeID = obj.DistributionTypeID;
            IsProductLotCodeEntryRequired = obj.IsProductLotCodeEntryRequired;
            TaxIDNumber = obj.TaxIDNumber;
            TaxIDName = obj.TaxIDName;
            IsVATEnterpriseRegistered = obj.IsVATEnterpriseRegistered;
            VATEnterpriseRegistrationNumber = obj.VATEnterpriseRegistrationNumber;
            VATEnterpriseRegisteredDate = obj.VATEnterpriseRegisteredDate;
            IsTaxAddressSameAsAddress = obj.IsTaxAddressSameAsAddress;
            StatusID = obj.StatusID;
            SAPCode = obj.SAPCode;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
            ModifiedDate = obj.ModifiedDate;
            ModifiedByUserID = obj.ModifiedByUserID;
            IsDeleted = obj.IsDeleted;
        }
        
        #endregion
        
    }

}