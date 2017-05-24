using System;

namespace Ark.OAuth.Configuration
{

    /// <summary>
    /// Caching options.
    /// </summary>
    public class CachingOptions
    {
        
        static readonly TimeSpan Default = TimeSpan.FromMinutes(15);

        /// <summary>
        /// Gets or sets the client store expiration.
        /// </summary>
        /// <value>
        /// The client store expiration.
        /// </value>
        public TimeSpan ClientStoreExpiration { get; set; } = Default;

        /// <summary>
        /// Gets or sets the scope store expiration.
        /// </summary>
        /// <value>
        /// The scope store expiration.
        /// </value>
        public TimeSpan ResourceStoreExpiration { get; set; } = Default;
    }
}