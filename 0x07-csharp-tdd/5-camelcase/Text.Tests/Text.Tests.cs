using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    ///<summary> tests for camelcase()</summary>
    public class Tests
    {

        [Test]
        public void Test_empty_string()
        {
            string s = "";
            var result = Str.CamelCase(s);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void Test_mulitiple_words()
        {
            string s = "testTestForJustLet";
            var result = Str.CamelCase(s);
            Assert.AreEqual(5, result);
        }
        [Test]
        public void Test_one_word()
        {
            string s = "test";
            var result = Str.CamelCase(s);
            Assert.AreEqual(1, result);
        }
                [Test]
        public void Test_two_words()
        {
            string s = "testTest";
            var result = Str.CamelCase(s);
            Assert.AreEqual(2, result);
        }
    }
}