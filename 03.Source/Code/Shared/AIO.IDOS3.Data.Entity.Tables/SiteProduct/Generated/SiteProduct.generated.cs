// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:28:00
// Description   : SiteProduct partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'SiteProduct.cs'
//       up to one level of this file location inside 'SiteProduct' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class SiteProduct : ISiteProduct
    {                
        
        #region Implements ISiteProduct

        public System.Guid SiteID { get; set; }            
        public int ProductID { get; set; }            

        
        
        public void CopyFrom(ISiteProduct obj)
        {
            SiteID = obj.SiteID;
            ProductID = obj.ProductID;
        }
        
        #endregion
        
    }

}
