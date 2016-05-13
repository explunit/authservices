using System;
using Kentor.AuthServices.WebSso;

namespace Kentor.AuthServices.Metadata
{
    /// <summary>
    /// Metadata for an assertion consumer service.
    /// </summary>
    public class AssertionConsumerService
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="uri">Full uri to the service.</param>
        public AssertionConsumerService(Uri uri)
        {
            Uri = uri;
            Binding = Saml2Binding.HttpPostUri;
        }

        /// <summary>
        /// The name of the attribute consuming service.
        /// </summary>
        public Uri Uri { get; set; }

        /// <summary>
        /// Is this the default AttributeConsumingService of the SP?
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Which binding for this endpoint?
        /// </summary>
        public Uri Binding { get; set; }
    }
}
