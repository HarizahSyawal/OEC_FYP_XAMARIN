using AIO.IDOS3.Client.Mobile.DependencyServices;
using AIO.IDOS3.Client.Mobile.Themes;
using AIO.IDOS3.Client.Mobile.ViewModels;
using AIO.IDOS3.Client.Mobile.Views;
using AIO.IDOS3.Client.Mobile.Views.Account;
using AIO.IDOS3.Client.Mobile.Views.AptitudeTest;
using AIO.IDOS3.Client.Mobile.Views.Consultation;
using AIO.IDOS3.Client.Mobile.Views.Universities;
using AIO.IDOS3.Mobile.Data.SQLiteNet;
using DevExpress.XamarinForms.Core.Themes;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using XFShimmerLayout.Controls;

namespace AIO.IDOS3.Client.Mobile
{

    public partial class App : PrismApplication
    {

        #region Static Members

        // FOR TESTING WITH LOCAL WEB SERVICE ONLY: ForceUseLocalDevService --> True: Force Local, False: Normal
        public static bool ForceUseLocalDevService = true;
        public static string LocalDevServiceRoot = "http://192.168.1.15"; // LOCAL DEV
        public static string LocalDevDataServiceRoot = LocalDevServiceRoot + "/OECApp/DataServices"; // LOCAL DEV
        public static string LocalDevFileServiceRoot = LocalDevServiceRoot + "/OECApp/FileServices";
        public static string LocalDevSignalRCommandHubServiceRoot = LocalDevServiceRoot + "/OECApp/ChatHub";

        // PRODUCTION WEB SERVICE
        public static string ProductionServiceRoot = "http://192.168.157.122";
        public static string ProductionDataServiceRoot = ProductionServiceRoot + "/OECApp/DataServices";
        public static string ProductionFileServiceRoot = ProductionServiceRoot + "/OECApp/FileServices";
        public static string ProductionSignalRCommandHubServiceRoot = ProductionServiceRoot + "/OECApp/ChatHub";

        //// DEVELOPMENT WEB SERVICE
        //public static string DevelopmentServiceRoot = "DevENV"; // DEV
        //public static string DevelopmentDataServiceRoot = DevelopmentServiceRoot + "/OECAppOECApp/DataServices";
        //public static string DevelopmentFileServiceRoot = DevelopmentServiceRoot + "/OECApp/FileServices";
        //public static string DevelopmentSignalRCommandHubServiceRoot = DevelopmentServiceRoot + "/OECAppOECApp/CommandHub";

        // ACTIVE ENVIRONMENT WEB SERVICE
        public static string ServiceRoot = LocalDevServiceRoot;
        public static string DataServiceRoot = LocalDevDataServiceRoot;
        public static string FileServiceRoot = LocalDevFileServiceRoot;
        public static string SignalRCommandHubServiceRoot = LocalDevSignalRCommandHubServiceRoot;

        public static string DownloadFileServiceMethod { get { return (FileServiceRoot + "/Download"); } }
        public static string UploadFileServiceMethod { get { return (FileServiceRoot + "/Upload"); } }


        public static int DBVersionNumber = 2022012501; // Format: yyyymmddnn --> nn: daily running number
        public static string Version = "OEC.MobileApp (2022.04.01-01)"; // Format: yyyy.mm.dd-nn --> nn: daily running number
        
        public static bool? IsLightTheme = null;

        #endregion

        #region Classes

        public class GlobalResources : INotifyPropertyChanged
        {

            #region Static Members

            public readonly static GlobalResources Current = new GlobalResources();

            #endregion

            #region Properties

            public string AppVersion { get { return App.Version; } }


            private Guid deviceID = Guid.Empty;
            public Guid DeviceID { get { return deviceID; } set { deviceID = value; OnPropertyChanged("DeviceID"); } }

            private string deviceIMEI = "";
            public string DeviceIMEI { get { return deviceIMEI; } set { deviceIMEI = value; OnPropertyChanged("DeviceIMEI"); } }

          

