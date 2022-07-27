using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using AIO.IDOS3.Client.Mobile.Models;
using AIO.IDOS3.Client.Mobile.Views;
using AIO.IDOS3.Client.Mobile.Views.Consultation;
using AIO.IDOS3.Client.Mobile.Views.Universities;
using Prism.Navigation;
using Prism.Services.Dialogs;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.ViewModels
{
    public class DetailsPageViewModel : EditPageViewModelBase<ApplyUniversitiesModel>
    {
        #region Constructors
        public DetailsPageViewModel(INavigationService navigationService, Prism.Services.IPageDialogService pageDialogService, IDialogService dialogService)
               : base(navigationService, pageDialogService, dialogService)
        {
            Title = "Universiti Teknologi Malaysia";
            Model = new ApplyUniversitiesModel();

            PerformConsultationCommand = new Command(async () => await OnPerformConsultation());
            PerformVisitWebsiteCommand = new Command(async () => await OnPerformVisitWebsite());
            PerformBackNavigationCommand = new Command(async () => await OnPerformBackNavigation());

        }

        #endregion

        #region Properties

        public ICommand PerformConsultationCommand { get; }
        public ICommand PerformVisitWebsiteCommand { get; }
        public ICommand PerformBackNavigationCommand { get; }


        #endregion

        #region Methods

        protected override async Task OnNavigatingTo(INavigationParameters parameters, NavigationMode navigationMode)
        {

            await Task.Yield();


            _ = Task.Run(async () =>
            {
                Exception exception = null;


                try
                {
                    switch (navigationMode)
                    {
                        case NavigationMode.New:



                            break;
                    }
                }
                catch (Exception ex)
                {
                    exception = ex;

                    Debug.Write(ex, "App.OnInitialize"); ////////////////////////
                }
                await Device.InvokeOnMainThreadAsync(() => {
                    if (exception == null)
                    {
                        switch (navigationMode)
                        {
                            case NavigationMode.New:


                                break;
                        }
                    }
                    else
                        Model.SetErrorMessage(exception.Message);

                    IsBusy = false;
                    return Task.CompletedTask;
                });
                await Task.CompletedTask;
            });
        }

        private async Task OnPerformVisitWebsite()
        {
            var navigationParams = new NavigationParameters();

            await NavigationService.NavigateAsync(nameof(UTMSite), navigationParams);
        }

        private async Task OnPerformConsultation()
        {
            var navigationParams = new NavigationParameters();

            await NavigationService.NavigateAsync(nameof(Consultation), navigationParams);
        }

        private async Task OnPerformBackNavigation()
        {
            var navigationParams = new NavigationParameters();

            await ForceNavigateTo(string.Format("../{0}", nameof(MainPage)), navigationParams, false, true);
        }
        #endregion
    }
}