using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using AIO.IDOS3.Client.Mobile.Models;
using AIO.IDOS3.Client.Mobile.Views;
using Prism.Navigation;
using Prism.Services.Dialogs;
using Xamarin.Forms;
using static AIO.IDOS3.Client.Mobile.Models.ApplyUniversitiesModel;

namespace AIO.IDOS3.Client.Mobile.ViewModels
{
    public class ApplyUniversitiesViewModel : TabViewItemViewModelBase<ApplyUniversitiesModel>
    {

        #region Constructors
        public ApplyUniversitiesViewModel(INavigationService navigationService, Prism.Services.IPageDialogService pageDialogService, IDialogService dialogService)
            : base(navigationService, pageDialogService, dialogService)
        {
            Title = "Apply University";

            PerformRefreshDataCommand = new Command(async () => await OnPerformRefreshData());
            NavigateToDetailsCommand = new Command<ApplyUniversitiesModel.ListUniv>(async (item) => await OnNavigateToDetails(item));

            Model = new ApplyUniversitiesModel();

            Model.ListUniversities.Add(new ListUniv() { ID = 1, UnivName = "Universiti Teknologi Malaysia", AdressName = "Skudai, Johor Bahru", UnivPhoto = "UTMProfile.jpg" });

        }

        #endregion

        #region Properties
        public ICommand PerformRefreshDataCommand { get; }
        public ICommand NavigateToDetailsCommand { get; }

        private bool isRefreshing = false;
        public bool IsRefreshing { get { return isRefreshing; } set { SetProperty(ref isRefreshing, value); } }

        #endregion

        #region Methods
        public async Task RefreshData() { IsBusy = true; /*await Task.Yield();*/ await OnPerformRefreshData(); }

        public override async Task OnSelectedChanged(bool selected)
        {
            await base.OnSelectedChanged(selected);

            if (selected)
            {
                await Device.InvokeOnMainThreadAsync(async () =>
                {
                    await RefreshData();
                });
            }
        }

        public async Task OnPerformRefreshData()
        {
            _ = Task.Run(async () =>
            {
                Exception exception = null;

               // UnivList = new ObservableCollection<ListUniv>();

                try
                {
                    //UnivList.Add(new ListUniv() { ID = 1, UnivName = "Universiti Teknologi Malaysia", AdressName = "Skudai, Johor Bahru", UnivPhoto = "UTMProfile.jpg" });
                    //UnivList.Add(new ListUniv() { ID = 2, UnivName = "Universiti Teknologi Malaysia", AdressName = "Jalan Sultan Yahya Petra, Kampung Datuk Keramat, 54100 Kuala Lumpur", UnivPhoto = "UTMProfile.jpg" });
                    //UnivList.Add(new ListUniv() { ID = 3, UnivName = "Universiti Teknologi Malaysia", AdressName = "Pagoh, Johor, Malaysia", UnivPhoto = "UTMProfile.jpg" });

                }
                catch (Exception ex)
                {
                    exception = ex;

                    Debug.Write(ex, "App.OnInitialize"); ////////////////////////
                }
                await Device.InvokeOnMainThreadAsync(async () =>
                {

                    IsBusy = false;
                    IsRefreshing = false;
                    /*await Task.Yield();*/
                });
            });

            await Task.CompletedTask;
        }

        protected async Task OnNavigateToDetails(ApplyUniversitiesModel.ListUniv item)
        {
            if (!IsBusy)
            {
                IsBusy = true;
                /*await Task.Yield();*/

                await Device.InvokeOnMainThreadAsync(async () =>
                {
                    var navigationParams = new NavigationParameters();

                    navigationParams.Add("UnivName", item.UnivName);
                    navigationParams.Add("UnivPhoto", item.UnivPhoto);
                    navigationParams.Add("AdressName", item.AdressName);

                    await NavigationService.NavigateAsync(string.Format("/{0}/{1}", nameof(NavigationPage), nameof(DetailsPage)));

                    IsBusy = false;
                    /*await Task.Yield();*/
                });
            }
        }

    }
    #endregion
}
