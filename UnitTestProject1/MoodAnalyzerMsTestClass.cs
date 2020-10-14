using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerMsTest
{
    [TestClass]
    public class MoodAnalyzerMsTestClass
    {
        [TestMethod]
        [DataRow (null)]
        [DataRow ("")]
        public void TestMethod1(string messages)
        {
            string expected = "Exception caught : Null encountered";
            string message = messages;
            MoodAnalyzerClass moodAnalyzer = new MoodAnalyzerClass(message);
            string result = moodAnalyzer.AnalyzerMethod();
            Assert.AreEqual(expected,result);
        }

        [TestMethod]
        public void GivenClassReturnsObject()
        {
            string message = null;
            object expected = new MoodAnalyzerClass(message);
            object result = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzer.MoodAnalyzerClass", "MoodAnalyzerClass");
            expected.Equals(result);
        }

    }
}
