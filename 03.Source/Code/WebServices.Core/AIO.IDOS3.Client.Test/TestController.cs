using AIO.IDOS3.Mobile.Data.Entity;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
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
    public class TestController : Controller
    {

        #region Fields

        protected readonly ILogger<TestController> logger;
        
        #endregion

        #region Constructors

        public TestController(ILogger<TestController> logger)
        {
            this.logger = logger;
        }

        #endregion

        #region Methods

        [HttpGet]
        public async Task<string> Get()
        {
            var text = "";
            var tickStarted = DateTime.Now.Ticks;

            MobileDbContext.DataServiceServiceRoot = new Uri("https://idos-odi.aio.co.id:10020/IDOS3Dev/IDOS3SvcCoreDev/DataServices");
            MobileDbContext.DataServiceUseEdmModelCsdl = true;
            
            MobileDbContext.ConfigureDbContext = (object context, DbContextOptionsBuilder builder) =>
                {
                    builder.UseSqlite(@"Data Source=C:\DATA\PROJECTS\2020.AIO.IDOS3\03.Source\Code\MobileApps\idos3_mobile.db;");                    
                };

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

            await context.DeleteAllAsync<mvAuthorization>();
            var authorizationSyncProvider = context.GetDataSyncProvider<mvAuthorizationSyncProvider>();
            exception = await authorizationSyncProvider.DownloadAllDataAsync(true);
            text += "Sync Download All Authorization Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            await context.DeleteAllAsync<mvSystemParameter>();
            var systemParameterSyncProvider = context.GetDataSyncProvider<mvSystemParameterSyncProvider>();
            exception = await systemParameterSyncProvider.DownloadAllDataAsync(true);
            text += "Sync Download All System Parameter Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            await context.DeleteAllAsync<mvSystemLookup>();
            var systemLookupSyncProvider = context.GetDataSyncProvider<mvSystemLookupSyncProvider>();
            exception = await systemLookupSyncProvider.DownloadAllDataAsync(true);
            text += "Sync Download All System Lookup Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            await context.DeleteAllAsync<mvUserSite>();
            var userSiteSyncProvider = context.GetDataSyncProvider<mvUserSiteSyncProvider>();
            exception = await userSiteSyncProvider.DownloadAllDataAsync(true);
            text += "Sync Download All User Site Sync Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            await context.DeleteAllAsync<mvSite>();
            var siteSyncProvider = context.GetDataSyncProvider<mvSiteSyncProvider>();
            exception = await siteSyncProvider.DownloadAllDataAsync(true);
            text += "Sync Download All Site Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            await context.DeleteAllAsync<mvEmployee>();
            var employeeSyncProvider = context.GetDataSyncProvider<mvEmployeeSyncProvider>();
            exception = await employeeSyncProvider.DownloadAllDataAsync(true);
            text += "Sync Download All Employee Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            await context.DeleteAllAsync<mvSalesman>();
            var salesmanSyncProvider = context.GetDataSyncProvider<mvSalesmanSyncProvider>();
            exception = await salesmanSyncProvider.DownloadAllDataAsync(true);
            text += "Sync Download All Salesman Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            await context.DeleteAllAsync<mvCollector>();
            var collectorSyncProvider = context.GetDataSyncProvider<mvCollectorSyncProvider>();
            exception = await collectorSyncProvider.DownloadAllDataAsync(true);
            text += "Sync Download All Collector Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            await context.DeleteAllAsync<mvWarehouse>();
            var warehouseSyncProvider = context.GetDataSyncProvider<mvWarehouseSyncProvider>();
            exception = await warehouseSyncProvider.DownloadAllDataAsync(true);
            text += "Sync Download All Warehouse Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            await context.DeleteAllAsync<mvCustomer>();
            var customerSyncProvider = context.GetDataSyncProvider<mvCustomerSyncProvider>();
            exception = await customerSyncProvider.DownloadAllDataAsync(true);
            text += "Sync Download All Customer Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            await context.DeleteAllAsync<mvProduct>();
            var productSyncProvider = context.GetDataSyncProvider<mvProductSyncProvider>();
            exception = await productSyncProvider.DownloadAllDataAsync(true);
            text += "Sync Download All Product Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            await context.DeleteAllAsync<mvProductPrice>();
            var productPriceSyncProvider = context.GetDataSyncProvider<mvProductPriceSyncProvider>();
            exception = await productPriceSyncProvider.DownloadAllDataAsync(true);
            text += "Sync Download All Product Price Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            await context.DeleteAllAsync<mvDiscountGroup>();
            var discountGroupSyncProvider = context.GetDataSyncProvider<mvDiscountGroupSyncProvider>();
            exception = await discountGroupSyncProvider.DownloadAllDataAsync(true);
            text += "Sync Download All Discount Group Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            await context.DeleteAllAsync<mvDiscountGroupProduct>();
            var discountGroupProductSyncProvider = context.GetDataSyncProvider<mvDiscountGroupProductSyncProvider>();
            exception = await discountGroupProductSyncProvider.DownloadAllDataAsync(true);
            text += "Sync Download All Discount Group Product Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            await context.DeleteAllAsync<mvDiscountStrata>();
            var discountStrataSyncProvider = context.GetDataSyncProvider<mvDiscountStrataSyncProvider>();
            exception = await discountStrataSyncProvider.DownloadAllDataAsync(true);
            text += "Sync Download All Discount Strata Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            await context.DeleteAllAsync<mvDiscountStrataDetails>();
            var discountStrataDetailsSyncProvider = context.GetDataSyncProvider<mvDiscountStrataDetailsSyncProvider>();
            exception = await discountStrataDetailsSyncProvider.DownloadAllDataAsync(true);
            text += "Sync Download All Discount Strata Details Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            await context.DeleteAllAsync<mvSalesPromotion>();
            var salesPromotionSyncProvider = context.GetDataSyncProvider<mvSalesPromotionSyncProvider>();
            exception = await salesPromotionSyncProvider.DownloadAllDataAsync(true);
            text += "Sync Download All Sales Promotion Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            await context.DeleteAllAsync<mvSalesPromotionProduct>();
            var salesPromotionProductSyncProvider = context.GetDataSyncProvider<mvSalesPromotionProductSyncProvider>();
            exception = await salesPromotionProductSyncProvider.DownloadAllDataAsync(true);
            text += "Sync Download All Sales Promotion Product Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            await context.DeleteAllAsync<mvSalesmanProduct>();
            var salesmanProductSyncProvider = context.GetDataSyncProvider<mvSalesmanProductSyncProvider>();
            exception = await salesmanProductSyncProvider.DownloadAllDataAsync(true);
            text += "Sync Download All Salesman Product Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            await context.DeleteAllAsync<mvProductLot>();
            await context.DeleteAllAsync<mvStockOnHandCurrent>();
            var stockOnHandCurrentSyncProvider = context.GetDataSyncProvider<mvStockOnHandCurrentSyncProvider>();
            exception = await stockOnHandCurrentSyncProvider.DownloadAllDataAsync(true);
            text += "Sync Download All Stock On Hand Current Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n";

            text += "\n\nTotal Time Elapsed: " + new DateTime(DateTime.Now.Ticks - tickStarted).ToLongTimeString() + "\n" + ((exception == null) ? "SUCCESS" : ("ERROR: " + exception.Message));

            return text;
        }

        #endregion

    }

}
