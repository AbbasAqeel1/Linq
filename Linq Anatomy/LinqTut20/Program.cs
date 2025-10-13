using System;

namespace LinqTut20
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //DemoFluentApi();
            //DemoIEnumerabeAndIQueryable();
            //DemoExecutionOrder();
            //DemoImmediateExecution();
            //DemoDeferredExecution();
            //DemoDeferredStreamingExecution();
            //DemoDeferredNonStreamingExecution();
            //DemoTake();
            //DemoFilterOrder();
            RunQuery();
            Console.ReadKey();
        }

        private static void RunQuery()
        {
            var deck = new Deck();

            var cards = deck.GetSample();

            var query = cards
                .Where(x => x.IsRed)
                .Skip(1)
                .OrderBy(x => x.Value)
                .Take(2).ToList();

            query.PrintDeck("");
        }

        private static void DemoFilterOrder()
        {
            var deck = new Deck();

            var cards = deck.Shuffle();

            var query1 = cards
                .Where(x => x.IsRed)
                .OrderBy(x => x.Value)
                .Take(10);

            var query2 = cards.OrderBy(x => x.Value)
                .Take(10) 
                .Where(x => x.IsRed);
                

            query1.PrintDeck("Top 10 cards in Red Cards");
            query2.PrintDeck("Red Cards in Top 10 Cards");

        }

        private static void DemoTake()
        {
            var deck = new Deck();

            var cards = deck.GetSample();

            var query = cards.Where(x => x.IsRed).Skip(3).Take(3);
        }

        private static void DemoDeferredStreamingExecution()
        {
            var Numbers = new int[] { 8, 1, 2, 3, 4, 5, 6, 12, 9 };

            var query = Numbers.Where(x => x > 5).Select(x => x * x).Where(x => x % 6 == 0).Take(2);

            foreach (var number in query)
            {
                Console.WriteLine(number);
            }
        }

        private static void DemoDeferredNonStreamingExecution()
        {
            var Numbers = new int[] { 8, 1, 2, 3, 4, 5, 6, 12, 9 };

            var query = Numbers.
                Where(x => x > 5).
                OrderBy(x => x). 
                Where(x => x % 6 == 0).
                Take(2);

            foreach (var number in query)
            {
                Console.WriteLine(number);
            }
        }

        private static void DemoImmediateExecution()
        {
            var Numbers = new int[] { 8, 1, 2, 3, 4, 5, 6, 12, 9 };


            var list = Numbers.Where(x => x> 5).
                Take(2).ToList();

            foreach (var number in list)
            {   
                Console.WriteLine(number);
            }
        }

        private static void DemoDeferredExecution()
        {
            var Numbers = new int[] { 8, 1, 2, 3, 4, 5, 6, 12, 9 };


            var query = Numbers.Where(x => x > 5).Select(x => x * x).
                Take(2);

            foreach (var number in query)
            {
                Console.WriteLine(number);
            }
        }

        private static void DemoFluentApi()
        {
            var deck = new Deck();
            var cards = deck.Shuffle();

            var query = cards.OrderBy(x => x.Value).
                Skip(10).Take(10).
                OrderBy(x => x.suite).ToList();

            foreach (var card in query)
            {
                Console.WriteLine(card.Name);
            }


        }
        private static void DemoIEnumerabeAndIQueryable()
        {
            var deck = new Deck();

            var IEnumerableQuery = deck.Shuffle().Where(x => x.Value > 5).Skip(5).OrderBy(x => x.suite).
                ThenByDescending(x => x.Value).Take(5).AsEnumerable(); 

            var IQueryableQuery = deck.Shuffle().Where(x => x.Value > 5).Skip(5).OrderBy(x => x.suite).
                ThenByDescending(x => x.Value).Take(5).AsQueryable();
        }
        private static void DemoExecutionOrder()
        {
            var Numbers = new int[] { 8, 1, 2, 3, 4, 5, 6, 12, 9 };

            var query = Numbers.Where(x => x > 5).
                Select(x => x * x).
                Where(x => x % 6 == 0).Take(2);

            foreach(var number in query)
            {
                Console.WriteLine(number);
            }

        }

    }
}