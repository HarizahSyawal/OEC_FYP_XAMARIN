using AIO.IDOS3.Mobile.Data.Entity;
using System;
using System.Collections.ObjectModel;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class MobileActivitiesModel : BindableErrorBase
    {

        #region Classes

        public class MobileActivity
        {

            #region Properties

            public Guid? ActivityID { get; set; }
            public string ActivityName { get; set; }            
            public Guid? SalesmanID { get; set; }
            public string Salesman { get; set; }
            public Guid? CollectorID { get; set; }
            public string Collector { get; set; }
            public Guid? SalesmanSiteID { get; set; }
            public string SalesmanSite { get; set; }
            public Guid? CollectorSiteID { get; set; }
            public string CollectorSite { get; set; }
            public bool IsSalesmanSiteVisible { get; set; }
            public bool IsCollectorSiteVisible { get; set; }
            public bool IsBottomLineVisible { get; set; }

            #endregion

        }

        #endregion

        #region Properties

        private ObservableCollection<MobileActivity> mobileActivitiesdata = new ObservableCollection<MobileActivity>();
        public ObservableCollection<MobileActivity> MobileActivities { get { return mobileActivitiesdata; } set { SetProperty(ref mobileActivitiesdata, value); } }
        
        #endregion

    }

}
