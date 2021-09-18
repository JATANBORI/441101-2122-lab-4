using System;

namespace L4._4_populationgrowth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Organism Population Growth Table");

            Console.WriteLine("What is the starting number of organisms?");
            int numOfOrganisms = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the daily percentage increase?");
            float percentIncrease = float.Parse(Console.ReadLine());

            Console.WriteLine("How many days should it be allowed to increase?");
            int daysToIncrease = int.Parse(Console.ReadLine());

            Console.WriteLine("| {0,11} | {1,11} !", "Day", "Population");
            Console.WriteLine("| {0,11} | {1,11} !", "===========", "===========");
            Console.WriteLine("| {0,11} | {1,11} |", 1, numOfOrganisms);

            // All other codes goes here

            

        }
    }
}
