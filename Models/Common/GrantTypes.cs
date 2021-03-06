using System.Collections.Generic;

namespace Ark.OAuth.Models
{
    public class GrantTypes
    {
        public static IEnumerable<string> Implicit =>
            new[] { GrantType.Implicit };

        public static IEnumerable<string> ImplicitAndClientCredentials =>
            new[]  { GrantType.Implicit, GrantType.ClientCredentials };

        public static IEnumerable<string> Code =>
            new[] { GrantType.AuthorizationCode };

        public static IEnumerable<string> CodeAndClientCredentials =>
            new[] { GrantType.AuthorizationCode, GrantType.ClientCredentials };

        public static IEnumerable<string> Hybrid =>
            new[] { GrantType.Hybrid };

        public static IEnumerable<string> HybridAndClientCredentials =>
            new[] { GrantType.Hybrid, GrantType.ClientCredentials };

        public static IEnumerable<string> ClientCredentials =>
            new[] { GrantType.ClientCredentials };

        public static IEnumerable<string> ResourceOwnerPassword =>
            new[] { GrantType.ResourceOwnerPassword };

        public static IEnumerable<string> ResourceOwnerPasswordAndClientCredentials =>
            new[] { GrantType.ResourceOwnerPassword, GrantType.ClientCredentials };

        public static IEnumerable<string> List(params string[] values) => values;
    }
}