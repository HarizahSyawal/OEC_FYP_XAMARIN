using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{ 
      public partial class vRegisterServiceProvider : DataServiceProvider<vRegister>
{
      #region Constructors

        public vRegisterServiceProvider(CoreDataServiceContext dataServiceContext)
            : base(dataServiceContext)
        {
        
        }

        #endregion
    }
}
