using System;
using Microsoft.Win32.SafeHandles;
using Shared;

namespace LinqTut11
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            var questions = QuestionBank.All;

            var question1 = questions.ElementAt(10); 
            Console.WriteLine(question1);

            var question2 = questions.ElementAtOrDefault(10000);
            if (question2 != null)
            {
                Console.WriteLine(question2);
            }
            else
            {
                Console.WriteLine("Element at 10000 not found.");
            }





            Console.WriteLine("\n\n\n");

            //var questionFirst = questions.First(x=> x.Title.Length == 0);
            //Console.WriteLine(questionFirst);

            var questionFirstOrDefault = questions.FirstOrDefault(x => x.Title.Length == 0);
            if (questionFirstOrDefault != null)
            {
                Console.WriteLine(questionFirstOrDefault.Title);
            }
            else
            {
                Console.WriteLine("Question with title length 0 not found. using FirstOrDefault");
            }




            Console.WriteLine("\n\n\n");

            //var LastQuestion = questions.Last(x=> x.Title.Length == 0);
            //Console.WriteLine(LastQuestion);

            var questionLastOrDefault = questions.LastOrDefault(x => x.Title.Length == 0);
            if (questionLastOrDefault != null)
            {
                Console.WriteLine(questionLastOrDefault.Title);
            }
            else
            {
                Console.WriteLine("Question with title length 0 not found. using LastOrDefault");
            }



            Console.WriteLine("\n\n\n");

            //var question3 = questions.Single(x => x.Title.Contains("#245"));
            
            var question4 = questions.SingleOrDefault(x => x.Title.Length == 0);

            if (question4 != null)
            {
                Console.WriteLine(question4);
            }
            else
            {
                Console.WriteLine("There is no exists question with no title. using SingleOrDefault");
            }

            //Console.WriteLine($"Question is single{question3}");

            Console.ReadKey();
        }
    }
}