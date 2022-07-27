using AIO.IDOS3.Client.Mobile.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Views
{

    [DesignTimeVisible(false)]
    public partial class MainPage : PageBase<MainViewModel>
    {

        #region Constructors

        public MainPage()
        {
            InitializeComponent();

            ViewModel.TabView = tabView;

            ViewModel.AccountViewModel = vwAccount.ViewModel;
            ViewModel.ApplyUniversitiesViewModel = vwApplyUniversities.ViewModel;
        }
        #endregion

    }
}