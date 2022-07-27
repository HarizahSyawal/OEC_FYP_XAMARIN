using AIO.IDOS3.Client.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Views
{

    [DesignTimeVisible(false)]
    public partial class PageBase<TViewModel> : ContentPage where TViewModel: IPageViewModel
    {

        #region Constructors

        public PageBase()
        {
            
        }

        #endregion

        #region Properties

        public TViewModel ViewModel { get { return (TViewModel)BindingContext; } }

        #endregion

        #region Methods

        protected override bool OnBackButtonPressed()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                await ViewModel.OnBackButtonPressed();
            });
            
            return true;
        }

        #endregion

    }

}
