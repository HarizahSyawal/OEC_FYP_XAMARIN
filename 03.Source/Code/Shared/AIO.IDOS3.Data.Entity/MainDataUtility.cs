using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIO.IDOS3.Data.Entity
{

    public sealed class MainDataUtility
    {

        #region Enumerations

        public enum MasterType
        {
            Customer = 1
        }

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
            Customer = 20,
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
            Voided = 13,
            Revised = 14
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
            Voided = 13,
            Revised = 14
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
            Voided = 13,
            Revised = 14
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
            Voided = 13,
            Revised = 14
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
            Voided = 13,
            Revised = 14
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
            Voided = 13,
            Revised = 14
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

        public enum MobileActivityStatus
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

        public static readonly int DecimalRoundPrecision = 0;

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

        #endregion

    }

}
