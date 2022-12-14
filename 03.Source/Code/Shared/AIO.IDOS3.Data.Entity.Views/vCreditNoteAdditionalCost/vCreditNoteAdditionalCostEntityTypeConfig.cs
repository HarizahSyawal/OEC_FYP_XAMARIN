// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:45:54
// Description   : vCreditNoteAdditionalCostEntityTypeConfig class.
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

    public class vCreditNoteAdditionalCostEntityTypeConfig : IEntityTypeConfiguration<vCreditNoteAdditionalCost>, IEdmEntityConfiguration<vCreditNoteAdditionalCost>
    {

        #region Implements IEntityTypeConfiguration<vCreditNoteAdditionalCost>
        
        public void Configure(EntityTypeBuilder<vCreditNoteAdditionalCost> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vCreditNoteAdditionalCost>

        public string EntitySetName { get; } = "vCreditNoteAdditionalCosts";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vCreditNoteAdditionalCost> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vCreditNoteAdditionalCost
        {
            builder.ToTable("vCreditNoteAdditionalCost");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.CNDocumentID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vCreditNoteAdditionalCost
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.CNDocumentID });
        }

        #endregion

    }

}
