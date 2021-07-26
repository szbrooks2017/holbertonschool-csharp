using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    ///</summary> tests for Max</summary>
    public class MaxTests
    {

        [Test]
        public void Test1()
        {
            List<int> num = null;
            int result = Operations.Max(num);
            Assert.AreEqual(0, result);
        }
    }
}