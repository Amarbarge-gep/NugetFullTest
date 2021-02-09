using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Constant
{
    public static class ElasticSearchConstants
    {
        public const string DocumentId = "ScheduleArray.purchaseOrderInternalId";//n
        public const string DocumentNumber = "basicDetails.name";//n
        public const string POScheduleLineNumber = "orderItems.lineItemNumber";
        public const string Item = "orderItems.description";
        public const string RequestDate = "orderItems.requestSchedules.requestDate";
        public const string PromisedDate = "orderItems.requestSchedules.promiseSchedules.promiseDate";
        public const string TotalPromisedQty = "orderItems.requestSchedules.totalQuantityPromised";
        public const string POStatus = "ScheduleArray.status";//n
        public const string POItemNumber = "orderItems.buyerItemNumber";
        public const string POSupplierName = "supplierDetails.supplierContact.firstName";
        public const string POCreatedOn = "basicDetails.createdOn";
        public const string CustomerItemName = "orderItems.buyerItemNumber";
        public const string ShipFrom = "orderItems.requestSchedules.promiseSchedules.shipFromLocation.locationName";
        public const string ShipTo = "orderItems.requestSchedules.shiptoLocation.locationName";
        public const string PurchaseOrderRequestScheduleId = "orderItems.requestSchedules.purchaseOrderRequestScheduleId";
        public const string PONo = "basicDetails.orderNumber";
        public const string DocumentStatus = "distinct_shedules.status";
        public const string RemainingRequestQuantity = "orderItems.requestSchedules.requestQuantity";
    }
}
