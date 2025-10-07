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

            //RunMethod01();
            //RunMethod02();
            //RunMethod03();
            //RunCount();
            //RunMaxQuestionTitleLength();
            //RunMaxByQuestionTitleLength();
            //RunMinQuestionTitleLength();
            //RunMinByQuestionTitleLength();
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

            Console.WriteLine($"The result of concatination: result");
        }

        private static void RunMethod02()
        {
            var nums = new[] { 1, 2, 3, 4, 5 };

            var result = nums.Aggregate(100,(a, b) => a + b);
            var Multiplication = nums.Aggregate(1, (a, b) => a * b);
            
            Console.WriteLine($"The result of Sum: {result}");
            Console.WriteLine($"The result of Multiply: {Multiplication}");
        }


        private static void RunMethod03()
        {
            var quiz = QuestionBank.All;

            var longestQuestionTitle = quiz[0];

            
            var result = quiz.Aggregate(longestQuestionTitle,
                                          (longest, next) => longest.Title.Length < next.Title.Length ? next : longest,
                                          (x => x));
            
            Console.WriteLine($"Longest Question Title: {result}");


            var ShortestQuestionTitle = quiz[0];


            var result2 = quiz.Aggregate(ShortestQuestionTitle,
                              (shortest, next) => shortest.Title.Length > next.Title.Length ? next : shortest,
                              (x => x));

            Console.WriteLine($"Shortest Question Title: {result2}");
        }


        private static void RunCount()
        {
            var questions = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));

            Console.WriteLine($"Number of questions: {questions.Count()}");
            Console.WriteLine($"Number of questions that length of the title is greater than 150: " +
                $"{questions.Count(x => x.Title.Length > 150)}");
            Console.WriteLine(questions.Where(x => x.Title.Length > 150).Count());
        }
        private static void RunMaxQuestionTitleLength()
        {
            var questions = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));

            Console.WriteLine($"Max Question Title Length is: {questions.Max(x => x.Title.Length)}");
            Console.WriteLine($"Max choices in question is: {questions.Max(x => x.Choices.Count)}");
        }

        private static void RunMaxByQuestionTitleLength()
        {
            var questions = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));

            Console.WriteLine($"Max Question title length: \n\n{questions.MaxBy(x => x.Title.Length)}");
            Console.WriteLine($"Question that has max choices: \n\n{questions.MaxBy(x => x.Choices.Count)}");

        }

        private static void RunMinQuestionTitleLength()
        {
            var questions = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));

            Console.WriteLine($"Minimum question Title length is: {questions.Min(x => x.Title.Length)}");
        }



        private static void RunMinByQuestionTitleLength()

        {
            var questions = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));

            Console.WriteLine($"Question that has Minimum title length: {questions.MinBy(x => x.Title.Length)}");
        }

        private static void RunSum()
        {
            var questions = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));

            Console.WriteLine($"Sum of all choices: {questions.Sum(x => x.Choices.Count)}");
           
        }

        private static void RunAverage()
        {
            var questions = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));

            Console.WriteLine($"Average of Choices: {questions.Average(x => x.Choices.Count)}");
        }
    }

}