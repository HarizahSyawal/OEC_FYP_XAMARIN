using AIO.IDOS3.Client.Mobile.Models;
using Prism.Navigation;
using Prism.Services.Dialogs;

namespace AIO.IDOS3.Client.Mobile.ViewModels
{
    public class AttemptTestViewModel : PageViewModelBase<AttemptTestModel>
    {
        #region Fields

        #endregion

        #region Constructors
        public AttemptTestViewModel(INavigationService navigationService, Prism.Services.IPageDialogService pageDialogService, IDialogService dialogService)
            : base(navigationService, pageDialogService, dialogService)
        {
            Title = "Attempt Aptitude Test";
        }
        #endregion

        #region Properties

        #endregion

        #region Methods
    }


    #endregion
}
