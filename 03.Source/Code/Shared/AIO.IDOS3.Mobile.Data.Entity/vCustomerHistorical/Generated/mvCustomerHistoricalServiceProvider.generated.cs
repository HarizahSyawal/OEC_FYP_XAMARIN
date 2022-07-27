using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{

    public partial class vCustomerHistoricalServiceProvider : DataServiceProvider<mvCustomerHistorical>
    {

        #region Constructors

        public vCustomerHistoricalServiceProvider(CoreDataServiceContext dataServiceContext)
            : base(dataServiceContext)
        {

        }

        #endregion

    }

}
