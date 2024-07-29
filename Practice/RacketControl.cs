using System;
namespace Practice
{
	public class RacketControl
	{
		public static void MoveRacketControl(ref Racket rackets, ConsoleKey key, int screenY)
		{
			switch (key)
			{
				case ConsoleKey.A:
					if (rackets.leftCord > 1) rackets.leftCord--;
					break;
				case ConsoleKey.Z:
                    if (rackets.leftCord < screenY - 2) rackets.leftCord++;
                    break;
				case ConsoleKey.K:
                    if (rackets.rightCord > 1) rackets.rightCord--;
                    break;
				case ConsoleKey.M:
                    if (rackets.rightCord < screenY - 2) rackets.rightCord++;
                    break;
			}
		}
	}
}

