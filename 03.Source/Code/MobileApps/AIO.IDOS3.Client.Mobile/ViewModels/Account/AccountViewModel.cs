using AIO.IDOS3.Client.Mobile.DependencyServices;
using AIO.IDOS3.Client.Mobile.Models;
using AIO.IDOS3.Client.Mobile.Utilities;
using AIO.IDOS3.Client.Mobile.Views;
using AIO.IDOS3.Client.Mobile.Views.Account;
using AIO.IDOS3.Mobile.Data.SQLiteNet;
using Prism.Navigation;
using Prism.Services.Dialogs;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.ViewModels
{

    public class AccountViewModel : ViewModelBase<AccountModel>
    {

        #region Constructors

        public AccountViewModel(INavigationService navigationService, Prism.Services.IPageDialogService pageDialogService, IDialogService dialogService)
            : base(navigationService, pageDialogService, dialogService)
        {
            Title = "Account";

            PerformLogoutCommand = new Command(async () => await OnPerformLogout());
            NavigateToChangelogCommand = new Command(async () => await OnNavigateToChangelog());
            NavigateToHelpCommand = new Command(async () => await OnNavigateToHelp());
            NavigateToTermConditionCommand = new Command(async () => await OnNavigateToTermCondition());
            NavigateToAboutUsCommand = new Command(async () => await OnNavigateToAboutUs());
            NavigateToPrivacyPolicyCommand = new Command(async () => await OnNavigateToPrivacyPolicy());
            NavigateToProfileCommand = new Command(async () => await OnNavigateToProfile());

        }


        #endregion

        #region Properties

        public ICommand PerformLogoutCommand { get; }
        public ICommand NavigateToChangelogCommand { get; }
        public ICommand NavigateToHelpCommand { get; }
        public ICommand NavigateToTermConditionCommand { get; }
        public ICommand NavigateToAboutUsCommand { get; }
        public ICommand NavigateToPrivacyPolicyCommand { get; }
        public ICommand NavigateToProfileCommand { get; }


        private string logoutPassword = "";
        public string LogoutPassword { get { return logoutPassword; } set { SetProperty(ref logoutPassword, value); } }

        private bool isDownloading = false;
        public bool IsDownloading { get { return isDownloading; } set { SetProperty(ref isDownloading, value); } }

        #endregion

        #region Methods

        private async Task OnPerformLogout()
        {
            if (!IsBusy)
            {
                if (await PageDialogService.DisplayAlertAsync("Sign Out Confirmation", "Are you sure want to Sign out?", "Yes", "No"))
                {
                    await NavigationService.NavigateAsync(string.Format("/{0}/{1}", nameof(NavigationPage), nameof(LoginPage)));
                }
            }

            await Task.CompletedTask;
        }

        private async Task OnNavigateToChangelog()
        {
            await NavigationService.NavigateAsync(nameof(ChangelogPage), new NavigationParameters(), false, true);
        }

        private async Task OnNavigateToPrivacyPolicy()
        {
            var navigationParams = new NavigationParameters();

            await NavigationService.NavigateAsync(nameof(PrivacyPolicy), navigationParams);
        }

        private async Task OnNavigateToAboutUs()
        {
            var navigationParams = new NavigationParameters();

            await NavigationService.NavigateAsync(nameof(AboutPage), navigationParams);
        }

        private async Task OnNavigateToTermCondition()
        {
            var navigationParams = new NavigationParameters();

            await NavigationService.NavigateAsync(nameof(TermCondition), navigationParams);
        }

        private async Task OnNavigateToHelp()
        {
            var navigationParams = new NavigationParameters();

            await NavigationService.NavigateAsync(nameof(HelpPage), navigationParams);
        }

        private async Task OnNavigateToProfile()
        {
            var navigationParams = new NavigationParameters();

            await NavigationService.NavigateAsync(nameof(ProfilePage), navigationParams);
        }

        private bool ValidateInternetConnection()
        {
            switch (Connectivity.NetworkAccess)
            {
                case NetworkAccess.ConstrainedInternet:
                case NetworkAccess.Internet:
                    return true;
                default:
                    throw new OperationCanceledException("Internet connection is not available.");
            }
        }

        #endregion

    }

}