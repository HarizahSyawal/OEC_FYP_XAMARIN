﻿// ===================================================================================
// Author        : System
// Created date  : 09 Aug 2020 15:54:52
// Description   : vUserRoleViewProvider partial class.
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

    public partial class vUserRoleViewProvider : DataViewProvider<vUserRole>
    {

        #region Methods
        
        protected override void OnInsertData(vUserRole obj, bool useTransaction) { OnInsertDataAsync(obj, useTransaction).Wait(); }
        protected override void OnUpdateData(vUserRole obj, bool useTransaction) { OnUpdateDataAsync(obj, useTransaction).Wait(); }
        protected override void OnDeleteData(vUserRole obj, bool useTransaction) { OnDeleteDataAsync(obj, useTransaction).Wait(); }


        protected override async Task OnInsertDataAsync(vUserRole obj, bool useTransaction)
        {
            var userRoleTableProvider = DbContext.GetDataTableProvider<UserRoleTableProvider>();

            var userRole = new UserRole();

            userRole.UserID = obj.UserID;
            userRole.RoleID = obj.RoleID;

            await userRoleTableProvider.InsertDataAsync(userRole);
        }

        protected override async Task OnUpdateDataAsync(vUserRole obj, bool useTransaction)
        {
            var userRoleTableProvider = DbContext.GetDataTableProvider<UserRoleTableProvider>();

            var userRole = await userRoleTableProvider.GetDataAsync(obj.UserID, obj.RoleID);


            await userRoleTableProvider.UpdateDataAsync(userRole);
        }

        protected override async Task OnDeleteDataAsync(vUserRole obj, bool useTransaction)
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
        }

        #endregion

    }

}
