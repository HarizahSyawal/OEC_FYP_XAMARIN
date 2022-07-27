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
    public class vLoginsController : DataServiceController<vLogin>
    {
        #region Constructors

        public vLoginsController(ILogger<vLoginsController> logger, MainDbContext context)
            : base(logger, context)
        {

        }

        #endregion

        #region Methods

        [EnableQuery]
        [HttpGet]
        public IQueryable<vLogin> Get()
        {
            var viewProvider = context.GetDataViewProvider<vLoginViewProvider>();

            return viewProvider.GetData();
        }

        [EnableQuery]
        [HttpGet]
        public async Task<IActionResult> Get([FromODataUri] int keyID)
        {
            var viewProvider = context.GetDataViewProvider<vLoginViewProvider>();

            return Ok(await viewProvider.GetDataAsync(keyID));
        }



        [HttpPost]
        public async Task<IActionResult> Post([FromBody] vLogin obj)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var viewProvider = context.GetDataViewProvider<vLoginViewProvider>();

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
        public async Task<IActionResult> Patch([FromODataUri] int keyID, [FromBody] vLogin obj)
        {
            return await Put(keyID, obj);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromODataUri] int keyID, [FromBody] vLogin obj)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var viewProvider = context.GetDataViewProvider<vLoginViewProvider>();

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
        public async Task<IActionResult> Delete([FromODataUri] int keyID)
        {
            var viewProvider = context.GetDataViewProvider<vLoginViewProvider>();

            var obj = new vLogin();
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
