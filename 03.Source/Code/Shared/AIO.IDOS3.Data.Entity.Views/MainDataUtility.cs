using System;
using System.Collections.Generic;
using System.Linq;

namespace AIO.IDOS3.Data.Entity
{

    public sealed class MainDataUtility
    {

        #region Enumerations

        public enum TransactionType
        {
            SalesOrder = 1,
            SalesOrderReturn = 2,
            SalesOrderSwap = 3,
            SalesOrderSample = 4,
            SalesOrderFOC = 5,
            StockOpname = 6,
            StockItemStatusChanges = 7,
            StockTransfer = 8,
            StockDisposal = 9,
            DeliveryOrder = 10,
            Invoice = 11,
            StockReceival = 12,
            StockMatching = 13,
            StockLotCodeChanges = 14,
            StockReturnForSample = 15,
            StockReturnForDisposal = 16,
            StockProductChanges = 17,
            StockReturn = 18,
            StockReceipt = 19,
            BillAndReceiptStatement = 21,
            PaymentCollection = 22,
            PaymentReconciliation = 23,
            CreditNote = 24,
            OtherIncomeOutcome = 25,
            CashDepositReceipt = 26,
            CashDepositToBank = 27,
            InvoiceOpname = 28
        }


        public enum StockTransactionDocumentStatus
        {
            PendingReserved = 1,
            PendingInTransit = 2,
            Pending3 = 3,
            Pending4 = 4,
            Pending5 = 5,
            Pending6 = 6,
            Pending7 = 7,
            Pending8 = 8,
            Pending9 = 9,
            Succeed = 10,
            Failed = 11
        }



        public enum SalesOrderDocumentStatus
        {
            Draft = 0,
            Submitted = 1,
            Shipment = 2,
            Position3Approved = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12,
            Voided = 13
        }

        public enum SalesOrderReturnDocumentStatus
        {
            Draft = 0,
            Submitted = 1,
            Position2Approved = 2,
            Position3Approved = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12,
            Voided = 13
        }

        public enum SalesOrderSwapDocumentStatus
        {
            Draft = 0,
            Submitted = 1,
            Shipment = 2,
            Position3Approved = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12,
            Voided = 13
        }

        public enum SalesOrderSampleDocumentStatus
        {
            Draft = 0,
            Submitted = 1,
            Shipment = 2,
            Position3Approved = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12,
            Voided = 13
        }

        public enum SalesOrderFOCDocumentStatus
        {
            Draft = 0,
            Submitted = 1,
            Shipment = 2,
            Position3Approved = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12,
            Voided = 13
        }

        public enum StockOpnameDocumentStatus
        {
            Draft = 0,
            Submitted = 1,
            Position2Approved = 2,
            Position3Approved = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12
        }

        public enum StockItemStatusChangesDocumentStatus
        {
            Draft = 0,
            Submitted = 1,
            Position2Approved = 2,
            Position3Approved = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12
        }

        public enum StockTransferDocumentStatus
        {
            Draft = 0,
            Submitted = 1,
            Shipment = 2,
            ProofOfDelivery = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12
        }

        public enum StockDisposalDocumentStatus
        {
            Draft = 0,
            Submitted = 1,
            Position2Approved = 2,
            Position3Approved = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12
        }

        public enum DeliveryOrderDocumentStatus
        {
            Draft = 0,
            Submitted = 1,
            Shipment = 2,
            ProofOfDelivery = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12,
            Voided = 13
        }

        public enum InvoiceDocumentStatus
        {
            Draft = 0,
            Submitted = 1,
            Position2Approved = 2,
            Position3Approved = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12,
            Voided = 13
        }

        public enum StockReceivalDocumentStatus
        {
            Draft = 0,
            Submitted = 1,
            Position2Approved = 2,
            Position3Approved = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12,
            Voided = 13
        }

        public enum StockMatchingDocumentStatus
        {
            Draft = 0,
            Submitted = 1,
            Position2Approved = 2,
            Position3Approved = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12
        }

        public enum StockReturnForSampleDocumentStatus
        {
            Draft = 0,
            Submitted = 1,
            Shipment = 2,
            ProofOfDelivery = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12
        }

        public enum StockReturnForDisposalDocumentStatus
        {
            Draft = 0,
            Submitted = 1,
            Position2Approved = 2,
            Position3Approved = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12
        }

        public enum StockLotCodeChangesDocumentStatus
        {
            Draft = 0,
            Submitted = 1,
            Position2Approved = 2,
            Position3Approved = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12
        }

