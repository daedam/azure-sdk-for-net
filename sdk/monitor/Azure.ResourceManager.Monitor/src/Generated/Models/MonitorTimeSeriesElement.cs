// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> A time series result type. The discriminator value is always TimeSeries in this case. </summary>
    public partial class MonitorTimeSeriesElement
    {
        /// <summary> Initializes a new instance of MonitorTimeSeriesElement. </summary>
        internal MonitorTimeSeriesElement()
        {
            Metadatavalues = new ChangeTrackingList<MonitorMetadataValue>();
            Data = new ChangeTrackingList<MonitorMetricValue>();
        }

        /// <summary> Initializes a new instance of MonitorTimeSeriesElement. </summary>
        /// <param name="metadatavalues"> the metadata values returned if $filter was specified in the call. </param>
        /// <param name="data"> An array of data points representing the metric values.  This is only returned if a result type of data is specified. </param>
        internal MonitorTimeSeriesElement(IReadOnlyList<MonitorMetadataValue> metadatavalues, IReadOnlyList<MonitorMetricValue> data)
        {
            Metadatavalues = metadatavalues;
            Data = data;
        }

        /// <summary> the metadata values returned if $filter was specified in the call. </summary>
        public IReadOnlyList<MonitorMetadataValue> Metadatavalues { get; }
        /// <summary> An array of data points representing the metric values.  This is only returned if a result type of data is specified. </summary>
        public IReadOnlyList<MonitorMetricValue> Data { get; }
    }
}
