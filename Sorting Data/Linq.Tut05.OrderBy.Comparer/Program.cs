using System;
using LINQTut05.Shared;

namespace Linq.Tut05.OrderBy.Comparer
{

    internal class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<Employee> emps = Repository.LoadEmployees();

            //IOrderedEnumerable<Employee> orderedEmps = emps.OrderBy(e => e.EmployeeNo);
             
           var  orderedEmps = emps.OrderBy(e => e,new EmployeeComparer());


            orderedEmps.Print("Ordered Employees by Emp No");








            Console.ReadKey();
        }
    }



}
