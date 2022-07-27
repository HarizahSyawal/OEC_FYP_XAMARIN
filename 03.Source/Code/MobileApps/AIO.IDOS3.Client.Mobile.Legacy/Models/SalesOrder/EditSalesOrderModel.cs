using AIO.IDOS3.Mobile.Data.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class EditSalesOrderModel : BindableErrorBase
    {

        #region Constructors

        public EditSalesOrderModel()
        {
            MobileDocumentCodeOptions.Caption = "Reference Number";

            TransactionDateOptions.Caption = "Transaction Date";

            WarehouseOptions.Caption = "Warehouse";

            SalesPromotionOptions.IsRequired = true;
            SalesPromotionOptions.Caption = "Promo";

            TermOfPaymentOptions.IsRequired = true;
            TermOfPaymentOptions.Caption = "Term of Payment";
        }

        #endregion

        #region Properties

        private mvSalesOrder salesOrder = null;
        public mvSalesOrder SalesOrder { get { return salesOrder; } set { SetProperty(ref salesOrder, value); } }


        public List<mvStockOnHandCurrent> StockOnHandCurrentProducts { get; set; }
        public List<mvStockOnHandCurrent> StockOnHandCurrentProductLots { get; set; }


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

        private ComboBoxEditOptions<mvSalesPromotion> salesPromotionOptions = new ComboBoxEditOptions<mvSalesPromotion>();
        public ComboBoxEditOptions<mvSalesPromotion> SalesPromotionOptions { get { return salesPromotionOptions; } set { SetProperty(ref salesPromotionOptions, value); } }
        private int? salesPromotionID = null;
        public int? SalesPromotionID { get { return salesPromotionID; } set { SetProperty(ref salesPromotionID, value); } }

        private ComboBoxEditOptions<mvSystemLookup> termOfPaymentOptions = new ComboBoxEditOptions<mvSystemLookup>();
        public ComboBoxEditOptions<mvSystemLookup> TermOfPaymentOptions { get { return termOfPaymentOptions; } set { SetProperty(ref termOfPaymentOptions, value); } }
        private int? termOfPaymentID = null;
        public int? TermOfPaymentID { get { return termOfPaymentID; } set { SetProperty(ref termOfPaymentID, value); } }

        private ObservableCollection<mvSalesOrderSummary> childSummaries = new ObservableCollection<mvSalesOrderSummary>();
        public ObservableCollection<mvSalesOrderSummary> ChildSummaries { get { return childSummaries; } set { SetProperty(ref childSummaries, value); } }


        private double? totalGrossAmount = null;
        public double? TotalGrossAmount { get { return totalGrossAmount; } set { SetProperty(ref totalGrossAmount, value); } }

        private double? totalTaxAmount = null;
        public double? TotalTaxAmount { get { return totalTaxAmount; } set { SetProperty(ref totalTaxAmount, value); } }

        private double? totalAmount = null;
        public double? TotalAmount { get { return totalAmount; } set { SetProperty(ref totalAmount, value); } }

        #endregion

    }

}
