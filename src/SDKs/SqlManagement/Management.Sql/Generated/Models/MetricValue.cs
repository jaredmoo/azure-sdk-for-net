// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents database metrics.
    /// </summary>
    public partial class MetricValue : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the MetricValue class.
        /// </summary>
        public MetricValue()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricValue class.
        /// </summary>
        /// <param name="name">Resource name</param>
        /// <param name="id">The resource ID.</param>
        /// <param name="count">The number of values for the metric.</param>
        /// <param name="average">The average value of the metric.</param>
        /// <param name="maximum">The max value of the metric.</param>
        /// <param name="minimum">The min value of the metric.</param>
        /// <param name="timestamp">The metric timestamp (ISO-8601
        /// format).</param>
        /// <param name="total">The total value of the metric.</param>
        public MetricValue(string name = default(string), string id = default(string), double? count = default(double?), double? average = default(double?), double? maximum = default(double?), double? minimum = default(double?), System.DateTime? timestamp = default(System.DateTime?), double? total = default(double?))
            : base(name, id)
        {
            Count = count;
            Average = average;
            Maximum = maximum;
            Minimum = minimum;
            Timestamp = timestamp;
            Total = total;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the number of values for the metric.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public double? Count { get; private set; }

        /// <summary>
        /// Gets the average value of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "average")]
        public double? Average { get; private set; }

        /// <summary>
        /// Gets the max value of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "maximum")]
        public double? Maximum { get; private set; }

        /// <summary>
        /// Gets the min value of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "minimum")]
        public double? Minimum { get; private set; }

        /// <summary>
        /// Gets the metric timestamp (ISO-8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTime? Timestamp { get; private set; }

        /// <summary>
        /// Gets the total value of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public double? Total { get; private set; }

    }
}
