// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Nginx.Models
{
    /// <summary> The NginxNetworkInterfaceConfiguration. </summary>
    internal partial class NginxNetworkInterfaceConfiguration
    {
        /// <summary> Initializes a new instance of NginxNetworkInterfaceConfiguration. </summary>
        public NginxNetworkInterfaceConfiguration()
        {
        }

        /// <summary> Initializes a new instance of NginxNetworkInterfaceConfiguration. </summary>
        /// <param name="subnetId"></param>
        internal NginxNetworkInterfaceConfiguration(string subnetId)
        {
            SubnetId = subnetId;
        }

        /// <summary> Gets or sets the subnet id. </summary>
        public string SubnetId { get; set; }
    }
}
