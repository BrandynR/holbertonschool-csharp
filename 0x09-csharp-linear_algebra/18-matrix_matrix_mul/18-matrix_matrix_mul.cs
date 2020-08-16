using System;

///<summary>Class for matrix math</summary>
class MatrixMath
{
	///<summary>method that multiplies two matrices and returns the resulting matrix</summary>
	///<return>the resulting matrix, or matrix containing -1</return>
	public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
	{
		int mtrx1_row = matrix1.GetLength(0);
		int mtrx1_col = matrix1.GetLength(1);
		int mtrx2_row = matrix2.GetLength(0);
		int mtrx2_col = matrix2.GetLength(1);
		if (mtrx1_col == mtrx2_row)
		{
			double[,] result = new double[mtrx1_row, mtrx2_col];
			for (int i = 0; i < mtrx1_row; i++)
			{
				for (int j = 0; j < mtrx2_col; j++)
				{
					for (int k = 0; k < mtrx1_col; k++)
					{
						result[i, j] += matrix1[i, k] * matrix2[k, j];
					}
				}
			}
			return result;
		}
		return new double[,] { { -1 } };
	}
}
