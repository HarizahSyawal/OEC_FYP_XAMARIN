using AIO.IDOS3.Client.Mobile.Models;
using Prism.Services.Dialogs;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.ViewModels
{

    public class EditDialogViewModelBase<T> : DialogViewModelBase<T> where T : BindableErrorBase, new()
    {

        #region Constructors

        public EditDialogViewModelBase()
            : base()
        {
            PerformSaveCommand = new Command(async () => await OnPerformSave());
            PerformCancelCommand = new Command(async () => await OnPerformCancel());
        }

        #endregion

        #region Properties

        public ICommand PerformSaveCommand { get; }
        public ICommand PerformCancelCommand { get; }

        #endregion

        #region Methods

        public override async void OnDialogOpened(IDialogParameters parameters)
        {
            IsBusy = true;
            /*await Task.Yield();*/

            base.OnDialogOpened(parameters);
            await OnDialogOpening(parameters);
        }

        public override async void OnDialogClosed()
        {
            await Device.InvokeOnMainThreadAsync(async () =>
            {                
                await OnDialogClosing();
                base.OnDialogClosed();

                IsBusy = false;
                /*await Task.Yield();*/
            });

            await Task.CompletedTask;
        }

        public override async Task<bool> CanCloseDialogAsync()
        {
            return await base.CanCloseDialogAsync();
        }



        protected virtual async Task OnDialogOpening(IDialogParameters parameters) { await Task.CompletedTask; }
        protected virtual async Task OnDialogClosing() { await Task.CompletedTask; }
        protected virtual async Task<bool> OnSaving(IDialogParameters parameters) { await Task.CompletedTask; return true; }
        protected virtual async Task<bool> OnCancelling(IDialogParameters parameters) { await Task.CompletedTask; return true; }



        private async Task OnPerformSave()
        {
            if (!IsBusy)
            {
                if (Model.Validate())
                {
                    IsBusy = true;
                    /*await Task.Yield();*/

                    await Device.InvokeOnMainThreadAsync(async () =>
                    {
                        var parameters = new DialogParameters();

                        parameters.Add("IsSave", true);

                        if (await OnSaving(parameters))
                            await RaiseRequestCloseAsync(parameters);
                    });
                }
            }
        }

        private async Task OnPerformCancel()
        {
            if (!IsBusy)
            {
                IsBusy = true;
                /*await Task.Yield();*/

                await Device.InvokeOnMainThreadAsync(async () =>
                {
                    var parameters = new DialogParameters();

                    parameters.Add("IsSave", false);

                    if (await OnCancelling(parameters))
                        await RaiseRequestCloseAsync(parameters);
                });
            }
        }

        #endregion

    }

}
