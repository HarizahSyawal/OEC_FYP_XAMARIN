using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class CollectionRoutesModel : BindableErrorBase
    {

        #region Classes

        public class CollectionRoute
        {

            #region Properties
                        
            public Guid ReferenceID { get; set; }
            public bool IsReferenceCustomerID { get; set; }
            public string ReferenceCode { get; set; }
            public string ReferenceName { get; set; }
            public string ReferenceBillAddress { get; set; }
            public string ReferenceNameInitials { get; set; }
            public Color ReferenceNameInitialsBackgroundColor { get; set; }
            public bool IsReferenceHasPhoto { get; set; }
            public string ReferencePhotoUrl { get; set; }
            public bool? IsCheckedIn { get; set; }

            #endregion

        }

        #endregion

        #region Properties

        private ObservableCollection<CollectionRoute> collectionRoutes = new ObservableCollection<CollectionRoute>();
        public ObservableCollection<CollectionRoute> CollectionRoutes { get { return collectionRoutes; } set { SetProperty(ref collectionRoutes, value); } }

        private ObservableCollection<CollectionRoute> filteredCollectionRoutes = new ObservableCollection<CollectionRoute>();
        public ObservableCollection<CollectionRoute> FilteredCollectionRoutes { get { return filteredCollectionRoutes; } set { SetProperty(ref filteredCollectionRoutes, value); } }


        private TextEditOptions<string> searchOptions = new TextEditOptions<string>();
        public TextEditOptions<string> SearchOptions { get { return searchOptions; } set { SetProperty(ref searchOptions, value); } }
        private string search = null;
        public string Search { get { return search; } set { SetProperty(ref search, value); } }

        #endregion

    }

}
