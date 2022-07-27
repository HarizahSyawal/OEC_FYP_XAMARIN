using AIO.IDOS3.Mobile.Data.Entity;
using System;
using System.Collections.Generic;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class EditSalesOrderSwapSummaryModel : BindableErrorBase
    {

        #region Constructors

        public EditSalesOrderSwapSummaryModel()
        {
            ProductOptions.IsRequired = true;
            ProductOptions.Caption = "Product";

            QtyConvLOptions.IsRequired = true;
            QtyConvLOptions.AllowNullValue = true;
            QtyConvLOptions.Caption = "Qty (L)";

            QtyConvMOptions.IsRequired = true;
            QtyConvMOptions.AllowNullValue = true;
            QtyConvMOptions.Caption = "(M)";

            QtyConvSOptions.IsRequired = true;
            QtyConvSOptions.AllowNullValue = true;
            QtyConvSOptions.Caption = "(S)";

            ReasonOptions.IsRequired = true;
            ReasonOptions.Caption = "Reason";
        }

        #endregion

        #region Properties

        private mvSalesOrderSwapSummary salesOrderSwapSummary = null;
        public mvSalesOrderSwapSummary SalesOrderSwapSummary { get { return salesOrderSwapSummary; } set { SetProperty(ref salesOrderSwapSummary, value); } }


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

        private ComboBoxEditOptions<mvSystemLookup> reasonOptions = new ComboBoxEditOptions<mvSystemLookup>();
        public ComboBoxEditOptions<mvSystemLookup> ReasonOptions { get { return reasonOptions; } set { SetProperty(ref reasonOptions, value); } }
        private int? reasonID = null;
        public int? ReasonID { get { return reasonID; } set { SetProperty(ref reasonID, value); } }

        #endregion

    }

}
