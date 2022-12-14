// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:09
// Description   : vPurchaseOrderEntityTypeConfig class.
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

    public class vPurchaseOrderEntityTypeConfig : IEntityTypeConfiguration<vPurchaseOrder>, IEdmEntityConfiguration<vPurchaseOrder>
    {

        #region Implements IEntityTypeConfiguration<vPurchaseOrder>
        
        public void Configure(EntityTypeBuilder<vPurchaseOrder> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vPurchaseOrder>

        public string EntitySetName { get; } = "vPurchaseOrders";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vPurchaseOrder> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vPurchaseOrder
        {
            builder.ToTable("vPurchaseOrder");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vPurchaseOrder
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID });
        }

        #endregion

    }

}
