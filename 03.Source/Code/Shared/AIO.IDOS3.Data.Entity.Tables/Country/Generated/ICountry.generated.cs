﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:46
// Description   : ICountry partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'ICountry.cs'
//       up to one level of this file location inside 'Country' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface ICountry
    {                
        
        #region Properties
        
        string ID { get; set; }
        string Name { get; set; }
        string Alpha3Code { get; set; }
        string DialCode { get; set; }
        int StatusID { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(ICountry obj);
        
        #endregion

    }

}
