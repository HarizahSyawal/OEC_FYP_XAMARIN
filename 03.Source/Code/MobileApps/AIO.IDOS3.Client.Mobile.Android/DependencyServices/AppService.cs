using AIO.IDOS3.Client.Mobile.DependencyServices;
using Android.App;
using Android.Content;
using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Android.DependencyServices
{

    public class AppService : IAppService
    {

        #region Fields

        private static Context context;

        #endregion

        #region Methods

        public static void Init(Context context)
        {
            AppService.context = context;
            DependencyService.Register<IAppService, AppService>();
        }

        #endregion

        #region Implements IAppInfo

        public void InstallApp(string filePath)
        {
            try
            {
                var install = new Intent(Intent.ActionInstallPackage);
                //install.PutExtra(Intent.ExtraNotUnknownSource, true);
                //install.AddFlags(ActivityFlags.ClearTask);

                install.SetDataAndType(global::Android.Net.Uri.FromFile(new Java.IO.File(filePath)), "application/vnd.android.package-archive");
                install.SetFlags(ActivityFlags.ClearTask | ActivityFlags.NewTask);
                install.AddFlags(ActivityFlags.GrantReadUriPermission);
                context.StartActivity(install);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void CloseApp()
        {
            ((global::Android.App.Activity)context).FinishAffinity();
        }

        #endregion

    }

}
