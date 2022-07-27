using AIO.IDOS3.Client.Mobile.Models;
using AIO.IDOS3.Client.Mobile.Utilities;
using Prism.Navigation;
using Prism.Services.Dialogs;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.ViewModels
{

    public class AppUpdateViewModel : PageViewModelBase<AppUpdateModel>
    {

        #region Constructors

        public AppUpdateViewModel(INavigationService navigationService, Prism.Services.IPageDialogService pageDialogService, IDialogService dialogService)
            : base(navigationService, pageDialogService, dialogService)
        {
            Title = "App Update";

            PerformUpdateCommand = new Command(async () => await OnPerformUpdate());
        }

        #endregion

        #region Properties

        public ICommand PerformUpdateCommand { get; }


        private bool isDownloading = false;
        public bool IsDownloading { get { return isDownloading; } set { SetProperty(ref isDownloading, value); } }

        private double progressValue = 0d;
        public double ProgressValue { get { return progressValue; } set { SetProperty(ref progressValue, value); } }

        private string progressText = "";
        public string ProgressText { get { return progressText; } set { SetProperty(ref progressText, value); } }

        #endregion

        #region Methods

        protected virtual async Task OnPerformUpdate()
        {
            var storageWriteStatus = await Permissions.RequestAsync<Permissions.StorageWrite>();

            if (storageWriteStatus == PermissionStatus.Granted)
            {
                async void ProgressChanged(double value)
                {
                    await Device.InvokeOnMainThreadAsync(async () =>
                    {
                        ProgressValue = value;
                        ProgressText = string.Format("Downloading... {0:N0}%", (value * 100d));
                        /*await Task.Yield();*/
                    });
                }

                var progress = new Progress<double>(ProgressChanged);
                var cts = new CancellationTokenSource();

                IsDownloading = true;

                ProgressValue = 0d;
                ProgressText = "Downloading...";
                /*await Task.Yield();*/

                _ = Task.Run(async () =>
                {
                    Exception exception = null;

                    var pathName = "MobileApps";
                    var fileName = "com.aio.idos3.client.mobile-Signed.apk";

                    try
                    {
                        await CommonUtility.DownloadFile(pathName, fileName, progress, cts.Token);                   
                    }
                    catch (Exception ex)
                    {
                        exception = ex;
                    }

                    await Device.InvokeOnMainThreadAsync(async () =>
                    {
                        IsDownloading = false;

                        if (exception == null)
                        {
                            ProgressValue = 1d;
                            ProgressText = "Successfully Downloaded";

                            //var appUdateUtility = DependencyService.Resolve<IDatabaseUtility>();

                            //appUdateUtility.ExecuteAppUpdate();

                            await PageDialogService.DisplayAlertAsync("App Update Download Succeed", "Please run manually the apk from: Internal Storage/Download/com.aio.idos3.client.mobile-Signed.apk", "OK");
                        }
                        else
                        {
                            ProgressText += "ERROR: " + exception.Message;
                        }
                    });
                });
            }

            await Task.CompletedTask;
        }

        #endregion

    }

}