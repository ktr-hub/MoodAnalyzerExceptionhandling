using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerMsTest
{
    [TestClass]
    public class MoodAnalyzerMsTest
    {
        [TestMethod]
       // [DataRow ("I am SAD")]
        [DataRow (null)]
        public void TestMethod1(string messages)
        {
            //string expected = "SAD";
            string expected = "HAPPY";
            string message = messages;
            MoodAnalyzerClass moodAnalyzer = new MoodAnalyzerClass(message);
            string result = moodAnalyzer.AnalyzerMethod();
            Assert.AreEqual(expected,result);
;        }
    }
}