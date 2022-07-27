using AIO.IDOS3.Data.Entity;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace AIO.IDOS3.Web.Services.Controllers
{
    public class DataServiceController<TEntity> : ODataController
        where TEntity : class, new()
    {

        #region Fields

        protected readonly ILogger<DataServiceController<TEntity>> logger;
        protected readonly MainDbContext context;

        #endregion

        #region Constructors

        public DataServiceController(ILogger<DataServiceController<TEntity>> logger, MainDbContext context)
        {
            this.logger = logger;
            this.context = context;
        }

        #endregion

    }

}
