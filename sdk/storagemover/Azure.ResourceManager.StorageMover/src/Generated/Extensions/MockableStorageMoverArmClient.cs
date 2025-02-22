// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.StorageMover;

namespace Azure.ResourceManager.StorageMover.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableStorageMoverArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableStorageMoverArmClient"/> class for mocking. </summary>
        protected MockableStorageMoverArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableStorageMoverArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableStorageMoverArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableStorageMoverArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="StorageMoverResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageMoverResource.CreateResourceIdentifier" /> to create a <see cref="StorageMoverResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageMoverResource" /> object. </returns>
        public virtual StorageMoverResource GetStorageMoverResource(ResourceIdentifier id)
        {
            StorageMoverResource.ValidateResourceId(id);
            return new StorageMoverResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StorageMoverAgentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageMoverAgentResource.CreateResourceIdentifier" /> to create a <see cref="StorageMoverAgentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageMoverAgentResource" /> object. </returns>
        public virtual StorageMoverAgentResource GetStorageMoverAgentResource(ResourceIdentifier id)
        {
            StorageMoverAgentResource.ValidateResourceId(id);
            return new StorageMoverAgentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StorageMoverEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageMoverEndpointResource.CreateResourceIdentifier" /> to create a <see cref="StorageMoverEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageMoverEndpointResource" /> object. </returns>
        public virtual StorageMoverEndpointResource GetStorageMoverEndpointResource(ResourceIdentifier id)
        {
            StorageMoverEndpointResource.ValidateResourceId(id);
            return new StorageMoverEndpointResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StorageMoverProjectResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageMoverProjectResource.CreateResourceIdentifier" /> to create a <see cref="StorageMoverProjectResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageMoverProjectResource" /> object. </returns>
        public virtual StorageMoverProjectResource GetStorageMoverProjectResource(ResourceIdentifier id)
        {
            StorageMoverProjectResource.ValidateResourceId(id);
            return new StorageMoverProjectResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="JobDefinitionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="JobDefinitionResource.CreateResourceIdentifier" /> to create a <see cref="JobDefinitionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="JobDefinitionResource" /> object. </returns>
        public virtual JobDefinitionResource GetJobDefinitionResource(ResourceIdentifier id)
        {
            JobDefinitionResource.ValidateResourceId(id);
            return new JobDefinitionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="JobRunResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="JobRunResource.CreateResourceIdentifier" /> to create a <see cref="JobRunResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="JobRunResource" /> object. </returns>
        public virtual JobRunResource GetJobRunResource(ResourceIdentifier id)
        {
            JobRunResource.ValidateResourceId(id);
            return new JobRunResource(Client, id);
        }
    }
}
