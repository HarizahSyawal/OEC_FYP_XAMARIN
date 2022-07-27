//using AIO.IDOS3.Data.Entity;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.SignalR;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text.Json;
//using System.Threading.Tasks;

//namespace AIO.IDOS3.Web.Services.SignalRHubs
//{

//    [Authorize]
//    public class CommandHub : Hub
//    {

//        #region Static Members

//        private static readonly int WaitCommandResponseTimeout = 60; // Seconds
//        private static readonly int WaitCommandResponseClear = 60; // Seconds
//        private static readonly ConcurrentDictionary<Guid, object> CommandResponds = new ConcurrentDictionary<Guid, object>();

//        #endregion

//        #region Fields

//        protected readonly MainDbContext dbContext;

//        #endregion

//        #region Constructors

//        #endregion

//        #region Methods

//        public async Task<object> UserDeviceLocationBySalesmanIDRequest(Guid salesmanID)
//        {
//            var userDeviceHubConnectionViewProvider = dbContext.GetDataTableProvider<vUserDeviceHubConnectionViewProvider>();

//            var userDeviceHubConnection = await userDeviceHubConnectionViewProvider.GetData()
//                .Where(p => p.SalesmanID.Equals(salesmanID) && (p.HubNameID == nameof(CommandHub))).FirstOrDefaultAsync();
//            if (userDeviceHubConnection == null)
//                throw new ArgumentNullException(string.Format("The SalesmanID '{0}' not found or Device was never connected to Server.", salesmanID.ToString()));

//            return await UserDeviceLocationRequest(userDeviceHubConnection.ConnectionID);
//        }

//        public async Task<object> UserDeviceLocationByCollectorIDRequest(Guid collectorID)
//        {
//            var userDeviceHubConnectionViewProvider = dbContext.GetDataTableProvider<vUserDeviceHubConnectionViewProvider>();

//            var userDeviceHubConnection = await userDeviceHubConnectionViewProvider.GetData()
//                .Where(p => p.CollectorID.Equals(collectorID) && (p.HubNameID == nameof(CommandHub))).FirstOrDefaultAsync();
//            if (userDeviceHubConnection == null)
//                throw new ArgumentNullException(string.Format("The CollectorID '{0}' not found or Device was never connected to Server.", collectorID.ToString()));

//            return await UserDeviceLocationRequest(userDeviceHubConnection.ConnectionID);
//        }

//        public async Task<object> UserDeviceLocationRequest(string connectionID)
//        {
//            try
//            {
//                var commandID = Guid.NewGuid();

//                await Clients.Client(connectionID).SendAsync("UserDeviceLocationRequest", commandID);

//                var timeout = WaitCommandResponseTimeout * 2; // seconds
//                while (!CommandResponds.ContainsKey(commandID) && (timeout > 0))
//                {
//                    await Task.Delay(500);
//                    timeout--;
//                }

//                return await TryGetCommandRespond(commandID);
//            }
//            catch (Exception ex)
//            {
//                throw new ArgumentNullException(string.Format("Device with ConnectionID '{0}' currently not connected to Server.", connectionID));
//            }
//        }

//        public async Task UserDeviceLocationRespond(Guid commandID, IDictionary<string, object> value)
//        {
//            var userDeviceHubConnection = await UpdateUserDeviceHubConnection(true);
                        
//            var userDeviceLocation = new vUserDeviceLocation();

//            userDeviceLocation.ID = Guid.NewGuid();
//            userDeviceLocation.UserID = userDeviceHubConnection.UserID;
//            userDeviceLocation.IMEI = value["IMEI"].ToString();
//            userDeviceLocation.Longitude = JsonSerializer.Deserialize<double>(value["Longitude"].ToString());
//            userDeviceLocation.Latitude = JsonSerializer.Deserialize<double>(value["Latitude"].ToString());

//            await TryAddCommandRespond(commandID, userDeviceLocation);

