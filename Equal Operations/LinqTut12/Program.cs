using System;
using Shared;

namespace LinqTut12
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            RunMethod1();
            RunMethod2();
            RunMethod3();
            Console.ReadKey();

        }

        private static void RunMethod1()
        {
            var q1 = QuestionBank.PickOne();
            var q2 = QuestionBank.PickOne();
            var q3 = QuestionBank.PickOne();

            var list1 = new List<Question>() { q1, q2, q3 };

            var list2 = new List<Question>() { q1, q2, q3 };

            var equal1 = list1.SequenceEqual(list2);

            Console.WriteLine($"Quiz1 and Quiz2 {(equal1 ? "are" : "are not")} equal");
        }

        private static void RunMethod2()
        {
            var randomFourQuestions = QuestionBank.GetQuestionRange(Enumerable.Range(1, 4));



            var list1 = randomFourQuestions;

            var list2 = randomFourQuestions;

            var equal1 = list1.SequenceEqual(list2);

            Console.WriteLine($"Quiz1 and Quiz2 {(equal1 ? "are" : "are not")} equal");
        }


        private static void RunMethod3()
        {
            var randomFourQuestions = QuestionBank.GetQuestionRange(Enumerable.Range(1, 4));
            var randomFourQuestion2 = QuestionBank.GetQuestionRange(Enumerable.Range(1, 4));



            var list1 = randomFourQuestions;

            var list2 = randomFourQuestion2;

            var equal1 = list1.SequenceEqual(list2);

            Console.WriteLine($"Quiz1 and Quiz2 {(equal1 ? "are" : "are not")} equal");
        }

    }
}
