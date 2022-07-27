using Prism.Services.Dialogs;
using System.Threading.Tasks;

namespace AIO.IDOS3.Client.Mobile.ViewModels
{

    public interface IDialogViewModel: IDialogAware
    {

        #region Properties

        public IViewModel ParentViewModel { get; set; }

        string Title { get; set; }
        bool IsBusy { get; set; }
        bool IsLocked { get; set; }

        #endregion

        #region Methods

        void RaiseRequestClose();
        void RaiseRequestClose(IDialogParameters parameters);

        Task RaiseRequestCloseAsync();
        Task RaiseRequestCloseAsync(IDialogParameters parameters);

        Task<bool> CanCloseDialogAsync();
        Task OnBackButtonPressed();

        #endregion

    }

}
