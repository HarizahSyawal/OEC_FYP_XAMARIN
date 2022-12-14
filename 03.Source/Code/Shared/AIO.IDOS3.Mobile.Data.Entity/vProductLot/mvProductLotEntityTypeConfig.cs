// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 07:11:04
// Description   : mvProductLotEntityTypeConfig class.
//
// Modified by   :
// Modified date :
// Comments      :
//
// NOTE: This file is initially generated by system and can be modified following
//       the requirement.
// ===================================================================================

using AIO.IDOS3.Data.Entity;
using Microsoft.AspNet.OData.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public class mvProductLotEntityTypeConfig : IEntityTypeConfiguration<mvProductLot>, IEdmEntityConfiguration<mvProductLot>
    {

        #region Fields

        private vProductLotEntityTypeConfig parentConfig = new vProductLotEntityTypeConfig();

        #endregion

        #region Implements IEntityTypeConfiguration<mvProductLot>

        public void Configure(EntityTypeBuilder<mvProductLot> builder)
        {
            parentConfig.InternalConfigure(builder);

            builder.HasOne(p => p.ExtendStockOnHandCurrent)
                .WithOne(q => q.ExtendProductLot)
                .HasForeignKey<mvStockOnHandCurrent>(q => q.ProductLotID);
        }

        #endregion

        #region Implements IEdmEntityConfiguration<mvProductLot>

        public string EntitySetName { get { return parentConfig.EntitySetName; } }

        public void ConfigureEdmEntity(EntityTypeConfiguration<mvProductLot> builder) { parentConfig.InternalConfigureEdmEntity(builder); }

        #endregion

    }

}
