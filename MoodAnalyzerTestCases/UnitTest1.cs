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

        [Test]
        //UC2
        public void Given_Null_Return_happy()
        {
            moodanalyzer = new Moodanalyzer();
            try
            {
                string Message = moodanalyzer.AnalyseMoodException();
            }
            catch (MoodAnalyserNull mood)
            {
                Assert.AreEqual("HAPPY", mood.Is_Happy);
            }
        }
        [Test]
        public void GiveMessage_WhenNull_UsingCustomException_shouldReturnNullMood()
        {

            moodanalyzer = new Moodanalyzer();
            try
            {
                string Message = moodanalyzer.AnalyseMood();
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.NULL_MOOD, exception.exceptionType);
            }
        }
        [Test]
        public void GiveMessage_WhenEmpty_UsingCustomException_shouldReturnEmptyMood()
        {

            moodanalyzer = new Moodanalyzer("");
            try
            {
                string Message = moodanalyzer.AnalyseMood();
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.EMPTY_MOOD, exception.exceptionType);
            }
        }
    }
}