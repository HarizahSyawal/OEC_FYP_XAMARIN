// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:29
// Description   : vSiteAccounting partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vSiteAccounting.cs'
//       up to one level of this file location inside 'vSiteAccounting' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vSiteAccounting : BaseEntityType, IvSiteAccounting
    {                
        
        #region Implements IvSiteAccounting

        public System.Guid SiteID { get; set; }
        public string GLAccountCode { get; set; }
        public string ProfitCenterCode { get; set; }
        public string CostCenterCode { get; set; }
        
        
        
        public void CopyFrom(IvSiteAccounting obj)
        {
            SiteID = obj.SiteID;
            GLAccountCode = obj.GLAccountCode;
            ProfitCenterCode = obj.ProfitCenterCode;
            CostCenterCode = obj.CostCenterCode;
        }
        
        #endregion

    }

}