        public enum StockProductChangesDocumentStatus
        {
            Draft = 0,
            Submitted = 1,
            Position2Approved = 2,
            Position3Approved = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12
        }


        public enum StockReturnDocumentStatus
        {
            Draft = 0,
            Submitted = 1,
            Shipment = 2,
            ProofOfDelivery = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12
        }

        public enum StockReceiptDocumentStatus
        {
            Draft = 0,
            Submitted = 1,
            Position2Approved = 2,
            Position3Approved = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12,
            Voided = 13
        }

        public enum BillAndReceiptStatementDocumentStatus
        {
            Draft = 0,
            Submitted = 1,
            Verified = 2,
            Completed = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12,
            Revised = 14
        }

        public enum PaymentCollectionDocumentStatus
        {
            Draft = 0,
            Position1Approved = 1,
            Position2Approved = 2,
            Position3Approved = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12,
            Voided = 13
        }

        public enum PaymentReconciliationDocumentStatus
        {
            Draft = 0,
            Position1Approved = 1,
            Position2Approved = 2,
            Position3Approved = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12,
            Voided = 13
        }

        public enum CreditNoteDocumentStatus
        {
            Draft = 0,
            Position1Approved = 1,
            Position2Approved = 2,
            Position3Approved = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12,
            Voided = 13
        }

        public enum OtherIncomeOutcomeDocumentStatus
        {
            Draft = 0,
            Position1Approved = 1,
            Position2Approved = 2,
            Position3Approved = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12,
            Voided = 13
        }

        public enum CashDepositReceiptDocumentStatus
        {
            Draft = 0,
            Position1Approved = 1,
            Position2Approved = 2,
            Position3Approved = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12,
            Voided = 13
        }

        public enum CashDepositToBankDocumentStatus
        {
            Draft = 0,
            SubmittedToBank = 1,
            Position2Approved = 2,
            Position3Approved = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12,
            Voided = 13
        }

        public enum InvoiceOpnameDocumentStatus
        {
            Draft = 0,
            Submitted = 1,
            Position2Approved = 2,
            Position3Approved = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12,
            Voided = 13
        }



        public enum PurchaseOrderDocumentStatus
        {
            Draft = 0,
            Submitted = 1,
            Position2Approved = 2,
            Position3Approved = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Posted = 10,
            Discarded = 11,
            Rejected = 12
        }



        public enum GiroStatus
        {
            Draft = 0,
            SubmittedToCollector = 1,
            SubmittedToCashier = 2,
            SubmittedToBank = 3,
            Position4Approved = 4,
            Position5Approved = 5,
            Position6Approved = 6,
            Position7Approved = 7,
            Position8Approved = 8,
            Position9Approved = 9,
            Clearing = 10,
            Discarded = 11,
            Rejected = 12
        }



        public enum BankStatementStatus
        {
            Open = 1,
            PartialReconciliation = 2,
            FullReconciliation = 3,
            Cancelled = 4
        }

        public enum BankStatementRefTransactionType
        {
            PaymentReconciliationDraft = 1,
            PaymentReconciliationDiscarded = 2,
            PaymentReconciliationPosted = 3,
            PaymentReconciliationVoided = 4,
            CashDepositToBankPosted = 5,
            CashDepositToBankVoided = 6
        }



        public enum DepositAccountTransactionType
        {
            PaymentReconciliationDraft = 1,
            PaymentReconciliationDiscarded = 2,
            PaymentReconciliationPosted = 3,
            PaymentReconciliationVoided = 4
        }



        public enum ProductItemStatus
        {
            Good = 1,
            Hold = 2,
            Bad = 3
        }

        public enum CreditNoteType
        {
            AdditionalCost = 1,
            InvoiceReturn = 2,
            Others = 3
        }

        public enum OtherIncomeOutcomeRefTransactionType
        {
            PaymentReconciliation = 23,
            CashDepositReceipt = 26
        }

        public enum MobileSalesActivityStatus
        {
            StartOfDay = 1,
            EndOfDay = 2
        }

        #endregion

        #region Classes

        public class Conversion
        {

            #region Properties

            public int QtyConvL { get; set; }
            public int QtyConvM { get; set; }
            public int QtyConvS { get; set; }
            public int QtyTransaction { get; set; }
            public string QtyTransactionConv { get; set; }

            #endregion

        }

        #endregion

        #region Constants

        public static readonly int DecimalRoundPrecision = 4;

        #endregion

        #region Properties

        public static DateTime MinDate { get; } = new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        public static DateTime MaxDate { get; } = new DateTime(9999, 12, 31, 23, 59, 59, 997, DateTimeKind.Utc);

