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
            var size = 20;
            var result   = emps.Paginate(page,size);
            result.Print($"Employees Page {page}");
            
            

            Console.ReadKey();
        }
    }

}
