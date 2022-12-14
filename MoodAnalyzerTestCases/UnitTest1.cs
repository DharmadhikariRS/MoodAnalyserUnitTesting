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
        /// <summary>
        /// UC4
        /// </summary>

        [Test]
        public void Using_Reflection_Given_ClassName_Return_Object()
        {
            moodanalyzer = new Moodanalyzer();
            string ClassName = "MoodAnalyzer.Moodanalyzer";
            object obj = MoodAnalyserFactory.CreateMoodAnalyser(ClassName, "Moodanalyzer");
            obj.Equals(moodanalyzer);
        }
        [Test]
        public void Using_Reflection_Given_Improper_ClassName_Return_No_Class_Found()
        {
            try
            {
                moodanalyzer = new Moodanalyzer();
                string ClassName = "MoodAnalyzr.moodAnalyzr";
                object obj = MoodAnalyserFactory.CreateMoodAnalyser(ClassName, "moodAnalyzr");
                obj.Equals(moodanalyzer);
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(exception.exceptionType, MoodAnalyserException.ExceptionType.NO_CLASS_FOUND);
            }

        }
        [Test]
        public void Using_Reflection_Given_Improper_Constructor_Name_Return_No_Constructor_Found()
        {
            try
            {
                moodanalyzer = new Moodanalyzer();
                string ClassName = "MoodAnalyzer.Moodanalyze";
                object obj = MoodAnalyserFactory.CreateMoodAnalyser(ClassName, "Moodanalyer");
                obj.Equals(moodanalyzer);
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(exception.exceptionType, MoodAnalyserException.ExceptionType.NO_CONSTRUCTOR);
            }

        }
        /// <summary>
        /// UC5
        /// </summary>
        [Test]
        public void Using_Reflection_Given_ClassName_Return_Object_Parametrised_Constructor()
        {
            moodanalyzer = new Moodanalyzer("I am in Happy Mood");
            string ClassName = "MoodAnalyzer.Moodanalyzer";
            object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParametrisedConstructor(ClassName, "Moodanalyzer");
            obj.Equals(moodanalyzer);
        }
        [Test]
        public void Using_Reflection_Given_Improper_ClassName_Return_No_Class_Found_Parametrerised_Constructor()
        {
            try
            {
                moodanalyzer = new Moodanalyzer("I am in Happy Mood");
                string ClassName = "MoodAnalyze.Moodanalyze";
                object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParametrisedConstructor(ClassName, "Moodanalyzer");
                obj.Equals(moodanalyzer);
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(exception.exceptionType, MoodAnalyserException.ExceptionType.NO_CLASS_FOUND);
            }
        }
        [Test]
        public void Using_Reflection_Given_proper_ClassName_Return_No_Class_Found_Parametrerised_Constructor()
        {
            try
            {
                moodanalyzer = new Moodanalyzer("I am in Happy Mood");
                string ClassName = "MoodAnalyzer.Moodanalyzer";
                object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParametrisedConstructor(ClassName, "Moodanalyze");
                obj.Equals(moodanalyzer);
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(exception.exceptionType, MoodAnalyserException.ExceptionType.NO_CONSTRUCTOR);
            }
        }

    }
}