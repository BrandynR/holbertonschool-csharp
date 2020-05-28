using System;

class MatrixMath
{
	/// <summary>shears a square 2D matrix by a given shear factor and returns the resulting matrix</summary>
	/// <param name="matrix">The matrix.</param>
	/// <param name="direction">The direction to shear.</param>
	/// <param name="factor">How much to shear by.</param>
	/// <returns>A new sheared matrix, -1 on fail.</returns>

	public static double[,] Shear2D(double[,] matrix, char direction, double factor)
	{
		double[,] fail = { { -1 } };
		double[,] new = new double[2, 2];
		double[,] shear;
		int i, j, k;
		double prod = 0;

		if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
			return (fail);

		if (direction == 'x')
			shear = new double[,] { { 1, 0 }, { factor, 1 } };
		else if (direction == 'y')
			shear = new double[,] { { 1, factor }, { 0, 1 } };
		else
			return (fail);

		for (i = 0; i < 2; i++)
		{
			for (j = 0; j < 2; j++)
			{
				prod = 0;
				for (k = 0; k < 2; k++)
				{
					prod += matrix[i, k] * shear[k, j];
				}
				new[i, j] = Math.Round(prod, 2);
			}
		}
		return (new);
	}
}
