// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:35:42
// Description   : IvBankStatementTransaction partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IvBankStatementTransaction.cs'
//       up to one level of this file location inside 'vBankStatementTransaction' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IvBankStatementTransaction
    {                
        
        #region Properties
        
        System.Guid TransactionID { get; set; }
        System.DateTime TransactionDate { get; set; }
        System.Guid BankStatementID { get; set; }
        string HolderCode { get; set; }
        string HolderName { get; set; }
        string Holder { get; set; }
        System.Guid? PICID { get; set; }
        string PICCode { get; set; }
        string PICName { get; set; }
        string PIC { get; set; }
        int? HolderTypeID { get; set; }
        string HolderTypeName { get; set; }
        System.Guid? RefDocumentID { get; set; }
        string RefDocumentCode { get; set; }
        System.DateTime? RefTransactionDate { get; set; }
        int RefTransactionTypeID { get; set; }
        string RefTransactionTypeName { get; set; }
        double TransactionAmount { get; set; }
        double AvailableAmount { get; set; }
        double ReservedAmount { get; set; }

        #endregion

        #region Methods
        
        void CopyFrom(IvBankStatementTransaction obj);
        
        #endregion
        
    }

}
