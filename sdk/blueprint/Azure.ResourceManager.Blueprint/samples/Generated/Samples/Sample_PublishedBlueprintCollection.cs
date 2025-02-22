// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Blueprint;

namespace Azure.ResourceManager.Blueprint.Samples
{
    public partial class Sample_PublishedBlueprintCollection
    {
        // PublishedManagementGroupBlueprint_Publish
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PublishedManagementGroupBlueprintPublish()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPDef/SealedBlueprint_Publish.json
            // this example is just showing the usage of "PublishedBlueprints_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BlueprintResource created on azure
            // for more information of creating BlueprintResource, please refer to the document of BlueprintResource
            string resourceScope = "providers/Microsoft.Management/managementGroups/ContosoOnlineGroup";
            string blueprintName = "simpleBlueprint";
            ResourceIdentifier blueprintResourceId = BlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName);
            BlueprintResource blueprint = client.GetBlueprintResource(blueprintResourceId);

            // get the collection of this PublishedBlueprintResource
            PublishedBlueprintCollection collection = blueprint.GetPublishedBlueprints();

            // invoke the operation
            string versionId = "v2";
            PublishedBlueprintData data = new PublishedBlueprintData();
            ArmOperation<PublishedBlueprintResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, versionId, data);
            PublishedBlueprintResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PublishedBlueprintData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PublishedSubscriptionBlueprint_Publish
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PublishedSubscriptionBlueprintPublish()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPDef/SealedBlueprint_Publish.json
            // this example is just showing the usage of "PublishedBlueprints_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BlueprintResource created on azure
            // for more information of creating BlueprintResource, please refer to the document of BlueprintResource
            string resourceScope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string blueprintName = "simpleBlueprint";
            ResourceIdentifier blueprintResourceId = BlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName);
            BlueprintResource blueprint = client.GetBlueprintResource(blueprintResourceId);

            // get the collection of this PublishedBlueprintResource
            PublishedBlueprintCollection collection = blueprint.GetPublishedBlueprints();

            // invoke the operation
            string versionId = "v2";
            PublishedBlueprintData data = new PublishedBlueprintData();
            ArmOperation<PublishedBlueprintResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, versionId, data);
            PublishedBlueprintResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PublishedBlueprintData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PublishedManagementGroupBlueprint
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PublishedManagementGroupBlueprint()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPDef/SealedBlueprint_Get.json
            // this example is just showing the usage of "PublishedBlueprints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BlueprintResource created on azure
            // for more information of creating BlueprintResource, please refer to the document of BlueprintResource
            string resourceScope = "providers/Microsoft.Management/managementGroups/ContosoOnlineGroup";
            string blueprintName = "simpleBlueprint";
            ResourceIdentifier blueprintResourceId = BlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName);
            BlueprintResource blueprint = client.GetBlueprintResource(blueprintResourceId);

            // get the collection of this PublishedBlueprintResource
            PublishedBlueprintCollection collection = blueprint.GetPublishedBlueprints();

            // invoke the operation
            string versionId = "v2";
            PublishedBlueprintResource result = await collection.GetAsync(versionId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PublishedBlueprintData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PublishedManagementGroupBlueprint
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_PublishedManagementGroupBlueprint()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPDef/SealedBlueprint_Get.json
            // this example is just showing the usage of "PublishedBlueprints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BlueprintResource created on azure
            // for more information of creating BlueprintResource, please refer to the document of BlueprintResource
            string resourceScope = "providers/Microsoft.Management/managementGroups/ContosoOnlineGroup";
            string blueprintName = "simpleBlueprint";
            ResourceIdentifier blueprintResourceId = BlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName);
            BlueprintResource blueprint = client.GetBlueprintResource(blueprintResourceId);

            // get the collection of this PublishedBlueprintResource
            PublishedBlueprintCollection collection = blueprint.GetPublishedBlueprints();

            // invoke the operation
            string versionId = "v2";
            bool result = await collection.ExistsAsync(versionId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // PublishedManagementGroupBlueprint
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_PublishedManagementGroupBlueprint()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPDef/SealedBlueprint_Get.json
            // this example is just showing the usage of "PublishedBlueprints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BlueprintResource created on azure
            // for more information of creating BlueprintResource, please refer to the document of BlueprintResource
            string resourceScope = "providers/Microsoft.Management/managementGroups/ContosoOnlineGroup";
            string blueprintName = "simpleBlueprint";
            ResourceIdentifier blueprintResourceId = BlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName);
            BlueprintResource blueprint = client.GetBlueprintResource(blueprintResourceId);

            // get the collection of this PublishedBlueprintResource
            PublishedBlueprintCollection collection = blueprint.GetPublishedBlueprints();

            // invoke the operation
            string versionId = "v2";
            NullableResponse<PublishedBlueprintResource> response = await collection.GetIfExistsAsync(versionId);
            PublishedBlueprintResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PublishedBlueprintData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // PublishedSubscriptionBlueprint
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PublishedSubscriptionBlueprint()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPDef/SealedBlueprint_Get.json
            // this example is just showing the usage of "PublishedBlueprints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BlueprintResource created on azure
            // for more information of creating BlueprintResource, please refer to the document of BlueprintResource
            string resourceScope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string blueprintName = "simpleBlueprint";
            ResourceIdentifier blueprintResourceId = BlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName);
            BlueprintResource blueprint = client.GetBlueprintResource(blueprintResourceId);

            // get the collection of this PublishedBlueprintResource
            PublishedBlueprintCollection collection = blueprint.GetPublishedBlueprints();

            // invoke the operation
            string versionId = "v2";
            PublishedBlueprintResource result = await collection.GetAsync(versionId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PublishedBlueprintData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PublishedSubscriptionBlueprint
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_PublishedSubscriptionBlueprint()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPDef/SealedBlueprint_Get.json
            // this example is just showing the usage of "PublishedBlueprints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BlueprintResource created on azure
            // for more information of creating BlueprintResource, please refer to the document of BlueprintResource
            string resourceScope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string blueprintName = "simpleBlueprint";
            ResourceIdentifier blueprintResourceId = BlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName);
            BlueprintResource blueprint = client.GetBlueprintResource(blueprintResourceId);

            // get the collection of this PublishedBlueprintResource
            PublishedBlueprintCollection collection = blueprint.GetPublishedBlueprints();

            // invoke the operation
            string versionId = "v2";
            bool result = await collection.ExistsAsync(versionId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // PublishedSubscriptionBlueprint
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_PublishedSubscriptionBlueprint()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPDef/SealedBlueprint_Get.json
            // this example is just showing the usage of "PublishedBlueprints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BlueprintResource created on azure
            // for more information of creating BlueprintResource, please refer to the document of BlueprintResource
            string resourceScope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string blueprintName = "simpleBlueprint";
            ResourceIdentifier blueprintResourceId = BlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName);
            BlueprintResource blueprint = client.GetBlueprintResource(blueprintResourceId);

            // get the collection of this PublishedBlueprintResource
            PublishedBlueprintCollection collection = blueprint.GetPublishedBlueprints();

            // invoke the operation
            string versionId = "v2";
            NullableResponse<PublishedBlueprintResource> response = await collection.GetIfExistsAsync(versionId);
            PublishedBlueprintResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PublishedBlueprintData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
