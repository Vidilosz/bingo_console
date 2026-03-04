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
		public bool BingoEll()
		{
			for (int i = 0; i < 5; i++)
			{
				bool teljes = true;
				for (int j = 0; j < 5; j++)
					if (!jelolve[i, j])
						teljes = false;

				if (teljes) return true;
			}

			for (int j = 0; j < 5; j++)
			{
				bool teljes = true;
				for (int i = 0; i < 5; i++)
					if (!jelolve[i, j])
						teljes = false;

				if (teljes) return true;
			}

			bool atlo1 = true;
			for (int i = 0; i < 5; i++)
				if (!jelolve[i, i])
					atlo1 = false;

			if (atlo1) return true;

			bool atlo2 = true;
			for (int i = 0; i < 5; i++)
				if (!jelolve[i, 4 - i])
					atlo2 = false;

			return atlo2;
		}
		public void KartyaKiir()
		{
			Console.WriteLine(Nev + " kártyája:");

			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					if (i == 2 && j == 2)
						Console.Write(" X ");
					else if (jelolve[i, j])
						Console.Write($"{kartya[i, j],3}");
					else
						Console.Write("  0");

					Console.Write(" ");
				}
				Console.WriteLine();
			}
		}
	}
}
