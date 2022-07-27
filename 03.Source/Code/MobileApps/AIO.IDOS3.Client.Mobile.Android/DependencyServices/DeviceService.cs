using AIO.IDOS3.Client.Mobile.DependencyServices;
using Android.Content;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Android.DependencyServices
{

    public class DeviceService : IDeviceService
    {

        #region Fields

        private static Context context;

        #endregion

        #region Methods

        public static void Init(Context context)
        {
            DeviceService.context = context;
            DependencyService.Register<IDeviceService, DeviceService>();
        }

        #endregion

        #region Implements IDeviceInfo

        public string GetDeviceID()
        {
            return global::Android.Provider.Settings.Secure.GetString(context.ContentResolver, global::Android.Provider.Settings.Secure.AndroidId);
        }

        #endregion

    }

}