//            _ = Task.Run(async () =>
//            {
//                using (var dataContext = new MainDbContext())
//                {
//                    using (var transaction = await dataContext.Database.BeginTransactionAsync())
//                    {
//                        try
//                        {
//                            var userDeviceLocationViewProvider = dataContext.GetDataTableProvider<vUserDeviceLocationViewProvider>();

//                            await userDeviceLocationViewProvider.InsertDataAsync(userDeviceLocation, true);

//                            await transaction.CommitAsync();
//                        }
//                        catch (Exception ex)
//                        {
//                            await transaction.RollbackAsync();
//                            throw ex;
//                        }
//                    }
//                }

//                var timeout = WaitCommandResponseClear * 2; // seconds
//                while (CommandResponds.ContainsKey(commandID) && (timeout > 0))
//                {
//                    await Task.Delay(500);
//                    timeout--;
//                }

//                if (timeout == 0)
//                    await TryGetCommandRespond(commandID);
//            });
//        }


//        public override async Task OnConnectedAsync()
//        {
//            await UpdateUserDeviceHubConnection(true);

//            await base.OnConnectedAsync();
//        }

//        public override async Task OnDisconnectedAsync(Exception exception)
//        {
//            await UpdateUserDeviceHubConnection(false);

//            await base.OnDisconnectedAsync(exception);
//        }


//        private async Task TryAddCommandRespond(Guid commandID, object value)
//        {
//            var attempts = 15 * 2;
//            while (attempts > 0) { try { CommandResponds.AddOrUpdate(commandID, value, (key, oldValue) => value); break; } catch { await Task.Delay(500); attempts--; } }
//        }

//        private async Task<object> TryGetCommandRespond(Guid commandID)
//        {
//            object value = null;
            
//            var attempts = 15 * 2;
//            while (attempts > 0) { try { if (CommandResponds.ContainsKey(commandID)) CommandResponds.Remove(commandID, out value); break; } catch { await Task.Delay(500); attempts--; } }

//            return value;
//        }

//        private async Task<vUserDeviceHubConnection> UpdateUserDeviceHubConnection(bool isConnected)
//        {
//            var userDeviceHubConnectionViewProvider = dbContext.GetDataTableProvider<vUserDeviceHubConnectionViewProvider>();

//            var authenticatedUser = dbContext.GetAuthenticatedUser();
//            if (authenticatedUser == null)
//                throw new UnauthorizedAccessException();

//            vUserDeviceHubConnection userDeviceHubConnection = null;
            
//            using (var transaction = await dbContext.Database.BeginTransactionAsync())
//            {
//                try
//                {
//                    userDeviceHubConnection = await userDeviceHubConnectionViewProvider.GetData()
//                        .Where(p => (p.UserID == authenticatedUser.ID) && (p.HubNameID == nameof(CommandHub))).FirstOrDefaultAsync();

//                    var connectionID = (isConnected) ? Context.ConnectionId : null;

//                    if (userDeviceHubConnection == null)
//                    {
//                        userDeviceHubConnection = new vUserDeviceHubConnection();

//                        userDeviceHubConnection.ID = Guid.NewGuid();
//                        userDeviceHubConnection.UserID = authenticatedUser.ID;
//                        userDeviceHubConnection.HubNameID = nameof(CommandHub);
//                        userDeviceHubConnection.ConnectionID = connectionID;

//                        await userDeviceHubConnectionViewProvider.InsertDataAsync(userDeviceHubConnection, true);
//                    }
//                    else
//                    {
//                        userDeviceHubConnection.ConnectionID = connectionID;

//                        await userDeviceHubConnectionViewProvider.UpdateDataAsync(userDeviceHubConnection, true);
//                    }

//                    await transaction.CommitAsync();
//                }
//                catch (Exception ex)
//                {
//                    await transaction.RollbackAsync();
//                    throw ex;
//                }
//            }

//            return userDeviceHubConnection;
//        }

//        #endregion

//    }

//}
