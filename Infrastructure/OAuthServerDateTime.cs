using System;

namespace Ark.OAuth.Infrastructure
{
    public class OAuthServerDateTime
    {
        public static DateTime UtcNow => UtcNowFunc();
        public static Func<DateTime> UtcNowFunc = () => DateTime.UtcNow;

    }
}