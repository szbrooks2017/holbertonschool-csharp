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
    }
}