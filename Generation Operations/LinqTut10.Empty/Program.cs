using System;
using System.Collections.Generic;
using System.Net.Quic;
using Shared;


namespace LinqTut10.Empty
{

    internal class Program
    {
        public static void Main(string[] args)
        {



            var question1 = Enumerable.Empty<Question>();
            question1.ToQuiz();

            var question2 = question1.DefaultIfEmpty();
            question2.ToQuiz();

            var question3 = question1.DefaultIfEmpty(Question.Default);
            question3.ToQuiz();







            Console.ReadKey();
        }
    }
}