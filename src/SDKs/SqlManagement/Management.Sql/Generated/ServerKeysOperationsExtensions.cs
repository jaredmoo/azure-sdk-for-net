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
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ServerKeysOperations.
    /// </summary>
    public static partial class ServerKeysOperationsExtensions
    {
            /// <summary>
            /// Gets a list of server keys.
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
            public static IPage<ServerKey> ListByServer(this IServerKeysOperations operations, string resourceGroupName, string serverName)
            {
                return operations.ListByServerAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of server keys.
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
            public static async Task<IPage<ServerKey>> ListByServerAsync(this IServerKeysOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a server key.
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
            /// <param name='keyName'>
            /// The name of the server key to be retrieved.
            /// </param>
            public static ServerKey Get(this IServerKeysOperations operations, string resourceGroupName, string serverName, string keyName)
            {
                return operations.GetAsync(resourceGroupName, serverName, keyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a server key.
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
            /// <param name='keyName'>
            /// The name of the server key to be retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerKey> GetAsync(this IServerKeysOperations operations, string resourceGroupName, string serverName, string keyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, keyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a server key.
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
            /// <param name='keyName'>
            /// The name of the server key to be operated on (updated or created). The key
            /// name is required to be in the format of 'vault_key_version'. For example,
            /// if the keyId is
            /// https://YourVaultName.vault.azure.net/keys/YourKeyName/01234567890123456789012345678901,
            /// then the server key name should be formatted as:
            /// YourVaultName_YourKeyName_01234567890123456789012345678901
            /// </param>
            /// <param name='parameters'>
            /// The requested server key resource state.
            /// </param>
            public static ServerKey CreateOrUpdate(this IServerKeysOperations operations, string resourceGroupName, string serverName, string keyName, ServerKey parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serverName, keyName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a server key.
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
            /// <param name='keyName'>
            /// The name of the server key to be operated on (updated or created). The key
            /// name is required to be in the format of 'vault_key_version'. For example,
            /// if the keyId is
            /// https://YourVaultName.vault.azure.net/keys/YourKeyName/01234567890123456789012345678901,
            /// then the server key name should be formatted as:
            /// YourVaultName_YourKeyName_01234567890123456789012345678901
            /// </param>
            /// <param name='parameters'>
            /// The requested server key resource state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerKey> CreateOrUpdateAsync(this IServerKeysOperations operations, string resourceGroupName, string serverName, string keyName, ServerKey parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, keyName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the server key with the given name.
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
            /// <param name='keyName'>
            /// The name of the server key to be deleted.
            /// </param>
            public static void Delete(this IServerKeysOperations operations, string resourceGroupName, string serverName, string keyName)
            {
                operations.DeleteAsync(resourceGroupName, serverName, keyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the server key with the given name.
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
            /// <param name='keyName'>
            /// The name of the server key to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IServerKeysOperations operations, string resourceGroupName, string serverName, string keyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, keyName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates a server key.
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
            /// <param name='keyName'>
            /// The name of the server key to be operated on (updated or created). The key
            /// name is required to be in the format of 'vault_key_version'. For example,
            /// if the keyId is
            /// https://YourVaultName.vault.azure.net/keys/YourKeyName/01234567890123456789012345678901,
            /// then the server key name should be formatted as:
            /// YourVaultName_YourKeyName_01234567890123456789012345678901
            /// </param>
            /// <param name='parameters'>
            /// The requested server key resource state.
            /// </param>
            public static ServerKey BeginCreateOrUpdate(this IServerKeysOperations operations, string resourceGroupName, string serverName, string keyName, ServerKey parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serverName, keyName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a server key.
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
            /// <param name='keyName'>
            /// The name of the server key to be operated on (updated or created). The key
            /// name is required to be in the format of 'vault_key_version'. For example,
            /// if the keyId is
            /// https://YourVaultName.vault.azure.net/keys/YourKeyName/01234567890123456789012345678901,
            /// then the server key name should be formatted as:
            /// YourVaultName_YourKeyName_01234567890123456789012345678901
            /// </param>
            /// <param name='parameters'>
            /// The requested server key resource state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerKey> BeginCreateOrUpdateAsync(this IServerKeysOperations operations, string resourceGroupName, string serverName, string keyName, ServerKey parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, keyName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the server key with the given name.
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
            /// <param name='keyName'>
            /// The name of the server key to be deleted.
            /// </param>
            public static void BeginDelete(this IServerKeysOperations operations, string resourceGroupName, string serverName, string keyName)
            {
                operations.BeginDeleteAsync(resourceGroupName, serverName, keyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the server key with the given name.
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
            /// <param name='keyName'>
            /// The name of the server key to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IServerKeysOperations operations, string resourceGroupName, string serverName, string keyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, serverName, keyName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a list of server keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ServerKey> ListByServerNext(this IServerKeysOperations operations, string nextPageLink)
            {
                return operations.ListByServerNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of server keys.
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
            public static async Task<IPage<ServerKey>> ListByServerNextAsync(this IServerKeysOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
