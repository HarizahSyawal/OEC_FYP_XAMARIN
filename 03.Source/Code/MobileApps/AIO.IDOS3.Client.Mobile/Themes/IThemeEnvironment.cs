using System.Threading.Tasks;

namespace AIO.IDOS3.Client.Mobile.Themes
{

    public interface IThemeEnvironment
    {

        #region Methods

        Task<bool> IsLightOperatingSystemTheme();

        #endregion

    }

}
