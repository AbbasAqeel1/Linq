using System;
using System.Collections.Generic;
using System.Linq;



namespace Shared
{
    public static class Extensions
    { 
        private static Random _random = new Random();

        public static void Print<T>(this IEnumerable<T> source, string title)
        {
            if (source == null)
                return;
            Console.WriteLine();
            Console.WriteLine("┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"│   {title.PadRight(52, ' ')}│");
            Console.WriteLine("└───────────────────────────────────────────────────────┘");
            Console.WriteLine();
            foreach (var item in source)
            {
                if (typeof(T).IsValueType)
                    Console.Write($" {item} "); // 1, 2, 3
                else
                    Console.WriteLine(item);
            } 
        }

        public static IEnumerable<Tsource> Paginate<Tsource>(this IEnumerable<Tsource> source,
            int Page = 1, int PageSize = 10)
        {

            if (source == null)
                throw new ArgumentException($"{nameof(source)}");
      
            if (Page <= 0)
                //Page = 1;
                throw new ArgumentException($"{nameof(Page)}");

            if (PageSize <= 0)
                //PageSize = 10;
                throw new ArgumentException($"{nameof(PageSize)}");

            if (!source.Any())
                return Enumerable.Empty<Tsource>();

            return source.Skip((Page -1 ) * PageSize).Take(PageSize);
        }

        public static IEnumerable<Tsource> Paginate2<Tsource>(this IEnumerable<Tsource> source,
            int? Page, int? PageSize)
        {

            if (source == null)
            {

                throw new ArgumentException($"{nameof(source)}");
            }

            if (!Page.HasValue)
                Page = 1;

            if (!PageSize.HasValue)
                PageSize = 10;

            if (!source.Any())
            {
                return Enumerable.Empty<Tsource>();
            }

            return source.Skip((Page.Value - 1) * PageSize.Value).Take(PageSize.Value);
        }

        public static IEnumerable<Tsource> WhereWithPaginate<Tsource>(this IEnumerable<Tsource> source,
            Func<Tsource, bool> predicate
            ,int Page, int PageSize)
        {

            if (source == null)
            {
                throw new ArgumentException($"{nameof(source)}");
            }

            if (predicate == null)
            {
                throw new ArgumentException($"{nameof(predicate)}");
            }


            var result = Enumerable.Where(source, predicate);
           

            return Paginate2(result,Page, PageSize);
        }

        public static Tsource Random<Tsource>(this IEnumerable<Tsource> source,
            Func<Tsource, bool> predicate)
        {   

            if (source == null)
            {
                throw new ArgumentException($"{nameof(source)}");
            }

            if (predicate == null)
            {
                throw new ArgumentException($"{nameof(predicate)}");
            }

            if (!source.Any())
                return default;

            var result = Enumerable.Where(source, predicate);

            return result.ElementAt(_random.Next(1, source.Count()));

             
            

            


        }
    }
}
