using System;


namespace LinqTut17
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //IEnumerable when you Iterate on its elements it will brings all data from anywhere
            //and will apply the (condition) and processing in the memory.
            //first: bring all data, second: it will apply the condition on these data and
            //will take the elements that match the condition.




            //IQueryable when you Iterate on its elements it will go and see the condition and then
            //it will convert the code into expression tree and then send it to the provider(EF Core)
            //And then it will send it to the sql, then it will execute the code in sql and it will bring
            //the data that match the condition only.

            Console.ReadKey();
        }
    }
}