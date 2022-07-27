using AIO.IDOS3.Client.Mobile.DependencyServices;
using AIO.IDOS3.Client.Mobile.Models;
using Prism.Navigation;
using Prism.Services.Dialogs;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.ViewModels
{

    public class ImagePreviewViewModel : EditPageViewModelBase<BindableErrorBase>
    {

        #region Constructors

        public ImagePreviewViewModel(INavigationService navigationService, Prism.Services.IPageDialogService pageDialogService, IDialogService dialogService)
            : base(navigationService, pageDialogService, dialogService)
        {
            Title = "ImagePreview";

            UseCancelConfirmation = false;

            ImagePreviewSource.BaseUrl = DependencyService.Resolve<IFileService>().GetAssetFileUrl("changelog.txt");
        }

        #endregion

        #region Properties

        private HtmlWebViewSource changelogSource = new HtmlWebViewSource();
        public HtmlWebViewSource ImagePreviewSource { get { return changelogSource; } set { SetProperty(ref changelogSource, value); } }

        #endregion

    }

}