using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.IEnumerableExtensions
{
    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> collection) where T : IComparable
        {
            dynamic sum = 0;
            foreach (var item in collection)
            {
                sum += item;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection) where T : IComparable
        {
            dynamic product = 1;
            foreach (var item in collection)
            {
                product *= item;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable
        {
            dynamic min = int.MaxValue;
            foreach (var item in collection)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            dynamic max = int.MinValue;
            foreach (var item in collection)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        public static double Average<T>(this IEnumerable<T> collection) where T : IComparable
        {
            dynamic sum = 0;
            double count = collection.Count();
            foreach (var item in collection)
            {
                sum += item;
                //counter++;
            }
            double average = sum / count;
            return average;
        }
    }
}
