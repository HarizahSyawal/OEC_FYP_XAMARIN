using AIO.IDOS3.Mobile.Data.Entity;
using System.Collections.ObjectModel;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class EditPaymentCollectionDetailsModel : BindableErrorBase
    {

        #region Properties

        private ObservableCollection<mvInvoice> invoices = new ObservableCollection<mvInvoice>();
        public ObservableCollection<mvInvoice> Invoices { get { return invoices; } set { SetProperty(ref invoices, value); } }

        #endregion

    }

}
