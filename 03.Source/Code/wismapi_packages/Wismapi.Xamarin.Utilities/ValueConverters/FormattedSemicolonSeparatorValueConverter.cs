using System;
using System.Globalization;
using Xamarin.Forms;

namespace Wismapi.Xamarin.Utilities.ValueConverters
{

    public class FormattedSemicolonSeparatorValueConverter : IValueConverter
    {

        #region Implements IValueConverter

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = "";

            if ((value is string) && (parameter is string))
            {
                var paramValues = ((string)parameter).Split('|');
                var values = ((string)value).Split(';');

                result = string.Format(paramValues[0], values[int.Parse(paramValues[1])]);
            }

            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion

    }

}
