using AIO.IDOS3.Client.Mobile.DependencyServices;
using AIO.IDOS3.Client.Mobile.Models;
using Prism.Navigation;
using Prism.Services.Dialogs;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.ViewModels
{

    public class ChangelogViewModel : EditPageViewModelBase<BindableErrorBase>
    {

        #region Constructors

        public ChangelogViewModel(INavigationService navigationService, Prism.Services.IPageDialogService pageDialogService, IDialogService dialogService)
            : base(navigationService, pageDialogService, dialogService)
        {
            Title = "Changelog";

            UseCancelConfirmation = false;

            ChangelogSource.BaseUrl = DependencyService.Resolve<IFileService>().GetAssetFileUrl("changelog.txt");
        }

        #endregion

        #region Properties

        private HtmlWebViewSource changelogSource = new HtmlWebViewSource();
        public HtmlWebViewSource ChangelogSource { get { return changelogSource; } set { SetProperty(ref changelogSource, value); } }

        #endregion

    }

}