        #endregion

        #region Methods

        public static Conversion GetConversion(string qtyTransactionConv, int? productConversionL, int? productConversionM, int? productConversionS)
        {
            var c = new Conversion();
            c.QtyTransaction = 0;
            c.QtyConvL = 0;
            c.QtyConvM = 0;
            c.QtyConvS = 0;

            var arr = qtyTransactionConv.Split('/');

            try
            {
                int n;

                if (arr.Length == 1)
                    c.QtyConvS = (!string.IsNullOrEmpty(arr[0]) && int.TryParse(arr[0], out n)) ? int.Parse(arr[0]) : 0;

                if (arr.Length == 2)
                {
                    c.QtyConvM = (!string.IsNullOrEmpty(arr[0]) && int.TryParse(arr[0], out n)) ? int.Parse(arr[0]) : 0;
                    c.QtyConvS = (!string.IsNullOrEmpty(arr[1]) && int.TryParse(arr[1], out n)) ? int.Parse(arr[1]) : 0;
                }

                if (arr.Length == 3)
                {
                    c.QtyConvL = (!string.IsNullOrEmpty(arr[0]) && int.TryParse(arr[0], out n)) ? int.Parse(arr[0]) : 0;
                    c.QtyConvM = (!string.IsNullOrEmpty(arr[1]) && int.TryParse(arr[1], out n)) ? int.Parse(arr[1]) : 0;
                    c.QtyConvS = (!string.IsNullOrEmpty(arr[2]) && int.TryParse(arr[2], out n)) ? int.Parse(arr[2]) : 0;
                }
            }
            catch (Exception)
            {
            }

            if (arr.Length == 1)
            {
                var conversion = CalcToConversion(c.QtyConvS, productConversionL, productConversionM, productConversionS);
                c.QtyConvL = conversion.QtyConvL;
                c.QtyConvM = conversion.QtyConvM;
                c.QtyConvS = conversion.QtyConvS;
            }

            c.QtyTransaction = (c.QtyConvL * (productConversionL.HasValue ? productConversionL.Value : 0)) +
                (c.QtyConvM * (productConversionM.HasValue ? productConversionM.Value : 0)) +
                (c.QtyConvS * (productConversionS.HasValue ? productConversionS.Value : 0));

            if ((arr.Length == 2) || (arr.Length == 3))
            {
                var conversion = CalcToConversion(c.QtyTransaction, productConversionL, productConversionM, productConversionS);
                c.QtyConvL = conversion.QtyConvL;
                c.QtyConvM = conversion.QtyConvM;
                c.QtyConvS = conversion.QtyConvS;
            }

            c.QtyTransactionConv = c.QtyConvL.ToString() + '/' + c.QtyConvM.ToString() + '/' + c.QtyConvS.ToString();

            return c;
        }

        public static Conversion CalcToConversion(int qty, int? productConversionL, int? productConversionM, int? productConversionS)
        {
            var c = new Conversion();
            c.QtyTransaction = qty;
            c.QtyConvL = 0;
            c.QtyConvM = 0;
            c.QtyConvS = 0;

            int div;
            int mod = 0;

            div = 0;
            if (productConversionL.HasValue)
            {
                div = (int)((qty >= 0) ? Math.Floor((double)qty / productConversionL.Value) : Math.Ceiling((double)qty / productConversionL.Value));
                mod = qty % productConversionL.Value;
                qty = (mod == 0) ? div : mod;
            }

            c.QtyConvL = div;
            div = 0;
            if ((mod > 0) && productConversionM.HasValue)
            {
                div = (int)((qty >= 0) ? Math.Floor((double)qty / productConversionM.Value) : Math.Ceiling((double)qty / productConversionM.Value));
                mod = qty % productConversionM.Value;
                qty = (mod == 0) ? div : mod;
            }

            c.QtyConvM = div;
            c.QtyConvS = mod;
            c.QtyTransactionConv = c.QtyConvL.ToString() + '/' + c.QtyConvM.ToString() + '/' + c.QtyConvS.ToString();

            return c;
        }

        public static double GetDiscountStrataDetailsPercentage(vDiscountStrata strata, DateTime priceDate, int qtyOrder)
        {
            if ((strata.ValidDateFrom.HasValue && (strata.ValidDateFrom <= priceDate)) && (strata.ValidDateTo.HasValue && (strata.ValidDateTo >= priceDate)))
            {
                var strataDetail = strata.ChildDetails.Where(p => (p.Minimum <= qtyOrder) && (p.Maximum >= qtyOrder)).SingleOrDefault();
                if ((strataDetail != null) && strataDetail.DiscountPercentage.HasValue)
                    return strataDetail.DiscountPercentage.Value;
            }

            return 0d;
        }

