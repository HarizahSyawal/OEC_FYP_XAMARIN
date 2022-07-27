using AIO.IDOS3.Client.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Views
{

    [DesignTimeVisible(false)]
    public partial class LoginPage : PageBase<LoginViewModel>
    {

        #region Constructors

        public LoginPage()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        protected override void OnAppearing()
        {
            base.OnAppearing();

            txtUserName.Completed += TxtUserName_Completed;
            txtPassword.Completed += TxtPassword_Completed;

            List<Image> imageSources = new List<Image>()
            {
                new Image(){Title="Image 1",Url="utm1.jpeg"},
                new Image(){Title="Image 2",Url="utm2.jpeg"},
                new Image(){Title="Image 3",Url="utm3.jpeg"}

            };

            crsGallery.ItemsSource = imageSources;
        }

        protected override void OnDisappearing()
        {
            txtUserName.Completed -= TxtUserName_Completed;
            txtPassword.Completed -= TxtPassword_Completed;

            base.OnDisappearing();
        }

        #endregion

        #region Events

        private void TxtPassword_Completed(object sender, System.EventArgs e)
        {
            txtPassword.Focus();
        }

        private void TxtUserName_Completed(object sender, System.EventArgs e)
        {
            ViewModel.PerformLoginCommand.Execute(null);
        }

        #endregion
        
    }

}
