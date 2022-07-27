﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:47
// Description   : ICustomerAdditionalInfo partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'ICustomerAdditionalInfo.cs'
//       up to one level of this file location inside 'CustomerAdditionalInfo' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface ICustomerAdditionalInfo
    {                
        
        #region Properties
        
        System.Guid CustomerID { get; set; }
        string Info1 { get; set; }
        string Info2 { get; set; }
        string Info3 { get; set; }
        string Info4 { get; set; }
        string Info5 { get; set; }
        string Info6 { get; set; }
        string Info7 { get; set; }
        string Info8 { get; set; }
        string Info9 { get; set; }
        string Info10 { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(ICustomerAdditionalInfo obj);
        
        #endregion

    }

}
