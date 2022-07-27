using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    public partial class mvRegisterServiceProvider : DataServiceProvider<mvRegister>
    {
        #region Constructors

        public mvRegisterServiceProvider(CoreDataServiceContext dataServiceContext)
            : base(dataServiceContext)
        {

        }

        #endregion
    }
}
