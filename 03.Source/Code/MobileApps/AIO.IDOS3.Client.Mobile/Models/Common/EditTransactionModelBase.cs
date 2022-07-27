using System;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class EditTransactionModelBase : BindableErrorBase
    {

        #region Constructors

        public EditTransactionModelBase()
        {
            MobileDocumentCodeOptions.Caption = "Mobile Document Number";

            TransactionDateOptions.Caption = "Transaction Date";
        }

        #endregion

        #region Properties

        private TextEditOptions<string> mobileDocumentCodeOptions = new TextEditOptions<string>();
        public TextEditOptions<string> MobileDocumentCodeOptions { get { return mobileDocumentCodeOptions; } set { SetProperty(ref mobileDocumentCodeOptions, value); } }
        private string mobileDocumentCode = null;
        public string MobileDocumentCode { get { return mobileDocumentCode; } set { SetProperty(ref mobileDocumentCode, value); } }

        private DateEditOptions<DateTime> transactionDateOptions = new DateEditOptions<DateTime>();
        public DateEditOptions<DateTime> TransactionDateOptions { get { return transactionDateOptions; } set { SetProperty(ref transactionDateOptions, value); } }
        private DateTime? transactionDate = null;
        public DateTime? TransactionDate { get { return transactionDate; } set { SetProperty(ref transactionDate, value); } }

        #endregion

        #region Methods

        public override void Reset()
        {
            MobileDocumentCode = null;
            TransactionDate = null;
            
            ResetErrorMessage();
        }

        public override bool Validate()
        {
            ResetErrorMessage();

            bool isValid = true;

            isValid = (TransactionDateOptions.Validate<DateTime?>(TransactionDate) && isValid);

            return isValid;
        }

        #endregion

    }

}
