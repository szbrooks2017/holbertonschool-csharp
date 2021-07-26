using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    ///<summary> Tests for palindrome</summary>
    public class StrTests
    {
        [Test]
        public void Test1()
        {
            string s = "";
            bool result = Str.IsPalindrome(s);
            Assert.AreEqual(true, result);
        }
        [Test]
        public void Test2()
        {
            string s = "Taco cat";
            bool result = Str.IsPalindrome(s);
            Assert.AreEqual(true, result);
        }
    }
}