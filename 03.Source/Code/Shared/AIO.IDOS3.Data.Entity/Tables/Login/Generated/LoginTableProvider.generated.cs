using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{
    public partial class LoginTableProvider : DataTableProvider<Login>
    {
        public LoginTableProvider(CoreDbContext dbContext)
    : base(dbContext)
        {

        }
    }
}
