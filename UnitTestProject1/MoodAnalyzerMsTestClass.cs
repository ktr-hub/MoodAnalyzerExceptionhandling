using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerMsTest
{
    [TestClass]
    public class MoodAnalyzerMsTestClass
    {
        [TestMethod]
       [DataRow ("I am in Sad Mood")]
       [DataRow ("I am in Any Mood")]
        public void TestMethod1(string messages)
        {
            string expected = "SAD";
            string message = messages;
            MoodAnalyzerClass moodAnalyzer = new MoodAnalyzerClass(message);
            string result = moodAnalyzer.AnalyzerMethod();
            Assert.AreEqual(expected,result);
;        }
    }
}
