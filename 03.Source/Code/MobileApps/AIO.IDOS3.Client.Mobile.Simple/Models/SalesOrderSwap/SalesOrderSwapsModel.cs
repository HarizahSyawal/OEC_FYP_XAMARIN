using AIO.IDOS3.Mobile.Data.Entity;
using System.Collections.ObjectModel;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class SalesOrderSwapsModel : BindableErrorBase
    {

        #region Properties

        private ObservableCollection<mvSalesOrderSwap> salesOrderSwaps = new ObservableCollection<mvSalesOrderSwap>();
        public ObservableCollection<mvSalesOrderSwap> SalesOrderSwaps { get { return salesOrderSwaps; } set { SetProperty(ref salesOrderSwaps, value); } }

        #endregion

    }

}
