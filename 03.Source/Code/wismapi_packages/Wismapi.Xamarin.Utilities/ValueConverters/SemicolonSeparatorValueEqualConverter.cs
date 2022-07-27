using System;
using System.Globalization;
using Xamarin.Forms;

namespace Wismapi.Xamarin.Utilities.ValueConverters
{

    public class SemicolonSeparatorValueEqualConverter : IValueConverter
    {

        #region Implements IValueConverter

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = false;

            if (value.GetType().Equals(typeof(string)) && parameter.GetType().Equals(typeof(string)))
            {
                var paramValues = ((string)parameter).Split('|');
                var values = ((string)value).Split(';');

                result = (values[int.Parse(paramValues[0])] == paramValues[1]);
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
