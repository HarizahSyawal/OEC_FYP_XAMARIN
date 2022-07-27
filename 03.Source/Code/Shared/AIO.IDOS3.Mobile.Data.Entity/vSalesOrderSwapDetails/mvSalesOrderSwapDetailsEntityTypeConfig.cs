﻿// ===================================================================================
// Author        : System
// Created date  : 15 Sep 2020 03:27:02
// Description   : mvSalesOrderSwapDetailsEntityTypeConfig class.
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
using AIO.IDOS3.Data.Entity;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public class mvSalesOrderSwapDetailsEntityTypeConfig : IEntityTypeConfiguration<mvSalesOrderSwapDetails>, IEdmEntityConfiguration<mvSalesOrderSwapDetails>
    {

        #region Fields

        private vSalesOrderSwapDetailsEntityTypeConfig parentConfig = new vSalesOrderSwapDetailsEntityTypeConfig();

        #endregion

        #region Implements IEntityTypeConfiguration<mvSalesOrderSwapDetails>

        public void Configure(EntityTypeBuilder<mvSalesOrderSwapDetails> builder) { parentConfig.InternalConfigure(builder); }

        #endregion

        #region Implements IEdmEntityConfiguration<mvSalesOrderSwapDetails>

        public string EntitySetName { get { return parentConfig.EntitySetName; } }

        public void ConfigureEdmEntity(EntityTypeConfiguration<mvSalesOrderSwapDetails> builder) { parentConfig.InternalConfigureEdmEntity(builder); }

        #endregion

    }

}