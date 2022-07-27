using DevExpress.XamarinForms.DataGrid;
using PanCardView.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.ValueConverters
{

    public class DXDataGridGroupRowDataValueConverter : IMultiValueConverter
    {

        #region Implements IMultiValueConverter

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            object result = null;

            try
            {
                if ((values.Count() == 2) && ((values[0] is Dictionary<string, object>) && (values[1] != null)))
                {
                    var dict = (Dictionary<string, object>)values[0];
                    var key = values[1].ToString();

                    if (dict.ContainsKey(key))
                    {
                        var obj = dict[key];
                        result = ((parameter != null) && (parameter is string)) ? obj.GetType().GetProperty(parameter.ToString()).GetValue(obj) : obj;
                    }
                }
            }
            catch { }

            return result;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion

    }

}
