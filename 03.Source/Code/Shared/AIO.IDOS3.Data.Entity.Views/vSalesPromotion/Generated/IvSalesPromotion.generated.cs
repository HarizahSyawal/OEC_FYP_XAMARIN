// ===================================================================================
// Author        : System
// Created date  : 24 Sep 2020 03:22:09
// Description   : IvSalesPromotion partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IvSalesPromotion.cs'
//       up to one level of this file location inside 'vSalesPromotion' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IvSalesPromotion
    {                
        
        #region Properties
        
        int ID { get; set; }
        string Code { get; set; }
        string Name { get; set; }
        System.DateTime? ValidDateFrom { get; set; }
        System.DateTime? ValidDateTo { get; set; }
        int TermOfPaymentID { get; set; }
        string TermOfPaymentName { get; set; }
        int StatusID { get; set; }
        string StatusName { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        string CreatedByUserName { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }
        string ModifiedByUserName { get; set; }
        bool IsDeleted { get; set; }

        #endregion

        #region Methods
        
        void CopyFrom(IvSalesPromotion obj);
        
        #endregion
        
    }

}
