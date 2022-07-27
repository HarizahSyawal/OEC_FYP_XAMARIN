﻿// ===================================================================================
// Author        : System
// Created date  : 09 Aug 2020 15:54:51
// Description   : vUserDeviceHubConnectionViewProvider partial class.
//
// Modified by   :
// Modified date :
// Comments      :
//
// NOTE: This file is initially generated by system and can be modified following
//       the requirement.
// ===================================================================================

using System;
using System.Threading.Tasks;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{

    public partial class vUserDeviceHubConnectionViewProvider : DataViewProvider<vUserDeviceHubConnection>
    {

        #region Methods
        
        protected override void OnInsertData(vUserDeviceHubConnection obj, bool useTransaction) { OnInsertDataAsync(obj, useTransaction).Wait(); }
        protected override void OnUpdateData(vUserDeviceHubConnection obj, bool useTransaction) { OnUpdateDataAsync(obj, useTransaction).Wait(); }
        protected override void OnDeleteData(vUserDeviceHubConnection obj, bool useTransaction) { OnDeleteDataAsync(obj, useTransaction).Wait(); }


        protected override async Task OnInsertDataAsync(vUserDeviceHubConnection obj, bool useTransaction)
        {
            var userDeviceHubConnectionTableProvider = DbContext.GetDataTableProvider<UserDeviceHubConnectionTableProvider>();

            var userDeviceHubConnection = new UserDeviceHubConnection();

            userDeviceHubConnection.ID = obj.ID;
            userDeviceHubConnection.UserID = obj.UserID;
            userDeviceHubConnection.HubNameID = obj.HubNameID;
            userDeviceHubConnection.ConnectionID= obj.ConnectionID;
            
            await userDeviceHubConnectionTableProvider.InsertDataAsync(userDeviceHubConnection);
        }

        protected override async Task OnUpdateDataAsync(vUserDeviceHubConnection obj, bool useTransaction)
        {
            var userDeviceHubConnectionTableProvider = DbContext.GetDataTableProvider<UserDeviceHubConnectionTableProvider>();

            var userDeviceHubConnection = await userDeviceHubConnectionTableProvider.GetDataAsync(obj.ID);
                        
            userDeviceHubConnection.ConnectionID = obj.ConnectionID;

            await userDeviceHubConnectionTableProvider.UpdateDataAsync(userDeviceHubConnection);
        }

        #endregion

    }

}
