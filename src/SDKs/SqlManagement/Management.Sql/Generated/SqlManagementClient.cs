// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// The Azure SQL Database management API provides a RESTful set of web
    /// services that interact with Azure SQL Database services to manage your
    /// databases. The API enables you to create, retrieve, update, and delete
    /// databases.
    /// </summary>
    public partial class SqlManagementClient : ServiceClient<SqlManagementClient>, ISqlManagementClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// The subscription ID that identifies an Azure subscription.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running Operations.
        /// Default value is 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IBackupLongTermRetentionPoliciesOperations.
        /// </summary>
        public virtual IBackupLongTermRetentionPoliciesOperations BackupLongTermRetentionPolicies { get; private set; }

        /// <summary>
        /// Gets the IBackupLongTermRetentionVaultsOperations.
        /// </summary>
        public virtual IBackupLongTermRetentionVaultsOperations BackupLongTermRetentionVaults { get; private set; }

        /// <summary>
        /// Gets the IRestorePointsOperations.
        /// </summary>
        public virtual IRestorePointsOperations RestorePoints { get; private set; }

        /// <summary>
        /// Gets the IRecoverableDatabasesOperations.
        /// </summary>
        public virtual IRecoverableDatabasesOperations RecoverableDatabases { get; private set; }

        /// <summary>
        /// Gets the IRestorableDroppedDatabasesOperations.
        /// </summary>
        public virtual IRestorableDroppedDatabasesOperations RestorableDroppedDatabases { get; private set; }

        /// <summary>
        /// Gets the ICapabilitiesOperations.
        /// </summary>
        public virtual ICapabilitiesOperations Capabilities { get; private set; }

        /// <summary>
        /// Gets the IServersOperations.
        /// </summary>
        public virtual IServersOperations Servers { get; private set; }

        /// <summary>
        /// Gets the IServerConnectionPoliciesOperations.
        /// </summary>
        public virtual IServerConnectionPoliciesOperations ServerConnectionPolicies { get; private set; }

        /// <summary>
        /// Gets the IDatabaseThreatDetectionPoliciesOperations.
        /// </summary>
        public virtual IDatabaseThreatDetectionPoliciesOperations DatabaseThreatDetectionPolicies { get; private set; }

        /// <summary>
        /// Gets the IDataMaskingPoliciesOperations.
        /// </summary>
        public virtual IDataMaskingPoliciesOperations DataMaskingPolicies { get; private set; }

        /// <summary>
        /// Gets the IDataMaskingRulesOperations.
        /// </summary>
        public virtual IDataMaskingRulesOperations DataMaskingRules { get; private set; }

        /// <summary>
        /// Gets the IElasticPoolsOperations.
        /// </summary>
        public virtual IElasticPoolsOperations ElasticPools { get; private set; }

        /// <summary>
        /// Gets the IFirewallRulesOperations.
        /// </summary>
        public virtual IFirewallRulesOperations FirewallRules { get; private set; }

        /// <summary>
        /// Gets the IGeoBackupPoliciesOperations.
        /// </summary>
        public virtual IGeoBackupPoliciesOperations GeoBackupPolicies { get; private set; }

        /// <summary>
        /// Gets the IDatabasesOperations.
        /// </summary>
        public virtual IDatabasesOperations Databases { get; private set; }

        /// <summary>
        /// Gets the IReplicationLinksOperations.
        /// </summary>
        public virtual IReplicationLinksOperations ReplicationLinks { get; private set; }

        /// <summary>
        /// Gets the IServerAzureADAdministratorsOperations.
        /// </summary>
        public virtual IServerAzureADAdministratorsOperations ServerAzureADAdministrators { get; private set; }

        /// <summary>
        /// Gets the IServerCommunicationLinksOperations.
        /// </summary>
        public virtual IServerCommunicationLinksOperations ServerCommunicationLinks { get; private set; }

        /// <summary>
        /// Gets the IServiceObjectivesOperations.
        /// </summary>
        public virtual IServiceObjectivesOperations ServiceObjectives { get; private set; }

        /// <summary>
        /// Gets the IElasticPoolActivitiesOperations.
        /// </summary>
        public virtual IElasticPoolActivitiesOperations ElasticPoolActivities { get; private set; }

        /// <summary>
        /// Gets the IElasticPoolDatabaseActivitiesOperations.
        /// </summary>
        public virtual IElasticPoolDatabaseActivitiesOperations ElasticPoolDatabaseActivities { get; private set; }

        /// <summary>
        /// Gets the IRecommendedElasticPoolsOperations.
        /// </summary>
        public virtual IRecommendedElasticPoolsOperations RecommendedElasticPools { get; private set; }

        /// <summary>
        /// Gets the IServiceTierAdvisorsOperations.
        /// </summary>
        public virtual IServiceTierAdvisorsOperations ServiceTierAdvisors { get; private set; }

        /// <summary>
        /// Gets the ITransparentDataEncryptionsOperations.
        /// </summary>
        public virtual ITransparentDataEncryptionsOperations TransparentDataEncryptions { get; private set; }

        /// <summary>
        /// Gets the ITransparentDataEncryptionActivitiesOperations.
        /// </summary>
        public virtual ITransparentDataEncryptionActivitiesOperations TransparentDataEncryptionActivities { get; private set; }

        /// <summary>
        /// Gets the IServerUsagesOperations.
        /// </summary>
        public virtual IServerUsagesOperations ServerUsages { get; private set; }

        /// <summary>
        /// Gets the IDatabaseUsagesOperations.
        /// </summary>
        public virtual IDatabaseUsagesOperations DatabaseUsages { get; private set; }

        /// <summary>
        /// Gets the IDatabaseBlobAuditingPoliciesOperations.
        /// </summary>
        public virtual IDatabaseBlobAuditingPoliciesOperations DatabaseBlobAuditingPolicies { get; private set; }

        /// <summary>
        /// Gets the IDatabaseAutomaticTuningOperations.
        /// </summary>
        public virtual IDatabaseAutomaticTuningOperations DatabaseAutomaticTuning { get; private set; }

        /// <summary>
        /// Gets the IEncryptionProtectorsOperations.
        /// </summary>
        public virtual IEncryptionProtectorsOperations EncryptionProtectors { get; private set; }

        /// <summary>
        /// Gets the IFailoverGroupsOperations.
        /// </summary>
        public virtual IFailoverGroupsOperations FailoverGroups { get; private set; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        public virtual IOperations Operations { get; private set; }

        /// <summary>
        /// Gets the IServerKeysOperations.
        /// </summary>
        public virtual IServerKeysOperations ServerKeys { get; private set; }

        /// <summary>
        /// Gets the ISyncAgentsOperations.
        /// </summary>
        public virtual ISyncAgentsOperations SyncAgents { get; private set; }

        /// <summary>
        /// Gets the ISyncGroupsOperations.
        /// </summary>
        public virtual ISyncGroupsOperations SyncGroups { get; private set; }

        /// <summary>
        /// Gets the ISyncMembersOperations.
        /// </summary>
        public virtual ISyncMembersOperations SyncMembers { get; private set; }

        /// <summary>
        /// Gets the ISubscriptionUsagesOperations.
        /// </summary>
        public virtual ISubscriptionUsagesOperations SubscriptionUsages { get; private set; }

        /// <summary>
        /// Gets the IVirtualNetworkRulesOperations.
        /// </summary>
        public virtual IVirtualNetworkRulesOperations VirtualNetworkRules { get; private set; }

        /// <summary>
        /// Gets the IServerAutomaticTuningOperations.
        /// </summary>
        public virtual IServerAutomaticTuningOperations ServerAutomaticTuning { get; private set; }

        /// <summary>
        /// Gets the IServerDnsAliasesOperations.
        /// </summary>
        public virtual IServerDnsAliasesOperations ServerDnsAliases { get; private set; }

        /// <summary>
        /// Gets the IDatabaseOperations.
        /// </summary>
        public virtual IDatabaseOperations DatabaseOperations { get; private set; }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected SqlManagementClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected SqlManagementClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected SqlManagementClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected SqlManagementClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SqlManagementClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SqlManagementClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SqlManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SqlManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            BackupLongTermRetentionPolicies = new BackupLongTermRetentionPoliciesOperations(this);
            BackupLongTermRetentionVaults = new BackupLongTermRetentionVaultsOperations(this);
            RestorePoints = new RestorePointsOperations(this);
            RecoverableDatabases = new RecoverableDatabasesOperations(this);
            RestorableDroppedDatabases = new RestorableDroppedDatabasesOperations(this);
            Capabilities = new CapabilitiesOperations(this);
            Servers = new ServersOperations(this);
            ServerConnectionPolicies = new ServerConnectionPoliciesOperations(this);
            DatabaseThreatDetectionPolicies = new DatabaseThreatDetectionPoliciesOperations(this);
            DataMaskingPolicies = new DataMaskingPoliciesOperations(this);
            DataMaskingRules = new DataMaskingRulesOperations(this);
            ElasticPools = new ElasticPoolsOperations(this);
            FirewallRules = new FirewallRulesOperations(this);
            GeoBackupPolicies = new GeoBackupPoliciesOperations(this);
            Databases = new DatabasesOperations(this);
            ReplicationLinks = new ReplicationLinksOperations(this);
            ServerAzureADAdministrators = new ServerAzureADAdministratorsOperations(this);
            ServerCommunicationLinks = new ServerCommunicationLinksOperations(this);
            ServiceObjectives = new ServiceObjectivesOperations(this);
            ElasticPoolActivities = new ElasticPoolActivitiesOperations(this);
            ElasticPoolDatabaseActivities = new ElasticPoolDatabaseActivitiesOperations(this);
            RecommendedElasticPools = new RecommendedElasticPoolsOperations(this);
            ServiceTierAdvisors = new ServiceTierAdvisorsOperations(this);
            TransparentDataEncryptions = new TransparentDataEncryptionsOperations(this);
            TransparentDataEncryptionActivities = new TransparentDataEncryptionActivitiesOperations(this);
            ServerUsages = new ServerUsagesOperations(this);
            DatabaseUsages = new DatabaseUsagesOperations(this);
            DatabaseBlobAuditingPolicies = new DatabaseBlobAuditingPoliciesOperations(this);
            DatabaseAutomaticTuning = new DatabaseAutomaticTuningOperations(this);
            EncryptionProtectors = new EncryptionProtectorsOperations(this);
            FailoverGroups = new FailoverGroupsOperations(this);
            Operations = new Operations(this);
            ServerKeys = new ServerKeysOperations(this);
            SyncAgents = new SyncAgentsOperations(this);
            SyncGroups = new SyncGroupsOperations(this);
            SyncMembers = new SyncMembersOperations(this);
            SubscriptionUsages = new SubscriptionUsagesOperations(this);
            VirtualNetworkRules = new VirtualNetworkRulesOperations(this);
            ServerAutomaticTuning = new ServerAutomaticTuningOperations(this);
            ServerDnsAliases = new ServerDnsAliasesOperations(this);
            DatabaseOperations = new DatabaseOperations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
    }
}
