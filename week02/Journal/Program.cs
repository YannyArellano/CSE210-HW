using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nPlease select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?. Choose an option (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToString("yyyy-MM-dd");


                    Entry newEntry = new Entry(date, prompt, response);
                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry added!");
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.WriteLine("Enter filename to save (e.g. journal.txt): ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    Console.WriteLine("Journal loaded");
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please chose 1-5.");
                    break;

            }
        }
    }
    static string ShowMenu()
    {
        Console.WriteLine("\nPlease select one of the following choices");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display all entries");
        Console.WriteLine("3. Save journal to file");
        Console.WriteLine("4. Load journal from file");
        Console.WriteLine("5. Exit");
        Console.Write("Choose an option (1-5): ");
        return Console.ReadLine();
    }
}