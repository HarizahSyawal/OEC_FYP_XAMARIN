﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:35:50
// Description   : vCompanyTaxAddress partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vCompanyTaxAddress.cs'
//       up to one level of this file location inside 'vCompanyTaxAddress' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vCompanyTaxAddress : BaseEntityType, IvCompanyTaxAddress
    {                
        
        #region Implements IvCompanyTaxAddress

        public int CompanyID { get; set; }
        public string ContactPerson { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address { get; set; }
        public int? CityID { get; set; }
        public string City { get; set; }
        public int? StateProvinceID { get; set; }
        public string StateProvince { get; set; }
        public string CountryID { get; set; }
        public string CountryName { get; set; }
        public string ZipCode { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        
        
        
        public void CopyFrom(IvCompanyTaxAddress obj)
        {
            CompanyID = obj.CompanyID;
            ContactPerson = obj.ContactPerson;
            Address1 = obj.Address1;
            Address2 = obj.Address2;
            Address3 = obj.Address3;
            Address = obj.Address;
            CityID = obj.CityID;
            City = obj.City;
            StateProvinceID = obj.StateProvinceID;
            StateProvince = obj.StateProvince;
            CountryID = obj.CountryID;
            CountryName = obj.CountryName;
            ZipCode = obj.ZipCode;
            Phone1 = obj.Phone1;
            Phone2 = obj.Phone2;
            Phone3 = obj.Phone3;
            Fax = obj.Fax;
            Email = obj.Email;
            Longitude = obj.Longitude;
            Latitude = obj.Latitude;
        }
        
        #endregion

    }

}
