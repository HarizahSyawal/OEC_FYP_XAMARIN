using System.ComponentModel;
using AIO.IDOS3.Client.Mobile.ViewModels;


namespace AIO.IDOS3.Client.Mobile.Views
{
    [DesignTimeVisible(false)]
    public partial class ApplyUniversities : ViewBase<ApplyUniversitiesViewModel>
    {
        public ApplyUniversities()
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