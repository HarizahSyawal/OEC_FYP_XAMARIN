using System;
using System.Collections.ObjectModel;
using FFImageLoading.Work;

namespace AIO.IDOS3.Client.Mobile.Models
{
    public class ApplyUniversitiesModel : EditTransactionModelBase
    {
        public ApplyUniversitiesModel()
        {
        }

        #region Classes

        public class ListUniv
        {

            #region Properties

            public int ID { get; set; }
            public string UnivName { get; set; }
            public string UnivPhoto { get; set; }
            public bool IsUnivHasPhoto { get; set; }
            public string AdressName { get; set; }

            #endregion

        }
        #endregion


        #region Properties


        private ObservableCollection<ListUniv> listUniversities = new ObservableCollection<ListUniv>();
        public ObservableCollection<ListUniv> ListUniversities { get { return listUniversities; } set { SetProperty(ref listUniversities, value); } }

        private string univPhoto = null;
        public string UnivPhoto { get { return univPhoto; } set { SetProperty(ref univPhoto, value); } }

        private bool isUnivHasPhoto = false;
        public bool IsUnivHasPhoto { get { return isUnivHasPhoto; } set { SetProperty(ref isUnivHasPhoto, value); } }

        private string univName = null;
        public string UnivName { get { return univName; } set { SetProperty(ref univName, value); } }
        private string addressName = null;
        public string AddressName { get { return addressName; } set { SetProperty(ref addressName, value); } }

        #endregion

        #region Methods

        public override void Reset()
        {
            univPhoto = null;
            univName = null;
            addressName = null;

            ResetErrorMessage();
        }

        #endregion
    }
}
