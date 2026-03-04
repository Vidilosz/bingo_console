namespace bingo_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int[,] szamok = new int[5, 5];
			string[] sorok = File.ReadAllLines("Andi.txt");

			for (int i = 0; i < 5; i++)
			{
				string[] darabok = sorok[i].Split(';');

				for (int j = 0; j < 5; j++)
				{
					if (darabok[j] == "X")
					{
						szamok[i, j] = 0;  
					}
					else
					{
						szamok[i, j] = int.Parse(darabok[j]);
					}
				}
			}

		}

	}
}
