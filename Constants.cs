using System;

namespace Ark.OAuth
{
    internal static class Constants
    {

        public const string IdentityServerName               = "ArkOAuthServer";
        public const string IdentityServerAuthenticationType = IdentityServerName;
        public const string ExternalAuthenticationMethod     = "external";
        public const string AccessTokenAudience              = "{0}resources";
        public const string DefaultHashAlgorithm             = "SHA256";

        public static readonly TimeSpan DefaultCookieTimeSpan = TimeSpan.FromHours(10);
        public static readonly TimeSpan DefaultCacheDuration  = TimeSpan.FromMinutes(5);

        public static class SigningAlgorithms
        {
            public const string RSA_SHA_256 = "RS256";
        }

        #region UI Constants

        public static class UIConstants
        {
            // the limit after which old messages are purged
            public const int CookieMessageThreshold = 2;

            public static class DefaultRoutePathParams
            {
                public const string Error = "errorId";
                public const string Login = "returnUrl";
                public const string Consent = "returnUrl";
                public const string Logout = "logoutId";
                public const string Custom = "returnUrl";
            }

            public static class DefaultRoutePaths
            {
                public const string Login = "/account/login";
                public const string Logout = "/account/logout";
                public const string Consent = "/consent";
                public const string Error = "/home/error";
            }
        }

        #endregion

        #region ProtocolRoutePaths

        public static class ProtocolRoutePaths
        {
            public const string Authorize              = "connect/authorize";
            public const string AuthorizeAfterConsent  = Authorize + "/consent";
            public const string AuthorizeAfterLogin    = Authorize + "/login";
            public const string DiscoveryConfiguration = ".well-known/openid-configuration";
            public const string DiscoveryWebKeys       = DiscoveryConfiguration + "/jwks";
            public const string Token                  = "connect/token";
            public const string Revocation             = "connect/revocation";
            public const string UserInfo               = "connect/userinfo";
            public const string Introspection          = "connect/introspect";
            public const string EndSession             = "connect/endsession";
            public const string EndSessionCallback     = EndSession + "/callback";
            public const string CheckSession           = "connect/checksession";
            
            public static readonly string[] CorsPaths =
            {
                DiscoveryConfiguration,
                DiscoveryWebKeys,
                Token,
                UserInfo,
                Revocation
            };
        }

        #endregion

    }
}