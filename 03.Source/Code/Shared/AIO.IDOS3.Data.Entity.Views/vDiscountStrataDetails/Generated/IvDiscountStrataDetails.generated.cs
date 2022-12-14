// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:01
// Description   : IvDiscountStrataDetails partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IvDiscountStrataDetails.cs'
//       up to one level of this file location inside 'vDiscountStrataDetails' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IvDiscountStrataDetails
    {                
        
        #region Properties
        
        int ID { get; set; }
        int StrataID { get; set; }
        double? Minimum { get; set; }
        double? Maximum { get; set; }
        double? DiscountPercentage { get; set; }

        #endregion

        #region Methods
        
        void CopyFrom(IvDiscountStrataDetails obj);
        
        #endregion
        
    }

}
