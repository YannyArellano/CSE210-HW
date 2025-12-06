using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", 
               "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int time = 0;
        while (time < _duration)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(4);
            time += 4;

            if (time >= _duration) break;

            Console.Write("\nBreathe out...");
            ShowCountDown(6);
            time += 6;
        }

        DisplayEndingMessage();
    }
}