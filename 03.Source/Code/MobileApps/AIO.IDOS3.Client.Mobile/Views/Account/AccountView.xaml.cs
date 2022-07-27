using AIO.IDOS3.Client.Mobile.ViewModels;
using System;
using System.ComponentModel;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Views
{

    [DesignTimeVisible(false)]
    public partial class AccountView : ViewBase<AccountViewModel>
    {

        #region Constructors

        public AccountView()
        {
            InitializeComponent();
        }

        #endregion

    }

}