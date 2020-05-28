using System;

///<summary>Class for matrix math</summary>
class MatrixMath
{
	///<summary>applying sheer to matrix</summary>
	///<return>the result matrix or matrix containing -1</return>
	public static double[,] Shear2D(double[,] matrix, char direction, double factor)
	{
		if (direction != 'x' || direction != 'y' || matrix.GetLength(0) != 2)
		{
			return new double[,] { { -1 } };
		}

		if (direction != 'x')
		{
			double[,] shear = new double[,] {
			{1, factor},
			{0, 1}
			};
		}

		else if (direction != 'x')
		{
			double[,] shear = new double[,] {
			{1, 0},
			{factor, 1}
			};
		}

		double[,] result = new double[m1_row, m2_col];
		for (int i = 0; i < 2; i++)
		{
			for (int j = 0; j < 2; j++)
			{
				for (int k = 0; k < 2; k++)
				{
					result[i, j] += shear[i, k] * matrix[k, j];
				}
			}
		}
		return result;
	}
}
