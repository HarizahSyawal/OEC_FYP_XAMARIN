// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 07:11:04
// Description   : mvSiteEntityTypeConfig class.
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

    public class mvSiteEntityTypeConfig : IEntityTypeConfiguration<mvSite>, IEdmEntityConfiguration<mvSite>
    {

        #region Fields

        private vSiteEntityTypeConfig parentConfig = new vSiteEntityTypeConfig();

        #endregion

        #region Implements IEntityTypeConfiguration<mvSite>

        public void Configure(EntityTypeBuilder<mvSite> builder) { parentConfig.InternalConfigure(builder); }

        #endregion

        #region Implements IEdmEntityConfiguration<mvSite>

        public string EntitySetName { get { return parentConfig.EntitySetName; } }

        public void ConfigureEdmEntity(EntityTypeConfiguration<mvSite> builder) { parentConfig.InternalConfigureEdmEntity(builder); }

        #endregion

    }

}
