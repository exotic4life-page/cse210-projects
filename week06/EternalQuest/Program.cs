using System;

// EXCEEDED REQUIREMENTS DESCRIPTION:
// 1. Added a dynamic leveling system based on accumulated points (1 level per 1,000 points) displayed in the user score header.
// 2. Added defensive error handling for non-existent save files and invalid selections during event recording.

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}