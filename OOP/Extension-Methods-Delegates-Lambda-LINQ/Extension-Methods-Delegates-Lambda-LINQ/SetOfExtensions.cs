namespace Extension_Methods_Delegates_Lambda_LINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class SetOfExtensions
    {
        public static T sum<T>(this IEnumerable<T> enumeration)
        {
            T result = (dynamic)0;
            foreach (var item in enumeration)
            {
                result += (dynamic)item;
            }

            return result;
        }

        public static T product<T>(this IEnumerable<T> enumeration)
        {
            T result = (dynamic)1;
            foreach (var item in enumeration)
            {
                result *= (dynamic)item;
            }

            return result;
        }

        public static T min<T>(this IEnumerable<T> enumeration)
        {
            var result = enumeration.FirstOrDefault();
            foreach (var item in enumeration)
            {
                if (result > (dynamic)item)
                {
                    result = item;
                }
            }

            return result;
        }

        public static T max<T>(this IEnumerable<T> enumeration)
        {
            var result = enumeration.FirstOrDefault();
            foreach (var item in enumeration)
            {
                if (result < (dynamic)item)
                {
                    result = item;
                }
            }

            return result;
        }

        public static T average<T>(this IEnumerable<T> enumeration)
        {
            var result = sum(enumeration);
            int divisor = enumeration.Count();
            result /= (dynamic)divisor;

            return result;
        }
    }
}