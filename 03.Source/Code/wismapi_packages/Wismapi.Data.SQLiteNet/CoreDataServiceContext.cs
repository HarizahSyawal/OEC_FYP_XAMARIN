using Microsoft.OData.Client;
using Microsoft.OData.Edm;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Threading.Tasks;
using Wismapi.Data.Entity.Common;

namespace Wismapi.Data.SQLiteNet
{

    public abstract class CoreDataServiceContext : DataServiceContext
    {

        #region Static Members

        protected static IEdmModel EdmModel = null;

        #endregion

        #region Classes

        protected class EntityInfo
        {

            #region Constructors

            public EntityInfo(DataServiceQuery dataServiceQuery, string controllerName, PropertyInfo[] primaryKeys, object copyFromMethod)
            {
                DataServiceQuery = dataServiceQuery;
                ControllerName = controllerName;
                PrimaryKeys = primaryKeys;
                CopyFromMethod = copyFromMethod;
            }

            #endregion

            #region Properties

            public DataServiceQuery DataServiceQuery { get; set; }
            public string ControllerName { get; set; }
            public PropertyInfo[] PrimaryKeys { get; set; }
            public object CopyFromMethod { get; set; }

            #endregion

        }

        #endregion

        #region Fields

        private CoreDbContext dbContext = null;

        private readonly ConcurrentDictionary<string, EntityInfo> entityInfos = new ConcurrentDictionary<string, EntityInfo>();
        private static ConcurrentDictionary<string, object> dataServiceProviders = new ConcurrentDictionary<string, object>();
        private static ConcurrentDictionary<string, object> internalSaveDeepChanges = new ConcurrentDictionary<string, object>();

        #endregion

        #region Constructors

        public CoreDataServiceContext(Uri serviceRoot)
            : this(serviceRoot, null)
        {

        }

        public CoreDataServiceContext(Uri serviceRoot, CoreDbContext dbContext)
            : base(serviceRoot, ODataProtocolVersion.V4)
        {
            this.dbContext = dbContext;
            MergeOption = MergeOption.NoTracking;

            BuildingRequest += CoreDataServiceContext_BuildingRequest;
        }

        #endregion

        #region Methods

        public TDataServiceProvider GetDataServiceProvider<TDataServiceProvider>()
        {
            var type = typeof(TDataServiceProvider);

            return (TDataServiceProvider)(((Func<CoreDataServiceContext, object>)dataServiceProviders.GetOrAdd(type.Name, (string key) =>
            {
                var ctorInfo = type.GetConstructor(new Type[] { typeof(CoreDataServiceContext) });
                var param = Expression.Parameter(typeof(CoreDataServiceContext), "p");
                var creatorExpr = Expression.Lambda<Func<CoreDataServiceContext, object>>(Expression.New(ctorInfo, new Expression[] { param }), param);

                return creatorExpr.Compile();
            }))(this));
        }

        public int SaveDeepChanges() { return SaveDeepChangesAsync().Result; }

        public async Task<int> SaveDeepChangesAsync()
        {
            var i = 0; ////////////

            foreach (var entry in Entities.Where(p => (p.State == EntityStates.Added) || (p.State == EntityStates.Modified) || (p.State == EntityStates.Deleted)))
            {
                var entity = entry.Entity;
                var entityType = entity.GetType();

                ((Action<CoreDataServiceContext, BaseEntityType, EntityStates>)internalSaveDeepChanges.GetOrAdd(entityType.Name, (string key) =>
                {
                    var paramContext = Expression.Parameter(typeof(CoreDataServiceContext), "context");
                    var paramData = Expression.Parameter(typeof(BaseEntityType), "data");
                    var paramState = Expression.Parameter(typeof(EntityStates), "state");
                    var callInternalSaveDeepChanges = Expression.Call(paramContext, "InternalSaveDeepChanges", new Type[] { entityType }, paramData, paramState);

                    return Expression.Lambda<Action<CoreDataServiceContext, BaseEntityType, EntityStates>>(callInternalSaveDeepChanges, paramContext, paramData, paramState).Compile();
                }))(this, (BaseEntityType)entity, entry.State);

                await Task.CompletedTask; //////////////////////////////////
                i++;
            }

            return i;
        }


        public virtual DataServiceQuery<TData> CreateQuery<TData>() where TData : class { return CreateQuery<TData>(GetEntityInfo<TData>().ControllerName); }

        public virtual DataServiceQuerySingle<TData> CreateQuerySingle<TData>(params object[] primaryKeys) where TData : class
        {
            var entityInfo = GetEntityInfo<TData>();
            var keys = new Dictionary<string, object>();
            for (int i = 0; i < entityInfo.PrimaryKeys.Length; i++)
                keys.Add(entityInfo.PrimaryKeys[i].Name, primaryKeys[i]);

            return new DataServiceQuerySingle<TData>(this, CreateQuery<TData>().GetKeyPath(Serializer.GetKeyString(this, keys)));
        }

        public virtual void AddObject<TData>(TData entity) where TData : class { AddObject(GetEntityInfo<TData>().ControllerName, entity); }
        public virtual void AttachTo<TData>(TData entity) where TData : class { AttachTo(GetEntityInfo<TData>().ControllerName, entity); }


        public DateTime GetDatabaseServerDateTime() { return GetDatabaseServerDateTimeAsync().Result; }
        public DateTime GetDatabaseServerUtcDateTime() { return GetDatabaseServerUtcDateTimeAsync().Result; }

