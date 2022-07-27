﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:50
// Description   : IEmployeeAddress partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IEmployeeAddress.cs'
//       up to one level of this file location inside 'EmployeeAddress' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IEmployeeAddress
    {                
        
        #region Properties
        
        System.Guid EmployeeID { get; set; }
        string Address1 { get; set; }
        string Address2 { get; set; }
        string City { get; set; }
        string StateProvince { get; set; }
        string CountryID { get; set; }
        string ZipCode { get; set; }
        string Phone1 { get; set; }
        string Phone2 { get; set; }
        string Email { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(IEmployeeAddress obj);
        
        #endregion

    }

}
