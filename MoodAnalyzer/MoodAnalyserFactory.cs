﻿using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using MoodAnalyzer;

namespace MoodAnalyzer
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyseUsingParameterized(string className, string constructorName)
        {
            Type type = typeof(MoodAnalyzerClass);

            if (type.Name.Equals(className)|| type.FullName.Equals(className))
            {
                if(type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance = ctor.Invoke(new object[] { "HAPPY" });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyserCustomException("Constructor is not found");
                }
            }
            else
            {
                throw new MoodAnalyserCustomException("Class is not found");
            }
        }
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
