using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace
{
    public static class IEnumerableExtensions
    {
        public static bool Any(this IEnumerable enumerable)
            => enumerable.GetEnumerator().MoveNext() == true;
    }
}
