using System;
using System.Globalization;
using Xamarin.Forms;

namespace Wismapi.Xamarin.Utilities.ValueConverters
{

    public class IntegerToObjectConverter<T> : IValueConverter
    {

        #region Properties

        public bool? ConditionEqualTo { get; set; }
        public bool? ConditionNotEqualTo { get; set; }
        public bool? ConditionGreaterThan { get; set; }
        public bool? ConditionGreaterThanEqualTo { get; set; }
        public bool? ConditionLessThan { get; set; }
        public bool? ConditionLessThanEqualTo { get; set; }

        public int Value { get; set; }

        public T TrueObject { get; set; }
        public T FalseObject { get; set; }

        #endregion

        #region Implements IValueConverter

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valueInt = (int)value;

            return (((ConditionEqualTo.HasValue && (valueInt == Value)) ||
                (ConditionNotEqualTo.HasValue && (valueInt != Value)) ||
                (ConditionGreaterThan.HasValue && (valueInt > Value)) ||
                (ConditionGreaterThanEqualTo.HasValue && (valueInt >= Value)) ||
                (ConditionLessThan.HasValue && (valueInt < Value)) ||
                (ConditionLessThanEqualTo.HasValue && (valueInt <= Value))) ? 
                TrueObject : FalseObject);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }

        #endregion

    }

}
