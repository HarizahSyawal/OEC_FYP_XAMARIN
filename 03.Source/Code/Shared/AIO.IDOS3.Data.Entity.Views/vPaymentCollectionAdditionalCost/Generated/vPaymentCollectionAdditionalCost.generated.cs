﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:11
// Description   : vPaymentCollectionAdditionalCost partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vPaymentCollectionAdditionalCost.cs'
//       up to one level of this file location inside 'vPaymentCollectionAdditionalCost' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vPaymentCollectionAdditionalCost : BaseEntityType, IvPaymentCollectionAdditionalCost
    {                
        
        #region Implements IvPaymentCollectionAdditionalCost

        public System.Guid PCDocumentID { get; set; }
        public double Cost1Amount { get; set; }
        public double Cost2Amount { get; set; }
        public double Cost3Amount { get; set; }
        public double Cost4Amount { get; set; }
        public double Cost5Amount { get; set; }
        public double Cost6Amount { get; set; }
        public double Cost7Amount { get; set; }
        public double Cost8Amount { get; set; }
        public double Cost9Amount { get; set; }
        public double Cost10Amount { get; set; }
        
        
        
        public void CopyFrom(IvPaymentCollectionAdditionalCost obj)
        {
            PCDocumentID = obj.PCDocumentID;
            Cost1Amount = obj.Cost1Amount;
            Cost2Amount = obj.Cost2Amount;
            Cost3Amount = obj.Cost3Amount;
            Cost4Amount = obj.Cost4Amount;
            Cost5Amount = obj.Cost5Amount;
            Cost6Amount = obj.Cost6Amount;
            Cost7Amount = obj.Cost7Amount;
            Cost8Amount = obj.Cost8Amount;
            Cost9Amount = obj.Cost9Amount;
            Cost10Amount = obj.Cost10Amount;
        }
        
        #endregion

    }

}
