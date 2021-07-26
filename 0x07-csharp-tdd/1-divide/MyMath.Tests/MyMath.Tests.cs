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
        [Test]
        public void Test2()
        {
            int[,] matrix = new int[,] {{6, 10}, {30, 40}, {4, 8}};
            int n = 2;
            int[,] result = Matrix.Divide(matrix, n);
            Assert.AreEqual(new int[,] {{3, 5}, {15, 20}, {2, 4}}, result);
        }
    }
}