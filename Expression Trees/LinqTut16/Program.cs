using System;
using System.Linq.Expressions;

namespace LinqTut16
{
    internal class Program
    {

        public static void Main(string[] args)
        { 
            Func<int,bool> IsEven = num => num % 2 == 0;

            var num = 10;
            Console.WriteLine($"Is {num} even num? => ({IsEven(num)})");
            Console.WriteLine(IsEven.Invoke(num).ToString());  


            Expression<Func<int,bool>> isEvenExpression = num => num % 2 == 0;
            Func<int,bool> isEvenV2 = isEvenExpression.Compile();

            Console.WriteLine(isEvenV2(10));

            Console.ReadKey();
        }
    }
}