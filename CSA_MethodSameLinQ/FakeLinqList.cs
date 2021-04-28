using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSA_MethodSameLinQ
{
    public static class FakeLinqList
    {
        public static IEnumerable<T> FakeWhere<T>(this IEnumerable<T> list, Func<T, bool> searchElement)
        {
            foreach (var item in list)
            {
                if (searchElement(item))
                {
                    yield return item;
                }
            }
        }
        public static T FakeFind<T>(this IEnumerable<T> list, Func<T, bool> searchElement)
        {
            foreach (var item in list)
            {
                if (searchElement(item))
                {
                    return item;
                }
            }
            return default(T);
        }
    }
}
