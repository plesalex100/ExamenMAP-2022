using System;

// Ples = {P = 80, l = 108, e = 101, s = 115} = {80 % 4, 108 % 5, 101 % 8, 115 % 3} = {0, 3, 5, 1} = Problemele 1, 14, 16, 10

namespace Problema_10
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, m, k = 0;
            
            string line = Console.ReadLine();
			char[] seps = {' ', '.', ',', '?'};
			string[] input = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);
    
            n = int.Parse(input[0]);
            m = int.Parse(input[1]);

            if (m * 2 >= n)
                Console.Write("0 ");
            else
                Console.Write($"{n - 2 * m} ");

            while(k * (k - 1) / 2 < m)
            {
                k++;
            }

            Console.Write(n - k);
        }
    }
}
