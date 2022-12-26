using System;

namespace Minesweeper
{
	class Program
	{
		static void Main(string[] args)
		{
			int width = int.Parse(args[0]);
			int height = int.Parse(args[1]);
			int mine = int.Parse(args[2]);

			var game = new Minesweeper(width, height, mine, new Random((int)DateTime.Now.Ticks));
			game.Init();

			string input = string.Empty;
			int x = 0;
			int y = 0;
			while (true)
			{
				Console.Clear();

				Console.WriteLine(game.Draw());
				Console.WriteLine();
				Console.WriteLine($"Command. (x: 0 ~ {game._width - 1}, y: 0 ~ {game._height - 1})");
				Console.WriteLine("o x y");
				Console.WriteLine("f x y");
				Console.WriteLine("c x y");
				Console.WriteLine("reset");
				Console.WriteLine("exit");
				Console.WriteLine();

				Console.Write("Input: ");

				input = Console.ReadLine();
				if (input == string.Empty)
				{
					continue;
				}
				else if (input.ToLower() == "exit")
				{
					break;
				}
				else if (input.ToLower() == "show")
				{
					Console.WriteLine();
					Console.WriteLine(game.ToString());
					Console.ReadLine();
					continue;
				}
				else if (input.ToLower() == "reset")
				{
					game = new Minesweeper(width, height, mine, new Random((int)DateTime.Now.Ticks));
					game.Init();
					continue;
				}
				else
				{
					string[] token = input.Split(" ");
					if (token.Length != 3)
					{
						Console.WriteLine("Argument Count Error.");
						Console.ReadLine();
						continue;
					}

					if (!int.TryParse(token[1], out x) || !(0 <= x && x < game._width))
					{
						Console.WriteLine("x Position Error.");
						Console.ReadLine();
						continue;
					}

					if (!int.TryParse(token[2], out y) || !(0 <= y && y < game._height))
					{
						Console.WriteLine("y Position Error.");
						Console.ReadLine();
						continue;
					}

					switch (token[0].ToLower())
					{
						case "o":
							if (!game.Open(x, y))
							{
								Console.WriteLine(game.ToString());
								Console.WriteLine("Lose");
								Console.ReadLine();
								game.Init();
							}
							break;

						case "f":
							if (!game.SetFlag(x, y))
							{
								Console.WriteLine(game.ToString());
								Console.WriteLine("Win");
								Console.ReadLine();
								game.Init();
							}
							break;

						case "c":
							if (!game.CancleFlag(x, y))
							{
								Console.WriteLine(game.ToString());
								Console.WriteLine("Win");
								Console.ReadLine();
								game.Init();
							}
							break;

						default:
							Console.WriteLine("Command Error.");
							Console.ReadLine();
							break;
					}
				}


			}
		}
	}
}
