using AIO.IDOS3.Mobile.Data.Entity;
using System.Collections.Generic;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class MobileActivityEndOfDayModel : BindableErrorBase
    {

        #region Properties

        private List<mvMobileActivity> mobileActivities = null;
        public List<mvMobileActivity> MobileActivities { get { return mobileActivities; } set { SetProperty(ref mobileActivities, value); } }


        private TextEditOptions<int?> endOdometerOptions = new TextEditOptions<int?>();
        public TextEditOptions<int?> EndOdometerOptions { get { return endOdometerOptions; } set { SetProperty(ref endOdometerOptions, value); } }
        private int? endOdometer = null;
        public int? EndOdometer { get { return endOdometer; } set { SetProperty(ref endOdometer, value); } }

        #endregion

    }

}
