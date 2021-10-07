using System;

namespace L4._5_MaizeCobRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maize Cob Counting Robot.");

            const int maizeCobsPerMinute = 100;

            //All the rest of your codes goes here
            
            Console.WriteLine("| {0,11} | {1,12} |", "Minutes", "Maize Cobs");
            Console.WriteLine("| {0,11} | {1,12} |", "===========", "============");

            for (int i = 10; i <= 30; i+=5)
            {
                float totalMaizeCobs = maizeCobsPerMinute * i;
                Console.WriteLine("| {0,11} | {1,12} |", i, totalMaizeCobs);
            }
        }
    }
}
