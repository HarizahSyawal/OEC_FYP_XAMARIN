using AIO.IDOS3.Mobile.Data.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class EditCustomerStockRecordModel : BindableErrorBase
    {

        #region Constructors

        public EditCustomerStockRecordModel()
        {
            RecordDateOptions.Caption = "Record Date";
        }

        #endregion

        #region Properties

        private DateEditOptions<DateTime> recordDateOptions = new DateEditOptions<DateTime>();
        public DateEditOptions<DateTime> RecordDateOptions { get { return recordDateOptions; } set { SetProperty(ref recordDateOptions, value); } }
        private DateTime? recordDateID = null;
        public DateTime? RecordDateID { get { return recordDateID; } set { SetProperty(ref recordDateID, value); } }

        private ObservableCollection<mvCustomerStockRecord> customerStockRecords = new ObservableCollection<mvCustomerStockRecord>();
        public ObservableCollection<mvCustomerStockRecord> CustomerStockRecords { get { return customerStockRecords; } set { SetProperty(ref customerStockRecords, value); } }


        private List<CustomerCallModel.ProductStock> productStocks = new List<CustomerCallModel.ProductStock>();
        public List<CustomerCallModel.ProductStock> ProductStocks { get { return productStocks; } set { SetProperty(ref productStocks, value); } }

        #endregion

        #region Methods

        public void Reset()
        {
            RecordDateID = null;

            CustomerStockRecords = null;

            ResetErrorMessage();
        }

        public bool Validate()
        {
            ResetErrorMessage();

            bool isValid = true;

            isValid = (RecordDateOptions.Validate<DateTime?>(RecordDateID) && isValid);

            return isValid;
        }

        #endregion

    }

}
