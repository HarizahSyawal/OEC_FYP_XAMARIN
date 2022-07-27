namespace AIO.IDOS3.Client.Mobile.Models
{

    public class EditTransactionSummaryModelBase : BindableErrorBase
    {

        #region Constructors

        public EditTransactionSummaryModelBase()
        {

            QtyConvLOptions.IsRequired = true;
            QtyConvMOptions.AllowNullValue = true;
            QtyConvLOptions.Caption = "Qty (L)";

            QtyConvMOptions.IsRequired = true;
            QtyConvMOptions.AllowNullValue = true;
            QtyConvMOptions.Caption = "Qty (M)";

            QtyConvSOptions.IsRequired = true;
            QtyConvMOptions.AllowNullValue = true;
            QtyConvSOptions.Caption = "Qty (S)";
        }

        #endregion

        #region Properties

   
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

        public override void Reset()
        {
            ProductID = null;
            QtyConvL = null;
            QtyConvM = null;
            QtyConvS = null;

            ResetErrorMessage();
        }

        public override bool Validate()
        {
            ResetErrorMessage();

            bool isValid = true;

            isValid = (QtyConvLOptions.Validate(QtyConvL) && isValid);
            isValid = (QtyConvMOptions.Validate(QtyConvM) && isValid);
            isValid = (QtyConvSOptions.Validate(QtyConvS) && isValid);

            return isValid;
        }

        #endregion

    }

}
