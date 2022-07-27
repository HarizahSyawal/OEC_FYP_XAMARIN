using AIO.IDOS3.Mobile.Data.Entity;
using System.Collections.Generic;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class MobileActivityStartOfDayModel : BindableErrorBase
    {

        #region Properties

        private List<mvMobileActivity> mobileActivities = null;
        public List<mvMobileActivity> MobileActivities { get { return mobileActivities; } set { SetProperty(ref mobileActivities, value); } }


        private TextEditOptions<int?> startOdometerOptions = new TextEditOptions<int?>();
        public TextEditOptions<int?> StartOdometerOptions { get { return startOdometerOptions; } set { SetProperty(ref startOdometerOptions, value); } }
        private int? startOdometer = null;
        public int? StartOdometer { get { return startOdometer; } set { SetProperty(ref startOdometer, value); } }

        #endregion

    }

}
