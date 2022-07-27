﻿// ===================================================================================
// Author        : System
// Created date  : 03 Sep 2020 02:32:40
// Description   : mvSystemParameterEntityTypeConfig class.
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

    public class mvSystemParameterEntityTypeConfig : IEntityTypeConfiguration<mvSystemParameter>, IEdmEntityConfiguration<mvSystemParameter>
    {

        #region Fields

        private vSystemParameterEntityTypeConfig parentConfig = new vSystemParameterEntityTypeConfig();

        #endregion

        #region Implements IEntityTypeConfiguration<mvSystemParameter>

        public void Configure(EntityTypeBuilder<mvSystemParameter> builder) { parentConfig.InternalConfigure(builder); }

        #endregion

        #region Implements IEdmEntityConfiguration<mvSystemParameter>

        public string EntitySetName { get { return parentConfig.EntitySetName; } }

        public void ConfigureEdmEntity(EntityTypeConfiguration<mvSystemParameter> builder) { parentConfig.InternalConfigureEdmEntity(builder); }

        #endregion

    }

}