using AIO.IDOS3.Mobile.Data.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class StockTransfersModel : BindableErrorBase
    {

        #region Properties

        private ObservableCollection<mvStockTransfer> stockTransfers = new ObservableCollection<mvStockTransfer>();
        public ObservableCollection<mvStockTransfer> StockTransfers { get { return stockTransfers; } set { SetProperty(ref stockTransfers, value); } }


        public List<mvSalesman> SalesmansData { get; set; }
        public List<mvSalesmanProduct> SalesmanProductsData { get; set; }
        public List<mvWarehouse> SourceWarehousesData { get; set; }
        public List<mvWarehouse> DestinationWarehousesData { get; set; }


        private ComboBoxEditOptions<mvWarehouse> destinationWarehouseOptions = new ComboBoxEditOptions<mvWarehouse>();
        public ComboBoxEditOptions<mvWarehouse> DestinationWarehouseOptions { get { return destinationWarehouseOptions; } set { SetProperty(ref destinationWarehouseOptions, value); } }
        private Guid? destinationWarehouseID = null;
        public Guid? DestinationWarehouseID { get { return destinationWarehouseID; } set { SetProperty(ref destinationWarehouseID, value); } }

        #endregion

    }

}
