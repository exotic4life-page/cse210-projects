using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creativity and Exceeding Requirements:
        // I added a small library of multiple scriptures and randomly
        // select one when the program starts. This gives the user
        // different scriptures to practice instead of only one scripture.

        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son that whoever believes in him should not perish but have eternal life"),

            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all your heart and do not lean on your own understanding In all your ways acknowledge him and he will make straight your paths"),

            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ who strengthens me")
        };

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to hide words or type quit: ");

            string input = Console.ReadLine() ?? "";

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Thank you for practicing!");
    }
}