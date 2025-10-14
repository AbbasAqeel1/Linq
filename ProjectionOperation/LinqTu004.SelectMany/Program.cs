using System;
using LINQTut04.Shared;


namespace LinqTu004.SelectMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            RunExample01();
            RunExample02();
            
            Console.ReadKey();
        }


        private static void RunExample01()
        {
            var Sequences = new List<string>
            {
                "I love asp.net",
                "I love sql server",
                "In general i love programming"
            };

            //this will split each word inside the list or strings and put it inside result as a single word
            var result = Sequences.SelectMany(x => x.Split(' '));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static void RunExample02()
        {
            var Employees = Repository.LoadEmployees();



            //this will take the skills without repetition
            var result = Employees.SelectMany(x => x.Skills).Distinct();

            var result01 = (from emp in Employees
                           from skill in emp.Skills
                           select skill).Distinct();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


        }
    }
}
