using NUnit.Framework;

namespace MyMath.Tests
{
	[TestFixture]
	public class MatrixTests
	{
		[Test]
		public void Test1()
		{
			int[,] matrix = new int[2, 2] { { 6, 2 }, { 2, 4 } };
			int num = 2;

			int[,] output = Matrix.Divide(matrix, num);

			Assert.AreEqual(new int[2, 2] { { 3, 1 }, { 1, 2 } }, output);
		}
        [Test]
		public void Test2()
		{
			Assert.AreEqual(null, Matrix.Divide(null, 2));
		}
		[Test]
		public void Test3()
		{
			int[,] matrix = null;
			int num = 2;

			int[,] output = Matrix.Divide(matrix, num);

			Assert.AreEqual(null, output);
		}
        [Test]
		public void Test4()
		{
			int[,] matrix = new int[2, 2] { { 9, 3 }, { 6, 12 } };

			Assert.AreEqual(null, Matrix.Divide(matrix, 0));
		}
		[Test]
		public void Test5()
		{
			int[,] matrix = new int[2, 2] { { 6, 2 }, { 2, 4 } };
			int num = 0;

			int[,] output = Matrix.Divide(matrix, num);

			Assert.AreEqual(null, output);
		}
        [Test]
		public void Test6()
		{
            int[,] matrix = new int[2, 2] { { 0, 3 }, { 6, 12 } };

			Assert.AreEqual(new int[2, 2] { { 0, 1 }, { 2, 4 } }, Matrix.Divide(matrix, 3));
		}
	}
}
