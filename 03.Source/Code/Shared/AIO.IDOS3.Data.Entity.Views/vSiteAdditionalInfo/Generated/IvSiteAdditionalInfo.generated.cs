﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:30
// Description   : IvSiteAdditionalInfo partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IvSiteAdditionalInfo.cs'
//       up to one level of this file location inside 'vSiteAdditionalInfo' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IvSiteAdditionalInfo
    {                
        
        #region Properties
        
        System.Guid SiteID { get; set; }
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
        
        void CopyFrom(IvSiteAdditionalInfo obj);
        
        #endregion
        
    }

}