using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a reference (example: John 3:16)
        Reference reference = new Reference("John", 3, 16);

        // Create a scripture
        string text = "For God so loved the world that he gave his only begotten Son";
        Scripture scripture = new Scripture(reference, text);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine("Scripture Memorization Program\n");
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3); // hide 3 more words each time
        }

        Console.WriteLine("\nAll words are hidden or you quit the program. Goodbye!");
    }
}