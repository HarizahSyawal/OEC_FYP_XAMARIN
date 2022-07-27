using System;
using System.Collections.Generic;
using System.ComponentModel;
using AIO.IDOS3.Client.Mobile.ViewModels;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Views
{
    [DesignTimeVisible(false)]
    public partial class UniversityInfo : ViewBase<UniversityInfoViewModel>
    {
        public UniversityInfo()
        {
            InitializeComponent();
            listView.ItemTapped += ListView_ItemTapped;
        }
        #region Events

        private void ListView_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            if (e.Item != null)
                ViewModel.NavigateToDetailsCommand.Execute(e.Item);
        }

        #endregion
    }
}
