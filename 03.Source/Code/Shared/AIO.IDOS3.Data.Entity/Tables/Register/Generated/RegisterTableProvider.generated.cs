using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{
      public partial class RegisterTableProvider : DataTableProvider<Register>
    {
        public RegisterTableProvider(CoreDbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
