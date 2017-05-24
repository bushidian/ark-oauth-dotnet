using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using System;

namespace Ark.OAuth.Services
{
    
    /// <summary>
    /// IMemoryCache-based implementation of the cache
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="IdentityServer4.Services.ICache{T}" />
    public class DefaultCache<T> : ICache<T>
        where T : class
    {
        const string KeySeparator = ":";

        readonly IMemoryCache _cache;

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultCache{T}"/> class.
        /// </summary>
        /// <param name="cache">The cache.</param>
        public DefaultCache(IMemoryCache cache)
        {
            _cache = cache;
        }

        string GetKey(string key)
        {
            return typeof(T).FullName + KeySeparator + key;
        }

        /// <summary>
        /// Gets the cached data based upon a key index.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>
        /// The cached item, or <c>null</c> if no item matches the key.
        /// </returns>
        public Task<T> GetAsync(string key)
        {
            key = GetKey(key);
            var item = _cache.Get<T>(key);
            return Task.FromResult(item);
        }

        /// <summary>
        /// Caches the data based upon a key
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="item">The item.</param>
        /// <param name="expiration">The expiration (minutes).</param>
        /// <returns></returns>
        public Task SetAsync(string key, T item, double expiration)
        {
            key = GetKey(key);
            var expirationTimeSpan  = DateTime.Now.AddMinutes(expiration) - DateTime.Now;
            _cache.Set(key, item, expirationTimeSpan);
            return Task.FromResult(0);
        }
    }
}