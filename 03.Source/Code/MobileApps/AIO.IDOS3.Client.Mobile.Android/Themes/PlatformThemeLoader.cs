using AIO.IDOS3.Client.Mobile.Android.Themes;
using AIO.IDOS3.Client.Mobile.Themes;
using Android.OS;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Dependency(typeof(PlatformThemeLoader))]
[assembly: Dependency(typeof(PlatformThemeEnvironment))]
namespace AIO.IDOS3.Client.Mobile.Android.Themes
{

    public class PlatformThemeLoader : IThemeLoader
    {

        #region Constructors

        public PlatformThemeLoader()
        {

        }

        #endregion

        #region Properties

        public MainActivity Activity { get; set; }

        #endregion

        #region Methods

        public void LoadTheme(ResourceDictionary theme, bool isLightTheme)
        {
            var statusBarColor = ((Color)theme["StatusBarColor"]).ToAndroid();
            var navigationBarColor = ((Color)theme["NavigationBarColor"]).ToAndroid();

            Device.BeginInvokeOnMainThread(() =>
            {
                var currentWindow = GetCurrentWindow();

                currentWindow.DecorView.SystemUiVisibility = (isLightTheme) ? ((StatusBarVisibility)SystemUiFlags.LightStatusBar | (StatusBarVisibility)SystemUiFlags.LightNavigationBar) : 0;

                if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                    currentWindow.SetStatusBarColor(statusBarColor);

                if (Build.VERSION.SdkInt >= BuildVersionCodes.OMr1)
                    currentWindow.SetNavigationBarColor(navigationBarColor);
            });
        }



        private Window GetCurrentWindow()
        {
            var window = Activity.Window;

            window.ClearFlags(WindowManagerFlags.TranslucentStatus);
            window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);

            return window;
        }

        #endregion

    }

}
