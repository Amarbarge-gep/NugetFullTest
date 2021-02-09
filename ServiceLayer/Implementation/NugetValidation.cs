using dm.lib.document.search.nuget.Services.Interfaces;
using dm.lib.document.search.nuget.Services.Models;
using ServiceLayer.Constant;
using ServiceLayer.Interface;
using ServiceLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Implementation
{
    public class NugetValidation : INugetValidation
    {
        private readonly Func<SearchDocumentTypes, ISearchDocumentService> _searchDelegate;
        public NugetValidation(Func<SearchDocumentTypes, ISearchDocumentService> searchDelegate)
        {
            _searchDelegate = searchDelegate;
        }
        public void JustCall()
        {
            List<String> HeaderProperties = new List<string>();
            HeaderProperties.Add(ElasticSearchConstants.DocumentId);
            HeaderProperties.Add(ElasticSearchConstants.DocumentNumber);
            HeaderProperties.Add(ElasticSearchConstants.POScheduleLineNumber);
            HeaderProperties.Add(ElasticSearchConstants.Item);
            HeaderProperties.Add(ElasticSearchConstants.RequestDate);
            HeaderProperties.Add(ElasticSearchConstants.PromisedDate);
            HeaderProperties.Add(ElasticSearchConstants.RemainingRequestQuantity);
            HeaderProperties.Add(ElasticSearchConstants.TotalPromisedQty);
            HeaderProperties.Add(ElasticSearchConstants.POStatus);
            HeaderProperties.Add(ElasticSearchConstants.POItemNumber);
            HeaderProperties.Add(ElasticSearchConstants.POSupplierName);
            HeaderProperties.Add(ElasticSearchConstants.POCreatedOn);
            HeaderProperties.Add(ElasticSearchConstants.PONo);
            HeaderProperties.Add(ElasticSearchConstants.CustomerItemName);
            HeaderProperties.Add(ElasticSearchConstants.ShipFrom);
            HeaderProperties.Add(ElasticSearchConstants.ShipTo);
            HeaderProperties.Add(ElasticSearchConstants.PurchaseOrderRequestScheduleId);
            Dictionary<string, string[]> searchFields = new Dictionary<string, string[]>();
            searchFields.Add(ElasticSearchConstants.DocumentStatus, new string[] { "Open" });
            _searchDelegate(SearchDocumentTypes.PurchaseOrder).Search<PurchaseOrderModel>(new RequestPayload()
            {
                PageNumber = 1,
                PageSize = 10,
                AdvancedSearch = searchFields

            }, new ReturnAttributes()
            {
                Level1Properties = HeaderProperties
            }, (level, sourcedic) =>
            {
                return sourcedic;
            }, (data) =>
            {
                List<PurchaseOrderModel> model = new List<PurchaseOrderModel>();
                return model;
            });
            throw new NotImplementedException();
        }
    }
}
