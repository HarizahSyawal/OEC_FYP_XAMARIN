using System;
using System.Globalization;
using Xamarin.Forms;

namespace Wismapi.Xamarin.Utilities.ValueConverters
{

    public class InvertBooleanConverter : IValueConverter
    {

        #region Implements IValueConverter

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = false;

            if (value is bool)
                result = !(bool)value;
            else if (value is bool?)
            {
                var obj = (bool?)value;
                result = (obj.HasValue && obj.Value);
            }

            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Convert(value, targetType, parameter, culture);
        }

        #endregion

    }

}