            #endregion

            #region Implements INotifyPropertyChanged

            public event PropertyChangedEventHandler PropertyChanged;

            protected virtual void OnPropertyChanged(string propertyName) { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); }

            #endregion

        }

        #endregion

        #region Constructors

        public App()
            : this(null)
        {
            
        }

        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
            DevExpress.XamarinForms.Navigation.Initializer.Init();
            DevExpress.XamarinForms.CollectionView.Initializer.Init();
            DevExpress.XamarinForms.DataGrid.Initializer.Init();
            DevExpress.XamarinForms.Editors.Initializer.Init();

            Xamarin.Forms.Application.Current.On<Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Pan);
            InitializeComponent();

            ShimmerLayout.Init(Xamarin.Essentials.DeviceDisplay.MainDisplayInfo.Density);
            Sharpnado.Shades.Initializer.Initialize(false);

            IsLightTheme = true; // Set Light Theme
            ThemeLoader.Instance.LoadTheme(); // Read from current operating system theme
        }

        #endregion

        #region Methods

        protected override async void OnInitialized()
        {
            await NavigationService.NavigateAsync(string.Format("/{0}", nameof(AppInitPage)));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            MobileDbContext.DataServiceServiceRoot = new Uri(DataServiceRoot);
            MobileDbContext.ConnectionString = DependencyService.Resolve<IDatabaseService>().GetDatabaseFilePath();
                                   
            
            containerRegistry.RegisterForNavigation<AppInitPage, AppInitViewModel>();

            containerRegistry.RegisterForNavigation<NavigationPage>();

            containerRegistry.RegisterForNavigation<LoginPage, LoginViewModel>();
            containerRegistry.RegisterForNavigation<AppUpdatePage, AppUpdateViewModel>();
            containerRegistry.RegisterForNavigation<ChangelogPage, ChangelogViewModel>();

            containerRegistry.RegisterForNavigation<MainPage, MainViewModel>();

            containerRegistry.RegisterForNavigation<AboutPage, AboutViewModel>();
            containerRegistry.RegisterForNavigation<AptitudePage, AptitudePageViewModel>();

            containerRegistry.RegisterForNavigation<AttemptTest, AttemptTestViewModel>();
            containerRegistry.RegisterForNavigation<SignUpPage, SignUpPageViewModel>();
            containerRegistry.RegisterForNavigation<HelpPage, HelpPageViewModel>();
            containerRegistry.RegisterForNavigation<PrivacyPolicy, PrivacyPolicyViewModel>();
            containerRegistry.RegisterForNavigation<TermCondition, TermConditionViewModel>();
            containerRegistry.RegisterForNavigation<ProfilePage, ProfileViewModel>();
            containerRegistry.RegisterForNavigation<DetailsPage, DetailsPageViewModel>();
            containerRegistry.RegisterForNavigation<UTMSite, UTMSiteViewModel>();
            containerRegistry.RegisterForNavigation<Consultation, ConsultationViewModel>();
            containerRegistry.RegisterForNavigation<StudyProgram, ApplyUniversitiesViewModel>();


        }

        protected override async void OnStart()
        {
            base.OnStart();

            if (!IsLightTheme.HasValue)
                IsLightTheme = await DependencyService.Get<IThemeEnvironment>().IsLightOperatingSystemTheme();

            ApplyTheme(IsLightTheme.Value);
        }

        protected override async void OnSleep()
        {
            //base.OnSleep();

            await Task.CompletedTask;
        }

        protected override async void OnResume()
        {
            base.OnResume();

            if (!IsLightTheme.HasValue)
                IsLightTheme = await DependencyService.Get<IThemeEnvironment>().IsLightOperatingSystemTheme();

            ApplyTheme(IsLightTheme.Value);
        }



        internal void ApplyTheme(bool isLightTheme)
        {
            ThemeManager.ThemeName = (isLightTheme) ? Theme.Light : Theme.Dark;
        }

        #endregion

    }

}
