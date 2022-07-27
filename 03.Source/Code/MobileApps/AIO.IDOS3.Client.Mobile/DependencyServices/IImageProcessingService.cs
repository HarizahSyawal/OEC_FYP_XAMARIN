using System.Threading.Tasks;

namespace AIO.IDOS3.Client.Mobile.DependencyServices
{

    public interface IImageProcessingService
    {

        #region Methods

        Task<bool> Process(string filePath, int? compressionQuality, int? maxWidthHeight);
        Task<bool> Process(string filePath, int? compressionQuality, int? customPhotoSize, int? maxWidthHeight);
        Task<bool> Process(string filePath, bool rotateImage, int? compressionQuality, int? customPhotoSize, int? maxWidthHeight);
        Task<bool> Process(string filePath, bool rotateImage, int? compressionQuality, int? customPhotoSize, int? maxWidthHeight, bool saveMetadata, double? latitude, double? longitude);

        #endregion

    }

}
