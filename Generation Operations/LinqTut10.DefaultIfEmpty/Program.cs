using System;
using Shared;


namespace LinqTut10.DefaultIfEmpty
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var questions1 = Enumerable.Empty<Question>();

            var questions2 = questions1.DefaultIfEmpty();

            var questions3 = questions2.DefaultIfEmpty(Question.Default);







            //var range = Enumerable.Range(0, 10);

            //var questions4 = QuestionBank.GetQuestionRange(range);

            //foreach (var questions in questions4)
            //{

            //    Console.WriteLine(questions);

            //}

            var q = QuestionBank.PickOne();

            var questionss = Enumerable.Repeat(q, 20);

            questionss.ToQuiz();

            Console.ReadKey();


        }
    }
}