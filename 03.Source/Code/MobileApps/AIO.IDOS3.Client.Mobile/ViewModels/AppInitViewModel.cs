using AIO.IDOS3.Client.Mobile.DependencyServices;
using AIO.IDOS3.Client.Mobile.Views;
using AIO.IDOS3.Mobile.Data.SQLiteNet;
using Prism.Navigation;
using Prism.Services.Dialogs;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.ViewModels
{

    public class AppInitViewModel : PageViewModelBase<object>
    {

        #region Fields

        private bool firstTime = true;

        #endregion

        #region Constructors

        public AppInitViewModel(INavigationService navigationService, Prism.Services.IPageDialogService pageDialogService, IDialogService dialogService)
            : base(navigationService, pageDialogService, dialogService)
        {

        }

        #endregion

        #region Methods

        public override async void OnAppearing()
        {
            base.OnAppearing();

            if (firstTime)
            {
                firstTime = false;

                IsBusy = true;
                /*await Task.Yield();*/

                await Task.Run(async () =>
                {
                    Exception exception = null;

                    mvLogin user = null;
                    var isOlderDBVersionNumber = false;
                    var activityDate = DateTime.SpecifyKind(DateTime.Today, DateTimeKind.Utc);

                    App.GlobalResources.Current.DeviceIMEI = DependencyService.Resolve<IDeviceService>().GetDeviceID();

                    var dbContext = MobileDbContext.Current;
                    var connection = dbContext.GetConnection();

                    using (connection.Lock())
                    {
                        try
                        {
                            connection.BeginTransaction();


                            var dbVersionNumber = 0;

                            if (App.ForceUseLocalDevService)
                            {
                                App.ServiceRoot = App.LocalDevServiceRoot;
                                App.DataServiceRoot = App.LocalDevDataServiceRoot;
                                App.FileServiceRoot = App.LocalDevFileServiceRoot;
                                App.SignalRCommandHubServiceRoot = App.LocalDevSignalRCommandHubServiceRoot;
                            }

                            MobileDbContext.DataServiceServiceRoot = new Uri(App.DataServiceRoot);
                            MobileDbContext.Current.DataServiceContext.BaseUri = MobileDbContext.DataServiceServiceRoot;
                            

                            if (!isOlderDBVersionNumber)
                            {
                                var loginTableProvider = dbContext.GetDataTableProvider<mvLoginTableProvider>();

                                user = await loginTableProvider.GetData().FirstOrDefaultAsync();
                                if (user != null)
                                {


                                }
                            }

                            connection.Commit();
                        }
                        catch (Exception ex)
                        {
                            connection.Rollback();

                            exception = ex;

                            Debug.Write(ex, "App.OnInitialize"); ////////////////////////
                        }
                    }

                    await Device.InvokeOnMainThreadAsync(async () =>
                    {
                        if (exception == null)
                        {
                            if (user != null)
                            {
                                MobileDbContext.SetAuthentication(user.Username, user.Password);

                                await NavigationService.NavigateAsync(string.Format("/{0}/{1}", nameof(NavigationPage), nameof(MainPage)));
                            }
                            else
                                await NavigationService.NavigateAsync(string.Format("/{0}/{1}", nameof(NavigationPage), nameof(LoginPage)));
                        }

                        IsBusy = false;
                        /*await Task.Yield();*/
                    });
                });
            }
        }

        #endregion

        #region Methods (WILL BE DELETED IF NOT NECESSARY)

        #endregion

    }

}
