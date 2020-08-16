using System;

///<summary>Class for matrix math</summary>
class MatrixMath
{
	///<summary>adds two matrices and returns the resulting matrix</summary>
	///<return>the resulting matrix, or matrix containing -1</return>
	public static double[,] Add(double[,] matrix1, double[,] matrix2)
	{
		if (matrix1.GetLength(0) == 2 && matrix1.GetLength(1) == 2 &&
		matrix2.GetLength(0) == 2 && matrix2.GetLength(1) == 2)
		{
			double[,] result = {
				{0, 0},
				{0, 0}
			};
			result[0, 0] = matrix1[0, 0] + matrix2[0, 0];
			result[0, 1] = matrix1[0, 1] + matrix2[0, 1];
			result[1, 0] = matrix1[1, 0] + matrix2[1, 0];
			result[1, 1] = matrix1[1, 1] + matrix2[1, 1];
			return result;
		}
		else if (matrix1.GetLength(0) == 3 && matrix1.GetLength(1) == 3 &&
		matrix2.GetLength(0) == 3 && matrix2.GetLength(1) == 3)
		{
			double[,] result = {
				{0, 0, 0},
				{0, 0, 0},
				{0, 0, 0}
			};
			result[0, 0] = matrix1[0, 0] + matrix2[0, 0];
			result[0, 1] = matrix1[0, 1] + matrix2[0, 1];
			result[0, 2] = matrix1[0, 2] + matrix2[0, 2];
			result[1, 0] = matrix1[1, 0] + matrix2[1, 0];
			result[1, 1] = matrix1[1, 1] + matrix2[1, 1];
			result[1, 2] = matrix1[1, 2] + matrix2[1, 2];
			result[2, 0] = matrix1[2, 0] + matrix2[2, 0];
			result[2, 1] = matrix1[2, 1] + matrix2[2, 1];
			result[2, 2] = matrix1[2, 2] + matrix2[2, 2];
			return result;
		}
		return new double[,] { { -1 } };
	}
}
