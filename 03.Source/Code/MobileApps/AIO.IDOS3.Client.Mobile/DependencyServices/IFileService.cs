using System.IO;

namespace AIO.IDOS3.Client.Mobile.DependencyServices
{

    public interface IFileService
    {

        #region Methods

        string GetDocumentsDirectory();
        string GetDownloadsDirectory();
        string GetMusicDirectory();
        string GetPicturesDirectory();
        string GetMoviesDirectory();

        string GetPublicDownloadsDirectory();

        Stream GetAsset(string fileName);
        string GetAssetsUrl();
        string GetAssetFileUrl(string fileName);

        #endregion

    }

}
