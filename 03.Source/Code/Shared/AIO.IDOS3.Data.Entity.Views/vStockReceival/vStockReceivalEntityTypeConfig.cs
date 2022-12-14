// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:32
// Description   : vStockReceivalEntityTypeConfig class.
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

    public class vStockReceivalEntityTypeConfig : IEntityTypeConfiguration<vStockReceival>, IEdmEntityConfiguration<vStockReceival>
    {

        #region Implements IEntityTypeConfiguration<vStockReceival>
        
        public void Configure(EntityTypeBuilder<vStockReceival> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vStockReceival>

        public string EntitySetName { get; } = "vStockReceivals";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vStockReceival> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vStockReceival
        {
            builder.ToTable("vStockReceival");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vStockReceival
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID });
        }

        #endregion

    }

}
