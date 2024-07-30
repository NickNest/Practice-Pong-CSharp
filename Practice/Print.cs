using System;
namespace Practice
{
	public class Print
	{
		public static void PrintFieldGraphic(Ball ball, Racket rackets, int screenX, int screenY)
		{
			Console.SetCursorPosition(0, 0);
			Console.CursorVisible = false;
			for (int y = 0; y < screenY; y++)
			{
				for (int x = 0; x < screenX; x++)
				{
					if (y == 0 || y == screenY - 1) Console.Write("-");
					else if (x == 0 || x == screenX - 1) Console.Write("|");
					else if (ball.cordX == x && ball.cordY == y) Console.Write("o");
					else if (x == 1 && (rackets.leftCord <= y && rackets.leftCord + rackets.size > y)) Console.Write("]");
					else if (x == screenX - 2 && (rackets.rightCord <= y && rackets.rightCord + rackets.size > y)) Console.Write("[");
					else if (x == screenX / 2) Console.Write(":");
					else Console.Write(" ");
				}
				Console.WriteLine();
			}
		}
		public static void PrintPlayersScore(Score score)
		{
			Console.WriteLine($"Left player score: {score.leftPlayerScore} | Right player score: {score.rightPlayerScore}");
		}
	}
}

