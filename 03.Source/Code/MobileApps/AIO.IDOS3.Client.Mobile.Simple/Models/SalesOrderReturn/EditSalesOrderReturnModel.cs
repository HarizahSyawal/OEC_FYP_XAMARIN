using AIO.IDOS3.Mobile.Data.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class EditSalesOrderReturnModel : BindableErrorBase
    {

        #region Constructors

        public EditSalesOrderReturnModel()
        {
            MobileDocumentCodeOptions.Caption = "Reference Number";

            TransactionDateOptions.Caption = "Transaction Date";

            WarehouseOptions.Caption = "Warehouse";

            TermOfPaymentOptions.IsRequired = true;
            TermOfPaymentOptions.Caption = "Term of Payment";

            ItemStatusOptions.IsRequired = true;
            ItemStatusOptions.Caption = "Item Status";
        }

        #endregion

        #region Properties

        private mvSalesOrderReturn salesOrderReturn = null;
        public mvSalesOrderReturn SalesOrderReturn { get { return salesOrderReturn; } set { SetProperty(ref salesOrderReturn, value); } }


        public List<mvStockOnHandCurrent> StockOnHandCurrentProducts { get; set; }


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

        private ComboBoxEditOptions<mvSystemLookup> termOfPaymentOptions = new ComboBoxEditOptions<mvSystemLookup>();
        public ComboBoxEditOptions<mvSystemLookup> TermOfPaymentOptions { get { return termOfPaymentOptions; } set { SetProperty(ref termOfPaymentOptions, value); } }
        private int? termOfPaymentID = null;
        public int? TermOfPaymentID { get { return termOfPaymentID; } set { SetProperty(ref termOfPaymentID, value); } }

        private ComboBoxEditOptions<mvSystemLookup> itemStatusOptions = new ComboBoxEditOptions<mvSystemLookup>();
        public ComboBoxEditOptions<mvSystemLookup> ItemStatusOptions { get { return itemStatusOptions; } set { SetProperty(ref itemStatusOptions, value); } }
        private int? itemStatusID = null;
        public int? ItemStatusID { get { return itemStatusID; } set { SetProperty(ref itemStatusID, value); } }

        private ObservableCollection<mvSalesOrderReturnSummary> childSummaries = new ObservableCollection<mvSalesOrderReturnSummary>();
        public ObservableCollection<mvSalesOrderReturnSummary> ChildSummaries { get { return childSummaries; } set { SetProperty(ref childSummaries, value); } }


        private double? totalGrossAmount = null;
        public double? TotalGrossAmount { get { return totalGrossAmount; } set { SetProperty(ref totalGrossAmount, value); } }

        private double? totalTaxAmount = null;
        public double? TotalTaxAmount { get { return totalTaxAmount; } set { SetProperty(ref totalTaxAmount, value); } }

        private double? totalAmount = null;
        public double? TotalAmount { get { return totalAmount; } set { SetProperty(ref totalAmount, value); } }

        #endregion

    }

}
