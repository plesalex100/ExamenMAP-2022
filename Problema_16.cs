using System;

// Ples = {P = 80, l = 108, e = 101, s = 115} = {80 % 4, 108 % 5, 101 % 8, 115 % 3} = {0, 3, 5, 1} = Problemele 1, 14, 16, 10

namespace Problema_16
{
	class Program
	{
		static void Main(string[] args)
		{
			int h, m, untilMin;

			string line = Console.ReadLine();
			char[] seps = {' ', '.', ',', '?'};
			string[] input = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);

			h = int.Parse(input[0]);
			m = int.Parse(input[1]);
			untilMin = int.Parse(input[2]);

			Console.WriteLine($"Ora curenta: ora {h} si {m} minute");
			Console.WriteLine($"Ora noua peste {untilMin} minute: ora {h + untilMin / 60} si {(m + untilMin) % 60} minute");
		}
	}
}
