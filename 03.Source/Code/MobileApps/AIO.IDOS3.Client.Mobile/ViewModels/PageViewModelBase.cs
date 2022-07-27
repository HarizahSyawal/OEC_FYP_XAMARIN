using Prism.Navigation;
using Prism.Services;
using Prism.Services.Dialogs;
using System.Threading.Tasks;

namespace AIO.IDOS3.Client.Mobile.ViewModels
{

    public class PageViewModelBase<TModel> : ViewModelBase<TModel>, IPageViewModel where TModel : class, new()
    {

        #region Constructors

        public PageViewModelBase(INavigationService navigationService)
            : this(navigationService, null, null)
        {

        }

        public PageViewModelBase(INavigationService navigationService, IPageDialogService pageDialogService)
            : this(navigationService, pageDialogService, null)
        {

        }

        public PageViewModelBase(INavigationService navigationService, IPageDialogService pageDialogService, IDialogService dialogService)
            : base(navigationService, pageDialogService, dialogService)
        {

        }

        #endregion

        #region Implements IPageViewModel

        #endregion

        #region Implements IPageViewModel - IPageLifecycleAware

        public virtual async void OnAppearing() { await Task.CompletedTask; }
        public virtual async void OnDisappearing() { await Task.CompletedTask; }

        #endregion

    }

}
