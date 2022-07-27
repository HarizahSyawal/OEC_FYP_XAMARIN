using DevExpress.XamarinForms.Core.Themes;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Themes
{

    internal class ThemeLoader : IThemeChangingHandler
    {

        #region Fields
        
        private static ThemeLoader instance = null;
        private IThemeLoader platformThemeLoader = null;

        #endregion

        #region Constructors

        private ThemeLoader()
        {
            platformThemeLoader = DependencyService.Get<IThemeLoader>();
            ThemeManager.AddThemeChangedHandler(this);
        }

        #endregion

        #region Properties

        public static ThemeLoader Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThemeLoader();

                return instance;
            }
        }

        #endregion

        #region Methods

        public void LoadTheme()
        {
            bool isLightTheme = (ThemeManager.ThemeName == Theme.Light);

            var theme = (isLightTheme) ? (ResourceDictionary)new LightTheme() : (ResourceDictionary)new DarkTheme();
            Application.Current.Resources.MergedDictionaries.Add(theme);
            
            if (platformThemeLoader != null)
                platformThemeLoader.LoadTheme(theme, isLightTheme);
        }

        #endregion

        #region Implements IThemeChangingHandler

        public void OnThemeChanged()
        {
            LoadTheme();
        }

        #endregion

    }

}
