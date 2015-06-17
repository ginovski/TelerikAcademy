namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> collection)
            where T : struct // Make T to accept only structs(int,double..)
        {
            dynamic result = 0;
            foreach (T item in collection)
            {
                result += item;
            }

            return result;
        }

        public static T Product<T>(this IEnumerable<T> collection)
            where T : struct
        {
            dynamic result = 1;
            foreach (T item in collection)
            {
                result *= item;
            }

            return result;
        }

        public static T Min<T>(this IEnumerable<T> collection)
            where T : IComparable<T> // Make T to accept only Comparable items
        {
            dynamic min = collection.ElementAt(0);
            foreach (T item in collection)
            {
                if (item.CompareTo(min) == -1)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
            where T : IComparable<T>
        {
            dynamic max = collection.ElementAt(0);
            foreach (T item in collection)
            {
                if (item.CompareTo(max) == 1)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> collection)
            where T : struct
        {
            dynamic sum = collection.Sum();

            return sum / collection.Count();
        }
    }
}
