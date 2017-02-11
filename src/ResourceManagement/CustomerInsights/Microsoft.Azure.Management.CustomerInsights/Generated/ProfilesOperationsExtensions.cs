// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ProfilesOperations.
    /// </summary>
    public static partial class ProfilesOperationsExtensions
    {
            /// <summary>
            /// Creates a profile within a Hub, or updates an existing profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='profileName'>
            /// The name of the profile.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/delete Profile type operation
            /// </param>
            public static ProfileResourceFormat CreateOrUpdate(this IProfilesOperations operations, string resourceGroupName, string hubName, string profileName, ProfileResourceFormat parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, hubName, profileName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a profile within a Hub, or updates an existing profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='profileName'>
            /// The name of the profile.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/delete Profile type operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProfileResourceFormat> CreateOrUpdateAsync(this IProfilesOperations operations, string resourceGroupName, string hubName, string profileName, ProfileResourceFormat parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, hubName, profileName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about the specified profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='profileName'>
            /// The name of the profile.
            /// </param>
            /// <param name='localeCode'>
            /// Locale of profile to retrieve, default is en-us.
            /// </param>
            public static ProfileResourceFormat Get(this IProfilesOperations operations, string resourceGroupName, string hubName, string profileName, string localeCode = "en-us")
            {
                return operations.GetAsync(resourceGroupName, hubName, profileName, localeCode).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about the specified profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='profileName'>
            /// The name of the profile.
            /// </param>
            /// <param name='localeCode'>
            /// Locale of profile to retrieve, default is en-us.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProfileResourceFormat> GetAsync(this IProfilesOperations operations, string resourceGroupName, string hubName, string profileName, string localeCode = "en-us", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, hubName, profileName, localeCode, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a profile within a hub
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='profileName'>
            /// The name of the profile.
            /// </param>
            /// <param name='localeCode'>
            /// Locale of profile to retrieve, default is en-us.
            /// </param>
            public static void Delete(this IProfilesOperations operations, string resourceGroupName, string hubName, string profileName, string localeCode = "en-us")
            {
                operations.DeleteAsync(resourceGroupName, hubName, profileName, localeCode).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a profile within a hub
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='profileName'>
            /// The name of the profile.
            /// </param>
            /// <param name='localeCode'>
            /// Locale of profile to retrieve, default is en-us.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IProfilesOperations operations, string resourceGroupName, string hubName, string profileName, string localeCode = "en-us", CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, hubName, profileName, localeCode, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets all profile in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='localeCode'>
            /// Locale of profile to retrieve, default is en-us.
            /// </param>
            public static IPage<ProfileResourceFormat> ListByHub(this IProfilesOperations operations, string resourceGroupName, string hubName, string localeCode = "en-us")
            {
                return operations.ListByHubAsync(resourceGroupName, hubName, localeCode).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all profile in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='localeCode'>
            /// Locale of profile to retrieve, default is en-us.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ProfileResourceFormat>> ListByHubAsync(this IProfilesOperations operations, string resourceGroupName, string hubName, string localeCode = "en-us", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByHubWithHttpMessagesAsync(resourceGroupName, hubName, localeCode, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a profile within a Hub, or updates an existing profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='profileName'>
            /// The name of the profile.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/delete Profile type operation
            /// </param>
            public static ProfileResourceFormat BeginCreateOrUpdate(this IProfilesOperations operations, string resourceGroupName, string hubName, string profileName, ProfileResourceFormat parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, hubName, profileName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a profile within a Hub, or updates an existing profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='profileName'>
            /// The name of the profile.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/delete Profile type operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProfileResourceFormat> BeginCreateOrUpdateAsync(this IProfilesOperations operations, string resourceGroupName, string hubName, string profileName, ProfileResourceFormat parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, hubName, profileName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a profile within a hub
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='profileName'>
            /// The name of the profile.
            /// </param>
            /// <param name='localeCode'>
            /// Locale of profile to retrieve, default is en-us.
            /// </param>
            public static void BeginDelete(this IProfilesOperations operations, string resourceGroupName, string hubName, string profileName, string localeCode = "en-us")
            {
                operations.BeginDeleteAsync(resourceGroupName, hubName, profileName, localeCode).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a profile within a hub
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='profileName'>
            /// The name of the profile.
            /// </param>
            /// <param name='localeCode'>
            /// Locale of profile to retrieve, default is en-us.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IProfilesOperations operations, string resourceGroupName, string hubName, string profileName, string localeCode = "en-us", CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, hubName, profileName, localeCode, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets all profile in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ProfileResourceFormat> ListByHubNext(this IProfilesOperations operations, string nextPageLink)
            {
                return operations.ListByHubNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all profile in the hub.
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
            public static async Task<IPage<ProfileResourceFormat>> ListByHubNextAsync(this IProfilesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByHubNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

