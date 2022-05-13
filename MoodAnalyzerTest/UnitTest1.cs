using MoodAnalyzerPrograms;
using NUnit.Framework;

namespace MoodAnalyzerTest
{
    public class Tests
    {
        [Test]
        public void GivenInputString_WhenTestAnalyseMood_ShouldReturnSad()
        {
            MoodAnalyzer analyzer = new MoodAnalyzer();
            string actual = analyzer.AnalyseMood("I am Sad");
            Assert.AreEqual(actual, "Sad");
        } 
        [Test]
        public void GivenInputString_WhenTestAnalyseMood_ShouldReturnHappy()
        {
            MoodAnalyzer analyzer = new MoodAnalyzer();
            string actual = analyzer.AnalyseMood("I am Happy");
            Assert.AreEqual(actual, "Happy");
        }
    }
}