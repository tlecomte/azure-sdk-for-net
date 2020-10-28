// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Confluent.Models
{
    using System.Linq;

    /// <summary>
    /// Confluent offer detail
    /// </summary>
    public partial class OrganizationResourcePropertiesOfferDetail : OfferDetail
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OrganizationResourcePropertiesOfferDetail class.
        /// </summary>
        public OrganizationResourcePropertiesOfferDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OrganizationResourcePropertiesOfferDetail class.
        /// </summary>
        /// <param name="publisherId">Publisher Id</param>
        /// <param name="id">Offer Id</param>
        /// <param name="planId">Offer Plan Id</param>
        /// <param name="planName">Offer Plan Name</param>
        /// <param name="termUnit">Offer Plan Term unit</param>
        /// <param name="status">SaaS Offer Status. Possible values include:
        /// 'Started', 'PendingFulfillmentStart', 'InProgress', 'Subscribed',
        /// 'Suspended', 'Reinstated', 'Succeeded', 'Failed', 'Unsubscribed',
        /// 'Updating'</param>
        public OrganizationResourcePropertiesOfferDetail(string publisherId = default(string), string id = default(string), string planId = default(string), string planName = default(string), string termUnit = default(string), string status = default(string))
            : base(publisherId, id, planId, planName, termUnit, status)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}