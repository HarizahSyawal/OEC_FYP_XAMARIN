using AIO.IDOS3.Client.Mobile.Models;
using AIO.IDOS3.Client.Mobile.Views;
using AIO.IDOS3.Client.Mobile.Views.AptitudeTest;
using AIO.IDOS3.Client.Mobile.Views.Consultation;
using AIO.IDOS3.Client.Mobile.Views.Universities;
using AIO.IDOS3.Mobile.Data.SQLiteNet;
using DevExpress.XamarinForms.Navigation;
using Prism.Navigation;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.ViewModels
{

    public class MainViewModel : PageViewModelBase<object>
    {

        #region Constructors

        public MainViewModel(INavigationService navigationService, Prism.Services.IPageDialogService pageDialogService, IDialogService dialogService)
            : base(navigationService, pageDialogService, dialogService)
        {
            Title = "";

            NavigateToConsultationCommand = new Command(async () => await OnNavigateToConsultation());
            NavigateToApplyUniversitiesCommand = new Command(async () => await OnNavigateToApplyUniversities());
            NavigateToAptitudePageCommand = new Command(async () => await OnNavigateToAptitudePage());

            MyEvents = GetEvents();
        }

        #endregion

        #region Properties

        public ObservableCollection<Event> MyEvents { get; set; }

        public TabView TabView { get; set; }

        private TabViewItem prevSelectedTabViewItem = null;
        private TabViewItem selectedTabViewItem = null;
        public TabViewItem SelectedTabViewItem { get { return selectedTabViewItem; } set { SetProperty(ref selectedTabViewItem, value); } }

        public TabViewItem SalesRoutesTabViewItem { get; set; }

        public TabView SalesRoutesTabView { get; set; }

        private TabViewItem prevSalesRoutesSelectedTabViewItem = null;
        private TabViewItem salesRoutesSelectedTabViewItem = null;
        public TabViewItem SalesRoutesSelectedTabViewItem { get { return salesRoutesSelectedTabViewItem; } set { SetProperty(ref salesRoutesSelectedTabViewItem, value); } }

        public TabViewItem SalesInRoutesTabViewItem { get; set; }
        public TabViewItem SalesOutRoutesTabViewItem { get; set; }
        public TabViewItem NewCustomerRoutesTabViewItem { get; set; }

        public TabViewItem CollectionRoutesTabViewItem { get; set; }

        public AccountViewModel AccountViewModel { get; set; }
        public ApplyUniversitiesViewModel ApplyUniversitiesViewModel { get; set; }

        public ICommand NavigateToConsultationCommand { get; }
        public ICommand NavigateToApplyUniversitiesCommand { get; }
        public ICommand NavigateToAptitudePageCommand { get; }


        private string userName = "";
        public string UserName { get { return userName; } set { SetProperty(ref userName, value); } }

        #endregion

        #region Methods

        private ObservableCollection<Event> GetEvents()
        {
            return new ObservableCollection<Event>
            {
                new Event { Title = "Xamarin Forms Masterclass", Image = "https://i.ytimg.com/vi/RWvWxrBkPKE/maxresdefault.jpg", Venue = "Register Online", Duration = "07:30 UTC - 09:30 UTC", Date = new DateTime(2020, 6, 8), Description = "This masterclass was design to help you take your Xamarin Forms Development to the next level. Register here: https://bit.ly/2XbkoTG"},
                new Event { Title = "Training: WDC Solution", Image = "https://i.ytimg.com/vi/VylSJkhWKQU/sddefault.jpg", Venue = "Zoom Meeting", Duration = "07:30 UTC - 09:30 UTC", Date = new DateTime(2020, 6, 9), Description = "Want to maximize your European vacation? Move through Europe with ease & discover how to travel around Europe by train with as little as possible."},
                new Event { Title = "World Dogs Championship", Image = "http://tree.utm.my/wp-content/uploads/2020/07/Webinar9-2020-Prof-Fatin-1024x723.jpeg", Venue = "Virtual Challenge", Duration = "07:30 UTC - 09:30 UTC", Date = new DateTime(2020, 6, 10), Description = "A dog earns a championship with wins at a specified number of conformation shows, where a judge evaluates a dog's breed type and how closely the dog approaches the ideal represented in its breed's standard."},
                new Event { Title = "Book Review Conference", Image = "http://science.utm.my/icowobas2019/files/2019/06/banner_v4.jpg", Venue = "Online", Duration = "07:30 UTC - 09:30 UTC", Date = new DateTime(2020, 6, 11), Description = "And whether you are a publishing insider or simply a book nerd, you should be able to find something to suit you in this list of events in 2020."},
                new Event { Title = "Tea Ceremony", Image = "https://i.ytimg.com/vi/Jj_YO1gF-aQ/maxresdefault.jpg", Venue = "Virtual Meetup", Duration = "07:30 UTC - 09:30 UTC", Date = new DateTime(2020, 6, 12), Description = "The tea ceremony sees the simple task of preparing a drink for a guest elevated to an art form, an intricate series of movements performed in strict order."}
            };
        }

        private async Task OpenAnimation(View view, uint length = 250)
        {
            view.RotationX = -90;
            view.IsVisible = true;
            view.Opacity = 0;
            _ = view.FadeTo(1, length);
            await view.RotateXTo(0, length);
        }

        private async Task CloseAnimation(View view, uint length = 250)
        {
            _ = view.FadeTo(0, length);
            await view.RotateXTo(-90, length);
            view.IsVisible = false;
        }

        private async Task MainExpander_Tapped(object sender, EventArgs e)
        {
            var expander = sender as Xamarin.CommunityToolkit.UI.Views.Expander;
            var imgView = expander.FindByName<Grid>("ImageView");
            var detailsView = expander.FindByName<Grid>("DetailsView");

            if (expander.IsExpanded)
            {
                await OpenAnimation(imgView);
                await OpenAnimation(detailsView);
            }
            else
            {
                await CloseAnimation(detailsView);
                await CloseAnimation(imgView);
            }
        }

        public override async void OnNavigatedTo(INavigationParameters parameters)
        {

            base.OnNavigatedTo(parameters);

            var navigationMode = parameters.ContainsKey("NavigationMode") ? parameters.GetValue<NavigationMode>("NavigationMode") : parameters.GetNavigationMode();

            switch (navigationMode)
            {
                case NavigationMode.New:
                    IsBusy = true;
                    /*await Task.Yield();*/
                    break;
            }

            var userName = "";

            switch (navigationMode)
            {
                case NavigationMode.New:
                    await Task.Run(async () =>
                    {
                        try
                        {
                            var dbContext = MobileDbContext.Current;

                            //var userTableProvider = dbContext.GetDataTableProvider<mvUserTableProvider>();

                            //var user = await userTableProvider.GetData().FirstOrDefaultAsync();
                            //if (user != null)
                            //    userName = user.Name;
                        }
                        catch { }
                    });

                    UserName = userName;

                    break;
            }

            IsBusy = false;
            /*await Task.Yield();*/
        }

        private bool isBackButtonBusy = false;
        public override async Task OnBackButtonPressed()
        {
            if (!isBackButtonBusy)
            {
                isBackButtonBusy = true;

                IDialogViewModel childDialogViewModel = null;

                if (childDialogViewModel != null)
                    await childDialogViewModel.OnBackButtonPressed();

                isBackButtonBusy = false;
            }
        }

        private async Task OnNavigateToApplyUniversities()
        {
            if (!IsBusy)
            {
                IsBusy = true;
                /*await Task.Yield();*/

                await Device.InvokeOnMainThreadAsync(async () =>
                {
                   await NavigationService.NavigateAsync(nameof(DetailsPage), new NavigationParameters(), false, true);

                    IsBusy = false;
                    /*await Task.Yield();*/
                });
            }
        }

        private async Task OnNavigateToConsultation()
        {
            if (!IsBusy)
            {
                IsBusy = true;
                /*await Task.Yield();*/

                await Device.InvokeOnMainThreadAsync(async () =>
                {
                 await NavigationService.NavigateAsync(nameof(Consultation), new NavigationParameters(), false, true);

                    IsBusy = false;
                    /*await Task.Yield();*/
                });
            }
        }

        private async Task OnNavigateToAptitudePage()
        {
            if (!IsBusy)
            {
                IsBusy = true;
                /*await Task.Yield();*/

                await Device.InvokeOnMainThreadAsync(async () =>
                {
                    await NavigationService.NavigateAsync(nameof(AptitudePage), new NavigationParameters(), false, true);

                    IsBusy = false;
                    /*await Task.Yield();*/
                });
            }
        }

        #endregion

    }

}
