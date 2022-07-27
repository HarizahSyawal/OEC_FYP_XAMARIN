using Microsoft.AspNet.OData.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{
    public class vUniversityEntityTypeConfig : IEntityTypeConfiguration<vUniversity>, IEdmEntityConfiguration<vUniversity>
    {

        #region Implements IEntityTypeConfiguration<vUniversity>

        public void Configure(EntityTypeBuilder<vUniversity> builder) { InternalConfigure(builder); }

        #endregion

        #region Implements IEdmEntityConfiguration<vUniversity>

        public string EntitySetName { get; } = "vUniversitys";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vUniversity> builder) { InternalConfigureEdmEntity(builder); }

        #endregion

        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vUniversity
        {
            builder.ToTable("vUniversity");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }

        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vUniversity
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }

        #endregion

    }
}
