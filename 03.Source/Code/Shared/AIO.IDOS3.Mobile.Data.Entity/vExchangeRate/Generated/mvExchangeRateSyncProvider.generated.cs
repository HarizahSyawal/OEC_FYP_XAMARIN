﻿// ===================================================================================
// Author        : System
// Created date  : 08 Oct 2020 05:23:00
// Description   : mvExchangeRateSyncProvider partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'mvExchangeRateSyncProvider.cs'
//       up to one level of this file location inside 'vExchangeRate' folder.
// ===================================================================================

using Wismapi.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public partial class mvExchangeRateSyncProvider : DataSyncProvider<mvExchangeRate>
    {

        #region Constructors

        public mvExchangeRateSyncProvider(CoreDbContext dbContext, CoreDataServiceContext dataServiceContext)
            : base(dbContext, dataServiceContext)
        {
        
        }

        #endregion

    }

}