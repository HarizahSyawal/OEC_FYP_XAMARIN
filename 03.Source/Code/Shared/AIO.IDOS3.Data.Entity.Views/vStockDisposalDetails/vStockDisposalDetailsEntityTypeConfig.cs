﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:22
// Description   : vStockDisposalDetailsEntityTypeConfig class.
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

    public class vStockDisposalDetailsEntityTypeConfig : IEntityTypeConfiguration<vStockDisposalDetails>, IEdmEntityConfiguration<vStockDisposalDetails>
    {

        #region Implements IEntityTypeConfiguration<vStockDisposalDetails>
        
        public void Configure(EntityTypeBuilder<vStockDisposalDetails> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vStockDisposalDetails>

        public string EntitySetName { get; } = "vStockDisposalDetails";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vStockDisposalDetails> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vStockDisposalDetails
        {
            builder.ToTable("vStockDisposalDetails");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.ProductID, p.ProductLotID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vStockDisposalDetails
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.ProductID, p.ProductLotID });
        }

        #endregion

    }

}
