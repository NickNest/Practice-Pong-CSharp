﻿using System;
namespace Practice
{
	public class PrintField
	{
		public static void PrintFieldGraphic(Ball ball, Racket rackets, int screenX, int screenY)
		{
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
	}
}

