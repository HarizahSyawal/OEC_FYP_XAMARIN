using System.IO;

namespace AIO.IDOS3.Web.Services
{

    public sealed class AppSettings
    {

        #region Fields

        private string filesDirectory = null;

        #endregion

        #region Properties

        public bool UseAuthorization { get; set; }

        public int ThumbnailMaxSize { get; set; }

        public string FilesDirectory
        {
            get
            {
                if (string.IsNullOrEmpty(filesDirectory))
                    return Path.Combine(Directory.GetCurrentDirectory(), @"Resources\Files");

                return filesDirectory;
            }
            set
            {
                if (filesDirectory != value)
                    filesDirectory = value;
            }
        }

        #endregion

    }

}
