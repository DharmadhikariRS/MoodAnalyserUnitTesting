using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class Moodanalyzer
    {
        public string message;
        public Moodanalyzer()
        {

        }
        public Moodanalyzer(string Messege)
        {
            this.message = Messege;
        }
        public string AnalysisUsinMoodWithDefaultConstructor(string sentence)
        {
            if (sentence.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
        public string AnalysisUsinMoodWithConstructorParameterized()
        {
            if (message.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
        //UC2

        public string AnalyseMoodException()
        {
            try
            {
                if (message.ToLower().Contains("sad"))

                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserNull("HAPPY");
            }
        }
        //UC3
        public string AnalyseMood()
        {
            try
            {
                if (message.ToLower().Contains("sad"))

                    return "SAD";
                else if (message.Equals(string.Empty))

                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MOOD, "Mood should not be empty");
                else return "HAPPY";

            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MOOD, "Mood should not be null");
            }
        }

    }
}
