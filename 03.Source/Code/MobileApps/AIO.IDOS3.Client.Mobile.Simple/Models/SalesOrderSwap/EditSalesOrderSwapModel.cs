using AIO.IDOS3.Mobile.Data.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class EditSalesOrderSwapModel : BindableErrorBase
    {

        #region Constructors

        public EditSalesOrderSwapModel()
        {
            MobileDocumentCodeOptions.Caption = "Reference Number";

            TransactionDateOptions.Caption = "Transaction Date";

            WarehouseOptions.Caption = "Warehouse";
        }

        #endregion

        #region Properties

        private mvSalesOrderSwap salesOrderSwap = null;
        public mvSalesOrderSwap SalesOrderSwap { get { return salesOrderSwap; } set { SetProperty(ref salesOrderSwap, value); } }

                
        public List<mvStockOnHandCurrent> StockOnHandCurrentProducts { get; set; }
        public List<mvStockOnHandCurrent> StockOnHandCurrentProductLotsData { get; set; }


        private TextEditOptions<string> mobileDocumentCodeOptions = new TextEditOptions<string>();
        public TextEditOptions<string> MobileDocumentCodeOptions { get { return mobileDocumentCodeOptions; } set { SetProperty(ref mobileDocumentCodeOptions, value); } }
        private string mobileDocumentCode = null;
        public string MobileDocumentCode { get { return mobileDocumentCode; } set { SetProperty(ref mobileDocumentCode, value); } }

        private DateEditOptions<DateTime> transactionDateOptions = new DateEditOptions<DateTime>();
        public DateEditOptions<DateTime> TransactionDateOptions { get { return transactionDateOptions; } set { SetProperty(ref transactionDateOptions, value); } }
        private DateTime? transactionDate = null;
        public DateTime? TransactionDate { get { return transactionDate; } set { SetProperty(ref transactionDate, value); } }

        private TextEditOptions<string> warehouseOptions = new TextEditOptions<string>();
        public TextEditOptions<string> WarehouseOptions { get { return warehouseOptions; } set { SetProperty(ref warehouseOptions, value); } }
        private string warehouse = null;
        public string Warehouse { get { return warehouse; } set { SetProperty(ref warehouse, value); } }

        private ObservableCollection<mvSalesOrderSwapSummary> childSummaries = new ObservableCollection<mvSalesOrderSwapSummary>();
        public ObservableCollection<mvSalesOrderSwapSummary> ChildSummaries { get { return childSummaries; } set { SetProperty(ref childSummaries, value); } }

        #endregion

    }

}
