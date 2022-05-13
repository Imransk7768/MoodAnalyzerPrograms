namespace MoodAnalyzerPrograms
{
    public class MoodAnalyzer
    {
        public string AnalyseMood(string message)
        {
            if (message.ToLower().Contains("sad"))
            {
                return "Sad";
            }
            else
            {
                Console.WriteLine("I am Happy");
                return "Happy";
            }
        }
    }
}
