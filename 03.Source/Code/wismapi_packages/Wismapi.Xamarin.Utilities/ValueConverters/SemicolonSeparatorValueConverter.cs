using System;
using System.Globalization;
using Xamarin.Forms;

namespace Wismapi.Xamarin.Utilities.ValueConverters
{

    public class SemicolonSeparatorValueConverter : IValueConverter
    {

        #region Implements IValueConverter

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = "";

            if (value.GetType().Equals(typeof(string)) && parameter.GetType().Equals(typeof(int)))
                result = ((string)value).Split(';')[(int)parameter];

            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion

    }

}
