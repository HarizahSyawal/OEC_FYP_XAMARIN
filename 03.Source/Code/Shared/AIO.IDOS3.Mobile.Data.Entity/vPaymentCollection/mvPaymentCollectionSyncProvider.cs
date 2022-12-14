// ===================================================================================
// Author        : System
// Created date  : 08 Oct 2020 05:23:03
// Description   : mvPaymentCollectionSyncProvider partial class.
//
// Modified by   :
// Modified date :
// Comments      :
//
// NOTE: This file is initially generated by system and can be modified following
//       the requirement.
// ===================================================================================

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public partial class mvPaymentCollectionSyncProvider : DataSyncProvider<mvPaymentCollection>
    {

        #region Properties

        public static string Selector = "DocumentID,DocumentCode,TransactionDate,IsPaidByCustomer,PaidByCustomerBillGroupID,PaidByCustomerBillGroupCode,PaidByCustomerBillGroupName,PaidByCustomerBillGroup,PaidByCustomerBillGroupHeadID,PaidByCustomerBillGroupHeadCode,PaidByCustomerBillGroupHeadName,PaidByCustomerBillGroupHead,PaidByCustomerID,PaidByCustomerCode,PaidByCustomerName,PaidByCustomer,CollectorID,IsCollectedByHeadOffice,CollectedBySiteID,CollectedByAreaID,CollectedByRegionID,CollectedByTerritoryID,CollectedByCompanyID,IsCash,IsBalance,MultiPaymentID,BankTransferTransactionCode,BankTransferProofOfTransferPhoto,GiroID,GiroBankID,GiroCode,Giro,VirtualAccountCode,MobilePaymentTransactionCode,CurrencyID,OriginAmount,RawAmount,Amount,IsUsePartialBalance,PartialBalanceAmount,AvailableBalanceAmount,AdditionalCost1Amount,AdditionalCost2Amount,AdditionalCost3Amount,AdditionalCost4Amount,AdditionalCost5Amount,AdditionalCost6Amount,AdditionalCost7Amount,AdditionalCost8Amount,AdditionalCost9Amount,AdditionalCost10Amount,RawTotalAmount,RawTotalAllocationAmount,RawTotalDiffAmount,RawTotalAdditionalCostAllocationAmount,RawTotalDiffAdditionalCostAmount,TotalAmount,TotalAllocationAmount,TotalDiffAmount,TotalAdditionalCostAmount,TotalAdditionalCostAllocationAmount,TotalDiffAdditionalCostAmount,ReferenceNumber,PRDocumentID,PRDocumentCode,PRTransactionDate,PrintCount,LastPrintedDate,DocumentStatusID,DocumentStatusName,MobileDocumentCode,PostedDate,CreatedDate,ModifiedDate,ChildDetails";
        public static string Expand = "ChildDetails";

        #endregion

        #region Methods

        private async Task<Expression<Func<mvPaymentCollection, bool>>> GetFilter()
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
        }



        protected override Exception OnDownloadAllData(bool continueOnError) { return OnDownloadAllDataAsync(continueOnError).Result; }
        protected override Exception OnUploadAllData(bool continueOnError) { return OnUploadAllDataAsync(continueOnError).Result; }
        protected override Exception OnDownloadData(mvPaymentCollection obj, bool useTransaction) { return OnDownloadDataAsync(obj, useTransaction).Result; }
        protected override Exception OnUploadData(mvPaymentCollection obj, bool useTransaction) { return OnUploadDataAsync(obj, useTransaction).Result; }


        protected override async Task<Exception> OnDownloadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var paymentCollectionTableProvider = DbContext.GetDataTableProvider<mvPaymentCollectionTableProvider>();
            var paymentCollectionServiceProvider = DataServiceContext.GetDataServiceProvider<mvPaymentCollectionServiceProvider>();

            DateTime? syncDate = null;

            List<mvPaymentCollection> serverDataList = null;

            var minSyncDate = (DateTimeOffset?)await paymentCollectionTableProvider.GetData().MinAsync(p => p.SyncDate);

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    var query = paymentCollectionServiceProvider.GetData().AddQueryOption("$select", Selector).AddQueryOption("$expand", Expand).Where(await GetFilter());

                    if (minSyncDate.HasValue)
                        query = query.Where(p => (p.CreatedDate > minSyncDate.Value) || ((p.ModifiedDate != null) && (p.ModifiedDate.Value > minSyncDate.Value)));

                    serverDataList = query.ToList();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) exception = ex;
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            if (serverDataList != null)
            {
                if (serverDataList.Count > 0)
                {
                    var multiPayments = await DbContext.GetDataTableProvider<mvMultiPaymentTableProvider>().GetData().ToListAsync();

                    int index = 0;
                    foreach (var serverData in serverDataList)
                    {
                        try
                        {
                            var multiPayment = multiPayments.Where(p => p.ID.Equals(serverData.MultiPaymentID)).SingleOrDefault();

                            AssignFromLocalData(serverData, multiPayment);

                            await ProcessLocalData(syncDate, 1, 1, serverData, null, paymentCollectionTableProvider, true);
                        }
                        catch (Exception ex)
                        {
                            if (!continueOnError)
                            {
                                exception = ex;
                                break;
                            }
                        }

                        index++;
                    }
                }

                await DbContext.UpdateAllSyncDateAsync<mvPaymentCollection>(syncDate.Value);
            }

            return exception;
        }

        protected override async Task<Exception> OnUploadAllDataAsync(bool continueOnError)
        {
            Exception exception = null;

            var paymentCollectionTableProvider = DbContext.GetDataTableProvider<mvPaymentCollectionTableProvider>();
            var paymentCollectionDetailsTableProvider = DbContext.GetDataTableProvider<mvPaymentCollectionDetailsTableProvider>();
            var paymentCollectionServiceProvider = DataServiceContext.GetDataServiceProvider<mvPaymentCollectionServiceProvider>();

            DateTime? syncDate = null;

            var localDataList = await paymentCollectionTableProvider.GetData().Where(p => (p.SyncDate == null)).Include(p => p.ChildDetails).ToListAsync();

            int index = 0;
            foreach (var obj in localDataList)
            {
                var lastStatus = 1;
                var serverData = new mvPaymentCollection();

                serverData.CopyFrom(obj);
                serverData.ChildDetails = new Collection<mvPaymentCollectionDetails>();
                if (obj.ChildDetails != null)
                {
                    foreach (var details in obj.ChildDetails)
                    {
                        var serverDataDetails = new mvPaymentCollectionDetails();
                        serverDataDetails.CopyFrom(details);

                        serverData.ChildDetails.Add(serverDataDetails);
                    }
                }

                if (serverData.SyncDate == null)
                    serverData.DocumentCode = "";

                for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
                {
                    try
                    {
                        if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                        await paymentCollectionServiceProvider.InsertDataAsync(serverData, true);

                        syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                        await ProcessLocalData(syncDate, 1, (i + 1), serverData, obj, paymentCollectionTableProvider, true);
                        break;
                    }
                    catch (Exception ex)
                    {
                        if (i == (DbContext.SyncMaxAttempts - 1))
                        {
                            exception = ex;
                            lastStatus = 0;
                            try { await ProcessLocalData(syncDate, 0, (i + 1), serverData, obj, paymentCollectionTableProvider, true); } catch (Exception) { }
                        }
                        else
                            await Task.Delay(DbContext.SyncAttemptDelay);
                    }
                }

                if ((lastStatus != 1) && !continueOnError)
                    break;

                index++;
            }

            return exception;
        }


        protected override async Task<Exception> OnDownloadDataAsync(mvPaymentCollection obj, bool useTransaction)
        {
            Exception exception = null;

            var paymentCollectionTableProvider = DbContext.GetDataTableProvider<mvPaymentCollectionTableProvider>();
            var paymentCollectionServiceProvider = DataServiceContext.GetDataServiceProvider<mvPaymentCollectionServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            mvPaymentCollection serverData = null;

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();

                    serverData = paymentCollectionServiceProvider.GetData().AddQueryOption("$select", Selector).AddQueryOption("$expand", Expand)
                        .Where(p => p.DocumentID.Equals(obj.DocumentID)).SingleOrDefault();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            if (serverData != null)
            {
                var multiPayment = await DbContext.GetDataTableProvider<mvMultiPaymentTableProvider>().GetDataAsync(serverData.MultiPaymentID);

                AssignFromLocalData(serverData, multiPayment);
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, paymentCollectionTableProvider, useTransaction);

            return exception;
        }

        protected override async Task<Exception> OnUploadDataAsync(mvPaymentCollection obj, bool useTransaction)
        {
            Exception exception = null;

            var paymentCollectionTableProvider = DbContext.GetDataTableProvider<mvPaymentCollectionTableProvider>();
            var paymentCollectionServiceProvider = DataServiceContext.GetDataServiceProvider<mvPaymentCollectionServiceProvider>();

            DateTime? syncDate = null;
            int status = 1;
            int attempts = 0;

            var serverData = new mvPaymentCollection();
            serverData.CopyFrom(obj);
            serverData.ChildDetails = new Collection<mvPaymentCollectionDetails>();
            if (obj.ChildDetails != null)
            {
                foreach (var details in obj.ChildDetails)
                {
                    var serverDataDetails = new mvPaymentCollectionDetails();
                    serverDataDetails.CopyFrom(details);

                    serverData.ChildDetails.Add(serverDataDetails);
                }
            }

            if (serverData.SyncDate == null)
                serverData.DocumentCode = "";

            for (int i = 0; i < DbContext.SyncMaxAttempts; i++)
            {
                try
                {
                    if (!syncDate.HasValue) syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                    attempts++;

                    await paymentCollectionServiceProvider.InsertDataAsync(serverData, useTransaction);

                    syncDate = await DataServiceContext.GetDatabaseServerUtcDateTimeAsync();
                    break;
                }
                catch (Exception ex)
                {
                    if (i == (DbContext.SyncMaxAttempts - 1)) { exception = ex; status = 0; }
                    else await Task.Delay(DbContext.SyncAttemptDelay);
                }
            }

            await ProcessLocalData(syncDate, status, attempts, serverData, obj, paymentCollectionTableProvider, useTransaction);

            return exception;
        }



        private async Task ProcessLocalData(DateTime? syncDate, int status, int attempts, mvPaymentCollection serverData, mvPaymentCollection obj,
            mvPaymentCollectionTableProvider tableProvider, bool useTransaction)
        {
            var localDate = (syncDate.HasValue) ? syncDate.Value : await DbContext.GetDatabaseUtcDateTimeAsync();
            mvPaymentCollection paymentCollection = null;

            if (serverData == null)
            {
                paymentCollection = new mvPaymentCollection();
                paymentCollection.DocumentID = obj.DocumentID;

                await tableProvider.DeleteDataAsync(paymentCollection, useTransaction);
            }
            else
            {
                var isInsert = false;
                paymentCollection = await tableProvider.GetDataAsync(serverData.DocumentID);
                if (paymentCollection == null)
                {
                    isInsert = true;
                    paymentCollection = new mvPaymentCollection();
                }

                paymentCollection.CopyFrom(serverData);
                paymentCollection.ChildDetails = serverData.ChildDetails;
                DbContext.SetSyncData(paymentCollection, syncDate, localDate, status, attempts);

                if (isInsert)
                    await tableProvider.InsertDataAsync(paymentCollection, useTransaction);
                else
                    await tableProvider.UpdateDataAsync(paymentCollection, useTransaction);

                if (obj != null)
                {
                    obj.CopyFrom(serverData);
                    DbContext.CopySyncData(obj, paymentCollection);
                }
            }
        }

        private void AssignFromLocalData(mvPaymentCollection serverData, mvMultiPayment multiPayment)
        {
            if (serverData.MultiPaymentID != null)
            {
                if (multiPayment != null)
                {
                    serverData.MultiPaymentCode = multiPayment.Code;
                    serverData.MultiPaymentName = multiPayment.Name;
                    serverData.MultiPayment = multiPayment.MultiPayment;
                    serverData.MultiPaymentIncomingAccountID = multiPayment.IncomingAccountID;
                    serverData.MultiPaymentIncomingAccountCode = multiPayment.IncomingAccountCode;
                    serverData.MultiPaymentIncomingAccountName = multiPayment.IncomingAccountName;
                    serverData.MultiPaymentIncomingAccount = multiPayment.IncomingAccount;
                    serverData.MultiPaymentInstitutionCode = multiPayment.Code;
                    serverData.MultiPaymentInstitutionName = multiPayment.Name;
                    serverData.MultiPaymentInstitution = multiPayment.Institution;
                    //serverData.MultiPaymentInstitutionShortName = multiPayment.InstitutionShortName;
                    serverData.MultiPaymentInstitutionTypeID = multiPayment.InstitutionTypeID;
                    serverData.MultiPaymentInstitutionTypeName = multiPayment.InstitutionTypeName;
                    serverData.MultiPaymentTypeID = multiPayment.TypeID;
                    serverData.MultiPaymentTypeName = multiPayment.TypeName;

                    //serverData.CollectedBySiteID = multiPayment.SiteID;
                    //serverData.CollectedBySiteCode = multiPayment.SiteCode;
                    //serverData.CollectedBySiteName = multiPayment.SiteName;
                    //serverData.CollectedBySite = multiPayment.Site;
                    //serverData.CollectedByAreaID = multiPayment.AreaID;
                    //serverData.CollectedByAreaCode = multiPayment.AreaCode;
                    //serverData.CollectedByAreaName = multiPayment.AreaName;
                    //serverData.CollectedByArea = multiPayment.Area;
                    //serverData.CollectedByRegionID = multiPayment.RegionID;
                    //serverData.CollectedByRegionCode = multiPayment.RegionCode;
                    //serverData.CollectedByRegionName = multiPayment.RegionName;
                    //serverData.CollectedByRegion = multiPayment.Region;
                    //serverData.CollectedByTerritoryID = multiPayment.TerritoryID;
                    //serverData.CollectedByTerritoryCode = multiPayment.TerritoryCode;
                    //serverData.CollectedByTerritoryName = multiPayment.TerritoryName;
                    //serverData.CollectedByTerritory = multiPayment.Territory;
                    //serverData.CollectedByCompanyID = multiPayment.CompanyID;
                    //serverData.CollectedByCompanyCode = multiPayment.CompanyCode;
                    //serverData.CollectedByCompanyName = multiPayment.CompanyName;
                    //serverData.CollectedByCompany = multiPayment.Company;
                    //serverData.CollectedBySiteDistributionTypeID = multiPayment.SiteDistributionTypeID;
                    //serverData.CollectedBySiteDistributionTypeName = multiPayment.SiteDistributionTypeName;
                }
            }
        }
        
        #endregion

    }

}
