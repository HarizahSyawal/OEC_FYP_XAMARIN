//using AIO.IDOS3.Client.Mobile.Utilities;
//using AIO.IDOS3.Mobile.Data.SQLiteNet;
//using Microsoft.AspNetCore.Http.Connections.Client;
//using Microsoft.AspNetCore.SignalR.Client;
//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Collections.Generic;
//using System.Threading;
//using System.Threading.Tasks;
//using Xamarin.Forms;

//namespace AIO.IDOS3.Client.Mobile
//{

//    public static class SignalRHubs
//    {

//        #region CommandHub

//        private static HubConnection CommandHubConnection = null;
//        private static int CommandHubConnectionRetryInterval = 1 * 10 * 1000; // 5 Minute
//        private static CancellationTokenSource CommandHubConnectionRetryTokenSource = new CancellationTokenSource();
//        private static bool isCommandHubConnectionReconnecting = false;
//        public static Command SendMessageCommand { get; }
//        public static Command ConnectCommand { get; }
//        public static Command DisconnectCommand { get; }

//        private static async Task ValidateCommandHubConnection()
//        {
//            if ((CommandHubConnection == null) || (CommandHubConnection.State == HubConnectionState.Disconnected))
//            {
//                if (CommandHubConnection != null)
//                    await CommandHubConnection.DisposeAsync();

//                CommandHubConnection = new HubConnectionBuilder().WithUrl(CommandHubServiceRoot, ConfigureHttpConnection).AddJsonProtocol().Build();

//                CommandHubConnection.Closed += CommandHubConnection_Closed;
//                CommandHubConnection.On<Guid>("UserDeviceLocationRequest", CommandHub_UserDeviceLocationRequest);
//            }

//            await Task.CompletedTask;
//        }

//        private static async Task CommandHubConnection_Closed(Exception arg)
//        {
//            if (((arg != null) || CommandHubKeepConnection) && (CommandHubConnection != null) && (CommandHubConnection.State == HubConnectionState.Disconnected))
//                await ConnectCommandHub();
//        }

//        private static async Task CommandHub_UserDeviceLocationRequest(Guid commandID)
//        {
//            _ = Task.Run(async () =>
//            {
//                var value = new Dictionary<string, object>();

//                value.Add("IMEI", App.GlobalResources.Current.DeviceIMEI);
//                value.Add("Longitude", 0d);
//                value.Add("Latitude", 0d);

//                try
//                {
//                    var location = await CommonUtility.GetLocation();

//                    value["Longitude"] = location.Longitude;
//                    value["Latitude"] = location.Latitude;
//                }
//                catch { }

//                var attempts = 10;
//                while (attempts > 0) { try { await CommandHubConnection.InvokeAsync("UserDeviceLocationRespond", commandID, value); break; } catch { await Task.Delay(500); attempts--; } }
//            });

//            await Task.CompletedTask;
//        }


//        public static string CommandHubServiceRoot { get; set; }
//        public static bool CommandHubKeepConnection { get; set; } = false;

//        public static bool IsCommandHubConnected
//        {
//            get
//            {
//                if (CommandHubConnection != null)
//                    return (CommandHubConnection.State == HubConnectionState.Connected);

//                return false;
//            }
//        }


//        public static async Task ConnectCommandHub()
//        {
//            if (!isCommandHubConnectionReconnecting)
//            {
//                _ = Task.Run(async () =>
//                {
//                    var attempts = CommandHubConnectionRetryInterval / 1000;
//                    while ((CommandHubConnection == null) || (CommandHubConnection.State != HubConnectionState.Connected))
//                    {
//                        try
//                        {
//                            await ValidateCommandHubConnection();

//                            if (CommonUtility.ValidateInternetConnection())
//                                await CommandHubConnection.StartAsync();
//                        }
//                        catch (Exception ex)
//                        {
//                            isCommandHubConnectionReconnecting = true;

//                            while (attempts > 0)
//                            {
//                                if (CommandHubConnectionRetryTokenSource.IsCancellationRequested)
//                                    break;

//                                await Task.Delay(1000);
//                                attempts--;
//                            }

//                            if (!CommandHubConnectionRetryTokenSource.IsCancellationRequested)
//                                attempts = CommandHubConnectionRetryInterval / 1000;
//                        }

//                        if (CommandHubConnectionRetryTokenSource.IsCancellationRequested)
//                            break;
//                    }

//                    isCommandHubConnectionReconnecting = false;
//                });
//            }

//            await Task.CompletedTask;
//        }

//        public static async Task DisconnectCommandHub()
//        {
//            if (!CommandHubConnectionRetryTokenSource.IsCancellationRequested)            
//                CommandHubConnectionRetryTokenSource.Cancel();

//            var timeout = 15; // seconds
//            while (isCommandHubConnectionReconnecting && (timeout > 0))
//            {
//                await Task.Delay(1000);
//                timeout--;
//            }

//            CommandHubConnectionRetryTokenSource.Dispose();
//            CommandHubConnectionRetryTokenSource = new CancellationTokenSource();

//            try
//            {
//                if ((CommandHubConnection != null) && (CommandHubConnection.State != HubConnectionState.Disconnected) && CommonUtility.ValidateInternetConnection())
//                {
//                    await CommandHubConnection.StopAsync();

//                    await CommandHubConnection.DisposeAsync();
//                    CommandHubConnection = null;
//                }
//            }
//            catch (Exception ex)
//            {

//            }
//        }

//        #endregion

//        #region Methods

//        private static void ConfigureHttpConnection(HttpConnectionOptions options)
//        {
//            options.Headers.Add(MobileDbContext.Current.GetAuthenticationHeader());
//        }

//        #endregion

//    }

//}
