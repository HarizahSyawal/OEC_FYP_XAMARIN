using AIO.IDOS3.Mobile.Data.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class EditPaymentCollectionModel : BindableErrorBase
    {

        #region Constructors

        public EditPaymentCollectionModel()
        {
            MobileDocumentCodeOptions.Caption = "Reference Number";

            TransactionDateOptions.Caption = "Transaction Date";

            MultiPaymentOptions.IsRequired = true;
            MultiPaymentOptions.Caption = "Method";


            BankTransferTransactionCodeOptions.Caption = "Transaction Number";
            BankTransferProofOfTransferPhotoOptions.Caption = "Proof of Transfer";

            GiroOptions.Caption = "Giro";

            VirtualAccountCodeOptions.Caption = "VA Number";

            MobilePaymentTransactionCodeOptions.Caption = "Transaction Number";


            AmountOptions.IsRequired = true;
            AmountOptions.AllowNullValue = true;
            AmountOptions.Caption = "Payment";
        }

        #endregion

        #region Properties

        private mvPaymentCollection paymentCollection = null;
        public mvPaymentCollection PaymentCollection { get { return paymentCollection; } set { SetProperty(ref paymentCollection, value); } }


        private TextEditOptions<string> mobileDocumentCodeOptions = new TextEditOptions<string>();
        public TextEditOptions<string> MobileDocumentCodeOptions { get { return mobileDocumentCodeOptions; } set { SetProperty(ref mobileDocumentCodeOptions, value); } }
        private string mobileDocumentCode = null;
        public string MobileDocumentCode { get { return mobileDocumentCode; } set { SetProperty(ref mobileDocumentCode, value); } }

        private DateEditOptions<DateTime> transactionDateOptions = new DateEditOptions<DateTime>();
        public DateEditOptions<DateTime> TransactionDateOptions { get { return transactionDateOptions; } set { SetProperty(ref transactionDateOptions, value); } }
        private DateTime? transactionDate = null;
        public DateTime? TransactionDate { get { return transactionDate; } set { SetProperty(ref transactionDate, value); } }
                
        private ComboBoxEditOptions<mvMultiPayment> multiPaymentOptions = new ComboBoxEditOptions<mvMultiPayment>();
        public ComboBoxEditOptions<mvMultiPayment> MultiPaymentOptions { get { return multiPaymentOptions; } set { SetProperty(ref multiPaymentOptions, value); } }
        private int? multiPaymentID = null;
        public int? MultiPaymentID { get { return multiPaymentID; } set { SetProperty(ref multiPaymentID, value); } }


        private TextEditOptions<string> bankTransferTransactionCodeOptions = new TextEditOptions<string>();
        public TextEditOptions<string> BankTransferTransactionCodeOptions { get { return bankTransferTransactionCodeOptions; } set { SetProperty(ref bankTransferTransactionCodeOptions, value); } }
        private string bankTransferTransactionCode = null;
        public string BankTransferTransactionCode { get { return bankTransferTransactionCode; } set { SetProperty(ref bankTransferTransactionCode, value); } }

        private TextEditOptions<string> bankTransferProofOfTransferPhotoOptions = new TextEditOptions<string>();
        public TextEditOptions<string> BankTransferProofOfTransferPhotoOptions { get { return bankTransferProofOfTransferPhotoOptions; } set { SetProperty(ref bankTransferProofOfTransferPhotoOptions, value); } }
        private string bankTransferProofOfTransferPhoto = null;
        public string BankTransferProofOfTransferPhoto { get { return bankTransferProofOfTransferPhoto; } set { SetProperty(ref bankTransferProofOfTransferPhoto, value); } }


        private ComboBoxEditOptions<mvGiro> giroOptions = new ComboBoxEditOptions<mvGiro>();
        public ComboBoxEditOptions<mvGiro> GiroOptions { get { return giroOptions; } set { SetProperty(ref giroOptions, value); } }
        private Guid? giroID = null;
        public Guid? GiroID { get { return giroID; } set { SetProperty(ref giroID, value); } }


        private TextEditOptions<string> virtualAccountCodeOptions = new TextEditOptions<string>();
        public TextEditOptions<string> VirtualAccountCodeOptions { get { return virtualAccountCodeOptions; } set { SetProperty(ref virtualAccountCodeOptions, value); } }
        private string virtualAccountCode = null;
        public string VirtualAccountCode { get { return virtualAccountCode; } set { SetProperty(ref virtualAccountCode, value); } }


        private TextEditOptions<string> mobilePaymentTransactionCodeOptions = new TextEditOptions<string>();
        public TextEditOptions<string> MobilePaymentTransactionCodeOptions { get { return mobilePaymentTransactionCodeOptions; } set { SetProperty(ref mobilePaymentTransactionCodeOptions, value); } }
        private string mobilePaymentTransactionCode = null;
        public string MobilePaymentTransactionCode { get { return mobilePaymentTransactionCode; } set { SetProperty(ref mobilePaymentTransactionCode, value); } }


        private NumericEditOptions<double> amountOptions = new NumericEditOptions<double>();
        public NumericEditOptions<double> AmountOptions { get { return amountOptions; } set { SetProperty(ref amountOptions, value); } }
        private double? amount = null;
        public double? Amount { get { return amount; } set { SetProperty(ref amount, value); } }

        private ObservableCollection<mvPaymentCollectionDetails> childDetails = new ObservableCollection<mvPaymentCollectionDetails>();
        public ObservableCollection<mvPaymentCollectionDetails> ChildDetails { get { return childDetails; } set { SetProperty(ref childDetails, value); } }


        private double? totalAdditionalCostAmount = null;
        public double? TotalAdditionalCostAmount { get { return totalAdditionalCostAmount; } set { SetProperty(ref totalAdditionalCostAmount, value); } }

        private double? totalAllocationAmount = null;
        public double? TotalAllocationAmount { get { return totalAllocationAmount; } set { SetProperty(ref totalAllocationAmount, value); } }

        private double? totalAmount = null;
        public double? TotalAmount { get { return totalAmount; } set { SetProperty(ref totalAmount, value); } }

        #endregion

    }

}
