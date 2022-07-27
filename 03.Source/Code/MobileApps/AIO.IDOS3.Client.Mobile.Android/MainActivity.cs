using AIO.IDOS3.Client.Mobile.Android.DependencyServices;
using AIO.IDOS3.Client.Mobile.Android.Themes;
using AIO.IDOS3.Client.Mobile.Themes;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using FFImageLoading.Forms.Platform;
using Xamarin;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Android
{

    [Activity(Label = "@string/app_name", Icon = "@mipmap/icon", RoundIcon = "@mipmap/icon_round", Theme = "@style/MainTheme",
        MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode)]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {

        #region Events

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }



        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            AppService.Init(this);
            DeviceService.Init(this);
            FileService.Init(this);
            DependencyServices.BluetoothService.Init(this);
            ImageProcessingService.Init(this);

            var databaseFileName = "idos3_mobile.db";
            DatabaseService.Init(this, databaseFileName);

            CreateNotificationChannel();

            CachedImageRenderer.Init(true);

            BackgroundJobManager.Init(this);

            Platform.Init(this, savedInstanceState);
            Forms.Init(this, savedInstanceState);
            FormsMaps.Init(this, savedInstanceState);

            var themeLoader = (PlatformThemeLoader)DependencyService.Get<IThemeLoader>();
            if (themeLoader != null)
                themeLoader.Activity = this;

            var environment = (PlatformThemeEnvironment)DependencyService.Get<IThemeEnvironment>();
            if (environment != null)
                environment.Activity = this;

            LoadApplication(new App());
        }

        protected override void OnNewIntent(Intent intent)
        {
            base.OnNewIntent(intent);

            //var application = (App)Xamarin.Forms.Application.Current;
            //if (application)
            //    application.ProcessNotificationIfNeed(intent.GetReminderId(), intent.GetRecurrenceIndex());
        }



        private void CreateNotificationChannel()
        {
            //if (Build.VERSION.SdkInt >= BuildVersionCodes.O)
            //{
            //    var notificationManager = (NotificationManager)GetSystemService(Context.NotificationService);
            //    var channel = new NotificationChannel("location_notification", "count", NotificationImportance.Default);
            //    notificationManager.CreateNotificationChannel(channel);
            //}
        }
                
        #endregion

    }

}
