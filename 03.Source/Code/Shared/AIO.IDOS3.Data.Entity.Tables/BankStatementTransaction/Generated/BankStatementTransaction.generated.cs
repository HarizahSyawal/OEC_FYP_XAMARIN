// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:44
// Description   : BankStatementTransaction partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'BankStatementTransaction.cs'
//       up to one level of this file location inside 'BankStatementTransaction' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class BankStatementTransaction : IBankStatementTransaction
    {                
        
        #region Implements IBankStatementTransaction

        public System.Guid TransactionID { get; set; }            
        public System.DateTime TransactionDate { get; set; }            
        public System.Guid BankStatementID { get; set; }            
        public int RefTransactionTypeID { get; set; }            
        public System.Guid? RefDocumentID { get; set; }            
        public double TransactionAmount { get; set; }            
        public double AvailableAmount { get; set; }            
        public double ReservedAmount { get; set; }            

        
        
        public void CopyFrom(IBankStatementTransaction obj)
        {
            TransactionID = obj.TransactionID;
            TransactionDate = obj.TransactionDate;
            BankStatementID = obj.BankStatementID;
            RefTransactionTypeID = obj.RefTransactionTypeID;
            RefDocumentID = obj.RefDocumentID;
            TransactionAmount = obj.TransactionAmount;
            AvailableAmount = obj.AvailableAmount;
            ReservedAmount = obj.ReservedAmount;
        }
        
        #endregion
        
    }

}
