// ===================================================================================
// Author        : System
// Created date  : 24 Sep 2020 05:15:05
// Description   : mvSalesmanProductSyncProvider partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'mvSalesmanProductSyncProvider.cs'
//       up to one level of this file location inside 'vSalesmanProduct' folder.
// ===================================================================================

using Wismapi.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public partial class mvSalesmanProductSyncProvider : DataSyncProvider<mvSalesmanProduct>
    {

        #region Constructors

        public mvSalesmanProductSyncProvider(CoreDbContext dbContext, CoreDataServiceContext dataServiceContext)
            : base(dbContext, dataServiceContext)
        {
        
        }

        #endregion

    }

}
