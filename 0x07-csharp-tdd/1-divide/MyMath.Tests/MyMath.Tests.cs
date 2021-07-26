using NUnit.Framework;

namespace MyMath.Tests
{
    public class MatrixTests
    {

        public void Test1()
        {
            int[,] matrix = null;
            int n = 2;
            int[,] result = Matrix.Divide(matrix, n);
            Assert.AreEqual(null, result);
        }
    }
}