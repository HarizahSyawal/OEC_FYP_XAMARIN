using AIO.IDOS3.Mobile.Data.Entity;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class EditPaymentCollectionAdditionalCostModel : BindableErrorBase
    {

        #region Properties

        public mvPaymentCollection paymentCollection = null;
        public mvPaymentCollection PaymentCollection { get { return paymentCollection; } set { SetProperty(ref paymentCollection, value); } }


        private TextEditOptions<double?> additionalCost1AmountOptions = new TextEditOptions<double?>();
        public TextEditOptions<double?> AdditionalCost1AmountOptions { get { return additionalCost1AmountOptions; } set { SetProperty(ref additionalCost1AmountOptions, value); } }
        private double? additionalCost1Amount = null;
        public double? AdditionalCost1Amount { get { return additionalCost1Amount; } set { SetProperty(ref additionalCost1Amount, value); } }

        private TextEditOptions<double?> additionalCost2AmountOptions = new TextEditOptions<double?>();
        public TextEditOptions<double?> AdditionalCost2AmountOptions { get { return additionalCost2AmountOptions; } set { SetProperty(ref additionalCost2AmountOptions, value); } }
        private double? additionalCost2Amount = null;
        public double? AdditionalCost2Amount { get { return additionalCost2Amount; } set { SetProperty(ref additionalCost2Amount, value); } }

        private TextEditOptions<double?> additionalCost3AmountOptions = new TextEditOptions<double?>();
        public TextEditOptions<double?> AdditionalCost3AmountOptions { get { return additionalCost3AmountOptions; } set { SetProperty(ref additionalCost3AmountOptions, value); } }
        private double? additionalCost3Amount = null;
        public double? AdditionalCost3Amount { get { return additionalCost3Amount; } set { SetProperty(ref additionalCost3Amount, value); } }

        private TextEditOptions<double?> additionalCost4AmountOptions = new TextEditOptions<double?>();
        public TextEditOptions<double?> AdditionalCost4AmountOptions { get { return additionalCost4AmountOptions; } set { SetProperty(ref additionalCost4AmountOptions, value); } }
        private double? additionalCost4Amount = null;
        public double? AdditionalCost4Amount { get { return additionalCost4Amount; } set { SetProperty(ref additionalCost4Amount, value); } }

        private TextEditOptions<double?> additionalCost5AmountOptions = new TextEditOptions<double?>();
        public TextEditOptions<double?> AdditionalCost5AmountOptions { get { return additionalCost5AmountOptions; } set { SetProperty(ref additionalCost5AmountOptions, value); } }
        private double? additionalCost5Amount = null;
        public double? AdditionalCost5Amount { get { return additionalCost5Amount; } set { SetProperty(ref additionalCost5Amount, value); } }

        private TextEditOptions<double?> additionalCost6AmountOptions = new TextEditOptions<double?>();
        public TextEditOptions<double?> AdditionalCost6AmountOptions { get { return additionalCost6AmountOptions; } set { SetProperty(ref additionalCost6AmountOptions, value); } }
        private double? additionalCost6Amount = null;
        public double? AdditionalCost6Amount { get { return additionalCost6Amount; } set { SetProperty(ref additionalCost6Amount, value); } }

        private TextEditOptions<double?> additionalCost7AmountOptions = new TextEditOptions<double?>();
        public TextEditOptions<double?> AdditionalCost7AmountOptions { get { return additionalCost7AmountOptions; } set { SetProperty(ref additionalCost7AmountOptions, value); } }
        private double? additionalCost7Amount = null;
        public double? AdditionalCost7Amount { get { return additionalCost7Amount; } set { SetProperty(ref additionalCost7Amount, value); } }

        private TextEditOptions<double?> additionalCost8AmountOptions = new TextEditOptions<double?>();
        public TextEditOptions<double?> AdditionalCost8AmountOptions { get { return additionalCost8AmountOptions; } set { SetProperty(ref additionalCost8AmountOptions, value); } }
        private double? additionalCost8Amount = null;
        public double? AdditionalCost8Amount { get { return additionalCost8Amount; } set { SetProperty(ref additionalCost8Amount, value); } }

        private TextEditOptions<double?> additionalCost9AmountOptions = new TextEditOptions<double?>();
        public TextEditOptions<double?> AdditionalCost9AmountOptions { get { return additionalCost9AmountOptions; } set { SetProperty(ref additionalCost9AmountOptions, value); } }
        private double? additionalCost9Amount = null;
        public double? AdditionalCost9Amount { get { return additionalCost9Amount; } set { SetProperty(ref additionalCost9Amount, value); } }

        private TextEditOptions<double?> additionalCost10AmountOptions = new TextEditOptions<double?>();
        public TextEditOptions<double?> AdditionalCost10AmountOptions { get { return additionalCost10AmountOptions; } set { SetProperty(ref additionalCost10AmountOptions, value); } }
        private double? additionalCost10Amount = null;
        public double? AdditionalCost10Amount { get { return additionalCost10Amount; } set { SetProperty(ref additionalCost10Amount, value); } }


        private double? totalAdditionalCostAmount = null;
        public double? TotalAdditionalCostAmount { get { return totalAdditionalCostAmount; } set { SetProperty(ref totalAdditionalCostAmount, value); } }

        #endregion

    }

}
