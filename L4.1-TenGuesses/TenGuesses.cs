using System;

namespace L4._1_tenGuesses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Guessing Game");
            Console.WriteLine("In this game you will have ten guesses to guess the secret number.");
            Console.WriteLine("The secret number is between 1 and 10 inclusive.");
            
            Random random = new Random();
            int secretNumber = random.Next(1, 11);

            // All your code goes here

            
        }
    }
}
