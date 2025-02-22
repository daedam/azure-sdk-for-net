// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Kusto.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Kusto
{
    /// <summary>
    /// A class representing the KustoPrivateEndpointConnection data model.
    /// A private endpoint connection
    /// </summary>
    public partial class KustoPrivateEndpointConnectionData : ResourceData
    {
        /// <summary> Initializes a new instance of KustoPrivateEndpointConnectionData. </summary>
        public KustoPrivateEndpointConnectionData()
        {
        }

        /// <summary> Initializes a new instance of KustoPrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateEndpoint"> Private endpoint which the connection belongs to. </param>
        /// <param name="connectionState"> Connection State of the Private Endpoint Connection. </param>
        /// <param name="groupId"> Group id of the private endpoint. </param>
        /// <param name="provisioningState"> Provisioning state of the private endpoint. </param>
        internal KustoPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SubResource privateEndpoint, KustoPrivateLinkServiceConnectionStateProperty connectionState, string groupId, string provisioningState) : base(id, name, resourceType, systemData)
        {
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
            GroupId = groupId;
            ProvisioningState = provisioningState;
        }

        /// <summary> Private endpoint which the connection belongs to. </summary>
        internal SubResource PrivateEndpoint { get; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint?.Id;
        }

        /// <summary> Connection State of the Private Endpoint Connection. </summary>
        public KustoPrivateLinkServiceConnectionStateProperty ConnectionState { get; set; }
        /// <summary> Group id of the private endpoint. </summary>
        public string GroupId { get; }
        /// <summary> Provisioning state of the private endpoint. </summary>
        public string ProvisioningState { get; }
    }
}
