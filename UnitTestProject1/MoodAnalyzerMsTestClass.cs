using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
using System;
using System.Reflection;

namespace MoodAnalyzerMsTest
{
    [TestClass]
    public class MoodAnalyzerMsTestClass
    {
        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        public void TestMethod1(string messages)
        {
            string expected = "Exception caught : Null encountered";
            string message = messages;
            MoodAnalyzerClass moodAnalyzer = new MoodAnalyzerClass(message);
            string result = moodAnalyzer.AnalyzerMethod();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GivenClassReturnsObject()
        {
            string message = null;
            object expected = new MoodAnalyzerClass(message);
            object result = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzer.MoodAnalyzerClass", "MoodAnalyzerClass");
            expected.Equals(result);
        }

        [TestMethod]
        public void GivenClassReturnsObjectParameterized()
        {
                object result = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterized("MoodAnalyzer.MoodAnalyzerClass", "MoodAnalyzerClass");
                object expected = new MoodAnalyzerClass("SAD");
                expected.Equals(result);
           
        }
        [TestMethod]
        public void InvokeMethodUsingReflection()
        {
            Type type = typeof(MoodAnalyzer.MoodAnalyzerClass);
            MethodInfo method = type.GetMethod("AnalyzerMethod");   
            object[] parametersArray = new object[] { };   /// Parameters to be passed in method can be mentioned here

            object classInstance = Activator.CreateInstance(type);

            object result = method.Invoke(classInstance,parametersArray);
        }

    }
}
