// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:46
// Description   : ICreditNoteAdditionalCost partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'ICreditNoteAdditionalCost.cs'
//       up to one level of this file location inside 'CreditNoteAdditionalCost' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface ICreditNoteAdditionalCost
    {                
        
        #region Properties
        
        System.Guid CNDocumentID { get; set; }
        double Cost1Amount { get; set; }
        double Cost2Amount { get; set; }
        double Cost3Amount { get; set; }
        double Cost4Amount { get; set; }
        double Cost5Amount { get; set; }
        double Cost6Amount { get; set; }
        double Cost7Amount { get; set; }
        double Cost8Amount { get; set; }
        double Cost9Amount { get; set; }
        double Cost10Amount { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(ICreditNoteAdditionalCost obj);
        
        #endregion

    }

}
