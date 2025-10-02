using System;
using LINQTut05.Shared;


namespace LinqTut05.Reverse
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            string[] fruits = { "apple", "apricot", "orange", "banana",
                "mango", "grape", "strawberry" };
            
            var reversedFruits = fruits.Reverse();

            fruits.Print("Original Fruits Order");
            reversedFruits.Print("Reversed Fruits");

            Console.ReadKey();
        }
    }
}