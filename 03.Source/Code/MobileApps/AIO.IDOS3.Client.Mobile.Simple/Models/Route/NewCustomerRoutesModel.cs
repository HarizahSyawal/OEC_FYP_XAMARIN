using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class NewCustomerRoutesModel : BindableErrorBase
    {

        #region Classes

        public class NewCustomerRoute
        {

            #region Properties
                        
            public Guid CustomerID { get; set; }
            public string CustomerCode { get; set; }
            public string CustomerName { get; set; }
            public string CustomerAddress { get; set; }
            public string CustomerNameInitials { get; set; }
            public Color CustomerNameInitialsBackgroundColor { get; set; }
            public bool IsCustomerHasPhoto { get; set; }
            public string CustomerPhotoUrl { get; set; }
            public bool? IsCheckedIn { get; set; }

            #endregion

        }

        #endregion

        #region Properties

        private ObservableCollection<NewCustomerRoute> allData = new ObservableCollection<NewCustomerRoute>();
        public ObservableCollection<NewCustomerRoute> AllData { get { return allData; } set { SetProperty(ref allData, value); } }

        private ObservableCollection<NewCustomerRoute> data = new ObservableCollection<NewCustomerRoute>();
        public ObservableCollection<NewCustomerRoute> Data { get { return data; } set { SetProperty(ref data, value); } }


        private TextEditOptions<string> searchOptions = new TextEditOptions<string>();
        public TextEditOptions<string> SearchOptions { get { return searchOptions; } set { SetProperty(ref searchOptions, value); } }
        private string search = null;
        public string Search { get { return search; } set { SetProperty(ref search, value); } }

        #endregion

    }

}
