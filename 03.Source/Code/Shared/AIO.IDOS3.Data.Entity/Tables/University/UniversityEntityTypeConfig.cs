using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AIO.IDOS3.Data.Entity
{
    public class UniversityEntityTypeConfig : IEntityTypeConfiguration<University>
    {

        #region Implements IEntityTypeConfiguration<University>

        public void Configure(EntityTypeBuilder<University> builder) { InternalConfigure(builder); }

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : University
        {
            builder.ToTable("University");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
            builder.Property(p => p.ID).ValueGeneratedOnAdd();
        }

        #endregion

    }
}
