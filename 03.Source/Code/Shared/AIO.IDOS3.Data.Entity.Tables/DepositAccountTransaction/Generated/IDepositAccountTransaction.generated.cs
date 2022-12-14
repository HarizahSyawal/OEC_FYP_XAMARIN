// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:49
// Description   : IDepositAccountTransaction partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IDepositAccountTransaction.cs'
//       up to one level of this file location inside 'DepositAccountTransaction' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IDepositAccountTransaction
    {                
        
        #region Properties
        
        System.Guid AccountID { get; set; }
        System.DateTime TransactionDateID { get; set; }
        int AccountTypeID { get; set; }
        int TransactionTypeID { get; set; }
        System.Guid? RefDocumentID { get; set; }
        double TransactionAmount { get; set; }
        double AvailableBalanceAmount { get; set; }
        double ReservedBalanceAmount { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(IDepositAccountTransaction obj);
        
        #endregion

    }

}
