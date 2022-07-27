using Microsoft.AspNet.OData.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{
    public class vAnnouncementEntityTypeConfig : IEntityTypeConfiguration<vAnnouncement>, IEdmEntityConfiguration<vAnnouncement>
    {
        #region Implements IEntityTypeConfiguration<vAnnouncement>

        public void Configure(EntityTypeBuilder<vAnnouncement> builder) { InternalConfigure(builder); }

        #endregion

        #region Implements IEdmEntityConfiguration<vUser>

        public string EntitySetName { get; } = "vAnnouncements";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vAnnouncement> builder) { InternalConfigureEdmEntity(builder); }

        #endregion

        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vAnnouncement
        {
            builder.ToTable("vAnnouncement");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }

        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vAnnouncement
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }

        #endregion
    }
}
