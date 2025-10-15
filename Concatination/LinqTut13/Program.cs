using System;
using Shared;

namespace LinqTut13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //RunMethod01();
            //RunMethod02();
            //RunMethod03();
            RunMethod04();
            Console.ReadKey();
        }

        private static void RunMethod01()
        {
            var q1 = QuestionBank.Randomize(3);
            var q2 = QuestionBank.Randomize(5);


            var QuestionTitle = q1.Concat(q2);
            Console.WriteLine("\n\n\n------------------------------------------------------------");
            Console.WriteLine("Run Method 01 simple Concaenation");
            Console.WriteLine("------------------------------------------------------------\n");
            foreach(var title in  QuestionTitle)
            {
                Console.WriteLine(title);
            }


            var q3 = QuestionBank.Randomize(2);
            var q4 = QuestionBank.Randomize(2);

            var questions = q3.Concat(q4);
            Console.WriteLine("\n\n\n------------------------------------------------------------");
            Console.WriteLine("Run Method 01 simple Concaenation (2 + 2)");
            Console.WriteLine("------------------------------------------------------------\n");
            foreach (var question in questions)
            {
                Console.WriteLine(question);
            }

        }

        private static void RunMethod02()
        {
            var q1 = QuestionBank.Randomize(3);
            var q2 = QuestionBank.Randomize(5);


            var QuestionTitle = q1.Select(q => q.Title).Concat(q2.Select(q => q.Title));
            Console.WriteLine("\n\n\n------------------------------------------------------------");
            Console.WriteLine("Run Method 02 Concatenate specific properties");
            Console.WriteLine("------------------------------------------------------------\n");
            foreach (var title in QuestionTitle)
            {
                Console.WriteLine(title);
            }
        }

        private static void RunMethod03()
        {
            var q1 = QuestionBank.Randomize(2);
            var q2 = QuestionBank.Randomize(2);
            var q3 = QuestionBank.Randomize(2);
            var q4 = QuestionBank.Randomize(2);
            var QuestionTitle = q1.Select(q => q.Title).
                Concat(q2.Select(q => q.Title)).
                Concat(q3.Select(q => q.Title)).Concat(q4.Select(q => q.Title));
            Console.WriteLine("\n\n\n------------------------------------------------------------");
            Console.WriteLine("Run Method 03 more than two concatinations");
            Console.WriteLine("------------------------------------------------------------\n");
            foreach (var title in QuestionTitle)
            {
                Console.WriteLine(title);
            }
        }

        private static void RunMethod04()
        {
            var q1 = QuestionBank.Randomize(2);
            var q2 = QuestionBank.Randomize(2);
            var q3 = QuestionBank.Randomize(2);

            Console.WriteLine("\n\n\n------------------------------------------------------------");
            Console.WriteLine("Run Method 04 Concatination using instantiation");
            Console.WriteLine("------------------------------------------------------------\n");

            var questions1 = new[] { q1, q2, q3 }.SelectMany(q => q);
            questions1.ToQuiz();
            
        }
    }
}
