﻿// ===================================================================================
// Author        : System
// Created date  : 09 Aug 2020 16:32:39
// Description   : UserNotificationTableProvider partial class.
//
// Modified by   :
// Modified date :
// Comments      :
//
// NOTE: This file is initially generated by system and can be modified following
//       the requirement.
// ===================================================================================

using System.Threading.Tasks;
using Wismapi.Data;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{

    public partial class UserNotificationTableProvider : DataTableProvider<UserNotification>
    {
        
        #region Methods

        protected override async Task OnBeginInsertDataAsync(BeginOperationDataEventArgs<UserNotification> e)
        {
            await Task.CompletedTask;
            await base.OnBeginInsertDataAsync(e);
        }

        protected override async Task OnBeginUpdateDataAsync(BeginOperationDataEventArgs<UserNotification> e)
        {
            await Task.CompletedTask;
            await base.OnBeginUpdateDataAsync(e);
        }

        protected override async Task OnBeginDeleteDataAsync(BeginOperationDataEventArgs<UserNotification> e)
        {
            await Task.CompletedTask;
            await base.OnBeginDeleteDataAsync(e);
        }

        #endregion
        
    }

}