using System;

namespace Uppgift_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många minuter är din låt? (ex. 3 min och 40 sekunder blir 3 min)");
            int minuter = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många sekunder är den? (ex. 3 min och 40 sekunder blir 40 sekunder)");
            int sekunder = int.Parse(Console.ReadLine());
            int sekunderTotal = (minuter * 60) + sekunder;

            if (sekunderTotal>=165 && sekunderTotal<=260)
                Console.WriteLine("Din låt får spelas på radiostationen.");
            else
                Console.WriteLine("Din låt får inte spelas på radiostationen.");

            Console.ReadKey();
        }
    }
}