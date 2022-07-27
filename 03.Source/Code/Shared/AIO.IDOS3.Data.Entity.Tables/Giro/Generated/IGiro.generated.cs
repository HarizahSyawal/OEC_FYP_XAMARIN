﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:50
// Description   : IGiro partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IGiro.cs'
//       up to one level of this file location inside 'Giro' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IGiro
    {                
        
        #region Properties
        
        System.Guid ID { get; set; }
        int BankID { get; set; }
        string Code { get; set; }
        string CurrentAccountCode { get; set; }
        string CurrentAccountName { get; set; }
        System.DateTime ReceivedDate { get; set; }
        System.DateTime IssuedDate { get; set; }
        System.Guid? IssuedByCustomerBillGroupID { get; set; }
        System.Guid? IssuedByCustomerID { get; set; }
        bool IsCheque { get; set; }
        System.DateTime EffectiveDateFrom { get; set; }
        System.DateTime EffectiveDateTo { get; set; }
        double Amount { get; set; }
        int IncomingAccountID { get; set; }
        string Remarks { get; set; }
        System.Guid? PCDocumentID { get; set; }
        int StatusID { get; set; }
        System.DateTime? ClearingDate { get; set; }
        string Photo { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }
        bool IsDeleted { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(IGiro obj);
        
        #endregion

    }

}
