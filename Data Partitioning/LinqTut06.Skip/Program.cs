using System;
using System.Net.Quic;
using LINQTut05.Shared;



namespace LinqTut06.Skip
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var emps = Repository.LoadEmployees();

            
            var q1 = emps.Skip(10);
            q1.Print("Skipping First 10 employees");



            var q2 = emps.SkipWhile(x => x.Salary != 2814);
            q2.Print("Skipping until i reach 2814 and then continue");



            var q3 = emps.SkipLast(20);
            q3.Print("Skipping last 74 Employee");

            Console.ReadKey();
        }
    }
}