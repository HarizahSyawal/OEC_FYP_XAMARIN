using AIO.IDOS3.Client.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Views
{

    [DesignTimeVisible(false)]
    public partial class ViewBase<TViewModel> : ContentView where TViewModel : IViewModel
    {

        #region Constructors

        public ViewBase()
        {
            
        }

        #endregion

        #region Properties

        public TViewModel ViewModel { get { return (TViewModel)BindingContext; } }

        #endregion

    }

}
