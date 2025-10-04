using System;
using System.Linq;
using LINQTut08.Shared;


namespace LinqTut08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunGroupByEx();
            //RunGroupByQuerySyntax();
            RunToLookupEx();
            Console.ReadKey();
        }

        private static void RunGroupByEx()
        {
            var employees = Repository.LoadEmployees();

            var groups = employees.GroupBy(x => x.Department);

            Console.WriteLine("Group By Example");

            foreach(var group in groups)
            {
                group.Print($"Employees of {group.Key} Department");
            }
        }

        private static void RunGroupByQuerySyntax()
        {
            var employees = Repository.LoadEmployees();

            var groups = from emp in employees
                         group emp by emp.Department;

            Console.WriteLine("Group By using query syntax Example");

            foreach (var group in groups)
            {
                group.Print($"Employees of {group.Key} Department");
            }
        }

        private static void RunToLookupEx()
        {
            var employees = Repository.LoadEmployees();

            var groups = employees.ToLookup(x => x.Department);

            Console.WriteLine("ToLookup Example");

            foreach (var group in groups)
            {
                group.Print($"Employees of {group.Key} Department");
            }
        }




    }
}