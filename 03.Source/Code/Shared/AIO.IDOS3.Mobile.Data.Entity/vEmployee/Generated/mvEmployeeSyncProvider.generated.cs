﻿// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 01:01:49
// Description   : mvEmployeeSyncProvider partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'mvEmployeeSyncProvider.cs'
//       up to one level of this file location inside 'vEmployee' folder.
// ===================================================================================

using Wismapi.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public partial class mvEmployeeSyncProvider : DataSyncProvider<mvEmployee>
    {

        #region Constructors

        public mvEmployeeSyncProvider(CoreDbContext dbContext, CoreDataServiceContext dataServiceContext)
            : base(dbContext, dataServiceContext)
        {
        
        }

        #endregion

    }

}
