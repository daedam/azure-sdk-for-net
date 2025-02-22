// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.DataFactory.Models;

namespace Azure.ResourceManager.DataFactory
{
    /// <summary>
    /// A Class representing a DataFactoryPipeline along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DataFactoryPipelineResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDataFactoryPipelineResource method.
    /// Otherwise you can get one from its parent resource <see cref="DataFactoryResource" /> using the GetDataFactoryPipeline method.
    /// </summary>
    public partial class DataFactoryPipelineResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DataFactoryPipelineResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="factoryName"> The factoryName. </param>
        /// <param name="pipelineName"> The pipelineName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string factoryName, string pipelineName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/pipelines/{pipelineName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dataFactoryPipelinePipelinesClientDiagnostics;
        private readonly PipelinesRestOperations _dataFactoryPipelinePipelinesRestClient;
        private readonly DataFactoryPipelineData _data;

        /// <summary> Initializes a new instance of the <see cref="DataFactoryPipelineResource"/> class for mocking. </summary>
        protected DataFactoryPipelineResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DataFactoryPipelineResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DataFactoryPipelineResource(ArmClient client, DataFactoryPipelineData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DataFactoryPipelineResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataFactoryPipelineResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataFactoryPipelinePipelinesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataFactory", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string dataFactoryPipelinePipelinesApiVersion);
            _dataFactoryPipelinePipelinesRestClient = new PipelinesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataFactoryPipelinePipelinesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DataFactory/factories/pipelines";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DataFactoryPipelineData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a pipeline.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/pipelines/{pipelineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pipelines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifNoneMatch"> ETag of the pipeline entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataFactoryPipelineResource>> GetAsync(string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _dataFactoryPipelinePipelinesClientDiagnostics.CreateScope("DataFactoryPipelineResource.Get");
            scope.Start();
            try
            {
                var response = await _dataFactoryPipelinePipelinesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataFactoryPipelineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a pipeline.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/pipelines/{pipelineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pipelines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifNoneMatch"> ETag of the pipeline entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataFactoryPipelineResource> Get(string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _dataFactoryPipelinePipelinesClientDiagnostics.CreateScope("DataFactoryPipelineResource.Get");
            scope.Start();
            try
            {
                var response = _dataFactoryPipelinePipelinesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifNoneMatch, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataFactoryPipelineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a pipeline.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/pipelines/{pipelineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pipelines_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _dataFactoryPipelinePipelinesClientDiagnostics.CreateScope("DataFactoryPipelineResource.Delete");
            scope.Start();
            try
            {
                var response = await _dataFactoryPipelinePipelinesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DataFactoryArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a pipeline.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/pipelines/{pipelineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pipelines_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _dataFactoryPipelinePipelinesClientDiagnostics.CreateScope("DataFactoryPipelineResource.Delete");
            scope.Start();
            try
            {
                var response = _dataFactoryPipelinePipelinesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DataFactoryArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a pipeline.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/pipelines/{pipelineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pipelines_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Pipeline resource definition. </param>
        /// <param name="ifMatch"> ETag of the pipeline entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataFactoryPipelineResource>> UpdateAsync(WaitUntil waitUntil, DataFactoryPipelineData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataFactoryPipelinePipelinesClientDiagnostics.CreateScope("DataFactoryPipelineResource.Update");
            scope.Start();
            try
            {
                var response = await _dataFactoryPipelinePipelinesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DataFactoryArmOperation<DataFactoryPipelineResource>(Response.FromValue(new DataFactoryPipelineResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a pipeline.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/pipelines/{pipelineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pipelines_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Pipeline resource definition. </param>
        /// <param name="ifMatch"> ETag of the pipeline entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataFactoryPipelineResource> Update(WaitUntil waitUntil, DataFactoryPipelineData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataFactoryPipelinePipelinesClientDiagnostics.CreateScope("DataFactoryPipelineResource.Update");
            scope.Start();
            try
            {
                var response = _dataFactoryPipelinePipelinesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, ifMatch, cancellationToken);
                var operation = new DataFactoryArmOperation<DataFactoryPipelineResource>(Response.FromValue(new DataFactoryPipelineResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a run of a pipeline.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/pipelines/{pipelineName}/createRun</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pipelines_CreateRun</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="parameterValueSpecification"> Parameters of the pipeline run. These parameters will be used only if the runId is not specified. </param>
        /// <param name="referencePipelineRunId"> The pipeline run identifier. If run ID is specified the parameters of the specified run will be used to create a new run. </param>
        /// <param name="isRecovery"> Recovery mode flag. If recovery mode is set to true, the specified referenced pipeline run and the new run will be grouped under the same groupId. </param>
        /// <param name="startActivityName"> In recovery mode, the rerun will start from this activity. If not specified, all activities will run. </param>
        /// <param name="startFromFailure"> In recovery mode, if set to true, the rerun will start from failed activities. The property will be used only if startActivityName is not specified. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PipelineCreateRunResult>> CreateRunAsync(IDictionary<string, BinaryData> parameterValueSpecification = null, string referencePipelineRunId = null, bool? isRecovery = null, string startActivityName = null, bool? startFromFailure = null, CancellationToken cancellationToken = default)
        {
            using var scope = _dataFactoryPipelinePipelinesClientDiagnostics.CreateScope("DataFactoryPipelineResource.CreateRun");
            scope.Start();
            try
            {
                var response = await _dataFactoryPipelinePipelinesRestClient.CreateRunAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, parameterValueSpecification, referencePipelineRunId, isRecovery, startActivityName, startFromFailure, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a run of a pipeline.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/pipelines/{pipelineName}/createRun</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pipelines_CreateRun</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="parameterValueSpecification"> Parameters of the pipeline run. These parameters will be used only if the runId is not specified. </param>
        /// <param name="referencePipelineRunId"> The pipeline run identifier. If run ID is specified the parameters of the specified run will be used to create a new run. </param>
        /// <param name="isRecovery"> Recovery mode flag. If recovery mode is set to true, the specified referenced pipeline run and the new run will be grouped under the same groupId. </param>
        /// <param name="startActivityName"> In recovery mode, the rerun will start from this activity. If not specified, all activities will run. </param>
        /// <param name="startFromFailure"> In recovery mode, if set to true, the rerun will start from failed activities. The property will be used only if startActivityName is not specified. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PipelineCreateRunResult> CreateRun(IDictionary<string, BinaryData> parameterValueSpecification = null, string referencePipelineRunId = null, bool? isRecovery = null, string startActivityName = null, bool? startFromFailure = null, CancellationToken cancellationToken = default)
        {
            using var scope = _dataFactoryPipelinePipelinesClientDiagnostics.CreateScope("DataFactoryPipelineResource.CreateRun");
            scope.Start();
            try
            {
                var response = _dataFactoryPipelinePipelinesRestClient.CreateRun(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, parameterValueSpecification, referencePipelineRunId, isRecovery, startActivityName, startFromFailure, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
