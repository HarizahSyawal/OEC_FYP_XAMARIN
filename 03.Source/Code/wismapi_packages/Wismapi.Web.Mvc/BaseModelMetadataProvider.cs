using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;

namespace Wismapi.Web.Mvc
{

    public class BaseModelMetadataProvider : DefaultModelMetadataProvider
    {

        #region Constructors

        public BaseModelMetadataProvider(ICompositeMetadataDetailsProvider detailsProvider)
        : base(detailsProvider)
        {
        }

        public BaseModelMetadataProvider(ICompositeMetadataDetailsProvider detailsProvider, IOptions<MvcOptions> optionsAccessor)
            : base(detailsProvider, optionsAccessor)
        {
        }

        #endregion

        #region Methods

        //protected override ModelMetadata CreateModelMetadata(DefaultMetadataDetails entry)
        //{
        //    var modelMetadata = base.CreateModelMetadata(entry);

        //    foreach (var item in entry.ModelAttributes.Attributes)
        //    {
        //        var key = item.GetType().FullName;
        //        if (modelMetadata.AdditionalValues.ContainsKey(key))
        //        {
        //            if (modelMetadata.AdditionalValues.Contains(item))
        //                continue;

        //            key = string.Format("{0}.{1}", key, modelMetadata.AdditionalValues.Count(p => (p.Key.ToString() == key) || (p.Key.ToString().StartsWith(key + "."))));
        //        }

        //        modelMetadata.AdditionalValues.Add(key, item);
        //    }


        //    return modelMetadata;
        //}

        //protected override ModelMetadata CreateModelMetadata(IEnumerable<Attribute> attributes, Type containerType, Func<object> modelAccessor, Type modelType, string propertyName)
        //{
        //    var modelMetadata = base.CreateModelMetadata(attributes, containerType, modelAccessor, modelType, propertyName);
            
        //    foreach (var item in attributes)
        //    {
        //        var key = item.GetType().FullName;
        //        if (modelMetadata.AdditionalValues.ContainsKey(key))
        //        {
        //            if (modelMetadata.AdditionalValues.ContainsValue(item))
        //                continue;

        //            key = string.Format("{0}.{1}", key, modelMetadata.AdditionalValues
        //                .Count(p => (p.Key == key) || (p.Key.StartsWith(key + "."))));
        //        }

        //        modelMetadata.AdditionalValues.Add(key, item);
        //    }

        //    return modelMetadata;
        //}


        //public override ModelMetadata GetMetadataForType(Type modelType)
        //{
        //    if (modelType == typeof(object))
        //        return base.GetMetadataForType(modelType);

        //    var identity = ModelMetadataIdentity.ForType(modelType);
        //    var details = CreateTypeDetails(identity);

        //    var context = new DisplayMetadataProviderContext(identity, details.ModelAttributes);
        //    //  Here your implementation of IDisplayMetadataProvider will be called
        //    DetailsProvider.CreateDisplayMetadata(context);
        //    details.DisplayMetadata = context.DisplayMetadata;

        //    return CreateModelMetadata(details);
        //}

        #endregion

    }

}
