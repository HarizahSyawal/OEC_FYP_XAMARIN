using AIO.IDOS3.Client.Mobile.Android.Themes;
using AIO.IDOS3.Client.Mobile.Themes;
using Android.Content.Res;
using Android.OS;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(PlatformThemeLoader))]
[assembly: Dependency(typeof(PlatformThemeEnvironment))]
namespace AIO.IDOS3.Client.Mobile.Android.Themes
{

    public class PlatformThemeEnvironment : IThemeEnvironment
    {

        #region Properties

        public MainActivity Activity { get; set; }

        #endregion

        #region Methods

        public Task<bool> IsLightOperatingSystemTheme()
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Froyo)
            {
                var uiModeFlags = (Activity.ApplicationContext.Resources.Configuration.UiMode & UiMode.NightMask);
                switch (uiModeFlags)
                {
                    case UiMode.NightYes:
                        return Task.FromResult(false);
                }
            }            

            return Task.FromResult(true);
        }

        #endregion

    }

}
