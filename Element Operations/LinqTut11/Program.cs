using System;
using Shared;

namespace LinqTut11
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            var questions = QuestionBank.All;

            
            var questionsAt10 = questions.ElementAt(1);
            Console.WriteLine(questionsAt10);

            var question2 = questions.ElementAtOrDefault(1000);

            if (question2 != null)
            {
                Console.WriteLine(question2);
            }
            else
            {
                Console.WriteLine("Question at index 1000 not exists.");
            }





            Console.WriteLine("\n\n\n");

            var questionFirst = questions.First(x => x.Title.Length == 0);

            Console.WriteLine(questionFirst);
            var questionFirstOrDefault = questions.FirstOrDefault(x => x.Title.Length == 0);

            if (questionFirstOrDefault != null)
            {
                Console.WriteLine(questionFirstOrDefault);
            }
            else
            {
                Console.WriteLine("Qustion is null");
            }



            Console.WriteLine("\n\n\n");
            var questionLast = questions.Last(x => x.Title.Length == 0);
            Console.WriteLine(questionLast);


            var questionLastOrDefault = questions.LastOrDefault(x => x.Title.Length == 0);

            if (questionLastOrDefault != null)
            {
                Console.WriteLine(questionLastOrDefault);
            }
            else
            {
                Console.WriteLine("Qustion is null");
            }



            Console.WriteLine("\n\n\n");
            var questionSingle1 = questions.Single(x => x.Title.Length == 0);
            var questionSingle2 = questions.SingleOrDefault(x => x.Title.Length == 0);

            if (questionSingle2 != null)
            {
                Console.WriteLine("Question2 is not null");
            }
            else
            {
                Console.WriteLine("Qustion2 is null");
            }

            Console.ReadKey();
        }
    }
}