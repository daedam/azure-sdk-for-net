// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> List of IP Extended Communities. </summary>
    internal partial class IPExtendedCommunityListResult
    {
        /// <summary> Initializes a new instance of IPExtendedCommunityListResult. </summary>
        internal IPExtendedCommunityListResult()
        {
            Value = new ChangeTrackingList<NetworkFabricIPExtendedCommunityData>();
        }

        /// <summary> Initializes a new instance of IPExtendedCommunityListResult. </summary>
        /// <param name="value"> List of IP Extended Communities resources. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        internal IPExtendedCommunityListResult(IReadOnlyList<NetworkFabricIPExtendedCommunityData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of IP Extended Communities resources. </summary>
        public IReadOnlyList<NetworkFabricIPExtendedCommunityData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}
