using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Themes
{

    public interface IThemeLoader
    {

        #region Methods

        void LoadTheme(ResourceDictionary theme, bool isLightTheme);

        #endregion

    }

}
