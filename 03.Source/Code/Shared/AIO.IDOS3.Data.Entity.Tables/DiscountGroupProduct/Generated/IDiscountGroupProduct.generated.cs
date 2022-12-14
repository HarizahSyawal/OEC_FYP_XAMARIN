// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:49
// Description   : IDiscountGroupProduct partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IDiscountGroupProduct.cs'
//       up to one level of this file location inside 'DiscountGroupProduct' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IDiscountGroupProduct
    {                
        
        #region Properties
        
        int DiscountGroupID { get; set; }
        int ProductID { get; set; }
        int? DiscountStrata1ID { get; set; }
        int? DiscountStrata2ID { get; set; }
        int? DiscountStrata3ID { get; set; }
        int? DiscountStrata4ID { get; set; }
        int? DiscountStrata5ID { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(IDiscountGroupProduct obj);
        
        #endregion

    }

}
