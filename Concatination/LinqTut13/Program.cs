using System;
using Shared;

namespace LinqTut13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            RunMethod01();
            RunMethod02();
            RunMethod03();
            RunMethod04();
            Console.ReadKey();
        }

        private static void RunMethod01()
        {
            var q1 = QuestionBank.Randomize(3);
            var q2 = QuestionBank.Randomize(5);


            var QuestionTitle = q1.Concat(q2);

            foreach(var title in  QuestionTitle)
            {
                Console.WriteLine(title);
            }
        }

        private static void RunMethod02()
        {
            var q1 = QuestionBank.Randomize(3);
            var q2 = QuestionBank.Randomize(5);


            var QuestionTitle = q1.Select(q => q.Title).Concat(q2.Select(q => q.Title));

            foreach (var title in QuestionTitle)
            {
                Console.WriteLine(title);
            }
        }

        private static void RunMethod03()
        {
            var q1 = QuestionBank.Randomize(3);
            var q2 = QuestionBank.Randomize(5);
            var q3 = QuestionBank.Randomize(5);

            var QuestionTitle = q1.Select(q => q.Title).
                Concat(q2.Select(q => q.Title)).
                Concat(q3.Select(q => q.Title));

            foreach (var title in QuestionTitle)
            {
                Console.WriteLine(title);
            }
        }

        private static void RunMethod04()
        {
            var q1 = QuestionBank.Randomize(3);
            var q2 = QuestionBank.Randomize(5);
            var q3 = QuestionBank.Randomize(5);
            
            var questions1 = new[] { q1, q2, q3 }.SelectMany(q => q);
            questions1.ToQuiz();
            
        }
    }
}