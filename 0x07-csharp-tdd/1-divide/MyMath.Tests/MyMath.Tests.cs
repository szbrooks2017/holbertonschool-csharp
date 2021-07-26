using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    ///<summary>Tests for Divide</summary>
    public class MatrixTests
    {

        [Test]
        public void Test1()
        {
            int[,] matrix = null;
            int n = 2;
            int[,] result = Matrix.Divide(matrix, n);
            Assert.AreEqual(null, result);
        }
    }
}