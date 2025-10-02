using System;
using LINQTut05.Shared;


namespace LinqTut05.ThenBy
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var emps = Repository.LoadEmployees();

            var orderedEmployees = emps.OrderBy(e => e.Name);

            orderedEmployees.Print("Ordered Employees By Name");

            var orderedEmployeesByNameAndSalary = emps.OrderBy(emps => emps.Name).ThenByDescending(emps => emps.Salary);
            orderedEmployeesByNameAndSalary.Print("Ordered Employees by name then salary");


            Console.ReadKey();
        }
    
    
    }

}