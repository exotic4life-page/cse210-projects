using System;
using System.Collections.Generic;
using System.Threading;

namespace Mindfulness
{
    public class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        public Activity()
        {
            _name = "Activity";
            _description = "Default description";
            _duration = 0;
        }

        public void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name}.");
            Console.WriteLine();
            Console.WriteLine(_description);
            Console.WriteLine();
            Console.Write("How long, in seconds, would you like for your session? ");
            
            while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
            {
                Console.Write("Please enter a valid positive integer for duration in seconds: ");
            }

            Console.Clear();
            Console.WriteLine("Get ready...");
            ShowSpinner(5);
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!!");
            ShowSpinner(3);
            Console.WriteLine();
            Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
            ShowSpinner(5);
        }

        public void ShowSpinner(int seconds)
        {
            List<string> animationFrames = new List<string> { "|", "/", "-", "\\" };
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);

            int i = 0;
            while (DateTime.Now < endTime)
            {
                string frame = animationFrames[i];
                Console.Write(frame);
                Thread.Sleep(250);
                Console.Write("\b \b");

                i = (i + 1) % animationFrames.Count;
            }
        }

        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                
                // Erase digits based on length (handles single and multi-digit numbers)
                string backspaces = new string('\b', i.ToString().Length);
                string spaces = new string(' ', i.ToString().Length);
                Console.Write($"{backspaces}{spaces}{backspaces}");
            }
        }
    }
}