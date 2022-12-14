// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:53
// Description   : PromoProduct partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'PromoProduct.cs'
//       up to one level of this file location inside 'PromoProduct' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class PromoProduct : IPromoProduct
    {                
        
        #region Implements IPromoProduct

        public int ID { get; set; }            
        public string Code { get; set; }            
        public int ProductID { get; set; }            
        public System.DateTime? ValidDateFrom { get; set; }            
        public System.DateTime? ValidDateTo { get; set; }            
        public int TermOfPaymentID { get; set; }            
        public int StatusID { get; set; }            
        public System.DateTime CreatedDate { get; set; }            
        public int? CreatedByUserID { get; set; }            
        public System.DateTime? ModifiedDate { get; set; }            
        public int? ModifiedByUserID { get; set; }            
        public bool IsDeleted { get; set; }            

        
        
        public void CopyFrom(IPromoProduct obj)
        {
            ID = obj.ID;
            Code = obj.Code;
            ProductID = obj.ProductID;
            ValidDateFrom = obj.ValidDateFrom;
            ValidDateTo = obj.ValidDateTo;
            TermOfPaymentID = obj.TermOfPaymentID;
            StatusID = obj.StatusID;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
            ModifiedDate = obj.ModifiedDate;
            ModifiedByUserID = obj.ModifiedByUserID;
            IsDeleted = obj.IsDeleted;
        }
        
        #endregion
        
    }

}
