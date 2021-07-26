using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    ///<summary>Tests Add()</summary>
    public class AddTests
    {
        [Test]
        public void Add_postive()
        {
            int result = Operations.Add(98, 2);
            Assert.AreEqual(100, result);
        }
    }
}