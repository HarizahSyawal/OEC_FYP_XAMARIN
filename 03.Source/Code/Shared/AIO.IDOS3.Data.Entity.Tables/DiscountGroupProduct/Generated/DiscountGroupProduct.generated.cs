﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:49
// Description   : DiscountGroupProduct partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'DiscountGroupProduct.cs'
//       up to one level of this file location inside 'DiscountGroupProduct' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class DiscountGroupProduct : IDiscountGroupProduct
    {                
        
        #region Implements IDiscountGroupProduct

        public int DiscountGroupID { get; set; }            
        public int ProductID { get; set; }            
        public int? DiscountStrata1ID { get; set; }            
        public int? DiscountStrata2ID { get; set; }            
        public int? DiscountStrata3ID { get; set; }            
        public int? DiscountStrata4ID { get; set; }            
        public int? DiscountStrata5ID { get; set; }            

        
        
        public void CopyFrom(IDiscountGroupProduct obj)
        {
            DiscountGroupID = obj.DiscountGroupID;
            ProductID = obj.ProductID;
            DiscountStrata1ID = obj.DiscountStrata1ID;
            DiscountStrata2ID = obj.DiscountStrata2ID;
            DiscountStrata3ID = obj.DiscountStrata3ID;
            DiscountStrata4ID = obj.DiscountStrata4ID;
            DiscountStrata5ID = obj.DiscountStrata5ID;
        }
        
        #endregion
        
    }

}