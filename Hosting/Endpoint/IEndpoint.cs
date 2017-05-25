using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Ark.OAuth.Hosting
{

    /// <summary>
    /// Endpoint handler
    /// </summary>
    public interface IEndpoint
    {
        /// <summary>
        /// Processes the request.
        /// </summary>
        /// <param name="context">The HTTP context.</param>
        /// <returns></returns>
        Task<IEndpointResult> ProcessAsync(HttpContext context);
    }
}