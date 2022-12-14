// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:45:55
// Description   : vCustomerBillGroupHeadEntityTypeConfig class.
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

    public class vCustomerBillGroupHeadEntityTypeConfig : IEntityTypeConfiguration<vCustomerBillGroupHead>, IEdmEntityConfiguration<vCustomerBillGroupHead>
    {

        #region Implements IEntityTypeConfiguration<vCustomerBillGroupHead>
        
        public void Configure(EntityTypeBuilder<vCustomerBillGroupHead> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vCustomerBillGroupHead>

        public string EntitySetName { get; } = "vCustomerBillGroupHeads";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vCustomerBillGroupHead> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vCustomerBillGroupHead
        {
            builder.ToTable("vCustomerBillGroupHead");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vCustomerBillGroupHead
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }

        #endregion

    }

}
