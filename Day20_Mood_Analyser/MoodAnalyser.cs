using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20_Mood_Analyser
{
   public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser()
        {

        }


        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        //Creating method for Analysing the mood
        public string AnalyseMood()
        {
            try
            {
                if (this.message==null)
                {
                    throw new MoodnullException("Mood can not be Null");
                }
                if (message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch(MoodnullException e)
            {
                Console.WriteLine("Exception" + e.Message);
            }
            return message;
        }
    }
}
