// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:51
// Description   : IInvoiceAccountReceivable partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IInvoiceAccountReceivable.cs'
//       up to one level of this file location inside 'InvoiceAccountReceivable' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IInvoiceAccountReceivable
    {                
        
        #region Properties
        
        System.Guid InvoiceDocumentID { get; set; }
        double RawTotalAmount { get; set; }
        double RawPaidAmount { get; set; }
        double RawOutstandingAmount { get; set; }
        double TotalAmount { get; set; }
        double PaidAmount { get; set; }
        double OutstandingAmount { get; set; }
        double PendingPaymentAmount { get; set; }
        int StatusID { get; set; }
        System.DateTime? SettledDate { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(IInvoiceAccountReceivable obj);
        
        #endregion

    }

}
