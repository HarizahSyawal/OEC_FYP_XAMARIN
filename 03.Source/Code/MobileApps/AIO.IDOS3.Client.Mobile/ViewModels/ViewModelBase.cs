using DevExpress.XamarinForms.Core.Themes;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using Prism.Services.Dialogs;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.ViewModels
{

    public class ViewModelBase<TModel> : BindableBase, IViewModel where TModel : class, new()
    {

        #region Constructors

        public ViewModelBase(INavigationService navigationService)
            : this(navigationService, null, null)
        {

        }

        public ViewModelBase(INavigationService navigationService, IPageDialogService pageDialogService)
            : this(navigationService, pageDialogService, null)
        {

        }

        public ViewModelBase(INavigationService navigationService, IPageDialogService pageDialogService, IDialogService dialogService)
        {
            NavigationService = navigationService;
            PageDialogService = pageDialogService;
            DialogService = dialogService;

            ThemeCommand = new Command(() => { IsLightTheme = !isLightTheme; });

            PerformBackButtonPressedCommand = new Command(async () => await OnBackButtonPressed());
        }

        #endregion

        #region Properties

        public ICommand ThemeCommand { get; }


        private bool isLightTheme = true;
        public bool IsLightTheme
        {
            get { isLightTheme = (ThemeManager.ThemeName == Theme.Light); return isLightTheme; }
            set { SetProperty(ref isLightTheme, value, onChanged: () => ((App)Application.Current).ApplyTheme(isLightTheme)); }
        }

        private TModel model = new TModel();

        public virtual async Task OnSelectedChanged(bool selected)
        {
            await Task.CompletedTask;
        }


        public TModel Model { get { return model; } set { SetProperty(ref model, value); } }


        protected INavigationService NavigationService { get; }
        protected IPageDialogService PageDialogService { get; }
        protected IDialogService DialogService { get; }

        public CancellationTokenSource ProcessTokenSource { get; protected set; } = new CancellationTokenSource();

        #endregion

        #region Methods

        protected virtual async Task ValidateBackButtonPressed() { await Task.CompletedTask; }

        #endregion

        #region Implements IViewModel

        public IDialogViewModel ChildDialogViewModel { get; set; }


        private string title = "";
        public string Title { get { return title; } set { SetProperty(ref title, value); } }

        private bool firstLoad = true;
        public bool FirstLoad { get { return firstLoad; } set { SetProperty(ref firstLoad, value); } }

        private bool isBusy = false;
        public bool IsBusy { get { return isBusy; } set { SetProperty(ref isBusy, value); } }

        private bool isLocked = false;
        public bool IsLocked { get { return isLocked; } set { SetProperty(ref isLocked, value); } }


        public ICommand PerformBackButtonPressedCommand { get; set; }

        private bool isBackButtonBusy = false;
        public virtual async Task OnBackButtonPressed()
        {
            if (!isBackButtonBusy)
            {
                isBackButtonBusy = true;

                if (ChildDialogViewModel != null)
                {
                    await ChildDialogViewModel.OnBackButtonPressed();
                    isBackButtonBusy = false;
                }
                else
                {
                    _ = Task.Run(async () =>
                    {
                        await ValidateBackButtonPressed();

                        if (IsBusy)
                        {
                            ProcessTokenSource.Cancel();

                            while (IsBusy)
                            {
                                await Task.Delay(500);
                            }
                        }

                        await Device.InvokeOnMainThreadAsync(async () =>
                        {
                            await NavigationService.GoBackAsync();
                        });

                        isBackButtonBusy = false;
                    });
                }
            }

            await Task.CompletedTask;
        }

        public virtual async Task CustomAction(string key, params object[] parameters)
        {
            await Task.CompletedTask;
        }



        protected async Task ShowChildDialog(string name, IDialogParameters dialogParams, Action<IDialogResult> dialogResult)
        {
            if (dialogParams == null)
                dialogParams = new DialogParameters();

            if (!dialogParams.ContainsKey("ParentViewModel"))
                dialogParams.Add("ParentViewModel", this);

            DialogService.ShowDialog(name, dialogParams, dialogResult);

            await Task.CompletedTask;
        }

        #endregion

        #region Implements IViewModel - IInitialize

        public virtual void Initialize(INavigationParameters parameters) { }

        #endregion

        #region Implements IViewModel - INavigationAware

        public virtual async void OnNavigatedFrom(INavigationParameters parameters) { await Task.CompletedTask; }
        public virtual async void OnNavigatedTo(INavigationParameters parameters) { await Task.CompletedTask; }

        #endregion

        #region Implements IViewModel - IDestructible

        public virtual void Destroy() { }

        #endregion

        #region Implements IViewModel - IConfirmNavigationAsync

        public virtual async Task<bool> CanNavigateAsync(INavigationParameters parameters) { await Task.CompletedTask; return true; }

        #endregion

    }

}
