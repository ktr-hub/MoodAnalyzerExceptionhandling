using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using MoodAnalyzer;

namespace MoodAnalyzer
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyse(string className,string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException) 
                {
                    throw new MoodAnalyserCustomException("Class not found");
                }
            }
            else
            {
                throw new MoodAnalyserCustomException("Constructor is not found");
            }
        }
    }
}
