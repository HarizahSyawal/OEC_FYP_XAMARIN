using DevExpress.XamarinForms.Editors;
using DevExpress.XamarinForms.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AIO.IDOS3.Client.Mobile.Utilities
{

    public sealed class DXUtility
    {

        #region Methods

        public static void TextEdit_TextChanged_Uppercase(object sender, EventArgs e)
        {
            //var ctl = (TextEdit)sender;

            //ctl.Text = ctl.Text.ToUpper();
        }

        public static void ComboBoxEdit_SelectionChanged(object sender, EventArgs e)
        {
            var ctl = (ComboBoxEdit)sender;

            if ((ctl.SelectedItem != null) && !string.IsNullOrEmpty(ctl.ValueMember))
            {
                var prop = ctl.SelectedItem.GetType().GetProperty(ctl.ValueMember);
                if (prop != null)
                    ctl.SelectedValue = prop.GetValue(ctl.SelectedItem);
            }
        }

        #endregion

    }

}
