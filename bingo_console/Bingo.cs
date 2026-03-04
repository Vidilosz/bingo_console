using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bingo_console
{
	internal class Bingo
	{
		public string Nev { get; private set; }
		private int[,] kartya;
		private bool[,] jelolve;

		public Bingo(string nev, int[,] szamok)
		{
			Nev = nev;
			kartya = szamok;
			jelolve = new bool[5, 5];

			jelolve[2, 2] = true;
		}
		public void SorsoltSzamotJelol(int szam)
		{
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					if (kartya[i, j] == szam)
					{
						jelolve[i, j] = true;
					}
				}
			}
		}
	}
}
