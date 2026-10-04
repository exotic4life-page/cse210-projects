using System;

/*
 * EXCEEDING CORE REQUIREMENTS:
 * 1. Randomization without duplicates:
 *    - Implemented tracking lists (_unusedPrompts and _unusedQuestions) in ReflectingActivity 
 *      and ListingActivity to ensure no prompt or reflection question repeats until all items 
 *      in the list have been shown at least once in the current session.
 * 2. Robust Input Handling:
 *    - Validated user duration inputs in the base Activity class to prevent negative numbers 
 *      or invalid string inputs.
 */

namespace Mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "4")
            {
                Console.Clear();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. Start breathing activity");
                Console.WriteLine("  2. Start reflecting activity");
                Console.WriteLine("  3. Start listing activity");
                Console.WriteLine("  4. Quit");
                Console.Write("Select a choice from the menu: ");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BreathingActivity breathing = new BreathingActivity();
                        breathing.Run();
                        break;

                    case "2":
                        ReflectingActivity reflecting = new ReflectingActivity();
                        reflecting.Run();
                        break;

                    case "3":
                        ListingActivity listing = new ListingActivity();
                        listing.Run();
                        break;

                    case "4":
                        Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Press Enter to try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}