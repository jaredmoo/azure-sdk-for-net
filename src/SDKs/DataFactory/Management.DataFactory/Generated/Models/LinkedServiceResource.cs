// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactory;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Linked service resource type.
    /// </summary>
    public partial class LinkedServiceResource : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the LinkedServiceResource class.
        /// </summary>
        public LinkedServiceResource()
        {
            Properties = new LinkedService();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LinkedServiceResource class.
        /// </summary>
        /// <param name="properties">Properties of linked service.</param>
        /// <param name="id">The resource identifier.</param>
        /// <param name="name">The resource name.</param>
        /// <param name="type">The resource type.</param>
        /// <param name="etag">Etag identifies change in the resource.</param>
        public LinkedServiceResource(LinkedService properties, string id = default(string), string name = default(string), string type = default(string), string etag = default(string))
            : base(id, name, type, etag)
        {
            Properties = new LinkedService();
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets properties of linked service.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public LinkedService Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
            if (Properties != null)
            {
                Properties.Validate();
            }
        }
    }
}