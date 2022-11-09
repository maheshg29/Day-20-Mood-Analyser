using Day20_Mood_Analyser;


namespace TestProject1
{
    [TestClass]
    public class Tests
    {
       
        [TestMethod]
        public void CheckSadMood()
        {

            //Arrange
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am Sad Mood");

            //Act
            string checksadmood = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual("SAD", checksadmood);
        }
    }
}