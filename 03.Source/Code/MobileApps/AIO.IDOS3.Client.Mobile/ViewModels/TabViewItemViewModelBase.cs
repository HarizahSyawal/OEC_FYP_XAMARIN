using AIO.IDOS3.Client.Mobile.Views;
using Prism.Navigation;
using Prism.Services;
using Prism.Services.Dialogs;
using System.Threading.Tasks;

namespace AIO.IDOS3.Client.Mobile.ViewModels
{

    public class TabViewItemViewModelBase<TModel> : ViewModelBase<TModel>, ITabViewItem
        where TModel : class, new()
    {

        #region Constructors

        public TabViewItemViewModelBase(INavigationService navigationService)
            : this(navigationService, null, null)
        {

        }

        public TabViewItemViewModelBase(INavigationService navigationService, IPageDialogService pageDialogService)
            : this(navigationService, pageDialogService, null)
        {

        }

        public TabViewItemViewModelBase(INavigationService navigationService, IPageDialogService pageDialogService, IDialogService dialogService)
            : base(navigationService, pageDialogService, dialogService)
        {

        }

        #endregion

        #region Implements ITabViewItem

        public virtual async Task OnSelectedChanged(bool selected)
        {
            await Task.CompletedTask;
        }

        #endregion

    }

}
