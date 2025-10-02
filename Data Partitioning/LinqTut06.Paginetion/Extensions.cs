using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTut06.Paginetion
{
    public static class Extensions
    {
        public static IEnumerable<T> Paginate<T>(this IEnumerable<T> source,
            int Page = 1, int Size = 10) where T : class
        {
            if (Page <= 0)
                Page = 1;
            if (Size <= 0)
                Size = 10;

            var result = source.Skip((Page - 1) * Size).Take(Size).ToList();

            return result;
        }
    }
}
