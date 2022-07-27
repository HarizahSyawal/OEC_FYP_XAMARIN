using AIO.IDOS3.Mobile.Data.Entity;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class EditSalesOrderReturnSummaryModel : BindableErrorBase
    {

        #region Constructors

        public EditSalesOrderReturnSummaryModel()
        {
            ProductOptions.IsRequired = true;
            ProductOptions.Caption = "Product";

            UnitPriceOptions.Caption = "Unit Price";

            QtyConvLOptions.IsRequired = true;
            QtyConvLOptions.AllowNullValue = true;
            QtyConvLOptions.Caption = "Qty (L)";

            QtyConvMOptions.IsRequired = true;
            QtyConvMOptions.AllowNullValue = true;
            QtyConvMOptions.Caption = "(M)";

            QtyConvSOptions.IsRequired = true;
            QtyConvSOptions.AllowNullValue = true;
            QtyConvSOptions.Caption = "(S)";

            DiscountStrataDefaultAmountOptions.Caption = "Multilevel Disc";

            ReasonOptions.IsRequired = true;
            ReasonOptions.Caption = "Reason";
        }

        #endregion

        #region Properties

        private mvSalesOrderReturnSummary salesOrderReturnSummary = null;
        public mvSalesOrderReturnSummary SalesOrderReturnSummary { get { return salesOrderReturnSummary; } set { SetProperty(ref salesOrderReturnSummary, value); } }


        private ComboBoxEditOptions<mvProduct> productOptions = new ComboBoxEditOptions<mvProduct>();
        public ComboBoxEditOptions<mvProduct> ProductOptions { get { return productOptions; } set { SetProperty(ref productOptions, value); } }
        private int? productID = null;
        public int? ProductID { get { return productID; } set { SetProperty(ref productID, value); } }

        private NumericEditOptions<double?> unitPriceOptions = new NumericEditOptions<double?>();
        public NumericEditOptions<double?> UnitPriceOptions { get { return unitPriceOptions; } set { SetProperty(ref unitPriceOptions, value); } }
        private double? unitPrice = null;
        public double? UnitPrice { get { return unitPrice; } set { SetProperty(ref unitPrice, value); } }

        private NumericEditOptions<int?> qtyConvLOptions = new NumericEditOptions<int?>();
        public NumericEditOptions<int?> QtyConvLOptions { get { return qtyConvLOptions; } set { SetProperty(ref qtyConvLOptions, value); } }
        private int? qtyConvL = null;
        public int? QtyConvL { get { return qtyConvL; } set { SetProperty(ref qtyConvL, value); } }

        private NumericEditOptions<int?> qtyConvMOptions = new NumericEditOptions<int?>();
        public NumericEditOptions<int?> QtyConvMOptions { get { return qtyConvMOptions; } set { SetProperty(ref qtyConvMOptions, value); } }
        private int? qtyConvM = null;
        public int? QtyConvM { get { return qtyConvM; } set { SetProperty(ref qtyConvM, value); } }

        private NumericEditOptions<int?> qtyConvSOptions = new NumericEditOptions<int?>();
        public NumericEditOptions<int?> QtyConvSOptions { get { return qtyConvSOptions; } set { SetProperty(ref qtyConvSOptions, value); } }
        private int? qtyConvS = null;
        public int? QtyConvS { get { return qtyConvS; } set { SetProperty(ref qtyConvS, value); } }

        private NumericEditOptions<double?> discountStrataDefaultAmountOptions = new NumericEditOptions<double?>();
        public NumericEditOptions<double?> DiscountStrataDefaultAmountOptions { get { return discountStrataDefaultAmountOptions; } set { SetProperty(ref discountStrataDefaultAmountOptions, value); } }
        private double? discountStrataDefaultAmount = null;
        public double? DiscountStrataDefaultAmount { get { return discountStrataDefaultAmount; } set { SetProperty(ref discountStrataDefaultAmount, value); } }

        private ComboBoxEditOptions<mvSystemLookup> reasonOptions = new ComboBoxEditOptions<mvSystemLookup>();
        public ComboBoxEditOptions<mvSystemLookup> ReasonOptions { get { return reasonOptions; } set { SetProperty(ref reasonOptions, value); } }
        private int? reasonID = null;
        public int? ReasonID { get { return reasonID; } set { SetProperty(ref reasonID, value); } }


        private double? subtotalAmount = null;
        public double? SubtotalAmount { get { return subtotalAmount; } set { SetProperty(ref subtotalAmount, value); } }

        #endregion

    }

}
