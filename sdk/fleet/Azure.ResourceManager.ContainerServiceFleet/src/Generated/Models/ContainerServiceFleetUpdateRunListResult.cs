// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ContainerServiceFleet;

namespace Azure.ResourceManager.ContainerServiceFleet.Models
{
    /// <summary> The response of a UpdateRun list operation. </summary>
    internal partial class ContainerServiceFleetUpdateRunListResult
    {
        /// <summary> Initializes a new instance of ContainerServiceFleetUpdateRunListResult. </summary>
        /// <param name="value"> The UpdateRun items on this page. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ContainerServiceFleetUpdateRunListResult(IEnumerable<ContainerServiceFleetUpdateRunData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ContainerServiceFleetUpdateRunListResult. </summary>
        /// <param name="value"> The UpdateRun items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        internal ContainerServiceFleetUpdateRunListResult(IReadOnlyList<ContainerServiceFleetUpdateRunData> value, Uri nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The UpdateRun items on this page. </summary>
        public IReadOnlyList<ContainerServiceFleetUpdateRunData> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public Uri NextLink { get; }
    }
}
