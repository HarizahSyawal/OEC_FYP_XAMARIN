// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:59
// Description   : SiteAccounting partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'SiteAccounting.cs'
//       up to one level of this file location inside 'SiteAccounting' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class SiteAccounting : ISiteAccounting
    {                
        
        #region Implements ISiteAccounting

        public System.Guid SiteID { get; set; }            
        public string GLAccountCode { get; set; }            
        public string ProfitCenterCode { get; set; }            
        public string CostCenterCode { get; set; }            

        
        
        public void CopyFrom(ISiteAccounting obj)
        {
            SiteID = obj.SiteID;
            GLAccountCode = obj.GLAccountCode;
            ProfitCenterCode = obj.ProfitCenterCode;
            CostCenterCode = obj.CostCenterCode;
        }
        
        #endregion
        
    }

}
