using AIO.IDOS3.Client.Mobile.DependencyServices;
using AIO.IDOS3.Client.Mobile.Models;
using AIO.IDOS3.Client.Mobile.Utilities;
using AIO.IDOS3.Client.Mobile.Views;
using AIO.IDOS3.Client.Mobile.Views.AptitudeTest;
using Prism.Navigation;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.ViewModels
{
    public class AptitudePageViewModel : PageViewModelBase<AptitudePageModel>
    {
        #region Fields

        #endregion

        #region Constructors
        public AptitudePageViewModel(INavigationService navigationService, Prism.Services.IPageDialogService pageDialogService, IDialogService dialogService)
            : base(navigationService, pageDialogService, dialogService)
        {
            Title = "Aptitude Test";

            PerformAttemptTestCommand = new Command(async () => await OnPerformAttempt());
            PerformFindCampusCommand = new Command(async () => await OnPerformFindCampus());
        }


        #endregion

        #region Properties
        public ICommand PerformAttemptTestCommand { get; }
        public ICommand PerformFindCampusCommand { get; }

        #endregion

        #region Methods

        protected async Task OnPerformAttempt()
        {
            var navigationParams = new NavigationParameters();

            await NavigationService.NavigateAsync(nameof(AttemptTest), navigationParams);
        }
        private async Task OnPerformFindCampus()
        {
            var navigationParams = new NavigationParameters();

           await NavigationService.NavigateAsync(nameof(DetailsPage), navigationParams);
        }
    }


    #endregion

}
