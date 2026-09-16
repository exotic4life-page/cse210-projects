using System;
// Creativity and Exceeding Requirements:
// I added a mood field to each journal entry. The user can record
// how they felt when writing the entry, and the mood is saved,
// loaded, and displayed along with the date, prompt, and response.

class Program { static void Main(string[] args) { Journal journal = new Journal();
    string[] prompts =
    {
        "What was the best part of your day?",
        "Who was the most interesting person you talked to today?",
        "What is something you learned today?",
        "What was the strongest emotion you felt today?",
        "What is one thing you would like to improve tomorrow?",
        "What made you smile today?",
        "What are you grateful for today?"
    };

    Random random = new Random();

    int choice = 0;

    while (choice != 5)
    {
        Console.WriteLine("Journal Menu");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal");
        Console.WriteLine("4. Load the journal");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");

        choice = int.Parse(Console.ReadLine());

        Console.WriteLine();

        if (choice == 1)
        {
            int randomIndex = random.Next(prompts.Length);
            string prompt = prompts[randomIndex];

            Console.WriteLine(prompt);
            Console.Write("> ");
            string response = Console.ReadLine();

            Console.Write("How would you describe your mood today? ");
            string mood = Console.ReadLine();

            Entry newEntry = new Entry();

            newEntry._date = DateTime.Now.ToShortDateString();
            newEntry._promptText = prompt;
            newEntry._entryText = response;
            newEntry._mood = mood;

            journal.AddEntry(newEntry);

            Console.WriteLine("Your entry has been saved.");
            Console.WriteLine();
        }
        else if (choice == 2)
        {
            journal.DisplayAll();
        }
        else if (choice == 3)
        {
            Console.Write("Enter the filename: ");
            string filename = Console.ReadLine();

            journal.SaveToFile(filename);

            Console.WriteLine("Journal saved successfully.");
            Console.WriteLine();
        }
        else if (choice == 4)
        {
            Console.Write("Enter the filename: ");
            string filename = Console.ReadLine();

            journal.LoadFromFile(filename);

            Console.WriteLine("Journal loaded successfully.");
            Console.WriteLine();
        }
        else if (choice == 5)
        {
            Console.WriteLine("Goodbye!");
        }
        else
        {
            Console.WriteLine("Please enter a number from 1 to 5.");
            Console.WriteLine();
        }
    }
}
}