using System;
using System.Linq;

namespace DecisionMaker5000
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] CoinFlips = new string[3];

            Console.WriteLine("Welcome to the DecisionMaker-5000! Please select one of the modules to start.\n\n\t1 - Input a sequence of things and it'll choose one at random\n\t2 - Generates a sequence of events from Coin Flips to D6s\n");
            switch (Console.ReadLine()) {
                case "1":
                    Console.WriteLine("Please input a series of words, numbers, or alike, separated by spaces.");
                    var Inputs = Console.ReadLine();
                    Console.WriteLine("The selected item was: " + Inputs.Split(' ')[random.Next(0, Inputs.Where(f => (f == ' ')).Count() + 2)]);
                    break;
                case "2":
                    if (random.Next(1, 3) == 1) CoinFlips[0] = "Heads";
                    else CoinFlips[0] = "Tails";
                    if (random.Next(1, 3) == 1) CoinFlips[1] = "Heads";
                    else CoinFlips[1] = "Tails";
                    if (random.Next(1, 3) == 1) CoinFlips[2] = "Heads";
                    else CoinFlips[2] = "Tails";
                    Console.WriteLine("The coin lands on " + CoinFlips[0]);
                    Console.WriteLine("\nThe coin lands on " + CoinFlips[1]);
                    Console.WriteLine("\nThe coin lands on " + CoinFlips[2]);
                    Console.WriteLine("\nYou roll two D6s and they land on " + random.Next(1, 7) + " and " + random.Next(1, 8));
                    Console.WriteLine("\nYou roll a D20 and it lands on " + random.Next(1, 21));
                    break;            
            }
            Console.WriteLine("\nPress Enter to finish.");
            Console.ReadLine();
        }
    }
}
