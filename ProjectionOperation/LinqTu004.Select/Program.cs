using System;
using System.Net.WebSockets;
using LinqTu004.Select;
using LinqTu004.Shared;
using LINQTut04.Shared;


namespace LinqTu004.Shared
{

    internal class Program
    {

        static void Main(string[] args)
        {
            //RunExample01();
            //RunExample02();
            RunExample03();


            Console.ReadKey();

        }

        private static void RunExample01()
        {
            List<string> list = new() { "I", "Love", "asp.net", "core" };

            //convert every  word to uppercase
            var result = list.Select(x => x.ToUpper());

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static void RunExample02()
        {
            List<int> list = new() { 2, 3, 7, 8 };

            var result = list.Select(x => x * x);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static void RunExample03()
        {
            var Emps = Repository.LoadEmployees();

            //This will select EmployeeName and number Of his skills
            var result = Emps.Select(x => {
                return new EmployeeDto { Name = x.FirstName +  " " + x.LastName,TotalSkills = x.Skills.Count };
                }); 

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

    }

}
