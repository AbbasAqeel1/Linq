using System;
using System.Collections.Generic;
using Shared;


namespace LinqTut10.Empty
{

    internal class Program
    {
        public static void Main(string[] args)
        {



            //var questions = new List<Question>();

            //foreach (var question in questions)
            //{
            //    Console.WriteLine(question);
            //}
            

            var questions2 = Enumerable.Empty<Question>();

            foreach (var question in questions2)
            {
                Console.WriteLine(question);
            }




            Console.ReadKey();
        }
    }
}