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
    public class vRegistersController : DataServiceController<vRegister>
    {
        #region Constructors

        public vRegistersController(ILogger<vRegistersController> logger, MainDbContext context)
            : base(logger, context)
        {

        }

        #endregion

        #region Methods

        [EnableQuery]
        [HttpGet]
        public IQueryable<vRegister> Get()
        {
            var viewProvider = context.GetDataViewProvider<vRegisterViewProvider>();

            return viewProvider.GetData();
        }

        [EnableQuery]
        [HttpGet]
        public async Task<IActionResult> Get([FromODataUri] int keyID)
        {
            var viewProvider = context.GetDataViewProvider<vRegisterViewProvider>();

            return Ok(await viewProvider.GetDataAsync(keyID));
        }



        [HttpPost]
        public async Task<IActionResult> Post([FromBody] vRegister obj)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var viewProvider = context.GetDataViewProvider<vRegisterViewProvider>();

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
        public async Task<IActionResult> Patch([FromODataUri] int keyID, [FromBody] vRegister obj)
        {
            return await Put(keyID, obj);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromODataUri] int keyID, [FromBody] vRegister obj)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var viewProvider = context.GetDataViewProvider<vRegisterViewProvider>();

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
            var viewProvider = context.GetDataViewProvider<vRegisterViewProvider>();

            var obj = new vRegister();
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
