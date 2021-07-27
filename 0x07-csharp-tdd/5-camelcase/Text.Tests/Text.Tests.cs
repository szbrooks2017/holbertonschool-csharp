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
            string s = "testTestForJust";
            var result = Str.CamelCase(s);
            Assert.AreEqual(4, result);
        }
    }
}