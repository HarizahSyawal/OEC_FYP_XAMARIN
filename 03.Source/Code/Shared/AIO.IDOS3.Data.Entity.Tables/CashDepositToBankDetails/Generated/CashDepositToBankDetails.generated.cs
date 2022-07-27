﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:45
// Description   : CashDepositToBankDetails partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'CashDepositToBankDetails.cs'
//       up to one level of this file location inside 'CashDepositToBankDetails' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class CashDepositToBankDetails : ICashDepositToBankDetails
    {                
        
        #region Implements ICashDepositToBankDetails

        public System.Guid DocumentID { get; set; }            
        public System.Guid CDRDocumentID { get; set; }            
        public double RawCollectedAmount { get; set; }            
        public double CollectedAmount { get; set; }            
        public double DepositAmount { get; set; }            

        
        
        public void CopyFrom(ICashDepositToBankDetails obj)
        {
            DocumentID = obj.DocumentID;
            CDRDocumentID = obj.CDRDocumentID;
            RawCollectedAmount = obj.RawCollectedAmount;
            CollectedAmount = obj.CollectedAmount;
            DepositAmount = obj.DepositAmount;
        }
        
        #endregion
        
    }

}
