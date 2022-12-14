// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:59
// Description   : ISite partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'ISite.cs'
//       up to one level of this file location inside 'Site' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface ISite
    {                
        
        #region Properties
        
        System.Guid ID { get; set; }
        string Code { get; set; }
        string Name { get; set; }
        int AreaID { get; set; }
        int CompanyID { get; set; }
        int DistributionTypeID { get; set; }
        bool IsProductLotCodeEntryRequired { get; set; }
        string TaxIDNumber { get; set; }
        string TaxIDName { get; set; }
        bool IsVATEnterpriseRegistered { get; set; }
        string VATEnterpriseRegistrationNumber { get; set; }
        System.DateTime? VATEnterpriseRegisteredDate { get; set; }
        bool IsTaxAddressSameAsAddress { get; set; }
        int StatusID { get; set; }
        string SAPCode { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }
        bool IsDeleted { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(ISite obj);
        
        #endregion

    }

}
