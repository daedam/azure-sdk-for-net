// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.DataLakeAnalytics.Mocking;
using Azure.ResourceManager.DataLakeAnalytics.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataLakeAnalytics
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.DataLakeAnalytics. </summary>
    public static partial class DataLakeAnalyticsExtensions
    {
        private static MockableDataLakeAnalyticsArmClient GetMockableDataLakeAnalyticsArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableDataLakeAnalyticsArmClient(client0));
        }

        private static MockableDataLakeAnalyticsResourceGroupResource GetMockableDataLakeAnalyticsResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableDataLakeAnalyticsResourceGroupResource(client, resource.Id));
        }

        private static MockableDataLakeAnalyticsSubscriptionResource GetMockableDataLakeAnalyticsSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableDataLakeAnalyticsSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataLakeAnalyticsAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataLakeAnalyticsAccountResource.CreateResourceIdentifier" /> to create a <see cref="DataLakeAnalyticsAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeAnalyticsArmClient.GetDataLakeAnalyticsAccountResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataLakeAnalyticsAccountResource" /> object. </returns>
        public static DataLakeAnalyticsAccountResource GetDataLakeAnalyticsAccountResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableDataLakeAnalyticsArmClient(client).GetDataLakeAnalyticsAccountResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataLakeStoreAccountInformationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataLakeStoreAccountInformationResource.CreateResourceIdentifier" /> to create a <see cref="DataLakeStoreAccountInformationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeAnalyticsArmClient.GetDataLakeStoreAccountInformationResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataLakeStoreAccountInformationResource" /> object. </returns>
        public static DataLakeStoreAccountInformationResource GetDataLakeStoreAccountInformationResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableDataLakeAnalyticsArmClient(client).GetDataLakeStoreAccountInformationResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataLakeAnalyticsStorageAccountInformationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataLakeAnalyticsStorageAccountInformationResource.CreateResourceIdentifier" /> to create a <see cref="DataLakeAnalyticsStorageAccountInformationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeAnalyticsArmClient.GetDataLakeAnalyticsStorageAccountInformationResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataLakeAnalyticsStorageAccountInformationResource" /> object. </returns>
        public static DataLakeAnalyticsStorageAccountInformationResource GetDataLakeAnalyticsStorageAccountInformationResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableDataLakeAnalyticsArmClient(client).GetDataLakeAnalyticsStorageAccountInformationResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataLakeAnalyticsStorageContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataLakeAnalyticsStorageContainerResource.CreateResourceIdentifier" /> to create a <see cref="DataLakeAnalyticsStorageContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeAnalyticsArmClient.GetDataLakeAnalyticsStorageContainerResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataLakeAnalyticsStorageContainerResource" /> object. </returns>
        public static DataLakeAnalyticsStorageContainerResource GetDataLakeAnalyticsStorageContainerResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableDataLakeAnalyticsArmClient(client).GetDataLakeAnalyticsStorageContainerResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataLakeAnalyticsComputePolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataLakeAnalyticsComputePolicyResource.CreateResourceIdentifier" /> to create a <see cref="DataLakeAnalyticsComputePolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeAnalyticsArmClient.GetDataLakeAnalyticsComputePolicyResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataLakeAnalyticsComputePolicyResource" /> object. </returns>
        public static DataLakeAnalyticsComputePolicyResource GetDataLakeAnalyticsComputePolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableDataLakeAnalyticsArmClient(client).GetDataLakeAnalyticsComputePolicyResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataLakeAnalyticsFirewallRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataLakeAnalyticsFirewallRuleResource.CreateResourceIdentifier" /> to create a <see cref="DataLakeAnalyticsFirewallRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeAnalyticsArmClient.GetDataLakeAnalyticsFirewallRuleResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataLakeAnalyticsFirewallRuleResource" /> object. </returns>
        public static DataLakeAnalyticsFirewallRuleResource GetDataLakeAnalyticsFirewallRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableDataLakeAnalyticsArmClient(client).GetDataLakeAnalyticsFirewallRuleResource(id);
        }

        /// <summary>
        /// Gets a collection of DataLakeAnalyticsAccountResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeAnalyticsResourceGroupResource.GetDataLakeAnalyticsAccounts()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DataLakeAnalyticsAccountResources and their operations over a DataLakeAnalyticsAccountResource. </returns>
        public static DataLakeAnalyticsAccountCollection GetDataLakeAnalyticsAccounts(this ResourceGroupResource resourceGroupResource)
        {
            return GetMockableDataLakeAnalyticsResourceGroupResource(resourceGroupResource).GetDataLakeAnalyticsAccounts();
        }

        /// <summary>
        /// Gets details of the specified Data Lake Analytics account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeAnalyticsResourceGroupResource.GetDataLakeAnalyticsAccountAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the Data Lake Analytics account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DataLakeAnalyticsAccountResource>> GetDataLakeAnalyticsAccountAsync(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            return await GetMockableDataLakeAnalyticsResourceGroupResource(resourceGroupResource).GetDataLakeAnalyticsAccountAsync(accountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets details of the specified Data Lake Analytics account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeAnalyticsResourceGroupResource.GetDataLakeAnalyticsAccount(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the Data Lake Analytics account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<DataLakeAnalyticsAccountResource> GetDataLakeAnalyticsAccount(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            return GetMockableDataLakeAnalyticsResourceGroupResource(resourceGroupResource).GetDataLakeAnalyticsAccount(accountName, cancellationToken);
        }

        /// <summary>
        /// Gets the first page of Data Lake Analytics accounts, if any, within the current subscription. This includes a link to the next page, if any.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataLakeAnalytics/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeAnalyticsSubscriptionResource.GetAccounts(SubscriptionResourceGetAccountsOptions,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataLakeAnalyticsAccountBasic" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DataLakeAnalyticsAccountBasic> GetAccountsAsync(this SubscriptionResource subscriptionResource, SubscriptionResourceGetAccountsOptions options, CancellationToken cancellationToken = default)
        {
            return GetMockableDataLakeAnalyticsSubscriptionResource(subscriptionResource).GetAccountsAsync(options, cancellationToken);
        }

        /// <summary>
        /// Gets the first page of Data Lake Analytics accounts, if any, within the current subscription. This includes a link to the next page, if any.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataLakeAnalytics/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeAnalyticsSubscriptionResource.GetAccounts(SubscriptionResourceGetAccountsOptions,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataLakeAnalyticsAccountBasic" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DataLakeAnalyticsAccountBasic> GetAccounts(this SubscriptionResource subscriptionResource, SubscriptionResourceGetAccountsOptions options, CancellationToken cancellationToken = default)
        {
            return GetMockableDataLakeAnalyticsSubscriptionResource(subscriptionResource).GetAccounts(options, cancellationToken);
        }

        /// <summary>
        /// Checks whether the specified account name is available or taken.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataLakeAnalytics/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeAnalyticsSubscriptionResource.CheckDataLakeAnalyticsAccountNameAvailability(AzureLocation,DataLakeAnalyticsAccountNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="content"> Parameters supplied to check the Data Lake Analytics account name availability. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<DataLakeAnalyticsAccountNameAvailabilityResult>> CheckDataLakeAnalyticsAccountNameAvailabilityAsync(this SubscriptionResource subscriptionResource, AzureLocation location, DataLakeAnalyticsAccountNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return await GetMockableDataLakeAnalyticsSubscriptionResource(subscriptionResource).CheckDataLakeAnalyticsAccountNameAvailabilityAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks whether the specified account name is available or taken.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataLakeAnalytics/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeAnalyticsSubscriptionResource.CheckDataLakeAnalyticsAccountNameAvailability(AzureLocation,DataLakeAnalyticsAccountNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="content"> Parameters supplied to check the Data Lake Analytics account name availability. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<DataLakeAnalyticsAccountNameAvailabilityResult> CheckDataLakeAnalyticsAccountNameAvailability(this SubscriptionResource subscriptionResource, AzureLocation location, DataLakeAnalyticsAccountNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return GetMockableDataLakeAnalyticsSubscriptionResource(subscriptionResource).CheckDataLakeAnalyticsAccountNameAvailability(location, content, cancellationToken);
        }

        /// <summary>
        /// Gets subscription-level properties and limits for Data Lake Analytics specified by resource location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataLakeAnalytics/locations/{location}/capability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_GetCapability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeAnalyticsSubscriptionResource.GetCapabilityLocation(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static async Task<Response<DataLakeAnalyticsCapabilityInformation>> GetCapabilityLocationAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return await GetMockableDataLakeAnalyticsSubscriptionResource(subscriptionResource).GetCapabilityLocationAsync(location, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets subscription-level properties and limits for Data Lake Analytics specified by resource location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataLakeAnalytics/locations/{location}/capability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_GetCapability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataLakeAnalyticsSubscriptionResource.GetCapabilityLocation(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Response<DataLakeAnalyticsCapabilityInformation> GetCapabilityLocation(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetMockableDataLakeAnalyticsSubscriptionResource(subscriptionResource).GetCapabilityLocation(location, cancellationToken);
        }
    }
}
