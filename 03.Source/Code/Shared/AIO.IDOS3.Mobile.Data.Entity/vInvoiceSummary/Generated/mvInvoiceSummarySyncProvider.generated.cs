// ===================================================================================
// Author        : System
// Created date  : 09 Oct 2020 07:17:55
// Description   : mvInvoiceSummarySyncProvider partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'mvInvoiceSummarySyncProvider.cs'
//       up to one level of this file location inside 'vInvoiceSummary' folder.
// ===================================================================================

using Wismapi.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public partial class mvInvoiceSummarySyncProvider : DataSyncProvider<mvInvoiceSummary>
    {

        #region Constructors

        public mvInvoiceSummarySyncProvider(CoreDbContext dbContext, CoreDataServiceContext dataServiceContext)
            : base(dbContext, dataServiceContext)
        {
        
        }

        #endregion

    }

}
