﻿// ===================================================================================
// Author        : System
// Created date  : 23 Nov 2020 04:14:46
// Description   : mvUserDeviceHubConnectionSyncProvider partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'mvUserDeviceHubConnectionSyncProvider.cs'
//       up to one level of this file location inside 'vUserDeviceHubConnection' folder.
// ===================================================================================

using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{

    public partial class mvUserDeviceHubConnectionSyncProvider : DataSyncProvider<mvUserDeviceHubConnection>
    {

        #region Constructors

        public mvUserDeviceHubConnectionSyncProvider(CoreDbContext dbContext, CoreDataServiceContext dataServiceContext)
            : base(dbContext, dataServiceContext)
        {
        
        }

        #endregion

    }

}