using System;
using FunctionalProgramming;

namespace linq.Ex03
{


    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();

            var empMale = employees.Where(x => x.Gender == "male");

            var empSalaryGreaterThan300k = employees.Where(x => x.Salary >= 300_300);


            empMale.Print("Male employees");
            empSalaryGreaterThan300k.Print("emps Where salary >= 300k");

            var empsInHrDepartment = empMale.Where(x => x.Department.ToLowerInvariant() == "hr");

            empsInHrDepartment.Print("Employees in hr department");

            var empsWithSalaryBelow90k = employees.Where(x => x.Salary < 200000);

            empsWithSalaryBelow90k.Print("Employees with salary < 200K");

            Console.ReadKey();
        }
    }



}
