using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    public partial class mvUniversityServiceProvider : DataServiceProvider<mvUniversity>
    {
        #region Constructors

        public mvUniversityServiceProvider(CoreDataServiceContext dataServiceContext)
            : base(dataServiceContext)
        {

        }

        #endregion
    }
}
