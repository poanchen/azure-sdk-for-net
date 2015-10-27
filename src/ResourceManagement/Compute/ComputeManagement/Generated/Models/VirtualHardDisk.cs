// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Describes the uri of a disk.
    /// </summary>
    public partial class VirtualHardDisk
    {
        /// <summary>
        /// Initializes a new instance of the VirtualHardDisk class.
        /// </summary>
        public VirtualHardDisk() { }

        /// <summary>
        /// Initializes a new instance of the VirtualHardDisk class.
        /// </summary>
        public VirtualHardDisk(string uri = default(string))
        {
            Uri = uri;
        }

        /// <summary>
        /// Gets or sets the virtual hard disk's uri. It should be a valid Uri
        /// to a virtual hard disk.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

    }
}
