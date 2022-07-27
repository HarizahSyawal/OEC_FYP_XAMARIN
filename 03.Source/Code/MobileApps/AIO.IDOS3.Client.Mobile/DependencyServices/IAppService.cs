
namespace AIO.IDOS3.Client.Mobile.DependencyServices
{

    public interface IAppService
    {

        #region Methods

        void InstallApp(string filePath);
        void CloseApp();

        #endregion

    }

}
