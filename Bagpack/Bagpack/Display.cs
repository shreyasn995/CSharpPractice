using System;
using Bagpack.BagpackTypes;

namespace Bagpack
{
    class Display
    {
        static void Main(string[] args)
        {
            string menuOption;
            AbstractBagpack bagpack;
            bagpack = GetBagpackType();

            do
            {
                Console.Clear();
                Console.WriteLine("Content of the bagpack are:");
                foreach (string item in bagpack.ItemList)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("What would you like to do? Choose between 'add', 'remove', and 'quit'.");
                menuOption = Console.ReadLine();

                switch (menuOption)
                {
                    case "add":
                        Console.WriteLine("What item would you like to add?");
                        Console.WriteLine(bagpack.AddItem(Console.ReadLine()));
                        break;
                    case "remove":
                        Console.WriteLine("What item would you like to remove?");
                        Console.WriteLine(bagpack.RemoveItem(Console.ReadLine()));
                        break;
                    case "quit":
                        continue; // Don't print "Hit any key to continue" when 'quit' option chosen
                    default:
                        Console.WriteLine("Incorrect input. Try again.");
                        break;
                }
                Console.WriteLine("Hit any key to continue:"); // User can read success/error message before screen clears
                Console.ReadKey();
            } while (menuOption != "quit");

        }

        private static AbstractBagpack GetBagpackType()
        {
            string bagpackType;

            Console.WriteLine("What type of bagpack would you like? Choose between 'basic', 'maxitem', and 'maxweight'.");
            bagpackType = Console.ReadLine();
            Console.Clear();

            switch (bagpackType)
            {
                case "basic":
                    return new BasicBagpack();
                case "maxitem":
                    return new MaxItemsBagpack();
                case "maxweight":
                    return new MaxWeightBagpack();
                default:
                    Console.WriteLine("Incorrect input. Try again.");
                    return GetBagpackType();
            }
        }
    }
}
