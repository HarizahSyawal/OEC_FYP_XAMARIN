using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.ViewModels
{

    public class DialogViewModelBase<TModel> : BindableBase, IDialogViewModel, IDialogAware where TModel : class, new()
    {

        #region Constructors

        public DialogViewModelBase()
        {
            
        }

        #endregion

        #region Properties

        private TModel model = new TModel();
        public TModel Model { get { return model; } set { SetProperty(ref model, value); } }

        #endregion

        #region Implements IDialogViewModel

        public IViewModel ParentViewModel { get; set; }


        private string title = "";
        public string Title { get { return title; } set { SetProperty(ref title, value); } }

        private bool isBusy = false;
        public bool IsBusy { get { return isBusy; } set { SetProperty(ref isBusy, value); } }

        private bool isLocked = false;
        public bool IsLocked { get { return isLocked; } set { SetProperty(ref isLocked, value); } }


        public virtual void RaiseRequestClose() { RaiseRequestClose(null); }
        public virtual void RaiseRequestClose(IDialogParameters parameters) { RaiseRequestCloseAsync(parameters).Wait(); }

        public virtual async Task RaiseRequestCloseAsync() { await RaiseRequestCloseAsync(null); }
        public virtual async Task RaiseRequestCloseAsync(IDialogParameters parameters) { RequestClose(parameters); await Task.CompletedTask; }

        public virtual async Task<bool> CanCloseDialogAsync() { await Task.CompletedTask; return CanCloseDialog(); }

        public virtual async Task OnBackButtonPressed()
        {
            await Device.InvokeOnMainThreadAsync(async () =>
            {
                await RaiseRequestCloseAsync();
            });

            await Task.CompletedTask;
        }

        #endregion

        #region Implements IDialogAware

        public event Action<IDialogParameters> RequestClose;


        public virtual bool CanCloseDialog() { return true; }

        public virtual async void OnDialogOpened(IDialogParameters parameters)
        {
            if (parameters != null)
            {
                ParentViewModel = parameters.GetValue<IViewModel>("ParentViewModel");
                if (ParentViewModel != null)
                    ParentViewModel.ChildDialogViewModel = this;
            }

            await Task.CompletedTask;
        }

        public virtual async void OnDialogClosed()
        {
            if (ParentViewModel != null)
            {
                ParentViewModel.ChildDialogViewModel = null;
                ParentViewModel = null;
            }

            await Task.CompletedTask;
        }

        #endregion

    }

}
