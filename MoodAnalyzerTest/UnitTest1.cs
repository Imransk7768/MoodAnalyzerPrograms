using MoodAnalyzerPrograms;
using NUnit.Framework;

namespace MoodAnalyzerTest
{
    public class Tests
    {
        [Test]
        public void GivenInputString_WhenTestAnalyseMood_ShouldReturnSad()
        {
            MoodAnalyzer analyzer = new MoodAnalyzer("I am Sad");
            string actual = analyzer.AnalyseMood();
            Assert.AreEqual(actual, "sad");
        } 
        [Test]
        public void GivenInputString_WhenTestAnalyseMood_ShouldReturnHappy()
        {
            MoodAnalyzer analyzer = new MoodAnalyzer("I am Happy");
            string actual = analyzer.AnalyseMood();
            Assert.AreEqual(actual, "happy");
        }
    }
}