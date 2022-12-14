// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:45:55
// Description   : vCustomerBillAddressEntityTypeConfig class.
//
// Modified by   :
// Modified date :
// Comments      :
//
// NOTE: This file is initially generated by system and can be modified following
//       the requirement.
// ===================================================================================

using Microsoft.AspNet.OData.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{

    public class vCustomerBillAddressEntityTypeConfig : IEntityTypeConfiguration<vCustomerBillAddress>, IEdmEntityConfiguration<vCustomerBillAddress>
    {

        #region Implements IEntityTypeConfiguration<vCustomerBillAddress>
        
        public void Configure(EntityTypeBuilder<vCustomerBillAddress> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vCustomerBillAddress>

        public string EntitySetName { get; } = "vCustomerBillAddresses";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vCustomerBillAddress> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vCustomerBillAddress
        {
            builder.ToTable("vCustomerBillAddress");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.CustomerID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vCustomerBillAddress
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.CustomerID });
        }

        #endregion

    }

}
