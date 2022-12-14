// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:45:55
// Description   : vCustomerBillGroupEntityTypeConfig class.
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

    public class vCustomerBillGroupEntityTypeConfig : IEntityTypeConfiguration<vCustomerBillGroup>, IEdmEntityConfiguration<vCustomerBillGroup>
    {

        #region Implements IEntityTypeConfiguration<vCustomerBillGroup>
        
        public void Configure(EntityTypeBuilder<vCustomerBillGroup> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vCustomerBillGroup>

        public string EntitySetName { get; } = "vCustomerBillGroups";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vCustomerBillGroup> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vCustomerBillGroup
        {
            builder.ToTable("vCustomerBillGroup");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vCustomerBillGroup
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }

        #endregion

    }

}
