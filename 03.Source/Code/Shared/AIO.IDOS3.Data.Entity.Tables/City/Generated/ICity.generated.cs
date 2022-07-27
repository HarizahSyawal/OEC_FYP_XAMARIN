﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:45
// Description   : ICity partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'ICity.cs'
//       up to one level of this file location inside 'City' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface ICity
    {                
        
        #region Properties
        
        int ID { get; set; }
        string Code { get; set; }
        string Name { get; set; }
        int StateProvinceID { get; set; }
        int StatusID { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }
        bool IsDeleted { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(ICity obj);
        
        #endregion

    }

}