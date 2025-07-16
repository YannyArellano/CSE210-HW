using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Helloo World! This is the Exercise2 Project.");
        /*Write a program that determines the letter grade for a course according to the following scale:
            A >= 90
            B >= 80
            C >= 70
            D >= 60
            F < 60*/

        Console.Write("Enter your grade percentage: ");
        string gradePercentage = Console.ReadLine();
        gradePercentage = gradePercentage.Replace("%", "");

        int grade = int.Parse(gradePercentage);

        string letter = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastDigit = grade % 10;
        if (letter != "F")
        {
            if (letter == "A" && lastDigit >= 7)
            {
                sign = "";
            }
            else if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit <= 3)
            {
                sign = "-";
            }
        }
        Console.WriteLine($"Your grade is {letter}{sign}");
        if (grade >= 70)
        {
            Console.WriteLine("Congrats, You passed the course!");
        }
        else
        {
            Console.WriteLine("You not passed, good luck next time");
        }
    }
}


