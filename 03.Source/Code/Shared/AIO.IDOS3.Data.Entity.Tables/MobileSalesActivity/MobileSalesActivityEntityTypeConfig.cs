// ===================================================================================
// Author        : System
// Created date  : 25 Sep 2020 00:18:57
// Description   : MobileSalesActivityEntityTypeConfig class.
//
// Modified by   :
// Modified date :
// Comments      :
//
// NOTE: This file is initially generated by system and can be modified following
//       the requirement.
// ===================================================================================

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AIO.IDOS3.Data.Entity
{

    public class MobileSalesActivityEntityTypeConfig : IEntityTypeConfiguration<MobileSalesActivity>
    {

        #region Implements IEntityTypeConfiguration<MobileSalesActivity>
                
        public void Configure(EntityTypeBuilder<MobileSalesActivity> builder) { InternalConfigure(builder); }
        
        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : MobileSalesActivity
        {
            builder.ToTable("MobileSalesActivity");
            
            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }
        
        #endregion

    }

}
