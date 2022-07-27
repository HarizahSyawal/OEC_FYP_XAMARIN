using Prism.Mvvm;
using System;

namespace AIO.IDOS3.Client.Mobile.Models
{
        
    public class SalesmanStartOfDaySyncModel : BindableErrorBase
    {

        #region Fields

        private TextEditOptions<string> odometerOptions = new TextEditOptions<string>();

        #endregion

        #region Properties

        public string Odometer { get; set; }


        public TextEditOptions<string> OdometerOptions
        {
            get { return odometerOptions; }
            set { SetProperty(ref odometerOptions, value); }
        }

        #endregion

    }

}
