using AIO.IDOS3.Web.Services.SignalRHubs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace AIO.IDOS3.Web.Services.Controllers
{

    [Route("SignalRHubServices")]
    [ApiController]
    public class SignalRHubServiceController : Controller
    {

        #region Fields

        protected readonly ILogger<SignalRHubServiceController> logger;
        protected readonly AppSettings appSettings;

        #endregion

        #region Constructors

        public SignalRHubServiceController(ILogger<SignalRHubServiceController> logger, IOptions<AppSettings> appSettingsOptions)
        {
            this.logger = logger;
            this.appSettings = appSettingsOptions.Value;
        }

        #endregion

        #region Methods

        private HubConnection GetHubConnection(string hubName)
        {
            var uri = new UriBuilder(Request.Scheme, Request.Host.Host, ((Request.Host.Port.HasValue) ? Request.Host.Port.Value : -1), Request.PathBase).Uri;

            var hubConnection = new HubConnectionBuilder().WithUrl(uri.AbsoluteUri + "/" + nameof(ChatHub), (options) =>
            {
            }).AddJsonProtocol().Build();

            return hubConnection;
        }

        #endregion

    }

}
