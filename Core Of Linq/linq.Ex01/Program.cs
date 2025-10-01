using System;
using FunctionalProgramming;


namespace linq.Ex01
{
    internal class Program
    {
        
        static void Main(string[] args)
        {


            var employees = Repository.LoadEmployees();
            var FemaleWithFirstNameStartWithS = employees.Filter(x =>x.Gender.ToLowerInvariant() == "female" && x.FirstName.ToLowerInvariant().StartsWith("s"));

            FemaleWithFirstNameStartWithS.Print("Female employees with first name start with s.");





            var FemaleWithFirstNameStartWithS02 = employees.Where(x => x.Gender.ToLowerInvariant() == "female" &&
            x.FirstName.ToLowerInvariant().StartsWith("s"));

            FemaleWithFirstNameStartWithS02.Print("Female employees with first name start with s. using Where");



            Console.ReadKey();
        }
    }

}