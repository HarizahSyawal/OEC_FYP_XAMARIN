using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    public partial class mvUniversityTableProvider : DataTableProvider<mvUniversity>
    {
        #region Constructors

        public mvUniversityTableProvider(CoreDbContext dbContext)
            : base(dbContext)
        {

        }

        #endregion
    }
}
