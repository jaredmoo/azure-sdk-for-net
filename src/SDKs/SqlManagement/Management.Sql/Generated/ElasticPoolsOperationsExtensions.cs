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
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ElasticPoolsOperations.
    /// </summary>
    public static partial class ElasticPoolsOperationsExtensions
    {
            /// <summary>
            /// Returns elastic pool  metrics.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool.
            /// </param>
            /// <param name='filter'>
            /// An OData filter expression that describes a subset of metrics to return.
            /// </param>
            public static IEnumerable<Metric> ListMetrics(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, string filter)
            {
                return operations.ListMetricsAsync(resourceGroupName, serverName, elasticPoolName, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns elastic pool  metrics.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool.
            /// </param>
            /// <param name='filter'>
            /// An OData filter expression that describes a subset of metrics to return.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Metric>> ListMetricsAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, string filter, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricsWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns elastic pool metric definitions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool.
            /// </param>
            public static IEnumerable<MetricDefinition> ListMetricDefinitions(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
            {
                return operations.ListMetricDefinitionsAsync(resourceGroupName, serverName, elasticPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns elastic pool metric definitions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<MetricDefinition>> ListMetricDefinitionsAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricDefinitionsWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all elastic pools in a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='skip'>
            /// The number of elements in the collection to skip.
            /// </param>
            public static IPage<ElasticPool> ListByServer(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string skip = default(string))
            {
                return operations.ListByServerAsync(resourceGroupName, serverName, skip).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all elastic pools in a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='skip'>
            /// The number of elements in the collection to skip.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ElasticPool>> ListByServerAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string skip = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerWithHttpMessagesAsync(resourceGroupName, serverName, skip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool.
            /// </param>
            public static ElasticPool Get(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
            {
                return operations.GetAsync(resourceGroupName, serverName, elasticPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ElasticPool> GetAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool.
            /// </param>
            /// <param name='parameters'>
            /// The elastic pool parameters.
            /// </param>
            public static ElasticPool CreateOrUpdate(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPool parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serverName, elasticPoolName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool.
            /// </param>
            /// <param name='parameters'>
            /// The elastic pool parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ElasticPool> CreateOrUpdateAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPool parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool.
            /// </param>
            public static void Delete(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
            {
                operations.DeleteAsync(resourceGroupName, serverName, elasticPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool.
            /// </param>
            /// <param name='parameters'>
            /// The elastic pool update parameters.
            /// </param>
            public static ElasticPool Update(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPoolUpdate parameters)
            {
                return operations.UpdateAsync(resourceGroupName, serverName, elasticPoolName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool.
            /// </param>
            /// <param name='parameters'>
            /// The elastic pool update parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ElasticPool> UpdateAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPoolUpdate parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool.
            /// </param>
            /// <param name='parameters'>
            /// The elastic pool parameters.
            /// </param>
            public static ElasticPool BeginCreateOrUpdate(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPool parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serverName, elasticPoolName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool.
            /// </param>
            /// <param name='parameters'>
            /// The elastic pool parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ElasticPool> BeginCreateOrUpdateAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPool parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool.
            /// </param>
            public static void BeginDelete(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
            {
                operations.BeginDeleteAsync(resourceGroupName, serverName, elasticPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool.
            /// </param>
            /// <param name='parameters'>
            /// The elastic pool update parameters.
            /// </param>
            public static ElasticPool BeginUpdate(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPoolUpdate parameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, serverName, elasticPoolName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool.
            /// </param>
            /// <param name='parameters'>
            /// The elastic pool update parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ElasticPool> BeginUpdateAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPoolUpdate parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all elastic pools in a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ElasticPool> ListByServerNext(this IElasticPoolsOperations operations, string nextPageLink)
            {
                return operations.ListByServerNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all elastic pools in a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ElasticPool>> ListByServerNextAsync(this IElasticPoolsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
