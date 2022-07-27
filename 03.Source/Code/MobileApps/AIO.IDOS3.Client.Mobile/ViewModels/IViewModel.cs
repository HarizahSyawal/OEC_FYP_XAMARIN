using Prism.Navigation;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AIO.IDOS3.Client.Mobile.ViewModels
{

    public interface IViewModel : IInitialize, INavigationAware, IDestructible, IConfirmNavigationAsync
    {

        #region Properties

        IDialogViewModel ChildDialogViewModel { get; set; }
        
        string Title { get; set; }
        bool FirstLoad { get; set; }
        bool IsBusy { get; set; }
        bool IsLocked { get; set; }

        ICommand PerformBackButtonPressedCommand { get; set; }

        #endregion

        #region Methods

        Task OnBackButtonPressed();

        Task CustomAction(string key, params object[] parameters);

        #endregion

    }

}
