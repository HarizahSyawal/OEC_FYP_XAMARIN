// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 01:01:48
// Description   : mvCustomerSyncProvider partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'mvCustomerSyncProvider.cs'
//       up to one level of this file location inside 'vCustomer' folder.
// ===================================================================================

using Wismapi.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public partial class mvCustomerSyncProvider : DataSyncProvider<mvCustomer>
    {

        #region Constructors

        public mvCustomerSyncProvider(CoreDbContext dbContext, CoreDataServiceContext dataServiceContext)
            : base(dbContext, dataServiceContext)
        {
        
        }

        #endregion

    }

}
