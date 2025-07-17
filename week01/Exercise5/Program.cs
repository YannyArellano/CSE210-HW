using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        WelcomMessge();

        string NameInput = UserInput();
        int NumberInput = FavoriteNumber();

        int SquareCalculation = SquareNumber(NumberInput);
        FinalMessage(NameInput, SquareCalculation);
    }
    static void WelcomMessge()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string UserInput()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int FavoriteNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void FinalMessage(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}