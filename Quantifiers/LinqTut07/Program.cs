using System;
using LINQTut07.Shared;


namespace LinqTut07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //RunAnyDemo();
            //RunAllDemo();
            //RunAllDemoQuerySyntax();
            RunContainsDemo();

            Console.ReadKey();
        }

        private static void RunAnyDemo()
        {

            var employees = Repository.LoadEmployees();
            
            //this will search if there is any employee has jac in his name?
            var q1 = employees.Any(x => x.Name.StartsWith("jac", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"Check if there is an employee with name starts with jac: {q1}");

            //this will search if there is any employee has Salary below 10,000
            var q2 = employees.Any(x => x.Salary < 10000);
            Console.WriteLine($"Check if there is an employee with salary less than 10.000: {q2}");

            //this will search if there is any employee has one skill?
            var q3 = employees.Any(x => x.Skills.Count == 1);
            Console.WriteLine($"Check if there is an employee have one Skill?: {q3}");


        }

        private static void RunAllDemo()
        {

            var employees = Repository.LoadEmployees();

            //True if all employees have emails , false if there is one employee has no email
            var q1 = employees.All(x => !string.IsNullOrWhiteSpace(x.Email));
            Console.WriteLine($"If all Employees have Emails?: {q1}");

            //False if there is one employee has no C# skill
            var q2 = employees.All(x => x.Skills.Any(s => s =="C#"));
            Console.WriteLine($"If all Employees have C# Skill?: {q2}");



        }

        private static void RunAllDemoQuerySyntax()
        {

            var employees = Repository.LoadEmployees();

            //Select employees that have C++ skill
            var q1 = from employee in employees
                     where employee.Skills.Any(s => s == "C++")
                     select employee;
            
            q1.Print("All employees with C++ Skill:");


            //this will not include employees with C# skill
            var q2 = from employee in employees
                     where employee.Skills.All(s => s.Length >= 3)

                     select employee;

            q2.Print("Employees with skills have 3 char and more.");


        }

        private static void RunContainsDemo()
        {

            var employees = Repository.LoadEmployees();

            var result1 = employees.Any(x => x.Name.Contains("ee"));

            Console.WriteLine($"check if any employee has ee in his name: {result1}");

            var e1 = new Employee { Email = "Evans.Hester@example.com" };
            //This will check if there is an employee with specific Email
            var result2 = employees.Contains(e1);
            Console.WriteLine($"check if any employee has emial with Evans.Hester@example.com: {result2}");
            
        }

    }
}
