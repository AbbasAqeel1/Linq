using System;
using Shared;
using System.Linq;


namespace LinqTut18
{
    internal class Program
    {


        public static void Main(string[] args)
        {

            //RunAsEnumerableMethod();
            //RunAsQueryableMethod();
            //RunCastMethod();
            //
            //RunOfTypeMethod();
            //RunToArryMethod();
            //RunToListMethod();
            //RunDictionaryMethod();
            RunToLookupMethod();
            Console.ReadKey();

        }

        private static void RunToLookupMethod()
        {
            //Imediate execution
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;


            ILookup<string, Shipping> Lookup1 = shippings.ToLookup(x => x.UniqueId);
            Lookup1["ABC005"].Process("Shippins equal to ABC005 ID");



            //example 02
            ILookup<DateTime,Shipping> Lookup2 = shippings.ToLookup(x => x.ShippingDate);
            var date1 = new DateTime(2025, 10, 10, 0, 0, 0);
            Lookup2[date1].Process($"sihppings on date {date1.ToString("dddd, MMMM dd yyyy")}");
        }

        private static void RunDictionaryMethod()
        {
            //deferred execution
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;


            Dictionary<string,Shipping> dictionary1 = shippings.ToDictionary(x => x.UniqueId);
            Shipping shipping1 = dictionary1["ABC005"];
            shipping1.Start();



            //example 02
            Dictionary<DateTime, List<Shipping>> dictionary2 = shippings.GroupBy(x => x.ShippingDate)
                .ToDictionary(s => s.Key, s => s.ToList());
            var date1 = new DateTime(2025, 10, 10, 0, 0, 0);
            dictionary2[date1].Process($"sihppings on date {date1.ToString("dddd, MMMM dd yyyy")}");
        }

        private static void RunToArryMethod()
        {
            var shippings = ShippingRepository.AllAsList;

            var ArrayShippings = shippings.ToArray();

            Console.WriteLine($"Array Size ({ArrayShippings.Length})");
            Console.WriteLine("First Shipping.");
            ArrayShippings[0].Start();
        }

        private static void RunToListMethod()
        {
            var shippings = ShippingRepository.AllAsList;

            List<Shipping> ArrayShippings = shippings.ToList();

            Console.WriteLine($"Array Size ({ArrayShippings.Count})");
            Console.WriteLine("First Shipping.");
            ArrayShippings[0].Start();
        }

        private static void RunOfTypeMethod()
        {
            var shippings = ShippingRepository.AllAsList;

            var groundshippings = shippings.OfType<GroundShipping>();

            groundshippings.Process("Ground shippings using ofType method");
        }

        private static void RunCastMethod()
        {
            var shippings = ShippingRepository.AllAsList;
            var groundshippings2 = shippings.Where(x => x.GetType() == typeof(GroundShipping)).Cast<GroundShipping>();

            groundshippings2.Process("Ground shippings using casting");
        }

        private static void RunAsQueryableMethod()
        {
            ShippingList<Shipping> shippings = ShippingRepository.AllAsShippingList;

            var todayShippings = shippings.Where(x => x.ShippingDate == DateTime.Today);
            
            todayShippings.Process("Today Shippings");

            IQueryable<Shipping> todayShippings2 = shippings.AsQueryable().Where(x => x.ShippingDate == DateTime.Today);

            todayShippings2.Process("Today shippings using IQueryable.");
            Console.WriteLine(todayShippings2.Expression);
        }

        private static void RunAsEnumerableMethod()
        {
            ShippingList<Shipping> shippings = ShippingRepository.AllAsShippingList;

            var todayShippings = shippings.Where(x => x.ShippingDate == DateTime.Today);

            todayShippings.Process("Today Shippings");

            IEnumerable<Shipping> todayShippings2 = shippings.AsEnumerable().Where(x => x.ShippingDate == DateTime.Today);

            todayShippings2.Process("Today shippings using IEnumerable.");
        }
    }
}