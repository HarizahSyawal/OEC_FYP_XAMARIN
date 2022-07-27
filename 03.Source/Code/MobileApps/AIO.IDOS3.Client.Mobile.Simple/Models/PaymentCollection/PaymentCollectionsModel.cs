using AIO.IDOS3.Mobile.Data.Entity;
using System.Collections.ObjectModel;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class PaymentCollectionsModel : BindableErrorBase
    {

        #region Properties

        private ObservableCollection<mvPaymentCollection> paymentCollections = new ObservableCollection<mvPaymentCollection>();
        public ObservableCollection<mvPaymentCollection> PaymentCollections { get { return paymentCollections; } set { SetProperty(ref paymentCollections, value); } }

        #endregion

    }

}
