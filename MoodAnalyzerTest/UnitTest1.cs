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
        public void GivenInputString_WhenTestMoodAnalyzer_ShouldReturnReturnNull()
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
        [Test]
        public void GivenMoodAnalyzer_MoodAnalyseObject()
        {
            object expected = new MoodAnalyzer();
            object obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyzerPrograms.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(obj);
        }
        [Test]
        public void GivenMoodAnalyseClassName_ShouldReturnObject_UsingParameterizedConstrctor()
        {
            object expected = new MoodAnalyzer("HAPPY");
            object obj = MoodAnalyzerFactory.CreateMoodAnalyzerUsingParameterizedConstrctor("MoodAnalyzerPrograms.MoodAnalyzer", "MoodAnalyzer", "HAPPY");
            expected.Equals(obj);
        }
        [Test]
        public void GivenString_MoodShouldReturnHappy()
        {
            string expected = "Happy";
            string mood = MoodAnalyzerFactory.InvokeMoodAnalyzer("Happy", "AnalyzeMood");
            Assert.AreEqual(expected, mood);
        }
    }
}