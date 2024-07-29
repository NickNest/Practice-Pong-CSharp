using System;
namespace Practice
{
	public class RacketControl
	{
		public static void MoveRacketControl(ref Racket rackets, ConsoleKey key, int screenY, int fieldBoardSize)
		{
			switch (key)
			{
				case ConsoleKey.A:
					if (rackets.leftCord > fieldBoardSize) rackets.leftCord--;
					break;
				case ConsoleKey.Z:
                    if (rackets.leftCord < screenY - rackets.size - fieldBoardSize) rackets.leftCord++;
                    break;
				case ConsoleKey.K:
                    if (rackets.rightCord > fieldBoardSize) rackets.rightCord--;
                    break;
				case ConsoleKey.M:
                    if (rackets.rightCord < screenY - rackets.size - fieldBoardSize) rackets.rightCord++;
                    break;
			}
		}
	}
}

