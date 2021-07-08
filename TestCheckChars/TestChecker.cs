using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckChars;

namespace TestCheckChars
{
    [TestClass]
    public class TestChecker
    {
        [TestMethod]
        public void TestCheckString()
        {
            string testString = "zdanie z ¹";

            Assert.IsTrue(Checker.TestString(testString));
        }
    }
}
