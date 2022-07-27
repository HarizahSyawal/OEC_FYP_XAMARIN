using System.Collections.Generic;
using System.ComponentModel;
using AIO.IDOS3.Client.Mobile.ViewModels;

namespace AIO.IDOS3.Client.Mobile.Views
{
    [DesignTimeVisible(false)]
    public partial class SignUpPage : PageBase<SignUpPageViewModel>
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        #region Methods

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
           txtUserName.Completed -= TxtUserName_Completed;
            txtPassword.Completed -= TxtPassword_Completed;

            base.OnDisappearing();
        }

        #endregion

        #region Events

        private void TxtUserName_Completed(object sender, System.EventArgs e)
        {
            ViewModel.PerformLoginCommand.Execute(null);
        }

        private void TxtPassword_Completed(object sender, System.EventArgs e)
        {
            txtPassword.Focus();
        }

        #endregion
    }
}
