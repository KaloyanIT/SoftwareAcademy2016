using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mines
{
	public class Mine
	{
		public class Point
		{
			string name;
			int points;

			public string Name
			{
				get { return this.name; }
				set { this.name = value; }
			}

			public int Points
			{
				get { return this.points; }
				set { this.points = value; }
			}

			public Point() { }

			public Point(string name, int points)
			{
				this.name = name;
				this.points = points;
			}
		}

		static void Main(string[] arguments)
		{
			string command = string.Empty;
			char[,] field = CreatePlayingField();
			char[,] bombs = PutBombsOnField();
			int counter = 0;
			bool thunder = false;
			List<Point> championsList = new List<Point>(6);
			int row = 0;
			int cow = 0;
			bool flag = true;
			const int maxPoints = 35;
			bool flag2 = false;

			do
			{
				if (flag)
				{
					Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
					" Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
					MakeTheBoard(field);
					flag = false;
				}
				Console.Write("Daj red i kolona : ");
				command = Console.ReadLine().Trim();
				if (command.Length >= 3)
				{
					if (int.TryParse(command[0].ToString(), out row) &&
					int.TryParse(command[2].ToString(), out cow) &&
						row <= field.GetLength(0) && cow <= field.GetLength(1))
					{
						command = "turn";
					}
				}
				switch (command)
				{
					case "top":
						MakeResultsList(championsList);
						break;
					case "restart":
						field = CreatePlayingField();
						bombs = PutBombsOnField();
						MakeTheBoard(field);
						thunder = false;
						flag = false;
						break;
					case "exit":
						Console.WriteLine("4a0, 4a0, 4a0!");
						break;
					case "turn":
						if (bombs[row, cow] != '*')
						{
							if (bombs[row, cow] == '-')
							{
								YouAreOnMove(field, bombs, row, cow);
								counter++;
							}
							if (maxPoints == counter)
							{
								flag2 = true;
							}
							else
							{
								MakeTheBoard(field);
							}
						}
						else
						{
							thunder = true;
						}
						break;
					default:
						Console.WriteLine("\nGreshka! nevalidna Komanda\n");
						break;
				}
				if (thunder)
				{
					MakeTheBoard(bombs);
					Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
						"Daj si niknejm: ", counter);
					string niknejm = Console.ReadLine();
					Point t = new Point(niknejm, counter);
					if (championsList.Count < 5)
					{
						championsList.Add(t);
					}
					else
					{
						for (int i = 0; i < championsList.Count; i++)
						{
							if (championsList[i].Points < t.Points)
							{
								championsList.Insert(i, t);
								championsList.RemoveAt(championsList.Count - 1);
								break;
							}
						}
					}
					championsList.Sort((Point r1, Point r2) => r2.Name.CompareTo(r1.Name));
					championsList.Sort((Point r1, Point r2) => r2.Points.CompareTo(r1.Points));
					MakeResultsList(championsList);

					field = CreatePlayingField();
					bombs = PutBombsOnField();
					counter = 0;
					thunder = false;
					flag = true;
				}
				if (flag2)
				{
					Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
					MakeTheBoard(bombs);
					Console.WriteLine("Daj si imeto, batka: ");
					string imeee = Console.ReadLine();
					Point to4kii = new Point(imeee, counter);
					championsList.Add(to4kii);
					MakeResultsList(championsList);
					field = CreatePlayingField();
					bombs = PutBombsOnField();
					counter = 0;
					flag2 = false;
					flag = true;
				}
			}
			while (command != "exit");
			Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
			Console.WriteLine("AREEEEEEeeeeeee.");
			Console.Read();
		}

		private static void MakeResultsList(List<Point> points)
		{
			Console.WriteLine("\nTo4KI:");
			if (points.Count > 0)
			{
				for (int i = 0; i < points.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} kutii",
						i + 1, points[i].Name, points[i].Points);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("prazna klasaciq!\n");
			}
		}

		private static void YouAreOnMove(char[,] field,
			char[,] bombs, int row, int cow)
		{
			char bombsCount = CalculateCurrentRowsAndCols(bombs, row, cow);
			bombs[row, cow] = bombsCount;
			field[row, cow] = bombsCount;
		}

		private static void MakeTheBoard(char[,] board)
		{
			int rows = board.GetLength(0);
			int cols = board.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < rows; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < cols; j++)
				{
					Console.Write(string.Format("{0} ", board[i, j]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] CreatePlayingField()
		{
			int boardRows = 5;
			int boardColumns = 10;
			char[,] board = new char[boardRows, boardColumns];
			for (int i = 0; i < boardRows; i++)
			{
				for (int j = 0; j < boardColumns; j++)
				{
					board[i, j] = '?';
				}
			}

			return board;
		}

		private static char[,] PutBombsOnField()
		{
			int rows = 5;
			int cows = 10;
			char[,] playingField = new char[rows, cows];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cows; j++)
				{
					playingField[i, j] = '-';
				}
			}

			List<int> resultList = new List<int>();
			while (resultList.Count < 15)
			{
				Random random = new Random();
				int asfd = random.Next(50);
				if (!resultList.Contains(asfd))
				{
					resultList.Add(asfd);
				}
			}

			foreach (int i2 in resultList)
			{
				int col = (i2 / cows);
				int row = (i2 % cows);
				if (row == 0 && i2 != 0)
				{
					col--;
					row = cows;
				}
				else
				{
					row++;
				}
				playingField[col, row - 1] = '*';
			}

			return playingField;
		}

		private static void CalculateField(char[,] field)
		{
			int fieldCols = field.GetLength(0);
			int fieldRows = field.GetLength(1);

			for (int i = 0; i < fieldCols; i++)
			{
				for (int j = 0; j < fieldRows; j++)
				{
					if (field[i, j] != '*')
					{
						char rowsAndColsCounter = CalculateCurrentRowsAndCols(field, i, j);
						field[i, j] = rowsAndColsCounter;
					}
				}
			}
		}

		private static char CalculateCurrentRowsAndCols(char[,] field, int rows, int cols)
		{
			int currentCount = 0;
			int currentRows = field.GetLength(0);
			int currentCols = field.GetLength(1);

			if (rows - 1 >= 0)
			{
				if (field[rows - 1, cols] == '*')
				{ 
					currentCount++; 
				}
			}
			if (rows + 1 < currentRows)
			{
				if (field[rows + 1, cols] == '*')
				{ 
					currentCount++; 
				}
			}
			if (cols - 1 >= 0)
			{
				if (field[rows, cols - 1] == '*')
				{ 
					currentCount++;
				}
			}
			if (cols + 1 < currentCols)
			{
				if (field[rows, cols + 1] == '*')
				{ 
					currentCount++;
				}
			}
			if ((rows - 1 >= 0) && (cols - 1 >= 0))
			{
				if (field[rows - 1, cols - 1] == '*')
				{ 
					currentCount++; 
				}
			}
			if ((rows - 1 >= 0) && (cols + 1 < currentCols))
			{
				if (field[rows - 1, cols + 1] == '*')
				{ 
					currentCount++; 
				}
			}
			if ((rows + 1 < currentRows) && (cols - 1 >= 0))
			{
				if (field[rows + 1, cols - 1] == '*')
				{ 
					currentCount++; 
				}
			}
			if ((rows + 1 < currentRows) && (cols + 1 < currentCols))
			{
				if (field[rows + 1, cols + 1] == '*')
				{ 
					currentCount++; 
				}
			}
			return char.Parse(currentCount.ToString());
		}
	}
}
