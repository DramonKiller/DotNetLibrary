using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dramonkiller.Utilities.EnumerableExtensions
{
    /// <summary>
    /// Class that contains the enumerable extensions.
    /// </summary>
    public static class EnumerableExtensionsImpl
    {
        /// <summary>
        /// Perform an action on each item in the enumerable
        /// </summary>
        public static void ForEach<T>(this IEnumerable<T> items, Action<T> action)
        {
            if (items == null)
            {
                return;
            }

            foreach (var item in items)
            {
                action(item);
            }
        }
    }
}
