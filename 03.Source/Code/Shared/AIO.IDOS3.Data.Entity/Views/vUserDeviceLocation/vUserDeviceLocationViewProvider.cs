﻿// ===================================================================================
// Author        : System
// Created date  : 09 Aug 2020 15:54:51
// Description   : vUserDeviceLocationViewProvider partial class.
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

    public partial class vUserDeviceLocationViewProvider : DataViewProvider<vUserDeviceLocation>
    {

        #region Methods
        
        protected override void OnInsertData(vUserDeviceLocation obj, bool useTransaction) { OnInsertDataAsync(obj, useTransaction).Wait(); }
        protected override void OnUpdateData(vUserDeviceLocation obj, bool useTransaction) { OnUpdateDataAsync(obj, useTransaction).Wait(); }
        protected override void OnDeleteData(vUserDeviceLocation obj, bool useTransaction) { OnDeleteDataAsync(obj, useTransaction).Wait(); }


        protected override async Task OnInsertDataAsync(vUserDeviceLocation obj, bool useTransaction)
        {
            var userDeviceLocationTableProvider = DbContext.GetDataTableProvider<UserDeviceLocationTableProvider>();

            var userDeviceLocation = new UserDeviceLocation();

            userDeviceLocation.ID = obj.ID;
            userDeviceLocation.UserID = obj.UserID;
            userDeviceLocation.IMEI = obj.IMEI;
            userDeviceLocation.Longitude = obj.Longitude;
            userDeviceLocation.Latitude = obj.Latitude;

            await userDeviceLocationTableProvider.InsertDataAsync(userDeviceLocation);
        }

        #endregion

    }

}
