using System;
using LINQTut05.Shared;


namespace LinqTut06.Take
{

    internal class Program
    {
        static void Main(string[] args)
        {

            var emps = Repository.LoadEmployees();

            //emps.Print("Employees");
            var q1 = emps.Take(10);
            q1.Print("Taking First 10 employees");



            var q2 = emps.TakeWhile(x => x.Salary != 3158);
            q2.Print("Taking record until reach salary 3700$");



            var q3 = emps.TakeLast(10);
            q3.Print("Taking last 10 Employee");

            var q4 = emps.TakeWhile(x => x.Salary != 1731);
            q4.Print("Taking emps While salary != 1731");

            var q5 = emps.OrderByDescending(x => x.Salary).Take(10);

            q5.Print("Top 10 Employees Salary");


            var q6 = emps.OrderBy(x => x.Salary).Take(10);

            q6.Print("Lowest 10 Employees Salary");


            var q7 = emps.OrderBy(e => e.Salary).Take(10).Reverse();
            q7.Print("lowest Salaries in the Company. Desc order");

            Console.ReadKey();
        }
    }

}
