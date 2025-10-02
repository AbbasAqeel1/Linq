using System;
using LINQTut05.Shared;



namespace LinqTut05.OrderBy
{


    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] fruits = { "apple", "apricot", "orange", "banana",
                "mango", "grape", "strawberry" };


            var orderedFruits = fruits.OrderBy(x => x);
            orderedFruits.Print("Fruits order by name ASC using method syntax");



            var orderedFruitsByQuerySyntax = from f in fruits
                                             orderby f
                                             select f;

            orderedFruitsByQuerySyntax.Print("Fruits order by name ASC using query syntax");


            var orderedFruitsDesc = fruits.OrderByDescending(x => x);
            orderedFruitsDesc.Print("Fruits order by name Desc using method syntax");



            var orderedFruitsByQuerySyntaxDesc = from f in fruits
                                             orderby f descending
                                             select f;

            orderedFruitsByQuerySyntaxDesc.Print("Fruits order by name Desc using query syntax");






            var orderedFruitsByLength = fruits.OrderBy(x => x.Length);
            orderedFruitsByLength.Print("Fruits order by Length using method syntax");



            var orderedFruitsByQuerySyntaxByLength = from f in fruits
                                                 orderby f.Length
                                                 select f;
            orderedFruitsByQuerySyntaxByLength.Print("Fruits order by Length using query syntax");




            var numbers = new List<int> { 1, 2, 9, 6, 3, 5, 8, 3, 7, 4, 18, 11, 32, 22, 19, 14, 13 };

            var SortedNumbers = numbers.OrderBy(x => x);

            SortedNumbers.Print("Sorted Numbers Asc");


           
            var SortedNumbersDesc = numbers.OrderByDescending(x => x);

            SortedNumbersDesc.Print("Sorted Numbers Desc");





            Console.ReadKey();

        }
    
    
    }

}