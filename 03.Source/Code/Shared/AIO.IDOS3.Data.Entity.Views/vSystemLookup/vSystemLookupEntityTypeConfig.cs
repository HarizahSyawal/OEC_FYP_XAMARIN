// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:37
// Description   : vSystemLookupEntityTypeConfig class.
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

    public class vSystemLookupEntityTypeConfig : IEntityTypeConfiguration<vSystemLookup>, IEdmEntityConfiguration<vSystemLookup>
    {

        #region Implements IEntityTypeConfiguration<vSystemLookup>
        
        public void Configure(EntityTypeBuilder<vSystemLookup> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vSystemLookup>

        public string EntitySetName { get; } = "vSystemLookups";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vSystemLookup> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vSystemLookup
        {
            builder.ToTable("vSystemLookup");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vSystemLookup
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }

        #endregion

    }

}
