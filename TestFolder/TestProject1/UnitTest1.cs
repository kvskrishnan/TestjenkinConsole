using NUnit.Framework;
using TestConsoleApp;

namespace TestProject1
{
    public class Tests
    {
        public Program objProgram { get; set; }
        public static string testString = "Hello World!";
        [SetUp]
        public void Setup()
        {
            objProgram = new Program();
        }

        [Test]
        public void Test1()
        {
            var result = objProgram.GetStudebntname();
            Assert.AreEqual(testString, result);
        }
    }
}