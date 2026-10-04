using System;
using System.Threading;

namespace Mindfulness
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity()
        {
            _name = "Breathing Activity";
            _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }

        public void Run()
        {
            DisplayStartingMessage();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("\nBreathe in... ");
                ShowCountDown(4);
                
                // Check if time is up before breathing out
                if (DateTime.Now >= endTime) break;

                Console.Write("\nNow breathe out... ");
                ShowCountDown(6);
                Console.WriteLine();
            }

            DisplayEndingMessage();
        }
    }
}