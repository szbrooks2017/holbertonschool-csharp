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
    }
}