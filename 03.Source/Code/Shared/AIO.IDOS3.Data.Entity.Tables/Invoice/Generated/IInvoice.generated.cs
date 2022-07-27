﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:50
// Description   : IInvoice partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IInvoice.cs'
//       up to one level of this file location inside 'Invoice' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IInvoice
    {                
        
        #region Properties
        
        System.Guid DocumentID { get; set; }
        string DocumentCode { get; set; }
        System.DateTime TransactionDate { get; set; }
        System.Guid RefDocumentID { get; set; }
        int RefTransactionTypeID { get; set; }
        System.DateTime? DueDate { get; set; }
        System.Guid? BARSDocumentID { get; set; }
        System.Guid? OpnameDocumentID { get; set; }
        int PrintCount { get; set; }
        System.DateTime? LastPrintedDate { get; set; }
        int DocumentStatusID { get; set; }
        System.DateTime? PostedDate { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(IInvoice obj);
        
        #endregion

    }

}
