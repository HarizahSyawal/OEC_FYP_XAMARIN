using AIO.IDOS3.Client.Mobile.Models;
using Prism.Navigation;
using Prism.Services.Dialogs;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.ViewModels
{

    public class EditTransactionViewModelBase<T> : EditPageViewModelBase<T> where T : EditTransactionModelBase, new()
    {

        #region Constructors

        public EditTransactionViewModelBase(INavigationService navigationService, Prism.Services.IPageDialogService pageDialogService, IDialogService dialogService)
            : base(navigationService, pageDialogService, dialogService)
        {
            PerformNewRowCommand = new Command(async () => await OnPerformNewRow());
            PerformEditRowCommand = new Command<object>(async (object id) => await OnPerformEditRow(id));
            PerformDeleteRowCommand = new Command<object>(async (object id) => await OnPerformDeleteRow(id));
        }

        #endregion

        #region Properties

        public ICommand PerformNewRowCommand { get; }
        public ICommand PerformEditRowCommand { get; }
        public ICommand PerformDeleteRowCommand { get; }

        #endregion

        #region Methods

        protected virtual async Task OnAddingRow() { await Task.CompletedTask; }
        protected virtual async Task OnEditingRow(object id) { await Task.CompletedTask; }
        protected virtual async Task OnDeletingRow(object id) { await Task.CompletedTask; }
        


        private async Task OnPerformNewRow()
        {
            if (!IsLocked)
            {
                IsLocked = true;
                /*await Task.Yield();*/

                await Device.InvokeOnMainThreadAsync(async () =>
                {
                    await OnAddingRow();

                    IsLocked = false;
                    /*await Task.Yield();*/
                });
            }
        }

        private async Task OnPerformEditRow(object id)
        {
            if (!IsLocked)
            {
                IsLocked = true;
                /*await Task.Yield();*/

                await Device.InvokeOnMainThreadAsync(async () =>
                {
                    await OnEditingRow(id);

                    IsLocked = false;
                    /*await Task.Yield();*/
                });
            }
        }

        private async Task OnPerformDeleteRow(object id)
        {
            if (!IsLocked)
            {
                if (await PageDialogService.DisplayAlertAsync("Delete Confirmation", "Are you sure want to delete this record?", "Yes", "No"))
                {
                    IsLocked = true;
                    /*await Task.Yield();*/

                    await Device.InvokeOnMainThreadAsync(async () =>
                    {
                        await OnDeletingRow(id);

                        IsLocked = false;
                        /*await Task.Yield();*/
                    });
                }
            }
        }

        #endregion

    }

}
