using Prism.Navigation;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.ViewModels
{

    public class AboutViewModel : ViewModelBase<object>
    {

        #region Constructors

        public AboutViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "About";

            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.linkedin.com/in/harizahsyawal"));
        }

        #endregion

        #region Properties

        public ICommand OpenWebCommand { get; }

        #endregion

    }

}