﻿// ===================================================================================
// Author        : System
// Created date  : 02 Nov 2020 02:02:30
// Description   : mvMobileDeviceSettingsSyncProvider partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'mvMobileDeviceSettingsSyncProvider.cs'
//       up to one level of this file location inside 'vMobileDeviceSettings' folder.
// ===================================================================================

using Wismapi.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public partial class mvMobileDeviceSettingsSyncProvider : DataSyncProvider<mvMobileDeviceSettings>
    {

        #region Constructors

        public mvMobileDeviceSettingsSyncProvider(CoreDbContext dbContext, CoreDataServiceContext dataServiceContext)
            : base(dbContext, dataServiceContext)
        {
        
        }

        #endregion

    }

}
