using Microsoft.AspNet.OData.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{
    public class vLoginEntityTypeConfig : IEntityTypeConfiguration<vLogin>, IEdmEntityConfiguration<vLogin>
    {
        #region Implements IEntityTypeConfiguration<vLogin>

        public void Configure(EntityTypeBuilder<vLogin> builder) { InternalConfigure(builder); }

        #endregion

        #region Implements IEdmEntityConfiguration<vUser>

        public string EntitySetName { get; } = "vLogins";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vLogin> builder) { InternalConfigureEdmEntity(builder); }

        #endregion

        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vLogin
        {
            builder.ToTable("vLogin");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }

        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vLogin
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }

        #endregion
    }
}