        public static void CalcProductPriceAndDiscount(vSalesOrderSummary summary, vProduct product, DateTime transactionDate, DateTime? priceDate, List<vProductPrice> productPrices,
            vDiscountGroup discountGroup, int qtyOrder,  double? addDiscountStrataPercentage, bool forceZero, bool isMultiStrataDiscount)
        {
            if (!priceDate.HasValue)
                priceDate = transactionDate;

            var weight = 0d;
            var dimension = 0;
            var unitGrossPrice = 0d;
            var unitPrice = 0d;
            var discountStrata1Percentage = 0d;
            var discountStrata2Percentage = 0d;
            var discountStrata3Percentage = 0d;
            var discountStrata4Percentage = 0d;
            var discountStrata5Percentage = 0d;

            if (!addDiscountStrataPercentage.HasValue)
                addDiscountStrataPercentage = 0d;

            var taxPercentage = 10d; ///////////////////////////

            if (product != null)
            {
                var productPrice = productPrices.Where(p => (p.ProductID == product.ID) && (!p.ValidDateFrom.HasValue || (p.ValidDateFrom.Value <= priceDate) &&
                    (!p.ValidDateTo.HasValue || (p.ValidDateTo.Value >= priceDate)))).SingleOrDefault();
                if (productPrice != null)
                {
                    weight = product.Weight;
                    dimension = product.DimensionL.Value * product.DimensionW.Value * product.DimensionH.Value;
                    unitGrossPrice = productPrice.GrossPrice;
                    unitPrice = productPrice.Price;
                }

                if ((discountGroup != null) && (discountGroup.ChildProducts.Count > 0))
                {
                    var discountGroupProduct = discountGroup.ChildProducts.Where(p => (p.ProductID == product.ID)).SingleOrDefault();
                    if (discountGroupProduct != null)
                    {
                        if (discountGroupProduct.ExtendDiscountStrata1 != null)
                            discountStrata1Percentage = GetDiscountStrataDetailsPercentage(discountGroupProduct.ExtendDiscountStrata1, priceDate.Value, qtyOrder);

                        if (isMultiStrataDiscount)
                        {
                            if (discountGroupProduct.ExtendDiscountStrata2 != null)
                                discountStrata2Percentage = GetDiscountStrataDetailsPercentage(discountGroupProduct.ExtendDiscountStrata2, priceDate.Value, qtyOrder);

                            if (discountGroupProduct.ExtendDiscountStrata3 != null)
                                discountStrata3Percentage = GetDiscountStrataDetailsPercentage(discountGroupProduct.ExtendDiscountStrata3, priceDate.Value, qtyOrder);

                            if (discountGroupProduct.ExtendDiscountStrata4 != null)
                                discountStrata4Percentage = GetDiscountStrataDetailsPercentage(discountGroupProduct.ExtendDiscountStrata4, priceDate.Value, qtyOrder);

                            if (discountGroupProduct.ExtendDiscountStrata5 != null)
                                discountStrata5Percentage = GetDiscountStrataDetailsPercentage(discountGroupProduct.ExtendDiscountStrata5, priceDate.Value, qtyOrder);
                        }
                    }
                }
            }

            var subtotalWeight = 0d; //weight * qtyOrder;
            var subtotalDimension = 0; //dimension * qtyOrder;

            // Raw (without rounded)
            var rawSubtotalGrossPrice = unitGrossPrice * qtyOrder;
            var rawSubtotalPrice = unitPrice * qtyOrder;

            if (forceZero)
            {
                rawSubtotalGrossPrice = 0d;
                rawSubtotalPrice = 0d;
            }

            var rawDiscountStrata1Amount = rawSubtotalPrice * (discountStrata1Percentage / 100d);
            var rawSubtotalDiscountStrata1Amount = rawSubtotalPrice - rawDiscountStrata1Amount;

            var rawDiscountStrata2Amount = rawSubtotalDiscountStrata1Amount * (discountStrata2Percentage / 100d);
            var rawSubtotalDiscountStrata2Amount = rawSubtotalDiscountStrata1Amount - rawDiscountStrata2Amount;

            var rawDiscountStrata3Amount = rawSubtotalDiscountStrata2Amount * (discountStrata3Percentage / 100d);
            var rawSubtotalDiscountStrata3Amount = rawSubtotalDiscountStrata2Amount - rawDiscountStrata3Amount;

            var rawDiscountStrata4Amount = rawSubtotalDiscountStrata3Amount * (discountStrata4Percentage / 100d);
            var rawSubtotalDiscountStrata4Amount = rawSubtotalDiscountStrata3Amount - rawDiscountStrata4Amount;

            var rawDiscountStrata5Amount = rawSubtotalDiscountStrata4Amount * (discountStrata5Percentage / 100d);
            var rawSubtotalDiscountStrata5Amount = rawSubtotalDiscountStrata4Amount - rawDiscountStrata5Amount;

            var rawAddDiscountStrataAmount = rawSubtotalDiscountStrata5Amount * (addDiscountStrataPercentage.Value / 100d);

            var rawSubtotalAmount = rawSubtotalDiscountStrata5Amount - rawAddDiscountStrataAmount;
            var rawSubtotalTaxAmount = rawSubtotalAmount - (rawSubtotalAmount / ((taxPercentage / 100d) + 1));
            var rawSubtotalGrossAmount = rawSubtotalAmount - rawSubtotalTaxAmount;

            summary.RawSubtotalGrossPrice = rawSubtotalGrossPrice;
            summary.RawSubtotalPrice = rawSubtotalPrice;
            summary.RawDiscountStrata1Amount = rawDiscountStrata1Amount;
            summary.RawDiscountStrata2Amount = rawDiscountStrata2Amount;
            summary.RawDiscountStrata3Amount = rawDiscountStrata3Amount;
            summary.RawDiscountStrata4Amount = rawDiscountStrata4Amount;
            summary.RawDiscountStrata5Amount = rawDiscountStrata5Amount;
            summary.RawAddDiscountStrataAmount = rawAddDiscountStrataAmount;
            summary.RawSubtotalDiscountStrata1 = rawSubtotalDiscountStrata1Amount;
            summary.RawSubtotalDiscountStrata2 = rawSubtotalDiscountStrata2Amount;
            summary.RawSubtotalDiscountStrata3 = rawSubtotalDiscountStrata3Amount;
            summary.RawSubtotalDiscountStrata4 = rawSubtotalDiscountStrata4Amount;
            summary.RawSubtotalDiscountStrata5 = rawSubtotalDiscountStrata5Amount;
            summary.RawSubtotalGrossAmount = rawSubtotalGrossAmount;
            summary.RawSubtotalTaxAmount = rawSubtotalTaxAmount;
            summary.RawSubtotalAmount = rawSubtotalAmount;

            // Rounded
            var subtotalGrossPrice = Math.Round((unitGrossPrice * qtyOrder), DecimalRoundPrecision);
            var subtotalPrice = Math.Round((unitPrice * qtyOrder), DecimalRoundPrecision);

            if (forceZero)
            {
                subtotalGrossPrice = 0d;
                subtotalPrice = 0d;
            }

            var discountStrata1Amount = Math.Round(Math.Floor(subtotalPrice * (discountStrata1Percentage / 100d)), DecimalRoundPrecision);
            var subtotalDiscountStrata1Amount = Math.Round((subtotalPrice - discountStrata1Amount), DecimalRoundPrecision);

            var discountStrata2Amount = Math.Round(Math.Floor(subtotalDiscountStrata1Amount * (discountStrata2Percentage / 100d)), DecimalRoundPrecision);
            var subtotalDiscountStrata2Amount = Math.Round((subtotalDiscountStrata1Amount - discountStrata2Amount), DecimalRoundPrecision);

            var discountStrata3Amount = Math.Round(Math.Floor(subtotalDiscountStrata2Amount * (discountStrata3Percentage / 100d)), DecimalRoundPrecision);
            var subtotalDiscountStrata3Amount = Math.Round((subtotalDiscountStrata2Amount - discountStrata3Amount), DecimalRoundPrecision);

            var discountStrata4Amount = Math.Round(Math.Floor(subtotalDiscountStrata3Amount * (discountStrata4Percentage / 100d)), DecimalRoundPrecision);
            var subtotalDiscountStrata4Amount = Math.Round((subtotalDiscountStrata3Amount - discountStrata4Amount), DecimalRoundPrecision);

            var discountStrata5Amount = Math.Round(Math.Floor(subtotalDiscountStrata4Amount * (discountStrata5Percentage / 100d)), DecimalRoundPrecision);
            var subtotalDiscountStrata5Amount = Math.Round((subtotalDiscountStrata4Amount - discountStrata5Amount), DecimalRoundPrecision);

            var addDiscountStrataAmount = Math.Round(Math.Floor(subtotalDiscountStrata5Amount * (addDiscountStrataPercentage.Value / 100d)), DecimalRoundPrecision);

            var subtotalAmount = Math.Round((subtotalDiscountStrata5Amount - addDiscountStrataAmount), DecimalRoundPrecision);
            var subtotalTaxAmount = Math.Round(Math.Floor(subtotalAmount - (subtotalAmount / ((taxPercentage / 100d) + 1))), DecimalRoundPrecision);
            var subtotalGrossAmount = Math.Round((subtotalAmount - subtotalTaxAmount), DecimalRoundPrecision);

            summary.SubtotalDiscountStrata1 = subtotalDiscountStrata1Amount;
            summary.SubtotalDiscountStrata2 = subtotalDiscountStrata2Amount;
            summary.SubtotalDiscountStrata3 = subtotalDiscountStrata3Amount;
            summary.SubtotalDiscountStrata4 = subtotalDiscountStrata4Amount;
            summary.SubtotalDiscountStrata5 = subtotalDiscountStrata5Amount;
            summary.TaxPercentage = taxPercentage;
            summary.SubtotalGrossPrice = subtotalGrossPrice;
            summary.SubtotalPrice = subtotalPrice;

            summary.UnitPrice = unitPrice;

            summary.DiscountStrata1Percentage = discountStrata1Percentage;
            summary.DiscountStrata1Amount = discountStrata1Amount;
            summary.DiscountStrata2Percentage = discountStrata2Percentage;
            summary.DiscountStrata2Amount = discountStrata2Amount;
            summary.DiscountStrata3Percentage = discountStrata3Percentage;
            summary.DiscountStrata3Amount = discountStrata3Amount;
            summary.DiscountStrata4Percentage = discountStrata4Percentage;
            summary.DiscountStrata4Amount = discountStrata4Amount;
            summary.DiscountStrata5Percentage = discountStrata5Percentage;
            summary.DiscountStrata5Amount = discountStrata5Amount;

            //summary.DiscountStrataDefaultAmount = discountStrata1Amount + discountStrata2Amount + discountStrata3Amount + discountStrata4Amount + discountStrata5Amount;

            summary.AddDiscountStrataAmount = addDiscountStrataAmount;

            summary.SubtotalGrossAmount = subtotalGrossAmount;
            summary.SubtotalTaxAmount = subtotalTaxAmount;
            summary.SubtotalAmount = subtotalAmount;
        }

