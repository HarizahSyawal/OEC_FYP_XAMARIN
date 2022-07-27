using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AIO.IDOS3.Data.Entity
{
    public class LoginEntityTypeConfig : IEntityTypeConfiguration<Login>
    {

        #region Implements IEntityTypeConfiguration<Login>

        public void Configure(EntityTypeBuilder<Login> builder) { InternalConfigure(builder); }

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : Login
        {
            builder.ToTable("Login");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
            builder.Property(p => p.ID).ValueGeneratedOnAdd();
        }

        #endregion
    }
}
