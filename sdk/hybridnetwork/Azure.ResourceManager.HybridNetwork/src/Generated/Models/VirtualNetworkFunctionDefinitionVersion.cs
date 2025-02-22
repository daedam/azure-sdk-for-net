// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Virtual network function network function definition version properties. </summary>
    public partial class VirtualNetworkFunctionDefinitionVersion : NetworkFunctionDefinitionVersionPropertiesFormat
    {
        /// <summary> Initializes a new instance of VirtualNetworkFunctionDefinitionVersion. </summary>
        public VirtualNetworkFunctionDefinitionVersion()
        {
            NetworkFunctionType = NetworkFunctionType.VirtualNetworkFunction;
        }

        /// <summary> Initializes a new instance of VirtualNetworkFunctionDefinitionVersion. </summary>
        /// <param name="provisioningState"> The provisioning state of the network function definition version resource. </param>
        /// <param name="versionState"> The network function definition version state. </param>
        /// <param name="description"> The network function definition version description. </param>
        /// <param name="deployParameters"> The deployment parameters of the network function definition version. </param>
        /// <param name="networkFunctionType"> The network function type. </param>
        /// <param name="networkFunctionTemplate">
        /// Virtual network function template.
        /// Please note <see cref="VirtualNetworkFunctionTemplate"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureCoreNetworkFunctionTemplate"/> and <see cref="AzureOperatorNexusNetworkFunctionTemplate"/>.
        /// </param>
        internal VirtualNetworkFunctionDefinitionVersion(ProvisioningState? provisioningState, VersionState? versionState, string description, string deployParameters, NetworkFunctionType networkFunctionType, VirtualNetworkFunctionTemplate networkFunctionTemplate) : base(provisioningState, versionState, description, deployParameters, networkFunctionType)
        {
            NetworkFunctionTemplate = networkFunctionTemplate;
            NetworkFunctionType = networkFunctionType;
        }

        /// <summary>
        /// Virtual network function template.
        /// Please note <see cref="VirtualNetworkFunctionTemplate"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureCoreNetworkFunctionTemplate"/> and <see cref="AzureOperatorNexusNetworkFunctionTemplate"/>.
        /// </summary>
        public VirtualNetworkFunctionTemplate NetworkFunctionTemplate { get; set; }
    }
}
