using System;

namespace MoodAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer Problem using Exception Handling");
            MoodAnalyserReflector moodAnalyserFactory = new MoodAnalyserReflector();
            moodAnalyserFactory.InvokeMethodUsingReflection();
        }
    }
}