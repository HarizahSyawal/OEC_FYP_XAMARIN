﻿// ===================================================================================
// Author        : System
// Created date  : 03 Sep 2020 02:32:37
// Description   : mvAuthorizationSyncProvider partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'mvAuthorizationSyncProvider.cs'
//       up to one level of this file location inside 'vAuthorization' folder.
// ===================================================================================

using Wismapi.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public partial class mvAuthorizationSyncProvider : DataSyncProvider<mvAuthorization>
    {

        #region Constructors

        public mvAuthorizationSyncProvider(CoreDbContext dbContext, CoreDataServiceContext dataServiceContext)
            : base(dbContext, dataServiceContext)
        {
        
        }

        #endregion

    }

}
