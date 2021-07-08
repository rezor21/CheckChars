using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckChars;

namespace TestCheckChars
{
    [TestClass]
    public class TestChecker
    {
        [TestMethod]
        public void TestCheckStringA()
        {
            string testString = "zdanie z ";
            char[] polishChars = { '¿', 'Ÿ', 'æ', 'ñ', 'ó', '³', 'ê', '¹', 'œ' };

            foreach(char polishChar in polishChars)
            {
                Assert.IsTrue(Checker.TestString(testString + polishChar));
            }

        }
    }
}
