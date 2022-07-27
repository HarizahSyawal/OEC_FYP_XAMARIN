using AIO.IDOS3.Client.Mobile.Android.DependencyServices;
using AIO.IDOS3.Client.Mobile.DependencyServices;
using Android.App;
using Android.Content;
using AndroidX.Core.Content;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(DatabaseService))]
namespace AIO.IDOS3.Client.Mobile.Android.DependencyServices
{

    public class DatabaseService : IDatabaseService
    {

        #region Fields

        private static Context context;
        private static string databaseFilePath = null;
        private static string databaseFileName = null;

        #endregion

        #region Constructors

        public static void Init(Context context, string databaseFileName)
        {
            DatabaseService.context = context;
            DatabaseService.databaseFileName = databaseFileName;

            CreateDatabaseFilePath();
        }

        #endregion

        #region Implements IDatabaseUtility

        public string GetDatabaseFilePath()
        {
            if (string.IsNullOrWhiteSpace(databaseFilePath))
                CreateDatabaseFilePath();

            return databaseFilePath;
        }

        public void ReplaceDatabase()
        {
            try
            {
                if (File.Exists(databaseFilePath))
                    File.Delete(databaseFilePath);

                CreateNewDatabase();
            }
            catch (Exception ex)
            {
                try
                {
                    new AlertDialog.Builder(context)
                        .SetPositiveButton("OK", (sender, args) => { })
                        .SetMessage(string.Format("Failed to replace database.\nERROR: {0}", ex.Message))
                        .SetTitle("Application Failed")
                        .Show();
                }
                catch { }
            }
        }

        public void ExportDatabase(string destinationFileName)
        {
            try
            {
                var destinationFilePath = Path.Combine(DependencyService.Resolve<IFileService>().GetPublicDownloadsDirectory(), destinationFileName);

                if (File.Exists(destinationFilePath))
                    File.Delete(destinationFilePath);

                File.Copy(databaseFilePath, destinationFilePath);

                try
                {
                    new AlertDialog.Builder(context)
                        .SetPositiveButton("OK", (sender, args) => { })
                        .SetMessage(string.Format("Successfully export database to '{0}'", destinationFilePath))
                        .SetTitle("Export Database Succeed")
                        .Show();
                }
                catch { }
            }
            catch (Exception ex)
            {
                try
                {
                    new AlertDialog.Builder(context)
                        .SetPositiveButton("OK", (sender, args) => { })
                        .SetMessage(string.Format("Failed to export database.\nERROR: {0}", ex.Message))
                        .SetTitle("Export Database Failed")
                        .Show();
                }
                catch { }
            }
        }

        public void ImportDatabase(string sourceFileName)
        {
            try
            {
                var sourceFilePath = Path.Combine(DependencyService.Resolve<IFileService>().GetPublicDownloadsDirectory(), sourceFileName);

                if (File.Exists(sourceFilePath))
                {
                    if (File.Exists(databaseFilePath))
                        File.Delete(databaseFilePath);

                    File.Copy(sourceFilePath, databaseFilePath);

                    try
                    {
                        new AlertDialog.Builder(context)
                        .SetPositiveButton("OK", (sender, args) => { })
                        .SetMessage(string.Format("Successfully import from '{0}'", sourceFilePath))
                        .SetTitle("Import Database Succeed")
                        .Show();
                    }
                    catch { }
                }
            }
            catch (Exception ex)
            {
                try
                {
                    new AlertDialog.Builder(context)
                        .SetPositiveButton("OK", (sender, args) => { })
                        .SetMessage(string.Format("Failed to import database.\nERROR: {0}", ex.Message))
                        .SetTitle("Import Database Failed")
                        .Show();
                }
                catch { }
            }
        }


        public void ExecuteAppUpdate()
        {
            var fileName = "com.aio.idos3.client.mobile-Signed.apk";
            var apkFileName = Path.Combine(DependencyService.Resolve<IFileService>().GetPublicDownloadsDirectory(), fileName);

            try
            {
                //Intent promptInstall = new Intent(Intent.ActionView).SetDataAndType(
                //    global::Android.Net.Uri.FromFile(new Java.IO.File(apkFileName)), "application/vnd.android.package-archive");
                //promptInstall.AddFlags(ActivityFlags.NewTask);

                //DatabaseUtility.context.StartActivity(promptInstall);

                var file = new Java.IO.File(apkFileName);
                //Uri fileUri = Uri.fromFile(file);
                //if (Build.VERSION.SdkIntSDK_INT >= 24)
                var fileUri = FileProvider.GetUriForFile(context, context.PackageName + ".provider", new Java.IO.File(apkFileName));

                var intent = new Intent(Intent.ActionView, fileUri);
                intent.SetDataAndType(fileUri, "application/vnd.android.package-archive");
                intent.SetFlags(ActivityFlags.ClearTask | ActivityFlags.NewTask);
                intent.SetFlags(ActivityFlags.GrantReadUriPermission);
                context.StartActivity(intent);
            }
            catch (Exception ex)
            {
                try
                {
                    new AlertDialog.Builder(context)
                        .SetPositiveButton("OK", (sender, args) => { })
                        .SetMessage(string.Format("Failed to locate {0}.\nERROR: {1}", apkFileName, ex.Message))
                        .SetTitle("App Update Failed")
                        .Show();
                }
                catch { }
            }
        }

        #endregion

        #region Methods

        private static void CreateDatabaseFilePath()
        {
            try
            {
                databaseFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), databaseFileName);

                if (!File.Exists(databaseFilePath))
                    CreateNewDatabase();
            }
            catch (Exception ex)
            {
                try
                {
                    new AlertDialog.Builder(context)
                        .SetPositiveButton("OK", (sender, args) => { })
                        .SetMessage(string.Format("Failed to create new database.\nERROR: {0}", ex.Message))
                        .SetTitle("Application Failed")
                        .Show();
                }
                catch { }
            }
        }

        private static void CreateNewDatabase()
        {
            using (var writeStream = new FileStream(databaseFilePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                context.Assets.Open(databaseFileName).CopyTo(writeStream);
            }
        }

        #endregion

    }

}
