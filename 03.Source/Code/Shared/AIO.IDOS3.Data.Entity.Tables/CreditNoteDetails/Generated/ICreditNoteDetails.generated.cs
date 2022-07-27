﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:46
// Description   : ICreditNoteDetails partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'ICreditNoteDetails.cs'
//       up to one level of this file location inside 'CreditNoteDetails' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface ICreditNoteDetails
    {                
        
        #region Properties
        
        System.Guid DocumentID { get; set; }
        System.Guid InvoiceDocumentID { get; set; }
        double AllocationAmount { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(ICreditNoteDetails obj);
        
        #endregion

    }

}