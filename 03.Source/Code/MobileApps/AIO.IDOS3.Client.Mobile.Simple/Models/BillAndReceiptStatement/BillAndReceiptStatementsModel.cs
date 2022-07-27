using AIO.IDOS3.Mobile.Data.Entity;
using System.Collections.ObjectModel;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class BillAndReceiptStatementsModel : BindableErrorBase
    {

        #region Properties
                
        private ObservableCollection<mvBillAndReceiptStatement> billAndReceiptStatements = new ObservableCollection<mvBillAndReceiptStatement>();
        public ObservableCollection<mvBillAndReceiptStatement> BillAndReceiptStatements { get { return billAndReceiptStatements; } set { SetProperty(ref billAndReceiptStatements, value); } }

        #endregion

    }

}
