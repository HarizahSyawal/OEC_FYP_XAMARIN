using AIO.IDOS3.Mobile.Data.SQLiteNet;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.OData.Edm;
using Microsoft.OData.UriParser;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AIO.IDOS3.Client.Test
{

    [Route("api/[controller]")]
    [ApiController]
    public class Test2Controller : Controller
    {

        #region Fields

        protected readonly ILogger<Test2Controller> logger;
        
        #endregion

        #region Constructors

        public Test2Controller(ILogger<Test2Controller> logger)
        {
            this.logger = logger;
        }

        #endregion

        #region Methods

        [HttpGet]
        public async Task<string> Get()
        {
            //var context2 = new Default.Container(new Uri("http://localhost/IDOS3Svc/DataServices"));

            //var test100 = context2.CreateQuery<AIO.IDOS3.Data.Entity2.vStockTransfer>("vStockTransfers").Expand(p => p.ChildSummaries).ToList();

            //var test102 = context2.CreateQuery<AIO.IDOS3.Data.Entity2.vStockOnHandCurrent>("vStockOnHandCurrents").Expand(p => p.ExtendProductLot)
            //    .Where(p => p.WarehouseID.Equals(new Guid("9C3C507B-003D-4B15-8535-D73C0EFA4672"))).ToList();

            //test100[0].ReferenceNumber = "112233";
            //await context2.SaveChangesAsync();

            var text = "";
            var tickStarted = DateTime.Now.Ticks;

            //var systemParameter = new mvSystemParameter();

            //systemParameter.ID = "Test";
            //systemParameter.Description = "This is a test";
            //systemParameter.Value = "VALUE";

            //var systemParameterTableProvider = context.GetDataTableProvider<mvSystemParameterTableProvider>();

            //var systemParameters = await systemParameterTableProvider.GetData().ToListAsync();

            //await systemParameterTableProvider.DeleteDataAsync(systemParameter);

            //await systemParameterTableProvider.InsertDataAsync(systemParameter);

            //systemParameter.ID = "CHANGES";

            //await systemParameterTableProvider.UpdateDataAsync(systemParameter);

            MobileDbContext.DataServiceServiceRoot = new Uri("https://idos-odi.aio.co.id:10020/IDOS3Dev/IDOS3SvcCoreDev/DataServices");

            MobileDbContext.ConnectionString = @"C:\DATA\PROJECTS\2020.AIO.IDOS3\03.Source\Code\MobileApps\idos3_mobile.db";

            var context = new MobileDbContext();

            Exception exception = null;
            var userName = "9443";


            //await context.DeleteAllAsync<mvSalesCall>();
            //var salesCallSyncProvider = context.GetDataSyncProvider<mvSalesCallSyncProvider>();
            //exception = await salesCallSyncProvider.DownloadAllDataAsync(true);
            //text += "Sync Download All Sales Call Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            //var salesCall = new mvSalesCall();
            //salesCall.ActivityID = Guid.NewGuid();
            //salesCall.CustomerID = Guid.NewGuid();
            //salesCall.IsInRoute = true;

            //salesCall.CheckedInTime = DateTime.UtcNow;
            //salesCall.FirstCheckedInTime = salesCall.CheckedInTime;

            //salesCall.CheckedInLongitude = 0d;
            //salesCall.CheckedInLatitude = 0d;
            //salesCall.FirstCheckedInLongitude = salesCall.CheckedInLongitude;
            //salesCall.FirstCheckedInLatitude = salesCall.CheckedInLatitude;

            //var salesCallTableProvider = context.GetDataTableProvider<mvSalesCallTableProvider>();
            //await salesCallTableProvider.InsertDataAsync(salesCall, true);



            //await context.DeleteAllAsync<mvCurrency>();
            //var currencySyncProvider = context.GetDataSyncProvider<mvCurrencySyncProvider>();
            //exception = await currencySyncProvider.DownloadAllDataAsync(true);
            //text += "Sync Download Currency Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            //await context.DeleteAllAsync<mvExchangeRate>();
            //var exchangeRateSyncProvider = context.GetDataSyncProvider<mvExchangeRateSyncProvider>();
            //exception = await exchangeRateSyncProvider.DownloadAllDataAsync(true);
            //text += "Sync Download Exchange Rate Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            //await context.DeleteAllAsync<mvFinanceInstitution>();
            //var financeInstitutionSyncProvider = context.GetDataSyncProvider<mvFinanceInstitutionSyncProvider>();
            //exception = await financeInstitutionSyncProvider.DownloadAllDataAsync(true);
            //text += "Sync Download FinanceInstitution Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            //await context.DeleteAllAsync<mvIncomingAccount>();
            //var incomingAccountSyncProvider = context.GetDataSyncProvider<mvIncomingAccountSyncProvider>();
            //exception = await incomingAccountSyncProvider.DownloadAllDataAsync(true);
            //text += "Sync Download Incoming Account Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            //await context.DeleteAllAsync<mvMultiPayment>();
            //var multiPaymentSyncProvider = context.GetDataSyncProvider<mvMultiPaymentSyncProvider>();
            //exception = await multiPaymentSyncProvider.DownloadAllDataAsync(true);
            //text += "Sync Download Multi-Payment Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";




            var userServiceProvider = context.DataServiceContext.GetDataServiceProvider<mvUserServiceProvider>();
            var user = userServiceProvider.GetData().Where(p => (p.Name.ToLower() == userName.ToLower())).Single();

            await context.DeleteAllAsync<mvUser>();
            var userTableProvider = context.GetDataTableProvider<mvUserTableProvider>();
            await userTableProvider.InsertDataAsync(user);
            text += "Sync Download User Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            text += "\n\nTotal Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n" + ((exception == null) ? "SUCCESS" : ("ERROR: " + exception.Message));

            return text;
        }

        #endregion

    }

}
