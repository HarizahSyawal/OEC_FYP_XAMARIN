using System;
using System.Globalization;
using Xamarin.Forms;

namespace Wismapi.Xamarin.Utilities.ValueConverters
{

    public class StringToObjectConverter<T> : IValueConverter
    {

        #region Properties

        public bool? ConditionEqualTo { get; set; }
        public bool? ConditionNotEqualTo { get; set; }

        public string Value { get; set; }

        public T TrueObject { get; set; }
        public T FalseObject { get; set; }

        #endregion

        #region Implements IValueConverter

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valueString = (string)value;

            return (((ConditionEqualTo.HasValue && (valueString == Value)) ||
                (ConditionNotEqualTo.HasValue && (valueString != Value))) ? 
                TrueObject : FalseObject);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }

        #endregion

    }

}
