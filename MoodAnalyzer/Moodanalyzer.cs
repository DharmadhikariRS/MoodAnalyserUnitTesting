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

    }
}
