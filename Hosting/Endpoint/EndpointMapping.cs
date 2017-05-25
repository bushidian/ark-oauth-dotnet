using System;

namespace Ark.OAuth.Hosting
{
    /// <summary>
    /// Mapping of endpoint to handler
    /// </summary>
    public class EndpointMapping
    {
        /// <summary>
        /// Gets or sets the endpoint.
        /// </summary>
        /// <value>
        /// The endpoint.
        /// </value>
        public EndpointName Endpoint { get; set; }

        /// <summary>
        /// Gets or sets the handler.
        /// </summary>
        /// <value>
        /// The handler.
        /// </value>
        public Type Handler { get; set; }
    }
}