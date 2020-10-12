using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerMsTest
{
    [TestClass]
    public class MoodAnalyzerMsTestClass
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "SAD";
            MoodAnalyzerClass moodAnalyzer = new MoodAnalyzerClass();
            string result = moodAnalyzer.AnalyzerMethod();
            Assert.AreEqual(expected,result);
;        }
    }
}
