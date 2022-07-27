using System.Threading.Tasks;
using Wismapi.Data;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{
    public partial class RegisterTableProvider : DataTableProvider<Register>
    {
        #region Methods

        protected override async Task OnBeginInsertDataAsync(BeginOperationDataEventArgs<Register> e)
        {
            //e.Data.CreatedDate = await DbContext.GetDatabaseUtcDateTimeAsync();

            //var authenticatedUser = ((MainDbContext)DbContext).GetAuthenticatedUser();
            //if (authenticatedUser != null)
            //    e.Data.CreatedByUserID = authenticatedUser.ID;

            await base.OnBeginInsertDataAsync(e);
        }

        protected override async Task OnBeginUpdateDataAsync(BeginOperationDataEventArgs<Register> e)
        {
            //e.Data.ModifiedDate = await DbContext.GetDatabaseUtcDateTimeAsync();

            //var authenticatedUser = ((MainDbContext)DbContext).GetAuthenticatedUser();
            //if (authenticatedUser != null)
            //    e.Data.ModifiedByUserID = authenticatedUser.ID;

            await base.OnBeginUpdateDataAsync(e);
        }

        protected override async Task OnBeginDeleteDataAsync(BeginOperationDataEventArgs<Register> e)
        {
           // e.Data.ModifiedDate = await DbContext.GetDatabaseUtcDateTimeAsync();

            await base.OnBeginDeleteDataAsync(e);
        }

        #endregion
    }
}
