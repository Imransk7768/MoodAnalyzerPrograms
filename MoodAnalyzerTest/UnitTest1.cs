using MoodAnalyzerPrograms;
using NUnit.Framework;

namespace MoodAnalyzerTest
{
    public class Tests
    {
        [Test]
        public void GivenInputIsString_WhenTestMoodAnalyzer_ShouldReturnReturnEmpty()
        {
            try
            {
                MoodAnalyzer analyse = new MoodAnalyzer("");
                string actual = analyse.AnalyzeMood();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "message is Empty");
            }
        }
        [Test]
        public void GivenInputIsString_WhenTestMoodAnalyzer_ShouldReturnReturnNull()
        {
            try
            {
                MoodAnalyzer analyse = new MoodAnalyzer(null);
                string actual = analyse.AnalyzeMood();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "message is null");
            }
        }
    }
}