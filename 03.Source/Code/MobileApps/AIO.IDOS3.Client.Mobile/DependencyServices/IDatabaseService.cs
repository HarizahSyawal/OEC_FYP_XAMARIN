
namespace AIO.IDOS3.Client.Mobile.DependencyServices
{

    public interface IDatabaseService
    {

        #region Methods

        string GetDatabaseFilePath();
        void ReplaceDatabase();
        void ExportDatabase(string destinationFileName);
        void ImportDatabase(string sourceFileName);
        void ExecuteAppUpdate();

        #endregion

    }

}
