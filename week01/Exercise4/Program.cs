using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            string response = Console.ReadLine();
            userNumber = int.Parse(response);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");

        float average = ((float)sum / numbers.Count);
        Console.WriteLine($"The average is: {average}");

        int smallestPositiveNumber = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositiveNumber)
            {
                smallestPositiveNumber = number;
            }
        }

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        if (smallestPositiveNumber != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
        }
        else
        {
            Console.Write("No positive numbers were entered");
        }
        numbers.Sort();
        Console.WriteLine("Sorted list: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}