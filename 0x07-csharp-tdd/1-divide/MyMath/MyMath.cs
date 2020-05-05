using System;

namespace MyMath
{
	///<summary>Class for Matrix</summary>
	public class Matrix
	{
		///<summary>Matrix division and returns the matrix</summary>
		public static int[,] Divide(int[,] matrix, int num)
		{
			if (num == 0)
			{
				Console.WriteLine("Num can not be 0");
				return null;
			}
			if (!matrix)
			{
				return null;
			}
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] = matrix[i, j] / num;
				}
			}
			return matrix;
		}
	}
}
