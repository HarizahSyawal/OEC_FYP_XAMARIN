// ===================================================================================
// Author        : System
// Created date  : 15 Sep 2020 03:27:01
// Description   : mvSalesOrderSwapDetailsSyncProvider partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'mvSalesOrderSwapDetailsSyncProvider.cs'
//       up to one level of this file location inside 'vSalesOrderSwapDetails' folder.
// ===================================================================================

using Wismapi.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public partial class mvSalesOrderSwapDetailsSyncProvider : DataSyncProvider<mvSalesOrderSwapDetails>
    {

        #region Constructors

        public mvSalesOrderSwapDetailsSyncProvider(CoreDbContext dbContext, CoreDataServiceContext dataServiceContext)
            : base(dbContext, dataServiceContext)
        {
        
        }

        #endregion

    }

}
