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

        [TestMethod]
        public void CheckHappyMood()
        {

            //Arrange
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am Any Mood");

            //Act
            string checkhappymood = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual("HAPPY", checkhappymood);
        }
    }
}