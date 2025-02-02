// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Nfv version of the list of RouteTables to advertise the routes to.
    /// </summary>
    public partial class PropagatedRouteTableNfv
    {
        /// <summary>
        /// Initializes a new instance of the PropagatedRouteTableNfv class.
        /// </summary>
        public PropagatedRouteTableNfv()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PropagatedRouteTableNfv class.
        /// </summary>
        /// <param name="labels">The list of labels.</param>
        /// <param name="ids">The list of resource ids of all the
        /// RouteTables.</param>
        public PropagatedRouteTableNfv(IList<string> labels = default(IList<string>), IList<RoutingConfigurationNfvSubResource> ids = default(IList<RoutingConfigurationNfvSubResource>))
        {
            Labels = labels;
            Ids = ids;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of labels.
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public IList<string> Labels { get; set; }

        /// <summary>
        /// Gets or sets the list of resource ids of all the RouteTables.
        /// </summary>
        [JsonProperty(PropertyName = "ids")]
        public IList<RoutingConfigurationNfvSubResource> Ids { get; set; }

    }
}
