using AIO.IDOS3.Mobile.Data.Entity;
using System.Collections.Generic;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class EditStockTransferSummaryModel : BindableErrorBase
    {

        #region Constructors

        public EditStockTransferSummaryModel()
        {
            ProductOptions.IsRequired = true;
            ProductOptions.Caption = "Product";

            QtyConvLOptions.IsRequired = true;
            QtyConvMOptions.AllowNullValue = true;
            QtyConvLOptions.Caption = "Qty (L)";

            QtyConvMOptions.IsRequired = true;
            QtyConvMOptions.AllowNullValue = true;
            QtyConvMOptions.Caption = "(M)";

            QtyConvSOptions.IsRequired = true;
            QtyConvMOptions.AllowNullValue = true;
            QtyConvSOptions.Caption = "(S)";
        }

        #endregion

        #region Properties

        private mvStockTransferSummary data = null;
        public mvStockTransferSummary Data { get { return data; } set { SetProperty(ref data, value); } }


        public List<mvSalesmanProduct> SalesmanProductsData { get; set; }


        private ComboBoxEditOptions<mvProduct> productOptions = new ComboBoxEditOptions<mvProduct>();
        public ComboBoxEditOptions<mvProduct> ProductOptions { get { return productOptions; } set { SetProperty(ref productOptions, value); } }
        private int? productID = null;
        public int? ProductID { get { return productID; } set { SetProperty(ref productID, value); } }

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

        #endregion

        #region Methods

        public void Reset()
        {
            Data = null;
            SalesmanProductsData = null;

            ProductID = null;
            QtyConvL = null;
            QtyConvM = null;
            QtyConvS = null;

            ResetErrorMessage();
        }

        public bool Validate()
        {
            ResetErrorMessage();

            bool isValid = true;

            isValid = (ProductOptions.Validate<int?>(ProductID) && isValid);
            isValid = (QtyConvLOptions.Validate(QtyConvL) && isValid);
            isValid = (QtyConvMOptions.Validate(QtyConvM) && isValid);
            isValid = (QtyConvSOptions.Validate(QtyConvS) && isValid);

            return isValid;
        }

        #endregion

    }

}
