using System;
using System.Globalization;
using Xamarin.Forms;

namespace Wismapi.Xamarin.Utilities.ValueConverters
{

    public class BooleanToObjectConverter<T> : IValueConverter
    {

        #region Properties

        public T TrueObject { get; set; }
        public T FalseObject { get; set; }

        #endregion

        #region Implements IValueConverter

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (((bool)value) ? TrueObject : FalseObject);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((T)value).Equals(TrueObject);
        }

        #endregion

    }

}
