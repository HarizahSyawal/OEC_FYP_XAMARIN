using Microsoft.AspNet.OData.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{
    public class vRegisterEntityTypeConfig : IEntityTypeConfiguration<vRegister>, IEdmEntityConfiguration<vRegister>
    {
        #region Implements IEntityTypeConfiguration<vUser>

        public void Configure(EntityTypeBuilder<vRegister> builder) { InternalConfigure(builder); }

        #endregion

        #region Implements IEdmEntityConfiguration<vUser>

        public string EntitySetName { get; } = "vRegisters";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vRegister> builder) { InternalConfigureEdmEntity(builder); }

        #endregion

        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vRegister
        {
            builder.ToTable("vRegister");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }

        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vRegister
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }

        #endregion
    }
}
