﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:47
// Description   : ICustomerBillGroupAddress partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'ICustomerBillGroupAddress.cs'
//       up to one level of this file location inside 'CustomerBillGroupAddress' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface ICustomerBillGroupAddress
    {                
        
        #region Properties
        
        System.Guid CustomerBillGroupID { get; set; }
        string ContactPerson { get; set; }
        string Address1 { get; set; }
        string Address2 { get; set; }
        string Address3 { get; set; }
        int? CityID { get; set; }
        string City { get; set; }
        int? StateProvinceID { get; set; }
        string StateProvince { get; set; }
        string CountryID { get; set; }
        string ZipCode { get; set; }
        string Phone1 { get; set; }
        string Phone2 { get; set; }
        string Phone3 { get; set; }
        string Fax { get; set; }
        string Email { get; set; }
        double? Longitude { get; set; }
        double? Latitude { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(ICustomerBillGroupAddress obj);
        
        #endregion

    }

}
