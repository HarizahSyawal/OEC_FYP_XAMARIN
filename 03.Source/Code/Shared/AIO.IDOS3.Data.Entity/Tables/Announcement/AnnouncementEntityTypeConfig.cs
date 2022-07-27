using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AIO.IDOS3.Data.Entity
{
    public class AnnouncementEntityTypeConfig : IEntityTypeConfiguration<Announcement>
    {
        #region Implements IEntityTypeConfiguration<Register>

        public void Configure(EntityTypeBuilder<Announcement> builder) { InternalConfigure(builder); }

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : Announcement
        {
            builder.ToTable("Announcement");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
            builder.Property(p => p.ID).ValueGeneratedOnAdd();
        }

        #endregion
    }
}
