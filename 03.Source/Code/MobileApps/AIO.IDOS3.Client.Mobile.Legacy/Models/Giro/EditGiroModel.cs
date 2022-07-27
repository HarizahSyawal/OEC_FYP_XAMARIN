using AIO.IDOS3.Mobile.Data.Entity;
using System;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class EditGiroModel : BindableErrorBase
    {

        #region Classes

        public class IssuedByCustomerBillGroup
        {

            #region Properties

            public Guid ID { get; set; }
            public string Code { get; set; }
            public string Name { get; set; }
            public string BillGroup { get; set; }
            public int HeadID { get; set; }
            public string HeadCode { get; set; }
            public string HeadName { get; set; }
            public string Head { get; set; }
            public string BillAddress { get; set; }

            #endregion

        }

        public class IssuedByCustomer
        {

            #region Properties

            public Guid ID { get; set; }
            public string Code { get; set; }
            public string Name { get; set; }
            public string Customer { get; set; }
            public string Address { get; set; }

            #endregion

        }

        #endregion

        #region Constructors

        public EditGiroModel()
        {
            CollectorOptions.IsRequired = true;
            CollectorOptions.Caption = "Site";

            BankOptions.IsRequired = true;
            BankOptions.Caption = "Bank";

            CodeOptions.IsRequired = true;
            CodeOptions.Caption = "Code";

            AmountOptions.IsRequired = true;
            AmountOptions.Caption = "Amount";

            ReceivedDateOptions.IsRequired = true;
            ReceivedDateOptions.Caption = "Received Date";

            IssuedDateOptions.IsRequired = true;
            IssuedDateOptions.Caption = "Issued Date";

            IssuedByCustomerBillGroupOptions.IsRequired = true;
            IssuedByCustomerBillGroupOptions.Caption = "Billing Group";
            
            IssuedByCustomerOptions.IsRequired = true;
            IssuedByCustomerOptions.Caption = "Customer";

            EffectiveDateOptions.IsRequired = true;
            EffectiveDateOptions.Caption = "Effective Date ";

            IncomingAccountOptions.IsRequired = true;
            IncomingAccountOptions.Caption = "Incoming Account";
        }

        #endregion

        #region Properties

        public mvGiro Giro { get; set; }



        private ComboBoxEditOptions<mvCollector> collectorOptions = new ComboBoxEditOptions<mvCollector>();
        public ComboBoxEditOptions<mvCollector> CollectorOptions { get { return collectorOptions; } set { SetProperty(ref collectorOptions, value); } }
        private Guid? collectorID = null;
        public Guid? CollectorID { get { return collectorID; } set { SetProperty(ref collectorID, value); } }

        private bool isCheque = false;
        public bool IsCheque { get { return isCheque; } set { SetProperty(ref isCheque, value); } }

        private ComboBoxEditOptions<mvFinanceInstitution> bankOptions = new ComboBoxEditOptions<mvFinanceInstitution>();
        public ComboBoxEditOptions<mvFinanceInstitution> BankOptions { get { return bankOptions; } set { SetProperty(ref bankOptions, value); } }
        private int? bankID = null;
        public int? BankID { get { return bankID; } set { SetProperty(ref bankID, value); } }

        private TextEditOptions<string> codeOptions = new TextEditOptions<string>();
        public TextEditOptions<string> CodeOptions { get { return codeOptions; } set { SetProperty(ref codeOptions, value); } }
        private string code = null;
        public string Code { get { return code; } set { SetProperty(ref code, value); } }

        private NumericEditOptions<double> amountOptions = new NumericEditOptions<double>();
        public NumericEditOptions<double> AmountOptions { get { return amountOptions; } set { SetProperty(ref amountOptions, value); } }
        private double? amount = null;
        public double? Amount { get { return amount; } set { SetProperty(ref amount, value); } }

        private DateEditOptions<DateTime> receivedDateOptions = new DateEditOptions<DateTime>();
        public DateEditOptions<DateTime> ReceivedDateOptions { get { return receivedDateOptions; } set { SetProperty(ref receivedDateOptions, value); } }
        private DateTime? receivedDate = null;
        public DateTime? ReceivedDate { get { return receivedDate; } set { SetProperty(ref receivedDate, value); } }

        private DateEditOptions<DateTime> issuedDateOptions = new DateEditOptions<DateTime>();
        public DateEditOptions<DateTime> IssuedDateOptions { get { return issuedDateOptions; } set { SetProperty(ref issuedDateOptions, value); } }
        private DateTime? issuedDate = null;
        public DateTime? IssuedDate { get { return issuedDate; } set { SetProperty(ref issuedDate, value); } }

        private bool isIssuedByCustomer = false;
        public bool IsIssuedByCustomer { get { return isIssuedByCustomer; } set { SetProperty(ref isIssuedByCustomer, value); } }

        private ComboBoxEditOptions<IssuedByCustomerBillGroup> issuedByCustomerBillGroupOptions = new ComboBoxEditOptions<IssuedByCustomerBillGroup>();
        public ComboBoxEditOptions<IssuedByCustomerBillGroup> IssuedByCustomerBillGroupOptions { get { return issuedByCustomerBillGroupOptions; } set { SetProperty(ref issuedByCustomerBillGroupOptions, value); } }
        private Guid? issuedByCustomerBillGroupID = null;
        public Guid? IssuedByCustomerBillGroupID { get { return issuedByCustomerBillGroupID; } set { SetProperty(ref issuedByCustomerBillGroupID, value); } }

        private ComboBoxEditOptions<IssuedByCustomer> issuedByCustomerOptions = new ComboBoxEditOptions<IssuedByCustomer>();
        public ComboBoxEditOptions<IssuedByCustomer> IssuedByCustomerOptions { get { return issuedByCustomerOptions; } set { SetProperty(ref issuedByCustomerOptions, value); } }
        private Guid? issuedByCustomerID = null;
        public Guid? IssuedByCustomerID { get { return issuedByCustomerID; } set { SetProperty(ref issuedByCustomerID, value); } }

        private DateEditOptions<DateTime> effectiveDateOptions = new DateEditOptions<DateTime>();
        public DateEditOptions<DateTime> EffectiveDateOptions { get { return effectiveDateOptions; } set { SetProperty(ref effectiveDateOptions, value); } }
        private DateTime? effectiveDate = null;
        public DateTime? EffectiveDate { get { return effectiveDate; } set { SetProperty(ref effectiveDate, value); } }

        private ComboBoxEditOptions<mvIncomingAccount> incomingAccountOptions = new ComboBoxEditOptions<mvIncomingAccount>();
        public ComboBoxEditOptions<mvIncomingAccount> IncomingAccountOptions { get { return incomingAccountOptions; } set { SetProperty(ref incomingAccountOptions, value); } }
        private int? incomingAccountID = null;
        public int? IncomingAccountID { get { return incomingAccountID; } set { SetProperty(ref incomingAccountID, value); } }

        #endregion

        #region Methods

        public void Reset()
        {
            BankID = null;
            Code = null;            
            ReceivedDate = null;
            IssuedDate = null;
            IssuedByCustomerBillGroupID = null;
            IssuedByCustomerID = null;
            EffectiveDate = null;
            Amount = null;
            IncomingAccountID = null;

            ResetErrorMessage();
        }

        public bool Validate()
        {
            ResetErrorMessage();

            bool isValid = true;

            isValid = (BankOptions.Validate<int?>(BankID) && isValid);
            isValid = (CodeOptions.Validate<string>(Code) && isValid);
            isValid = (ReceivedDateOptions.Validate<DateTime?>(ReceivedDate) && isValid);
            isValid = (IssuedDateOptions.Validate<DateTime?>(IssuedDate) && isValid);

            if (IsIssuedByCustomer)            
                isValid = (IssuedByCustomerOptions.Validate<Guid?>(IssuedByCustomerID) && isValid);
            else
                isValid = (IssuedByCustomerBillGroupOptions.Validate<Guid?>(IssuedByCustomerBillGroupID) && isValid);

            isValid = (EffectiveDateOptions.Validate<DateTime?>(EffectiveDate) && isValid);
            isValid = (AmountOptions.Validate<double?>(Amount) && isValid);
            isValid = (IncomingAccountOptions.Validate<int?>(IncomingAccountID) && isValid);

            return isValid;
        }

        #endregion

    }

}
