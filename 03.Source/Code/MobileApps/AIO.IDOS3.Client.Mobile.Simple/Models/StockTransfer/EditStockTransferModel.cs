using AIO.IDOS3.Mobile.Data.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class EditStockTransferModel : BindableErrorBase
    {

        #region Properties

        public mvStockTransfer data = null;
        public mvStockTransfer Data { get { return data; } set { SetProperty(ref data, value); } }


        public mvSalesman SalesmanData { get; set; }
        public List<mvSalesmanProduct> SalesmanProductsData { get; set; }
        public mvWarehouse SourceWarehouseData { get; set; }
        public mvWarehouse DestinationWarehouseData { get; set; }


        private TextEditOptions<string> mobileDocumentCodeOptions = new TextEditOptions<string>();
        public TextEditOptions<string> MobileDocumentCodeOptions { get { return mobileDocumentCodeOptions; } set { SetProperty(ref mobileDocumentCodeOptions, value); } }
        private string mobileDocumentCode = null;
        public string MobileDocumentCode { get { return mobileDocumentCode; } set { SetProperty(ref mobileDocumentCode, value); } }

        private DateEditOptions<DateTime> transactionDateOptions = new DateEditOptions<DateTime>();
        public DateEditOptions<DateTime> TransactionDateOptions { get { return transactionDateOptions; } set { SetProperty(ref transactionDateOptions, value); } }
        private DateTime? transactionDate = null;
        public DateTime? TransactionDate { get { return transactionDate; } set { SetProperty(ref transactionDate, value); } }

        private TextEditOptions<string> sourceWarehouseOptions = new TextEditOptions<string>();
        public TextEditOptions<string> SourceWarehouseOptions { get { return sourceWarehouseOptions; } set { SetProperty(ref sourceWarehouseOptions, value); } }
        private string sourceWarehouse = null;
        public string SourceWarehouse { get { return sourceWarehouse; } set { SetProperty(ref sourceWarehouse, value); } }

        private TextEditOptions<string> destinationWarehouseOptions = new TextEditOptions<string>();
        public TextEditOptions<string> DestinationWarehouseOptions { get { return destinationWarehouseOptions; } set { SetProperty(ref destinationWarehouseOptions, value); } }
        private string destinationWarehouse = null;
        public string DestinationWarehouse { get { return destinationWarehouse; } set { SetProperty(ref destinationWarehouse, value); } }

        private TextEditOptions<string> documentStatusNameOptions = new TextEditOptions<string>();
        public TextEditOptions<string> DocumentStatusNameOptions { get { return documentStatusNameOptions; } set { SetProperty(ref documentStatusNameOptions, value); } }
        private string documentStatusName = null;
        public string DocumentStatusName { get { return documentStatusName; } set { SetProperty(ref documentStatusName, value); } }

        private ObservableCollection<mvStockTransferSummary> childSummaries = new ObservableCollection<mvStockTransferSummary>();
        public ObservableCollection<mvStockTransferSummary> ChildSummaries { get { return childSummaries; } set { SetProperty(ref childSummaries, value); } }

        #endregion

    }

}
