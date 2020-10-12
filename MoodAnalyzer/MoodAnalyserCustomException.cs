using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace MoodAnalyzer
{
    class MoodAnalyserCustomException : MoodAnalyzerClass
    {
        public MoodAnalyserCustomException(string message) : base(message)
        {
            Console.WriteLine(message);
        }

    }
}