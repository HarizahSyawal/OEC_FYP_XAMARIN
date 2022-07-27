using System;
using AIO.IDOS3.Client.Mobile.Models;
using Prism.Navigation;
using Prism.Services.Dialogs;


namespace AIO.IDOS3.Client.Mobile.ViewModels
{
    public class HelpPageViewModel : PageViewModelBase<HelpPageModel>
    {
        public HelpPageViewModel(INavigationService navigationService, Prism.Services.IPageDialogService pageDialogService, IDialogService dialogService)
            : base(navigationService, pageDialogService, dialogService)

            {
            #region Constructors
            {
                Title = "Help";
            }

            #endregion
        }
    }
}
