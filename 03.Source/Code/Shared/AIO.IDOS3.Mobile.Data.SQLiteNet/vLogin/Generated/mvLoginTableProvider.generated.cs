using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    public partial class mvLoginTableProvider : DataTableProvider<mvLogin>
    {
        #region Constructors

        public mvLoginTableProvider(CoreDbContext dbContext)
            : base(dbContext)
        {

        }

        #endregion
    }
}
