using Microsoft.AspNet.OData.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{

    public class vCustomerHistoricalEntityTypeConfig : IEntityTypeConfiguration<vCustomerHistorical>, IEdmEntityConfiguration<vCustomerHistorical>
    {

        #region Implements IEntityTypeConfiguration<vCustomer>

        public void Configure(EntityTypeBuilder<vCustomerHistorical> builder) { InternalConfigure(builder); }

        #endregion

        #region Implements IEdmEntityConfiguration<vCustomer>

        public string EntitySetName { get; } = "vCustomersHistoricals";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vCustomerHistorical> builder) { InternalConfigureEdmEntity(builder); }

        #endregion

        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vCustomerHistorical
        {
            builder.ToTable("vCustomerHistorical");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.CustomerID });
        }

        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vCustomerHistorical
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.CustomerID });
        }

        #endregion

    }

}
