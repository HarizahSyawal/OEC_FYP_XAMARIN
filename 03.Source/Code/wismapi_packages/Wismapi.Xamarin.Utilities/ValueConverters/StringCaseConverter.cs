using System;
using System.Globalization;
using Xamarin.Forms;

namespace Wismapi.Xamarin.Utilities.ValueConverters
{

    public class StringCaseConverter : IValueConverter
    {

        #region Implements IValueConverter

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (((value is string) && !string.IsNullOrEmpty((string)value)) && (parameter is bool))
                return ((bool)parameter) ? ((string)value).ToUpper() : ((string)value).ToLower();

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Convert(value, targetType, parameter, culture);
        }

        #endregion

    }

}
