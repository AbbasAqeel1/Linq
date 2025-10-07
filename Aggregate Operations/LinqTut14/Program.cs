using System;
using System.Linq;
using System.Xml.XPath;
using Shared;


namespace LinqTut10
{
    internal class Program
    {
    
        public static void Main(string[] args)
        {

            RunMethod01();
            RunMethod02();
            RunMethod03();
            RunCount();
            RunMaxQuestionTitleLength();
            RunMaxByQuestionTitleLength();
            RunMinQuestionTitleLength();
            RunMinByQuestionTitleLength();
            RunSum();
            RunAverage();
            Console.ReadKey();
        }

        private static void RunMethod01()
        {
            var names = new[] { "Ali", "Abbas", "Ammar", "Ahmed", "Muhammed" };


            var result = names.Aggregate((a, b) =>
            {
                return $"{a},{b}";
            });

            Console.WriteLine(result);
        }

        private static void RunMethod02()
        {
            var names = new[] { 1, 2, 3, 4, 5 };

            var result = names.Aggregate(100,(a, b) => a + b);

            Console.WriteLine($"{result}");
        }


        private static void RunMethod03()
        {
            var quiz = QuestionBank.All;

            var longestQuestionTitle = quiz[0];

            Console.WriteLine($"{longestQuestionTitle}\n\n");

            var result = quiz.Aggregate(longestQuestionTitle,
                                          (longest, next) => longest.Title.Length < next.Title.Length ? next : longest,
                                          (x => x));

            Console.WriteLine($"{result}");
        }


        private static void RunCount()
        {
            var questions = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));

            Console.WriteLine(questions.Count());
            Console.WriteLine(questions.Count(x => x.Title.Length > 150));
            Console.WriteLine(questions.Where(x => x.Title.Length > 150).Count());
        }
        private static void RunMaxQuestionTitleLength()
        {
            var questions = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));

            Console.WriteLine($"Max Question Title Length is: {questions.Max(x => x.Title.Length)}");
        }

        private static void RunMaxByQuestionTitleLength()
        {
            var questions = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));

            Console.WriteLine($"{questions.MaxBy(x => x.Title.Length)}");
        }

        private static void RunMinQuestionTitleLength()
        {
            var questions = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));

            Console.WriteLine($"{questions.Min(x => x.Title.Length)}");
        }



        private static void RunMinByQuestionTitleLength()
        {
            var questions = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));

            Console.WriteLine($"{questions.MinBy(x => x.Title.Length)}");
        }

        private static void RunSum()
        {
            var questions = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));

            Console.WriteLine($"{questions.Sum(x => x.Choices.Count)}");
        }

        private static void RunAverage()
        {
            var questions = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));

            Console.WriteLine($"{questions.Average(x => x.Choices.Count)}");
        }
    }

}