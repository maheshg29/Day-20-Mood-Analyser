namespace Day20_Mood_Analyser
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Day 20 Mood Analyser Problem");
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am Sad Mood");
            string checkmood = moodAnalyser.AnalyseMood();
            Console.WriteLine(checkmood);
        }
    }
}
