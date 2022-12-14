// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:11
// Description   : vSalesBySiteReportEntityTypeConfig class.
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

    public class vSalesBySiteReportEntityTypeConfig : IEntityTypeConfiguration<vSalesBySiteReport>, IEdmEntityConfiguration<vSalesBySiteReport>
    {

        #region Implements IEntityTypeConfiguration<vSalesBySiteReport>
        
        public void Configure(EntityTypeBuilder<vSalesBySiteReport> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vSalesBySiteReport>

        public string EntitySetName { get; } = "vSalesBySiteReports";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vSalesBySiteReport> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vSalesBySiteReport
        {
            builder.ToTable("vSalesBySiteReport");

            //// Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.SiteID, p.ProductBrandID, p.ProductGroup });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vSalesBySiteReport
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.SiteID, p.ProductBrandID, p.ProductGroup });
        }

        #endregion

    }

}
