// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:10
// Description   : vRoutePlanSalesmanEntityTypeConfig class.
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

    public class vRoutePlanSalesmanEntityTypeConfig : IEntityTypeConfiguration<vRoutePlanSalesman>, IEdmEntityConfiguration<vRoutePlanSalesman>
    {

        #region Implements IEntityTypeConfiguration<vRoutePlanSalesman>
        
        public void Configure(EntityTypeBuilder<vRoutePlanSalesman> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vRoutePlanSalesman>

        public string EntitySetName { get; } = "vRoutePlanSalesmen";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vRoutePlanSalesman> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vRoutePlanSalesman
        {
            builder.ToTable("vRoutePlanSalesman");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.SalesmanID, p.CustomerID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vRoutePlanSalesman
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.SalesmanID, p.CustomerID });
        }

        #endregion

    }

}
