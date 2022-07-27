﻿// ===================================================================================
// Author        : System
// Created date  : 17 Aug 2020 01:45:40
// Description   : vUserDeviceHubConnectionController class.
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

    public class vUserDeviceHubConnectionsController : DataServiceController<vUserDeviceHubConnection>
    {

        #region Constructors
                
        public vUserDeviceHubConnectionsController(ILogger<vUserDeviceHubConnectionsController> logger, MainDbContext context)
            : base(logger, context)
        {

        }

        #endregion

        #region Methods

        [EnableQuery]
        [HttpGet]
        public IQueryable<vUserDeviceHubConnection> Get()
        {
            var viewProvider = context.GetDataViewProvider<vUserDeviceHubConnectionViewProvider>();

            return viewProvider.GetData();
        }
        
        [EnableQuery]
        [HttpGet]
        public async Task<IActionResult> Get([FromODataUri] int keyID)
        {
            var viewProvider = context.GetDataViewProvider<vUserDeviceHubConnectionViewProvider>();

            return Ok(await viewProvider.GetDataAsync(keyID));
        }



        [HttpPost]
        public async Task<IActionResult> Post([FromBody] vUserDeviceHubConnection obj)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var viewProvider = context.GetDataViewProvider<vUserDeviceHubConnectionViewProvider>();

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
        public async Task<IActionResult> Patch([FromODataUri] Guid keyID, [FromBody] vUserDeviceHubConnection obj)
        {
            return await Put(keyID, obj);
        }
        
        [HttpPut]
        public async Task<IActionResult> Put([FromODataUri] Guid keyID, [FromBody] vUserDeviceHubConnection obj)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var viewProvider = context.GetDataViewProvider<vUserDeviceHubConnectionViewProvider>();

            obj.ID = keyID;
			
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
        public async Task<IActionResult> Delete([FromODataUri] Guid keyID)
        {
            var viewProvider = context.GetDataViewProvider<vUserDeviceHubConnectionViewProvider>();

            var obj = new vUserDeviceHubConnection();
            obj.ID = keyID;
			
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