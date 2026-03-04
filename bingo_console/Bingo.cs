using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bingo_console
{
	internal class Bingo
	{
		private string nev;
		private string[,] Kartya;
		private int[] Talalatok;

		public Bingo(string nev, string[,] kartya, int[] talalatok)
		{
			this.nev = nev;
			Kartya = kartya;
			Talalatok = talalatok;
		}

		public string Nev { get => nev; set => nev = value; }
		public string[,] Kartya1 { get => Kartya; set => Kartya = value; }
		public int[] Talalatok1 { get => Talalatok; set => Talalatok = value; }

		public void SorsoltSzamotJelol(int szam)
		{
			for (int i = 0; i < Kartya.GetLength(0); i++)
			{
				for (int j = 0; j < Kartya.GetLength(1); j++)
				{
					if (Kartya[i, j] == szam.ToString())
					{
						Talalatok[i]++;
						Kartya[i, j] = "X";
					}
				}
			}
			Console.WriteLine($"{nev} jelölte a {szam} számot.");
		}
	}
}
