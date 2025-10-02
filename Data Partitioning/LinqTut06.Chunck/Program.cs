using System;
using LINQTut05.Shared;


namespace LinqTut06.Chunck
{

    internal class Program
    {
        static void Main(string[] args)
        {

            var emps = Repository.LoadEmployees();

            var q1 = emps.Chunk(10).ToList();

            for(int i =0;i< q1.Count();i++)
            {
                q1[i].Print($"Chunck #{i + 1}");
            }

            Console.ReadKey();
        }
    }

}
