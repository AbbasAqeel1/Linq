using System;
using System.Collections;
using System.Globalization;
using FunctionalProgramming;



namespace linq.Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            var evenNumsUsingExtensionWhere = Numbers.Where(x => x % 2 == 0);
            var evenNumsUsingEnumerableWhereMethod = Enumerable.Where(Numbers, x => x % 2 == 0);

            var evenNumsUsingQuerySyntax = from x in Numbers
                                           where x % 2 == 0
                                           select x;

            evenNumsUsingExtensionWhere.Print("evenNumsUsing ExtensionWhere");
            evenNumsUsingEnumerableWhereMethod.Print("evenNumsUsing where method");
            evenNumsUsingQuerySyntax.Print("evenNumsUsing query syntax");

            Console.WriteLine("Using foreach statement.");
            foreach (int num in evenNumsUsingExtensionWhere)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}