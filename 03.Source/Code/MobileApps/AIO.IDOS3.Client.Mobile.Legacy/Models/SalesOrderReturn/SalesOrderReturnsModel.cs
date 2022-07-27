using AIO.IDOS3.Mobile.Data.Entity;
using System.Collections.ObjectModel;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class SalesOrderReturnsModel : BindableErrorBase
    {

        #region Properties

        private ObservableCollection<mvSalesOrderReturn> salesOrderReturns = new ObservableCollection<mvSalesOrderReturn>();
        public ObservableCollection<mvSalesOrderReturn> SalesOrderReturns { get { return salesOrderReturns; } set { SetProperty(ref salesOrderReturns, value); } }

        #endregion

    }

}
