// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> ClusterPatchParameters represents the body of the request to patch the cluster properties. </summary>
    public partial class NetworkCloudClusterPatch
    {
        /// <summary> Initializes a new instance of NetworkCloudClusterPatch. </summary>
        public NetworkCloudClusterPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            ComputeRackDefinitions = new ChangeTrackingList<NetworkCloudRackDefinition>();
        }

        /// <summary> The Azure resource tags that will replace the existing ones. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The rack definition that is intended to reflect only a single rack in a single rack cluster, or an aggregator rack in a multi-rack cluster. </summary>
        public NetworkCloudRackDefinition AggregatorOrSingleRackDefinition { get; set; }
        /// <summary> The customer-provided location information to identify where the cluster resides. </summary>
        public string ClusterLocation { get; set; }
        /// <summary> The service principal to be used by the cluster during Arc Appliance installation. </summary>
        public ServicePrincipalInformation ClusterServicePrincipal { get; set; }
        /// <summary> The validation threshold indicating the allowable failures of compute machines during environment validation and deployment. </summary>
        public ValidationThreshold ComputeDeploymentThreshold { get; set; }
        /// <summary>
        /// The list of rack definitions for the compute racks in a multi-rack
        /// cluster, or an empty list in a single-rack cluster.
        /// </summary>
        public IList<NetworkCloudRackDefinition> ComputeRackDefinitions { get; }
    }
}
