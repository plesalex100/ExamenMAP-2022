using System;

// Ples = {P = 80, l = 108, e = 101, s = 115} = {80 % 4, 108 % 5, 101 % 8, 115 % 3} = {0, 3, 5, 1} = Problemele 1, 14, 16, 10

namespace Problema_1
{
	class Program
	{
		static void Main(string[] args)
		{
			int n, m, val;
			int[,] a = new int[51, 51];

			n = Convert.ToInt32(Console.ReadLine());
			m = Convert.ToInt32(Console.ReadLine());

			for(int i = 1; i <= n; i++)
				for(int j = 1; j <= m; j++)
					a[i, j] = Convert.ToInt32(Console.ReadLine());

			val = a[n, m];

			for(int i = 1; i <= n; i++)
				a[i, 1] = a[i, m] = val;

			for (int i = 1; i <= m; i++)
				a[1, i] = a[n, i] = val;

			for (int i = 1; i <= n; i++)
            {
				for (int j = 1; j <= m; j++)
					Console.Write($"{a[i, j]} ");
				Console.WriteLine();
			}
		}
	}
}
