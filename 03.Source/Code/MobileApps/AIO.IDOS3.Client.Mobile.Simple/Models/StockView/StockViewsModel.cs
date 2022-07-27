using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class StockViewsModel : BindableErrorBase
    {

        #region Classes

        public class StockView
        {

            #region Properties

            public Guid WarehouseID { get; set; }
            public string Warehouse { get; set; }
            public Guid SiteID { get; set; }
            public string Site { get; set; }

            public List<StockViewProduct> ChildProducts { get; set; }

            #endregion

        }

        public class StockViewProduct
        {

            #region Properties

            public int ProductID { get; set; }
            public string ProductCode { get; set; }
            public string ProductName { get; set; }
            public string Product { get; set; }
            public string ProductShortName { get; set; }
            public int? ProductConversionL { get; set; }
            public int? ProductConversionM { get; set; }
            public int? ProductConversionS { get; set; }
            public int QtyOnHandGood { get; set; }
            public string QtyOnHandConvGood { get; set; }
            public int QtyInTransitGood { get; set; }
            public string QtyInTransitConvGood { get; set; }

            public List<StockViewProductLot> ChildProductLots { get; set; }

            #endregion

        }

        public class StockViewProductLot
        {

            #region Properties

            public int ProductID { get; set; }
            public int ProductLotID { get; set; }
            public string ProductLotCode { get; set; }
            public DateTime? ProductLotExpiredDate { get; set; }
            public string ProductLot { get; set; }
            public int QtyOnHandGood { get; set; }
            public string QtyOnHandConvGood { get; set; }
            public int QtyInTransitGood { get; set; }
            public string QtyInTransitConvGood { get; set; }

            #endregion

        }

        #endregion

        #region Properties

        private ObservableCollection<StockView> stockViews = new ObservableCollection<StockView>();
        public ObservableCollection<StockView> StockViews { get { return stockViews; } set { SetProperty(ref stockViews, value); } }

        #endregion

    }

}
