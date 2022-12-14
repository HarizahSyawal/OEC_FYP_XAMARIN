// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:00
// Description   : vEmployeeAddressEntityTypeConfig class.
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

    public class vEmployeeAddressEntityTypeConfig : IEntityTypeConfiguration<vEmployeeAddress>, IEdmEntityConfiguration<vEmployeeAddress>
    {

        #region Implements IEntityTypeConfiguration<vEmployeeAddress>
        
        public void Configure(EntityTypeBuilder<vEmployeeAddress> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vEmployeeAddress>

        public string EntitySetName { get; } = "vEmployeeAddresses";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vEmployeeAddress> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vEmployeeAddress
        {
            builder.ToTable("vEmployeeAddress");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.EmployeeID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vEmployeeAddress
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.EmployeeID });
        }

        #endregion

    }

}
