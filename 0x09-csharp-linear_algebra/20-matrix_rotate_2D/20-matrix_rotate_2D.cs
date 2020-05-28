using System;

///<summary>Class for matrix math</summary>
class MatrixMath
{
	///<summary>method that rotates a square 2D matrix by a given angle in radians and returns the resulting matrix</summary>
	///<return>the result matrix or matrix containing -1</return>
	
	public static double[,] Rotate2D(double[,] matrix, double angle)
	{
		double[,] failMatrix = { { -1 } };
		double[,] newMatrix = new double[2, 2];
		double[,] rotateMatrix = { { Math.Cos(angle), Math.Sin(angle) }, { Math.Sin(angle) * -1, Math.Cos(angle) } };
		int i, j, k;
		double prod = 0;

		if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
			return (failMatrix);

		for (i = 0; i < 2; i++)
		{
			for (j = 0; j < 2; j++)
			{
				prod = 0;
				for (k = 0; k < 2; k++)
				{
					prod += Math.Round(matrix[i, k] * rotateMatrix[k, j], 2);
				}
				newMatrix[i, j] = prod;
			}
		}
		return (newMatrix);
	}
}
