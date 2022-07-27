using AIO.IDOS3.Data.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public sealed class MobileDataUtility
    {
        
        #region Enumerations

        public enum RoutePlanType
        {
            SalesInRoute = 1,
            SalesOutRoute = 2,
            CollectionRoute = 3
        }

        #endregion

        #region Methods

        public static void CalcProductPriceAndDiscount(mvSalesOrderSummary summary, mvProduct product, DateTime transactionDate, DateTime? priceDate, List<mvProductPrice> productPrices,
            mvDiscountGroup discountGroup, int qtyOrder, double? addDiscountStrataPercentage, bool forceZero, bool isMultiStrataDiscount)
        {
            var _productPrices = productPrices.ToList<vProductPrice>();

            var _discountGroup = new vDiscountGroup();
            _discountGroup.CopyFrom(discountGroup);
            _discountGroup.ChildProducts = new Collection<vDiscountGroupProduct>();

            foreach (var item in discountGroup.ChildProducts)
            {
                var _discountGroupProduct = new vDiscountGroupProduct();
                _discountGroupProduct.CopyFrom(item);
                _discountGroupProduct.Parent = _discountGroup;

                if (item.ExtendDiscountStrata1 != null)
                {
                    var _discountStrata = new vDiscountStrata();
                    _discountStrata.CopyFrom(item.ExtendDiscountStrata1);
                    _discountStrata.ChildDetails = new Collection<vDiscountStrataDetails>();

                    foreach (var subItem in item.ExtendDiscountStrata1.ChildDetails)
                    {
                        var _discountStrataDetails = new vDiscountStrataDetails();
                        _discountStrataDetails.CopyFrom(subItem);
                        _discountStrataDetails.Parent = _discountStrata;
                        _discountStrata.ChildDetails.Add(_discountStrataDetails);
                    }

                    _discountGroupProduct.ExtendDiscountStrata1 = _discountStrata;
                }

                if (item.ExtendDiscountStrata2 != null)
                {
                    var _discountStrata = new vDiscountStrata();
                    _discountStrata.CopyFrom(item.ExtendDiscountStrata2);
                    _discountStrata.ChildDetails = new Collection<vDiscountStrataDetails>();

                    foreach (var subItem in item.ExtendDiscountStrata2.ChildDetails)
                    {
                        var _discountStrataDetails = new vDiscountStrataDetails();
                        _discountStrataDetails.CopyFrom(subItem);
                        _discountStrataDetails.Parent = _discountStrata;
                        _discountStrata.ChildDetails.Add(_discountStrataDetails);
                    }

                    _discountGroupProduct.ExtendDiscountStrata2 = _discountStrata;
                }

                if (item.ExtendDiscountStrata3 != null)
                {
                    var _discountStrata = new vDiscountStrata();
                    _discountStrata.CopyFrom(item.ExtendDiscountStrata3);
                    _discountStrata.ChildDetails = new Collection<vDiscountStrataDetails>();

                    foreach (var subItem in item.ExtendDiscountStrata3.ChildDetails)
                    {
                        var _discountStrataDetails = new vDiscountStrataDetails();
                        _discountStrataDetails.CopyFrom(subItem);
                        _discountStrataDetails.Parent = _discountStrata;
                        _discountStrata.ChildDetails.Add(_discountStrataDetails);
                    }

                    _discountGroupProduct.ExtendDiscountStrata3 = _discountStrata;
                }

                if (item.ExtendDiscountStrata4 != null)
                {
                    var _discountStrata = new vDiscountStrata();
                    _discountStrata.CopyFrom(item.ExtendDiscountStrata4);
                    _discountStrata.ChildDetails = new Collection<vDiscountStrataDetails>();

                    foreach (var subItem in item.ExtendDiscountStrata4.ChildDetails)
                    {
                        var _discountStrataDetails = new vDiscountStrataDetails();
                        _discountStrataDetails.CopyFrom(subItem);
                        _discountStrataDetails.Parent = _discountStrata;
                        _discountStrata.ChildDetails.Add(_discountStrataDetails);
                    }

                    _discountGroupProduct.ExtendDiscountStrata4 = _discountStrata;
                }

                if (item.ExtendDiscountStrata5 != null)
                {
                    var _discountStrata = new vDiscountStrata();
                    _discountStrata.CopyFrom(item.ExtendDiscountStrata5);
                    _discountStrata.ChildDetails = new Collection<vDiscountStrataDetails>();

                    foreach (var subItem in item.ExtendDiscountStrata5.ChildDetails)
                    {
                        var _discountStrataDetails = new vDiscountStrataDetails();
                        _discountStrataDetails.CopyFrom(subItem);
                        _discountStrataDetails.Parent = _discountStrata;
                        _discountStrata.ChildDetails.Add(_discountStrataDetails);
                    }

                    _discountGroupProduct.ExtendDiscountStrata5 = _discountStrata;
                }

                _discountGroup.ChildProducts.Add(_discountGroupProduct);
            }

            MainDataUtility.CalcProductPriceAndDiscount(summary, product, transactionDate, priceDate, _productPrices, _discountGroup, qtyOrder, addDiscountStrataPercentage,
                forceZero, isMultiStrataDiscount);
        }

        public static void CalcProductPriceAndDiscount(mvSalesOrderReturnSummary summary, mvProduct product, DateTime transactionDate, DateTime? priceDate, List<mvProductPrice> productPrices,
            mvDiscountGroup discountGroup, int qtyOrder, double? addDiscountStrataPercentage, bool forceZero, bool isMultiStrataDiscount)
        {
            var _productPrices = productPrices.ToList<vProductPrice>();

            var _discountGroup = new vDiscountGroup();
            _discountGroup.CopyFrom(discountGroup);
            _discountGroup.ChildProducts = new Collection<vDiscountGroupProduct>();

            foreach (var item in discountGroup.ChildProducts)
            {
                var _discountGroupProduct = new vDiscountGroupProduct();
                _discountGroupProduct.CopyFrom(item);
                _discountGroupProduct.Parent = _discountGroup;

                if (item.ExtendDiscountStrata1 != null)
                {
                    var _discountStrata = new vDiscountStrata();
                    _discountStrata.CopyFrom(item.ExtendDiscountStrata1);
                    _discountStrata.ChildDetails = new Collection<vDiscountStrataDetails>();

                    foreach (var subItem in item.ExtendDiscountStrata1.ChildDetails)
                    {
                        var _discountStrataDetails = new vDiscountStrataDetails();
                        _discountStrataDetails.CopyFrom(subItem);
                        _discountStrataDetails.Parent = _discountStrata;
                        _discountStrata.ChildDetails.Add(_discountStrataDetails);
                    }

                    _discountGroupProduct.ExtendDiscountStrata1 = _discountStrata;
                }

                if (item.ExtendDiscountStrata2 != null)
                {
                    var _discountStrata = new vDiscountStrata();
                    _discountStrata.CopyFrom(item.ExtendDiscountStrata2);
                    _discountStrata.ChildDetails = new Collection<vDiscountStrataDetails>();

                    foreach (var subItem in item.ExtendDiscountStrata2.ChildDetails)
                    {
                        var _discountStrataDetails = new vDiscountStrataDetails();
                        _discountStrataDetails.CopyFrom(subItem);
                        _discountStrataDetails.Parent = _discountStrata;
                        _discountStrata.ChildDetails.Add(_discountStrataDetails);
                    }

                    _discountGroupProduct.ExtendDiscountStrata2 = _discountStrata;
                }

                if (item.ExtendDiscountStrata3 != null)
                {
                    var _discountStrata = new vDiscountStrata();
                    _discountStrata.CopyFrom(item.ExtendDiscountStrata3);
                    _discountStrata.ChildDetails = new Collection<vDiscountStrataDetails>();

                    foreach (var subItem in item.ExtendDiscountStrata3.ChildDetails)
                    {
                        var _discountStrataDetails = new vDiscountStrataDetails();
                        _discountStrataDetails.CopyFrom(subItem);
                        _discountStrataDetails.Parent = _discountStrata;
                        _discountStrata.ChildDetails.Add(_discountStrataDetails);
                    }

                    _discountGroupProduct.ExtendDiscountStrata3 = _discountStrata;
                }

                if (item.ExtendDiscountStrata4 != null)
                {
                    var _discountStrata = new vDiscountStrata();
                    _discountStrata.CopyFrom(item.ExtendDiscountStrata4);
                    _discountStrata.ChildDetails = new Collection<vDiscountStrataDetails>();

                    foreach (var subItem in item.ExtendDiscountStrata4.ChildDetails)
                    {
                        var _discountStrataDetails = new vDiscountStrataDetails();
                        _discountStrataDetails.CopyFrom(subItem);
                        _discountStrataDetails.Parent = _discountStrata;
                        _discountStrata.ChildDetails.Add(_discountStrataDetails);
                    }

                    _discountGroupProduct.ExtendDiscountStrata4 = _discountStrata;
                }

                if (item.ExtendDiscountStrata5 != null)
                {
                    var _discountStrata = new vDiscountStrata();
                    _discountStrata.CopyFrom(item.ExtendDiscountStrata5);
                    _discountStrata.ChildDetails = new Collection<vDiscountStrataDetails>();

                    foreach (var subItem in item.ExtendDiscountStrata5.ChildDetails)
                    {
                        var _discountStrataDetails = new vDiscountStrataDetails();
                        _discountStrataDetails.CopyFrom(subItem);
                        _discountStrataDetails.Parent = _discountStrata;
                        _discountStrata.ChildDetails.Add(_discountStrataDetails);
                    }

                    _discountGroupProduct.ExtendDiscountStrata5 = _discountStrata;
                }

                _discountGroup.ChildProducts.Add(_discountGroupProduct);
            }

            MainDataUtility.CalcProductPriceAndDiscount(summary, product, transactionDate, priceDate, _productPrices, _discountGroup, qtyOrder, addDiscountStrataPercentage,
                forceZero, isMultiStrataDiscount);
        }

        #endregion

    }

}
