using System;
using System.Runtime.InteropServices;
using Shared;


namespace LinqTut19
{

    internal class Program

    {
        public static void Main(string[] args)
        {
            var Employees = Repository.Employees;

            var Page = 4;
            var Pages = 10;

            //var Page4X10 = Employees.Paginate(Page, Pages);
            //Page4X10.Print("Employees Page (4) [10 Employees]");

            //var Page1X10 = Employees.Paginate();
            //Page1X10.Print("Employees Page (1) [10 Employees]");

            //var Page1X7 = Employees.Paginate2(null, 7);
            //Page1X7.Print("Employees Page 1 [7 Employees]");

            var EmployeesWithPensionPlan = Employees.WhereWithPaginate(x => x.HasPensionPlan, 1, 5);
            EmployeesWithPensionPlan.Print("Employees With pension plan #Page 1 [5 Employees]");

            var EmployeesWithoutPensionPlan = Employees.WhereWithPaginate(x => !x.HasPensionPlan, 1, 5);
            EmployeesWithoutPensionPlan.Print("Employees Without pension plan #Page 1 [5 Employees]");


            var EmployeesWithHealthInsurance = Employees.WhereWithPaginate(x => x.HasHealthInsurance, 1, 5);
            EmployeesWithHealthInsurance.Print("Employees With Health Insurance #Page 1 [5 Employees]");

            var EmployeesWithoutHealthInsurance = Employees.WhereWithPaginate(x => !x.HasHealthInsurance, 1, 5);
            EmployeesWithoutHealthInsurance.Print("Employees Without Health Insurance #Page 1 [5 Employees]");

            var RandomEmployee = Employees.Random(x => true);
            Console.WriteLine("\n\nRandom Employee");
            Console.WriteLine(RandomEmployee);
            Console.ReadKey();

        }
    }
}