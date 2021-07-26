using NUnit.Framework;

namespace MyMath.Tests
{
    [TextFixture]
    public class OperationsTests
    {
        [Test]
        public void Add_postive()
        {
            int a = 98;
            int b = 2;
            int result = MyMath.Operations.Add(a,b);
            Assert.AreEqual(a + b, result);
        }
    }
}