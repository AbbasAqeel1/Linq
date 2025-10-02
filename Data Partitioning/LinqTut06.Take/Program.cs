using System;
using LINQTut05.Shared;


namespace LinqTut06.Take
{

    internal class Program
    {
        static void Main(string[] args)
        {

            var emps = Repository.LoadEmployees();

            
            var q1 = emps.Take(10);
            q1.Print("Taking First 10 employees");



            var q2 = emps.TakeWhile(x => x.Salary != 3700);
            q2.Print("Taking record until reach salary 3700$");



            var q3 = emps.TakeLast(10);
            q3.Print("Taking last 10 Employee");

            Console.ReadKey();
        }
    }

}
