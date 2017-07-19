// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RestorableDroppedDatabasesOperations.
    /// </summary>
    public static partial class RestorableDroppedDatabasesOperationsExtensions
    {
            /// <summary>
            /// Gets a deleted database that can be restored
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
            /// <param name='restorableDroppededDatabaseId'>
            /// The id of the deleted database in the form of
            /// databaseName,deletionTimeInFileTimeFormat
            /// </param>
            public static RestorableDroppedDatabase Get(this IRestorableDroppedDatabasesOperations operations, string resourceGroupName, string serverName, string restorableDroppededDatabaseId)
            {
                return operations.GetAsync(resourceGroupName, serverName, restorableDroppededDatabaseId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a deleted database that can be restored
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
            /// <param name='restorableDroppededDatabaseId'>
            /// The id of the deleted database in the form of
            /// databaseName,deletionTimeInFileTimeFormat
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RestorableDroppedDatabase> GetAsync(this IRestorableDroppedDatabasesOperations operations, string resourceGroupName, string serverName, string restorableDroppededDatabaseId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, restorableDroppededDatabaseId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of deleted databases that can be restored
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
            public static IEnumerable<RestorableDroppedDatabase> ListByServer(this IRestorableDroppedDatabasesOperations operations, string resourceGroupName, string serverName)
            {
                return operations.ListByServerAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of deleted databases that can be restored
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<RestorableDroppedDatabase>> ListByServerAsync(this IRestorableDroppedDatabasesOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