        public static void CalcProductPriceAndDiscount(vSalesOrderReturnSummary summary, vProduct product, DateTime transactionDate, DateTime? priceDate, List<vProductPrice> productPrices,
            vDiscountGroup discountGroup, int qtyOrder, double? addDiscountStrataPercentage, bool forceZero, bool isMultiStrataDiscount)
        {
            if (!priceDate.HasValue)
                priceDate = transactionDate;

            var weight = 0d;
            var dimension = 0;
            var unitGrossPrice = 0d;
            var unitPrice = 0d;
            var discountStrata1Percentage = 0d;
            var discountStrata2Percentage = 0d;
            var discountStrata3Percentage = 0d;
            var discountStrata4Percentage = 0d;
            var discountStrata5Percentage = 0d;

            if (!addDiscountStrataPercentage.HasValue)
                addDiscountStrataPercentage = 0d;

            var taxPercentage = 10d; ///////////////////////////

            if (product != null)
            {
                var productPrice = productPrices.Where(p => (p.ProductID == product.ID) && (!p.ValidDateFrom.HasValue || (p.ValidDateFrom.Value <= priceDate) &&
                    (!p.ValidDateTo.HasValue || (p.ValidDateTo.Value >= priceDate)))).SingleOrDefault();
                if (productPrice != null)
                {
                    weight = product.Weight;
                    dimension = product.DimensionL.Value * product.DimensionW.Value * product.DimensionH.Value;
                    unitGrossPrice = productPrice.GrossPrice;
                    unitPrice = productPrice.Price;
                }

                if ((discountGroup != null) && (discountGroup.ChildProducts.Count > 0))
                {
                    var discountGroupProduct = discountGroup.ChildProducts.Where(p => (p.ProductID == product.ID)).SingleOrDefault();
                    if (discountGroupProduct != null)
                    {
                        if (discountGroupProduct.ExtendDiscountStrata1 != null)
                            discountStrata1Percentage = GetDiscountStrataDetailsPercentage(discountGroupProduct.ExtendDiscountStrata1, priceDate.Value, qtyOrder);

                        if (isMultiStrataDiscount)
                        {
                            if (discountGroupProduct.ExtendDiscountStrata2 != null)
                                discountStrata2Percentage = GetDiscountStrataDetailsPercentage(discountGroupProduct.ExtendDiscountStrata2, priceDate.Value, qtyOrder);

                            if (discountGroupProduct.ExtendDiscountStrata3 != null)
                                discountStrata3Percentage = GetDiscountStrataDetailsPercentage(discountGroupProduct.ExtendDiscountStrata3, priceDate.Value, qtyOrder);

                            if (discountGroupProduct.ExtendDiscountStrata4 != null)
                                discountStrata4Percentage = GetDiscountStrataDetailsPercentage(discountGroupProduct.ExtendDiscountStrata4, priceDate.Value, qtyOrder);

                            if (discountGroupProduct.ExtendDiscountStrata5 != null)
                                discountStrata5Percentage = GetDiscountStrataDetailsPercentage(discountGroupProduct.ExtendDiscountStrata5, priceDate.Value, qtyOrder);
                        }
                    }
                }
            }

            var subtotalWeight = 0d; //weight * qtyOrder;
            var subtotalDimension = 0; //dimension * qtyOrder;

            // Raw (without rounded)
            var rawSubtotalGrossPrice = unitGrossPrice * qtyOrder;
            var rawSubtotalPrice = unitPrice * qtyOrder;

            if (forceZero)
            {
                rawSubtotalGrossPrice = 0d;
                rawSubtotalPrice = 0d;
            }

            var rawDiscountStrata1Amount = rawSubtotalPrice * (discountStrata1Percentage / 100d);
            var rawSubtotalDiscountStrata1Amount = rawSubtotalPrice - rawDiscountStrata1Amount;

            var rawDiscountStrata2Amount = rawSubtotalDiscountStrata1Amount * (discountStrata2Percentage / 100d);
            var rawSubtotalDiscountStrata2Amount = rawSubtotalDiscountStrata1Amount - rawDiscountStrata2Amount;

            var rawDiscountStrata3Amount = rawSubtotalDiscountStrata2Amount * (discountStrata3Percentage / 100d);
            var rawSubtotalDiscountStrata3Amount = rawSubtotalDiscountStrata2Amount - rawDiscountStrata3Amount;

            var rawDiscountStrata4Amount = rawSubtotalDiscountStrata3Amount * (discountStrata4Percentage / 100d);
            var rawSubtotalDiscountStrata4Amount = rawSubtotalDiscountStrata3Amount - rawDiscountStrata4Amount;

            var rawDiscountStrata5Amount = rawSubtotalDiscountStrata4Amount * (discountStrata5Percentage / 100d);
            var rawSubtotalDiscountStrata5Amount = rawSubtotalDiscountStrata4Amount - rawDiscountStrata5Amount;

            var rawAddDiscountStrataAmount = rawSubtotalDiscountStrata5Amount * (addDiscountStrataPercentage.Value / 100d);

            var rawSubtotalAmount = rawSubtotalDiscountStrata5Amount - rawAddDiscountStrataAmount;
            var rawSubtotalTaxAmount = rawSubtotalAmount - (rawSubtotalAmount / ((taxPercentage / 100d) + 1));
            var rawSubtotalGrossAmount = rawSubtotalAmount - rawSubtotalTaxAmount;

            summary.RawSubtotalGrossPrice = rawSubtotalGrossPrice;
            summary.RawSubtotalPrice = rawSubtotalPrice;
            summary.RawDiscountStrata1Amount = rawDiscountStrata1Amount;
            summary.RawDiscountStrata2Amount = rawDiscountStrata2Amount;
            summary.RawDiscountStrata3Amount = rawDiscountStrata3Amount;
            summary.RawDiscountStrata4Amount = rawDiscountStrata4Amount;
            summary.RawDiscountStrata5Amount = rawDiscountStrata5Amount;
            summary.RawAddDiscountStrataAmount = rawAddDiscountStrataAmount;
            summary.RawSubtotalDiscountStrata1 = rawSubtotalDiscountStrata1Amount;
            summary.RawSubtotalDiscountStrata2 = rawSubtotalDiscountStrata2Amount;
            summary.RawSubtotalDiscountStrata3 = rawSubtotalDiscountStrata3Amount;
            summary.RawSubtotalDiscountStrata4 = rawSubtotalDiscountStrata4Amount;
            summary.RawSubtotalDiscountStrata5 = rawSubtotalDiscountStrata5Amount;
            summary.RawSubtotalGrossAmount = rawSubtotalGrossAmount;
            summary.RawSubtotalTaxAmount = rawSubtotalTaxAmount;
            summary.RawSubtotalAmount = rawSubtotalAmount;

            // Rounded
            var subtotalGrossPrice = Math.Round((unitGrossPrice * qtyOrder), DecimalRoundPrecision);
            var subtotalPrice = Math.Round((unitPrice * qtyOrder), DecimalRoundPrecision);

            if (forceZero)
            {
                subtotalGrossPrice = 0d;
                subtotalPrice = 0d;
            }

            var discountStrata1Amount = Math.Round(Math.Floor(subtotalPrice * (discountStrata1Percentage / 100d)), DecimalRoundPrecision);
            var subtotalDiscountStrata1Amount = Math.Round((subtotalPrice - discountStrata1Amount), DecimalRoundPrecision);

            var discountStrata2Amount = Math.Round(Math.Floor(subtotalDiscountStrata1Amount * (discountStrata2Percentage / 100d)), DecimalRoundPrecision);
            var subtotalDiscountStrata2Amount = Math.Round((subtotalDiscountStrata1Amount - discountStrata2Amount), DecimalRoundPrecision);

            var discountStrata3Amount = Math.Round(Math.Floor(subtotalDiscountStrata2Amount * (discountStrata3Percentage / 100d)), DecimalRoundPrecision);
            var subtotalDiscountStrata3Amount = Math.Round((subtotalDiscountStrata2Amount - discountStrata3Amount), DecimalRoundPrecision);

            var discountStrata4Amount = Math.Round(Math.Floor(subtotalDiscountStrata3Amount * (discountStrata4Percentage / 100d)), DecimalRoundPrecision);
            var subtotalDiscountStrata4Amount = Math.Round((subtotalDiscountStrata3Amount - discountStrata4Amount), DecimalRoundPrecision);

            var discountStrata5Amount = Math.Round(Math.Floor(subtotalDiscountStrata4Amount * (discountStrata5Percentage / 100d)), DecimalRoundPrecision);
            var subtotalDiscountStrata5Amount = Math.Round((subtotalDiscountStrata4Amount - discountStrata5Amount), DecimalRoundPrecision);

            var addDiscountStrataAmount = Math.Round(Math.Floor(subtotalDiscountStrata5Amount * (addDiscountStrataPercentage.Value / 100d)), DecimalRoundPrecision);

            var subtotalAmount = Math.Round((subtotalDiscountStrata5Amount - addDiscountStrataAmount), DecimalRoundPrecision);
            var subtotalTaxAmount = Math.Round(Math.Floor(subtotalAmount - (subtotalAmount / ((taxPercentage / 100d) + 1))), DecimalRoundPrecision);
            var subtotalGrossAmount = Math.Round((subtotalAmount - subtotalTaxAmount), DecimalRoundPrecision);
            
            summary.SubtotalDiscountStrata1 = subtotalDiscountStrata1Amount;
            summary.SubtotalDiscountStrata2 = subtotalDiscountStrata2Amount;
            summary.SubtotalDiscountStrata3 = subtotalDiscountStrata3Amount;
            summary.SubtotalDiscountStrata4 = subtotalDiscountStrata4Amount;
            summary.SubtotalDiscountStrata5 = subtotalDiscountStrata5Amount;
            summary.TaxPercentage = taxPercentage;
            summary.SubtotalGrossPrice = subtotalGrossPrice;
            summary.SubtotalPrice = subtotalPrice;

            summary.UnitPrice = unitPrice;

            summary.DiscountStrata1Percentage = discountStrata1Percentage;
            summary.DiscountStrata1Amount = discountStrata1Amount;
            summary.DiscountStrata2Percentage = discountStrata2Percentage;
            summary.DiscountStrata2Amount = discountStrata2Amount;
            summary.DiscountStrata3Percentage = discountStrata3Percentage;
            summary.DiscountStrata3Amount = discountStrata3Amount;
            summary.DiscountStrata4Percentage = discountStrata4Percentage;
            summary.DiscountStrata4Amount = discountStrata4Amount;
            summary.DiscountStrata5Percentage = discountStrata5Percentage;
            summary.DiscountStrata5Amount = discountStrata5Amount;

            //summary.DiscountStrataDefaultAmount = discountStrata1Amount + discountStrata2Amount + discountStrata3Amount + discountStrata4Amount + discountStrata5Amount;

            summary.AddDiscountStrataAmount = addDiscountStrataAmount;

            summary.SubtotalGrossAmount = subtotalGrossAmount;
            summary.SubtotalTaxAmount = subtotalTaxAmount;
            summary.SubtotalAmount = subtotalAmount;
        }

        #endregion

    }

}
