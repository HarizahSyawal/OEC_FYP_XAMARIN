using AIO.IDOS3.Client.Mobile.Models;
using Prism.Navigation;
using Prism.Services.Dialogs;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.ViewModels
{

    public class EditPageViewModelBase<T> : PageViewModelBase<T> where T : BindableErrorBase, new()
    {

        #region Constructors

        public EditPageViewModelBase(INavigationService navigationService, Prism.Services.IPageDialogService pageDialogService, IDialogService dialogService)
            : base(navigationService, pageDialogService, dialogService)
        {
            UseSaveConfirmation = true;
            UseCancelConfirmation = true;

            PerformSaveCommand = new Command(async () => await OnPerformSave());
            PerformCancelCommand = new Command(async () => await OnPerformCancel());

            CanNavigate = false;
        }

        #endregion

        #region Properties

        public bool UseSaveConfirmation { get; set; }
        public bool UseCancelConfirmation { get; set; }

        public ICommand PerformSaveCommand { get; }
        public ICommand PerformCancelCommand { get; }


        protected bool CanNavigate { get; set; }

        #endregion

        #region Methods

        public override async void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            var navigationMode = parameters.ContainsKey("NavigationMode") ? parameters.GetValue<NavigationMode>("NavigationMode") : parameters.GetNavigationMode();

            switch (navigationMode)
            {
                case NavigationMode.New:
                    IsBusy = true;
                    /*await Task.Yield();*/
                    break;
            }

            await OnNavigatingTo(parameters, navigationMode);
        }

        public override async void OnNavigatedFrom(INavigationParameters parameters)
        {
            var navigationMode = parameters.ContainsKey("NavigationMode") ? parameters.GetValue<NavigationMode>("NavigationMode") : parameters.GetNavigationMode();

            await Device.InvokeOnMainThreadAsync(async () =>
            {
                await OnNavigatingFrom(parameters, navigationMode);
                base.OnNavigatedFrom(parameters);

                IsBusy = false;
                /*await Task.Yield();*/
            });

            await Task.CompletedTask;
        }

        public override async Task<bool> CanNavigateAsync(INavigationParameters parameters)
        {
            var navigationMode = parameters.ContainsKey("NavigationMode") ? parameters.GetValue<NavigationMode>("NavigationMode") : parameters.GetNavigationMode();

            if (IsBusy && !CanNavigate)
                return false;

            var result = await base.CanNavigateAsync(parameters);
            if (result)
            {
                if (!CanNavigate && UseCancelConfirmation && (navigationMode == NavigationMode.Back))
                {
                    await Device.InvokeOnMainThreadAsync(async () =>
                    {
                        if (!(await PageDialogService.DisplayAlertAsync("Cancel Confirmation", "Are you sure want to Cancel this transaction?", "Yes", "No")))
                            result = false;
                    });
                }                    
            }

            CanNavigate = false;

            return result;
        }

        public override async void OnAppearing()
        {
            base.OnAppearing();

            await Task.CompletedTask;
        }

        public override async void OnDisappearing()
        {
            base.OnAppearing();

            await Task.CompletedTask;
        }



        protected virtual async Task OnNavigatingTo(INavigationParameters parameters, NavigationMode navigationMode) { IsBusy = false; /*await Task.Yield();*/ }
        protected virtual async Task OnNavigatingFrom(INavigationParameters parameters, NavigationMode navigationMode) { await Task.CompletedTask; }
        protected virtual async Task<bool> OnSaving() { await Task.CompletedTask; return true; }
        protected virtual async Task<bool> OnCancelling() { await Task.CompletedTask; return true; }

        protected virtual async Task ForceNavigateToBack()
        {
            CanNavigate = true;
            /*await Task.Yield();*/

            await NavigationService.GoBackAsync();
        }

        protected virtual async Task ForceNavigateTo(string name, INavigationParameters navigationParams = null, bool? useModalNavigation = null, bool animated = true)
        {
            CanNavigate = true;
            /*await Task.Yield();*/

            await NavigationService.NavigateAsync(name, navigationParams, useModalNavigation, animated);
        }



        private async Task OnPerformSave()
        {
            if (!IsBusy)
            {
                if (Model.Validate())
                {
                    if (!UseSaveConfirmation || await PageDialogService.DisplayAlertAsync("Save Confirmation", "Are you sure want to Save this transaction?", "Yes", "No"))
                    {
                        IsBusy = true;
                        /*await Task.Yield();*/

                        await Device.InvokeOnMainThreadAsync(async () =>
                        {
                            if (await OnSaving())
                                await ForceNavigateToBack();
                        });
                    }
                }
                else
                    Model.SetErrorMessage("Please specify the required fields");
            }
        }

        private async Task OnPerformCancel()
        {
            if (!IsBusy)
            {
                if (!UseCancelConfirmation || await PageDialogService.DisplayAlertAsync("Cancel Confirmation", "Are you sure want to Cancel this transaction?", "Yes", "No"))
                {
                    IsBusy = true;
                    /*await Task.Yield();*/

                    await Device.InvokeOnMainThreadAsync(async () =>
                    {
                        if (await OnCancelling())
                            await ForceNavigateToBack();
                    });
                }
            }
        }

        #endregion

    }

}
