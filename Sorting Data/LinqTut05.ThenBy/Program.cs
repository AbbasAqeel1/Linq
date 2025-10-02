using System;
using LINQTut05.Shared;


namespace LinqTut05.ThenBy
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var emps = Repository.LoadEmployees();


            //order employees by name asc
            var orderedEmployees = emps.OrderBy(e => e.Name);
            orderedEmployees.Print("Ordered Employees By Name");
            

            //order employees by name asc first and then salary desc
            var orderedEmployeesByNameThenSalary = emps.OrderBy(e => e.Name).ThenByDescending(e => e.Salary);
            orderedEmployeesByNameThenSalary.Print("Ordered Employees by name then salary");

            
            
            //order employees by department asc first and then salary desc
            var orderedEmployeesByDepartmentThenSalary = 
                emps.OrderBy(e => e.DepartmentName).ThenByDescending(e => e.Salary);
            orderedEmployeesByDepartmentThenSalary.Print("Employees order by Department then by Salary desc");



            Console.ReadKey();
        }
    
    
    }

}