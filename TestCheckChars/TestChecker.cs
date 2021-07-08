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
            char[] polishChars = { '�', '�', '�', '�', '�', '�', '�', '�', '�' };

            foreach(char polishChar in polishChars)
            {
                Assert.IsTrue(Checker.TestString(testString + polishChar));
            }

        }
    }
}
