namespace _02.IEnumerableExtension
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> collection) 
        {
            T sum = (dynamic)0;
            foreach (var item in collection)
            {
                var num = Convert.ToDecimal(item);
                sum += (dynamic)num;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            T sum = (dynamic)1;
            foreach (var item in collection)
            {
                var num = Convert.ToDecimal(item);
                sum *= (dynamic)num;
            }
            return sum;
        }

        public static T Minimal<T>(this IEnumerable<T> collection) where T : IComparable<T>
        {            
            return collection.Min();
        }

        public static T Maximal<T>(this IEnumerable<T> collcetion) where T : IComparable<T>
        {
            return collcetion.Max();
        }
        
        public static T Average<T>(this IEnumerable<T> collection)
        {
            var sum = collection.Sum();
            var count = collection.Count();
            var average = sum / (dynamic)count;
            return average;
        }

    }
}
