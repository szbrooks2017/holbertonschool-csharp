using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    ///<summary> test for unique</summary>
    public class Tests
    {

        [Test]
        public void Test_no_string()
        {
            string s = "";
            var result = Str.UniqueChar(s);
            Assert.AreEqual(-1, result);
        }
        [Test]
        public void Test_middle_index()
        {
            string s = "helloholberton";
            var result = Str.UniqueChar(s);
            Assert.AreEqual(8, result);
        }
        [Test]
        public void Test_last_index()
        {
            string s = "hhht";
            var result = Str.UniqueChar(s);
            Assert.AreEqual(3, result);
        }
        [Test]
        public void Test_first_index()
        {
            string s = "httt";
            var result = Str.UniqueChar(s);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void Test_no_unique()
        {
            string s = "hhhhh";
            var result = Str.UniqueChar(s);
            Assert.AreEqual(-1, result);
        }
    }
}