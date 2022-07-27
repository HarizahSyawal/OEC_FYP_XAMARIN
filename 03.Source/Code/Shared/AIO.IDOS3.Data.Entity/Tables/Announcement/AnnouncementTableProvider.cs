using System.Threading.Tasks;
using Wismapi.Data;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{
    public partial class AnnouncementTableProvider : DataTableProvider<Announcement>
    {
        #region Methods

        protected override async Task OnBeginInsertDataAsync(BeginOperationDataEventArgs<Announcement> e)
        {
            //e.Data.CreatedDate = await DbContext.GetDatabaseUtcDateTimeAsync();

            //var authenticatedUser = ((MainDbContext)DbContext).GetAuthenticatedUser();
            //if (authenticatedUser != null)
            //    e.Data.CreatedByUserID = authenticatedUser.ID;

            await base.OnBeginInsertDataAsync(e);
        }

        protected override async Task OnBeginUpdateDataAsync(BeginOperationDataEventArgs<Announcement> e)
        {
            //e.Data.ModifiedDate = await DbContext.GetDatabaseUtcDateTimeAsync();

            //var authenticatedUser = ((MainDbContext)DbContext).GetAuthenticatedUser();
            //if (authenticatedUser != null)
            //    e.Data.ModifiedByUserID = authenticatedUser.ID;

            await base.OnBeginUpdateDataAsync(e);
        }

        protected override async Task OnBeginDeleteDataAsync(BeginOperationDataEventArgs<Announcement> e)
        {
            // e.Data.ModifiedDate = await DbContext.GetDatabaseUtcDateTimeAsync();

            await base.OnBeginDeleteDataAsync(e);
        }

        #endregion
    }
}
