// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:05
// Description   : vPaymentCollectionAdditionalCostEntityTypeConfig class.
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

    public class vPaymentCollectionAdditionalCostEntityTypeConfig : IEntityTypeConfiguration<vPaymentCollectionAdditionalCost>, IEdmEntityConfiguration<vPaymentCollectionAdditionalCost>
    {

        #region Implements IEntityTypeConfiguration<vPaymentCollectionAdditionalCost>
        
        public void Configure(EntityTypeBuilder<vPaymentCollectionAdditionalCost> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vPaymentCollectionAdditionalCost>

        public string EntitySetName { get; } = "vPaymentCollectionAdditionalCosts";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vPaymentCollectionAdditionalCost> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vPaymentCollectionAdditionalCost
        {
            builder.ToTable("vPaymentCollectionAdditionalCost");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.PCDocumentID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vPaymentCollectionAdditionalCost
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.PCDocumentID });
        }

        #endregion

    }

}
