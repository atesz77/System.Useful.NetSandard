using System.Linq;
using System.Collections.Generic;

namespace System {
	public static class BoolExtensions
    {
        //public static bool And<T>(this T element, params T[] compareElements)
        //{
        //    return compareElements.All(x => x.Equals(element));
        //}

        public static bool Or<T>(this T element, params T[] compareElements)
        {
            return compareElements.Any(x => x.Equals(element));
        }

        public static bool Or<T>(this T element, IEqualityComparer<T> comparer, params T[] compareElements)
        {
            return compareElements.Any(x => comparer.Equals(element, x));
        }

        public static bool Not(this bool val)
        {
            return !val;
        }
    } 	
}