using System;
using LINQTut05.Shared;

namespace LinqTut06.Paginetion
{

    internal class Program
    {
        static void Main(string[] args)
        {

            var emps = Repository.LoadEmployees();

            var page = 1;
            var size = 10;


            var q1   = emps.Paginate(page,size);
            q1.Print($"Employees Page {page}");


            page = 3;
            size = 10;

            var q2 = emps.Paginate(page,size);
            q2.Print($"Employees Page {page}");
            
            

            Console.ReadKey();
        }
    }

}
