﻿// ===================================================================================
// Author        : System
// Created date  : 03 Sep 2020 03:21:13
// Description   : mvUserSiteEntityTypeConfig class.
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

    public class mvUserSiteEntityTypeConfig : IEntityTypeConfiguration<mvUserSite>, IEdmEntityConfiguration<mvUserSite>
    {

        #region Fields

        private vUserSiteEntityTypeConfig parentConfig = new vUserSiteEntityTypeConfig();

        #endregion

        #region Implements IEntityTypeConfiguration<mvUserSite>

        public void Configure(EntityTypeBuilder<mvUserSite> builder) { parentConfig.InternalConfigure(builder); }

        #endregion

        #region Implements IEdmEntityConfiguration<mvUserSite>

        public string EntitySetName { get { return parentConfig.EntitySetName; } }

        public void ConfigureEdmEntity(EntityTypeConfiguration<mvUserSite> builder) { parentConfig.InternalConfigureEdmEntity(builder); }

        #endregion

    }

}