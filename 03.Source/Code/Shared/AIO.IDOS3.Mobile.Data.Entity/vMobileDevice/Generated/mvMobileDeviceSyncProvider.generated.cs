// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 01:01:49
// Description   : mvMobileDeviceSyncProvider partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'mvMobileDeviceSyncProvider.cs'
//       up to one level of this file location inside 'vMobileDevice' folder.
// ===================================================================================

using Wismapi.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public partial class mvMobileDeviceSyncProvider : DataSyncProvider<mvMobileDevice>
    {

        #region Constructors

        public mvMobileDeviceSyncProvider(CoreDbContext dbContext, CoreDataServiceContext dataServiceContext)
            : base(dbContext, dataServiceContext)
        {

        }

        #endregion

    }

}
