using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Ark.OAuth.Extensions
{
   public static class IEnumerableExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> list)
        {
            if (list == null)
            {
                return true;
            }

            if (!list.Any())
            {
                return true;
            }

            return false;
        }
    }
}