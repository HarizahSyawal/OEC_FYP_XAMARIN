using System;
using Prism.Navigation;
using Prism.Services.Dialogs;

namespace AIO.IDOS3.Client.Mobile.ViewModels
{
    public class UTMSiteViewModel : ViewModelBase<object>
    {
        #region Constructors
        public UTMSiteViewModel(INavigationService navigationService, Prism.Services.IPageDialogService pageDialogService, IDialogService dialogService)
               : base(navigationService, pageDialogService, dialogService)
        {

        }

        #endregion
    }
}