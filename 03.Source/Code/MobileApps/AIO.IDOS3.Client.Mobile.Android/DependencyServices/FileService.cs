using AIO.IDOS3.Client.Mobile.DependencyServices;
using Android.Content;
using System.IO;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Android.DependencyServices
{

    public class FileService : IFileService
    {

        #region Fields

        private static Context context;

        private string documentsDirectory = null;
        private string downloadsDirectory = null;
        private string musicDirectory = null;
        private string picturesDirectory = null;
        private string moviesDirectory = null;

        private string publicDownloadsDirectory = null;

        private string assetsUrl = "file:///android_asset/";

        #endregion

        #region Methods

        public static void Init(Context context)
        {
            FileService.context = context;
            DependencyService.Register<IFileService, FileService>();
        }

        #endregion

        #region Implements IFileUtility

        public string GetDocumentsDirectory()
        {
            if (string.IsNullOrEmpty(documentsDirectory))
                documentsDirectory = context.GetExternalFilesDir(global::Android.OS.Environment.DirectoryDocuments).AbsolutePath;

            return documentsDirectory;
        }

        public string GetDownloadsDirectory()
        {
            if (string.IsNullOrEmpty(downloadsDirectory))
                downloadsDirectory = context.GetExternalFilesDir(global::Android.OS.Environment.DirectoryDownloads).AbsolutePath;

            return downloadsDirectory;
        }

        public string GetMusicDirectory()
        {
            if (string.IsNullOrEmpty(musicDirectory))
                musicDirectory = context.GetExternalFilesDir(global::Android.OS.Environment.DirectoryMusic).AbsolutePath;

            return musicDirectory;
        }

        public string GetPicturesDirectory()
        {
            if (string.IsNullOrEmpty(picturesDirectory))
                picturesDirectory = context.GetExternalFilesDir(global::Android.OS.Environment.DirectoryPictures).AbsolutePath;

            return picturesDirectory;
        }

        public string GetMoviesDirectory()
        {
            if (string.IsNullOrEmpty(moviesDirectory))
                moviesDirectory = context.GetExternalFilesDir(global::Android.OS.Environment.DirectoryMovies).AbsolutePath;

            return moviesDirectory;
        }


        public string GetPublicDownloadsDirectory()
        {
            if (string.IsNullOrEmpty(publicDownloadsDirectory))
                publicDownloadsDirectory = global::Android.OS.Environment.GetExternalStoragePublicDirectory(global::Android.OS.Environment.DirectoryDownloads).AbsolutePath;

            return publicDownloadsDirectory;
        }


        public Stream GetAsset(string fileName)
        {
            return context.Assets.Open(fileName);
        }

        public string GetAssetsUrl()
        {
            return assetsUrl;
        }

        public string GetAssetFileUrl(string fileName)
        {
            return Path.Combine(GetAssetsUrl(), fileName);
        }

        #endregion

    }

}
