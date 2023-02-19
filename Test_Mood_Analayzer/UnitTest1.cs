using NUnit.Framework;
using Mood_Analyzer;

namespace Test_Mood_Analayzer
{
    public class Tests
    {
        Mood mood;
        [SetUp]
        public void Setup()
        {
            mood = new Mood();
        }

        [TestCase("sad")]
        [TestCase("SAD")]
        [TestCase("i am sad")]
        [TestCase("i am in sad mood")]
        [TestCase("I AM SAD")]
        public void test_TO_checkMood(string moodinput)
        {
             mood= new Mood();
            string expected = "SAD";
            var actual=mood.checkMood(expected);
            Assert.AreEqual(expected,actual);
        }
    }
}