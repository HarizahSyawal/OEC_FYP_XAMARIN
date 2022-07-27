﻿// ===================================================================================
// Author        : System
// Created date  : 15 Sep 2020 03:27:02
// Description   : mvSalesOrderSwapSummaryEntityTypeConfig class.
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

    public class mvSalesOrderSwapSummaryEntityTypeConfig : IEntityTypeConfiguration<mvSalesOrderSwapSummary>, IEdmEntityConfiguration<mvSalesOrderSwapSummary>
    {

        #region Fields

        private vSalesOrderSwapSummaryEntityTypeConfig parentConfig = new vSalesOrderSwapSummaryEntityTypeConfig();

        #endregion

        #region Implements IEntityTypeConfiguration<mvSalesOrderSwapSummary>

        public void Configure(EntityTypeBuilder<mvSalesOrderSwapSummary> builder) { parentConfig.InternalConfigure(builder); }

        #endregion

        #region Implements IEdmEntityConfiguration<mvSalesOrderSwapSummary>

        public string EntitySetName { get { return parentConfig.EntitySetName; } }

        public void ConfigureEdmEntity(EntityTypeConfiguration<mvSalesOrderSwapSummary> builder) { parentConfig.InternalConfigureEdmEntity(builder); }

        #endregion

    }

}
