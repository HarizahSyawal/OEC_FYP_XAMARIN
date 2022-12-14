// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:32
// Description   : vStockReceivalDetailsEntityTypeConfig class.
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

    public class vStockReceivalDetailsEntityTypeConfig : IEntityTypeConfiguration<vStockReceivalDetails>, IEdmEntityConfiguration<vStockReceivalDetails>
    {

        #region Implements IEntityTypeConfiguration<vStockReceivalDetails>
        
        public void Configure(EntityTypeBuilder<vStockReceivalDetails> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vStockReceivalDetails>

        public string EntitySetName { get; } = "vStockReceivalDetails";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vStockReceivalDetails> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vStockReceivalDetails
        {
            builder.ToTable("vStockReceivalDetails");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.ProductID, p.ProductLotID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vStockReceivalDetails
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.ProductID, p.ProductLotID });
        }

        #endregion

    }

}
