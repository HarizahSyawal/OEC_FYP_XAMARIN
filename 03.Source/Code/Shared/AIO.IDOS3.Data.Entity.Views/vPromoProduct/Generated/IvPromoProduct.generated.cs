﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:17
// Description   : IvPromoProduct partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IvPromoProduct.cs'
//       up to one level of this file location inside 'vPromoProduct' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IvPromoProduct
    {                
        
        #region Properties
        
        int ID { get; set; }
        string Code { get; set; }
        int ProductID { get; set; }
        string ProductCode { get; set; }
        string ProductName { get; set; }
        string Product { get; set; }
        int ProductBrandID { get; set; }
        string ProductBrandCode { get; set; }
        string ProductBrandName { get; set; }
        string ProductBrand { get; set; }
        string ProductShortName { get; set; }
        int? ProductUOMLID { get; set; }
        int? ProductUOMMID { get; set; }
        int? ProductUOMSID { get; set; }
        string ProductUOMLName { get; set; }
        string ProductUOMMName { get; set; }
        string ProductUOMSName { get; set; }
        double ProductWeight { get; set; }
        int? ProductDimensionL { get; set; }
        int? ProductDimensionW { get; set; }
        int? ProductDimensionH { get; set; }
        int? ProductConversionL { get; set; }
        int? ProductConversionM { get; set; }
        int? ProductConversionS { get; set; }
        int ProductStatusID { get; set; }
        string ProductStatusName { get; set; }
        string ProductAdditionalInfo1 { get; set; }
        string ProductAdditionalInfo2 { get; set; }
        string ProductAdditionalInfo3 { get; set; }
        string ProductAdditionalInfo4 { get; set; }
        string ProductAdditionalInfo5 { get; set; }
        string ProductAdditionalInfo6 { get; set; }
        string ProductAdditionalInfo7 { get; set; }
        string ProductAdditionalInfo8 { get; set; }
        string ProductAdditionalInfo9 { get; set; }
        string ProductAdditionalInfo10 { get; set; }
        System.DateTime? ValidDateFrom { get; set; }
        System.DateTime? ValidDateTo { get; set; }
        int TermOfPaymentID { get; set; }
        string TermOfPaymentName { get; set; }
        int StatusID { get; set; }
        string StatusName { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        string CreatedByUserName { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }
        string ModifiedByUserName { get; set; }
        bool IsDeleted { get; set; }

        #endregion

        #region Methods
        
        void CopyFrom(IvPromoProduct obj);
        
        #endregion
        
    }

}
