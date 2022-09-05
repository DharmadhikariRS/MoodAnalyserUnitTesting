using MoodAnalyzer;
namespace MoodAnalyzerTestCases
{
    public class Tests
    {
        Moodanalyzer moodanalyzer;
        [SetUp]
        public void Setup()
        {
            // moodanalyzer = new Moodanalyzer();
        }

        [Test]
        public void Given_Sad_Return_Sad_Default_constructor()
        {
            moodanalyzer = new Moodanalyzer();

            string messege = "I am in sad mood";

            string result = moodanalyzer.AnalysisUsinMoodWithDefaultConstructor(messege);
            Assert.AreEqual("SAD", result);
        }
        [Test]
        public void Given_Happy_Return_Happy_Default_constructor()
        {
            moodanalyzer = new Moodanalyzer();

            string messege = "I am in Happy mood";

            string result = moodanalyzer.AnalysisUsinMoodWithDefaultConstructor(messege);
            Assert.AreEqual("HAPPY", result);
        }
        [Test]
        public void Given_Sad_Return_Sad_Default_constructor_Parameterized()
        {
            string messege = "I am in Sad mood";

            moodanalyzer = new Moodanalyzer(messege);

            string result = moodanalyzer.AnalysisUsinMoodWithConstructorParameterized();
            Assert.AreEqual("SAD", result);
        }

        [Test]
        public void Given_Happy_Return_Happy_Default_constructor_Parameterized()
        {
            string messege = "I am in Happy mood";

            moodanalyzer = new Moodanalyzer(messege);

            string result = moodanalyzer.AnalysisUsinMoodWithConstructorParameterized();
            Assert.AreEqual("HAPPY", result);
        }
    }
}