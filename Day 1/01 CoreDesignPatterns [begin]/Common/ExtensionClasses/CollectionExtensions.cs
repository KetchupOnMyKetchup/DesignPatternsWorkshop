using System;
using System.Collections.Generic;

namespace Common.ExtensionClasses
{
    public static class CollectionExtensions
    {
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> value, Action<T> action)
        {
            foreach (var item in value)
            {
                action(item);
            }

            return value;
        }

      
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> value, Action<T, int> action)
        {
            var index = 0;
            foreach (var item in value)
            {
                action(item, index);
                index += 1;
            }

            return value;
        }

        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> value, int seed, Action<T, int> action)
        {
            var index = seed;
            foreach (var item in value)
            {
                action(item, index);
                index += 1;
            }

            return value;
        }


    }
}
