using AIO.IDOS3.Mobile.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class CustomerCallModel : BindableErrorBase
    {

        #region Classes

        public class ProductStock
        {

            #region Properties

            public int ProductID { get; set; }
            public string Product { get; set; }
            public string ProductShortName { get; set; }
            public int? ProductConversionL { get; set; }
            public int? ProductConversionM { get; set; }
            public int? ProductConversionS { get; set; }
            public int? QtyOnHandGood { get; set; }
            public int? QtyOnHandHold { get; set; }
            public int? QtyOnHandBad { get; set; }

            #endregion

        }

        #endregion

        #region Constructors

        public CustomerCallModel()
        {
            
        }

        #endregion

        #region Properties

        public bool InRoute { get; set; }
        public bool IsCollectionCallAvailable { get; set; }
        public mvCustomer Customer { get; set; }
        public mvCollectionCall CollectionCall { get; set; }
        public mvSalesCall SalesCall { get; set; }        
        public mvMobileActivity MobileActivity { get; set; }
        
        public mvSalesman Salesman { get; set; }
        public mvWarehouse Warehouse { get; set; }
        public mvWarehouse MainWarehouse { get; set; }
        public List<mvProductPrice> ProductPrices { get; set; }
        public mvDiscountGroup DiscountGroup { get; set; }
        public List<mvSalesmanProduct> SalesmanProducts { get; set; }
        public List<mvSalesPromotion> SalesPromotions { get; set; }
        public List<mvSystemLookup> TermOfPayments { get; set; }
        public List<mvSystemLookup> ItemStatuses { get; set; }
        public List<mvSystemLookup> ReturnSummaryReasons { get; set; }
        public List<mvSystemLookup> SwapSummaryReasons { get; set; }
        public List<mvMultiPayment> MultiPayments { get; set; }



        private string operationText = "Check In";
        public string OperationText { get { return operationText; } set { SetProperty(ref operationText, value); } }

        private bool? isNewCustomer = null;
        public bool? IsNewCustomer { get { return isNewCustomer; } set { SetProperty(ref isNewCustomer, value); } }

        private bool isCheckedIn = false;
        public bool IsCheckedIn { get { return isCheckedIn; } set { SetProperty(ref isCheckedIn, value); } }

        private bool isCustomerStockRecordCompleted = false;
        public bool IsCustomerStockRecordCompleted { get { return isCustomerStockRecordCompleted; } set { SetProperty(ref isCustomerStockRecordCompleted, value); } }

        private bool isOtherActivityCompleted = false;
        public bool IsOtherActivityCompleted { get { return isOtherActivityCompleted; } set { SetProperty(ref isOtherActivityCompleted, value); } }

        private bool isSalesOrderCompleted = false;
        public bool IsSalesOrderCompleted { get { return isSalesOrderCompleted; } set { SetProperty(ref isSalesOrderCompleted, value); } }
                
        #endregion

        #region Methods

        public void Reset()
        {
            InRoute = false;
            IsCollectionCallAvailable = false;
            Customer = null;
            CollectionCall = null;
            SalesCall = null;            
            MobileActivity = null;

            Salesman = null;
            Warehouse = null;

            OperationText = "";
            IsCheckedIn = false;
            IsCustomerStockRecordCompleted = false;
            IsSalesOrderCompleted = false;

            ResetErrorMessage();
        }

        public bool Validate()
        {
            ResetErrorMessage();

            bool isValid = true;
                       
            return isValid;
        }



        protected override void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            switch (args.PropertyName)
            {
                case "IsCheckedIn": 
                    OperationText = string.Format("Check {0}", (IsCheckedIn) ? "Out" : "In");
                    break;
            }

            base.OnPropertyChanged(args);
        }

        #endregion

    }

}
