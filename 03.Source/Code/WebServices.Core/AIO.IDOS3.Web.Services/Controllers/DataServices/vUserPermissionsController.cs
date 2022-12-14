// ===================================================================================
// Author        : System
// Created date  : 17 Aug 2020 01:45:40
// Description   : vUserPermissionController class.
//
// Modified by   :
// Modified date :
// Comments      :
//
// NOTE: This file is initially generated by system and can be modified following
//       the requirement.
// ===================================================================================

using AIO.IDOS3.Data;
using AIO.IDOS3.Data.Entity;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AIO.IDOS3.Web.Services.Controllers.DataServices
{

    public class vUserPermissionsController : DataServiceController<vUserPermission>
    {

        #region Constructors
                
        public vUserPermissionsController(ILogger<vUserPermissionsController> logger, MainDbContext context)
            : base(logger, context)
        {

        }

        #endregion

        #region Methods

        [EnableQuery]
        [HttpGet]
        public IQueryable<vUserPermission> Get()
        {
            var viewProvider = context.GetDataViewProvider<vUserPermissionViewProvider>();

            return viewProvider.GetData();
        }
        
        [EnableQuery]
        [HttpGet]
        public async Task<IActionResult> Get([FromODataUri] int keyUserID, [FromODataUri] string keyPermissionObjectID)
        {
            var viewProvider = context.GetDataViewProvider<vUserPermissionViewProvider>();

            return Ok(await viewProvider.GetDataAsync(keyUserID, keyPermissionObjectID));
        }



        [HttpPost]
        public async Task<IActionResult> Post([FromBody] vUserPermission obj)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var viewProvider = context.GetDataViewProvider<vUserPermissionViewProvider>();

            using (var transaction = await context.Database.BeginTransactionAsync())
            {
                try
                {
                    await viewProvider.InsertDataAsync(obj, true);
                    await transaction.CommitAsync();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw ex;
                }
            }

            return Created(obj);
        }
        
        [HttpPatch]
        public async Task<IActionResult> Patch([FromODataUri] int keyUserID, [FromODataUri] string keyPermissionObjectID, [FromBody] vUserPermission obj)
        {
            return await Put(keyUserID, keyPermissionObjectID, obj);
        }
        
        [HttpPut]
        public async Task<IActionResult> Put([FromODataUri] int keyUserID, [FromODataUri] string keyPermissionObjectID, [FromBody] vUserPermission obj)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var viewProvider = context.GetDataViewProvider<vUserPermissionViewProvider>();

            obj.UserID = keyUserID;
			obj.PermissionObjectID = keyPermissionObjectID;
			
            using (var transaction = await context.Database.BeginTransactionAsync())
            {
                try
                {
                    await viewProvider.UpdateDataAsync(obj, true);
                    await transaction.CommitAsync();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw ex;
                }
            }

            return Updated(obj);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromODataUri] int keyUserID, [FromODataUri] string keyPermissionObjectID)
        {
            var viewProvider = context.GetDataViewProvider<vUserPermissionViewProvider>();

            var obj = new vUserPermission();
            obj.UserID = keyUserID;
			obj.PermissionObjectID = keyPermissionObjectID;
			
            using (var transaction = await context.Database.BeginTransactionAsync())
            {
                try
                {
                    await viewProvider.DeleteDataAsync(obj, true);
                    await transaction.CommitAsync();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw ex;
                }
            }

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        #endregion

    }

}
