// ===================================================================================
// Author        : System
// Created date  : 24 Sep 2020 03:19:45
// Description   : SalesPromotion partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'SalesPromotion.cs'
//       up to one level of this file location inside 'SalesPromotion' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class SalesPromotion : ISalesPromotion
    {                
        
        #region Implements ISalesPromotion

        public int ID { get; set; }            
        public string Code { get; set; }            
        public string Name { get; set; }            
        public System.DateTime? ValidDateFrom { get; set; }            
        public System.DateTime? ValidDateTo { get; set; }            
        public int TermOfPaymentID { get; set; }            
        public int StatusID { get; set; }            
        public System.DateTime CreatedDate { get; set; }            
        public int? CreatedByUserID { get; set; }            
        public System.DateTime? ModifiedDate { get; set; }            
        public int? ModifiedByUserID { get; set; }            
        public bool IsDeleted { get; set; }            
        
        
        
        public void CopyFrom(ISalesPromotion obj)
        {
            ID = obj.ID;
            Code = obj.Code;
            Name = obj.Name;
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
