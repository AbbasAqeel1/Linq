using System;
using System.Security.Cryptography.X509Certificates;
using LINQTut04.Shared;


namespace LinqTu004.SelectMany
{
    internal class Program
    {

        static void Main(string[] args)
        {
            RunExample01();
            Console.WriteLine();
            RunExample02();
            Console.ReadKey();
        }

        private static void RunExample01()
        {
            string[] colorName = { "Red", "Green", "Blue" };
            string[] colorhex = { "FF0000", "00FF00", "0000FF" };

            var Colors = colorName.Zip(colorhex,(name,hex) => $"{name} -> {hex}");

            foreach (var color in Colors)
            {
                Console.WriteLine(color);
            }
        }

        private static void RunExample02()
        {
            var employees    = Repository.LoadEmployees().ToArray();

            var FirstTeam = employees[..3];
            var LastTeam = employees[^3..];
            //this will make teams matching first three employees with last three employees in the list
            var Teams = FirstTeam.Zip(LastTeam,(First,Last) => $"{First.FullName} -> {Last.FullName}");

            foreach(var team in Teams)
            {
                Console.WriteLine(team);
            }
        }
    }
}
