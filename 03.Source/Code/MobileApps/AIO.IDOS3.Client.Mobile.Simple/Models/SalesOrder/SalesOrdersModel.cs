using AIO.IDOS3.Data.Entity;
using AIO.IDOS3.Mobile.Data.Entity;
using System.Collections.ObjectModel;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class SalesOrdersModel : BindableErrorBase
    {

        #region Properties

        private ObservableCollection<mvSalesOrder> salesOrders = new ObservableCollection<mvSalesOrder>();
        public ObservableCollection<mvSalesOrder> SalesOrders { get { return salesOrders; } set { SetProperty(ref salesOrders, value); } }


        private PaymentCollectionsModel soPaymentCollectiosnModel = null;
        public PaymentCollectionsModel SOPaymentCollectiosnModel { get { return soPaymentCollectiosnModel; } set { SetProperty(ref soPaymentCollectiosnModel, value); } }

        #endregion

    }

}