        public async Task<DateTime> GetDatabaseServerDateTimeAsync()
        {
            return await CreateFunctionQuerySingle<DateTime>("", "GetDatabaseServerDateTime", true).GetValueAsync();
        }

        public async Task<DateTime> GetDatabaseServerUtcDateTimeAsync()
        {
            return await CreateFunctionQuerySingle<DateTime>("", "GetDatabaseServerUtcDateTime", true).GetValueAsync();
        }



        private void InternalSaveDeepChanges<TData>(BaseEntityType data, EntityStates state) where TData : BaseEntityType
        {
            var entityInfo = GetEntityInfo<TData>();
            var type = typeof(TData);

            var jsonSettings = new JsonSerializerSettings();

            jsonSettings.ContractResolver = DataDefaultContractResolver.Instance;
            jsonSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            jsonSettings.DateParseHandling = DateParseHandling.DateTimeOffset;
            jsonSettings.DateFormatHandling = DateFormatHandling.IsoDateFormat;
            jsonSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;

            var serializedEntity = JsonConvert.SerializeObject(data, jsonSettings);

            using (var httpHandler = new HttpClientHandler())
            {
                using (var httpClient = new HttpClient(httpHandler))
                {
                    httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Prefer", @"odata.include-annotations=""*""");
                    httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json;odata.metadata=minimal");

                    var authenticationHeader = dbContext.GetAuthenticationHeader();
                    if (!string.IsNullOrEmpty(authenticationHeader.Value))
                        httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", authenticationHeader.Value);

                    using (var odataContent = new StringContent(serializedEntity))
                    {
                        odataContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                        HttpResponseMessage response = null;

                        string uri = "";
                        switch (state)
                        {
                            case EntityStates.Added:
                                uri = CreateQuery<TData>().RequestUri.AbsoluteUri;
                                break;
                            case EntityStates.Modified:
                            case EntityStates.Deleted:
                                var keys = new List<object>();
                                for (int i = 0; i < entityInfo.PrimaryKeys.Length; i++)
                                    keys.Add(entityInfo.PrimaryKeys[i].GetValue(data));

                                uri = CreateQuerySingle<TData>(keys.ToArray()).RequestUri.AbsoluteUri;
                                break;
                        }

                        switch (state)
                        {
                            case EntityStates.Added: response = httpClient.PostAsync(uri, odataContent).Result; break;
                            case EntityStates.Modified: response = httpClient.PutAsync(uri, odataContent).Result; break;
                            case EntityStates.Deleted: response = httpClient.DeleteAsync(uri).Result; break;
                        }

                        var content = response.Content.ReadAsStringAsync().Result;

                        if (response.IsSuccessStatusCode == false)
                            throw new Exception(content);

                        var responseData = JsonConvert.DeserializeObject<TData>(content, jsonSettings);

                        if (entityInfo.CopyFromMethod != null)
                            ((Action<TData, TData>)entityInfo.CopyFromMethod)((TData)data, responseData);
                        else
                        {
                            foreach (var propertyInfo in type.GetProperties().Where(p => p.GetCustomAttribute(typeof(IgnoreClientPropertyAttribute)) == null))
                                propertyInfo.SetValue(responseData, propertyInfo.GetValue(data));
                        }
                    }
                }
            }
        }

        private EntityInfo GetEntityInfo<TData>() where TData : class
        {
            var type = typeof(TData);

            return entityInfos.GetOrAdd(type.Name, (string key) =>
            {
                var clrEntityTypeConfig = GetType().Assembly.GetExportedTypes().SingleOrDefault(p => (p.Name == string.Format("{0}EntityTypeConfig", type.Name)));
                if (clrEntityTypeConfig == null)
                    throw new EntryPointNotFoundException(string.Format("'{0}EntityTypeConfig' class not found or not implements {1}.", type.Name, nameof(IEdmEntityConfiguration<TData>)));

                var clrEntityTypeConfigInstance = (Expression.Lambda<Func<IEdmEntityConfiguration<TData>>>(Expression.New(clrEntityTypeConfig.GetConstructor(Type.EmptyTypes))).Compile())();
                var controllerName = clrEntityTypeConfigInstance.EntitySetName;

                var entity = EdmModel.EntityContainer.EntitySets().Single(p => p.Name == controllerName).EntityType();

                var query = CreateQuery<TData>(controllerName);
                var primaryKeys = new List<PropertyInfo>();
                foreach (var primaryKey in entity.DeclaredKey.ToList())
                    primaryKeys.Add(type.GetProperty(primaryKey.Name));

                object copyFromMethod = null;
                var copyFromMethodInfo = type.GetMethod("CopyFrom");
                if (copyFromMethodInfo != null)
                {
                    var paramData = Expression.Parameter(type, "data");
                    var paramSource = Expression.Parameter(type, "source");
                    var callCopyFrom = Expression.Call(paramData, copyFromMethodInfo, paramSource);
                    copyFromMethod = Expression.Lambda<Action<TData, TData>>(callCopyFrom, paramData, paramSource).Compile();
                }

                return new EntityInfo(query, controllerName, primaryKeys.ToArray(), copyFromMethod);
            });
        }

        #endregion

        #region Events

        private void CoreDataServiceContext_BuildingRequest(object sender, BuildingRequestEventArgs e)
        {
            e.Headers.Add(dbContext.GetAuthenticationHeader());
        }

        #endregion

    }

}
