﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:25
// Description   : vStockMatchingEntityTypeConfig class.
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

    public class vStockMatchingEntityTypeConfig : IEntityTypeConfiguration<vStockMatching>, IEdmEntityConfiguration<vStockMatching>
    {

        #region Implements IEntityTypeConfiguration<vStockMatching>
        
        public void Configure(EntityTypeBuilder<vStockMatching> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vStockMatching>

        public string EntitySetName { get; } = "vStockMatchings";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vStockMatching> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vStockMatching
        {
            builder.ToTable("vStockMatching");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vStockMatching
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID });
        }

        #endregion

    }

}
