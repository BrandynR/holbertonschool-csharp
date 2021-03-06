using System;

class MatrixMath
{
	/// <summary>Rotates a 2x2 matrix by a given angle</summary>
	/// <param name="matrix">The matrix to rotate.</param>
	/// <param name="angle">The angle to rotate the matrix by.</param>
	/// <returns>The new rotated, matrix, -1 on fail.</returns>
	public static double[,] Rotate2D(double[,] matrix, double angle)
	{
		double[,] failMatrix = new double[,] { { -1 } };
		double[,] newMatrix = new double[2, 2];
		double[,] rotateMatrix = new double[,] {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}};
		double prod;
		int i, j, k;

		if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
			return (failMatrix);

		for (i = 0; i < 2; i++)
		{
			for (j = 0; j < 2; j++)
			{
				prod = 0;
				for (k = 0; k < 2; k++)
				{
					prod = Math.Round(prod + (matrix[i, k] * rotateMatrix[k, j]), 2);
				}
				newMatrix[i, j] = prod;
			}
		}
		return (newMatrix);
	}
}
