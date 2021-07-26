using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    ///<summary> test for unique</summary>
    public class Tests
    {

        [Test]
        public void Test1()
        {
            string s = "";
            var result = Str.UniqueChar(s);
            Assert.AreEqual(-1, result);
        }
        [Test]
        public void Test2()
        {
            string s = "helloholberton";
            var result = Str.UniqueChar(s);
            Assert.AreEqual(8, result);
        }
        [Test]
        public void Test3()
        {
            string s = "hhht";
            var result = Str.UniqueChar(s);
            Assert.AreEqual(3, result);
        }
        [Test]
        public void Test4()
        {
            string s = "httt";
            var result = Str.UniqueChar(s);
            Assert.AreEqual(0, result);
        }
                [Test]
        public void Test5()
        {
            string s = "hhhhh";
            var result = Str.UniqueChar(s);
            Assert.AreEqual(-1, result);
        }
    }
}