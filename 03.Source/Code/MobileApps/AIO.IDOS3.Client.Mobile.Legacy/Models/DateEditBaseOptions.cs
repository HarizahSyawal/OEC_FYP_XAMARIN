using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class DateEditOptions<T> : EditBaseOptions<T>
    {

        #region Properties

        private bool isReadOnly = false;
        public bool IsReadOnly { get { return isReadOnly; } set { SetProperty(ref isReadOnly, value); } }

        private DateTime minDate = DateTime.MinValue;
        public DateTime MinDate { get { return minDate; } set { SetProperty(ref minDate, value); } }

        private DateTime maxDate = DateTime.MaxValue;
        public DateTime MaxDate { get { return maxDate; } set { SetProperty(ref maxDate, value); } }

        private DateTime date = DateTime.Today;
        public DateTime Date { get { return date; } set { SetProperty(ref date, value); } }

        #endregion

    }

}
