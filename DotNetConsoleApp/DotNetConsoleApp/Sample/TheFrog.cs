//
//  TheFrog.cs
//
//
//  Author:
//       Nithin Mohan (nitrix-reloaded)
//
//  Copyright (c) 2016 - NitRiX-Reloaded
//
using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetConsoleApp
{

	/*
	 * 
	 A frog only moves forward, but it can move in steps 1 inch long or in jumps 2 inches long. A frog can cover the same distance using different combinations of steps and jumps.

		Write a function that calculates the number of different combinations a frog can use to cover a given distance.

		For example, a distance of 3 inches can be covered in three ways: step-step-step, step-jump, and jump-step.

	*/

	public class TheFrog
	{
		public TheFrog ()
		{
		}




		public static int NumberOfWays(int n)
		{
			return NoOfPermutaions(NoOfCombinations(n));
		}

		private static List<Tuple<int, int>> NoOfCombinations(int distance)
		{
			List<Tuple<int, int>> lst = new List<Tuple<int, int>>();
			for (int i = 0; i <= distance; i++)
				for (int j = 0; j <= distance; j++)
				{
					if ((i * 1 + j * 2) == distance) lst.Add(new Tuple<int, int>(i, j));
				}
			return lst;
		}

		private static int NoOfPermutaions(List<Tuple<int, int>> lst)
		{
			int Sum = 0;
			foreach (Tuple<int, int> itm in lst)
			{
				Sum += Convert.ToInt32(Factorial(itm.Item1 + itm.Item2) / Factorial(itm.Item1) / Factorial(itm.Item2)); //Formula: C(n,r)=n!/r!;
			}

			return Sum;
		}

		private static double Factorial(double num)
		{
			if (num <= 1)
				return 1;
			return num * Factorial(num - 1);
		}


		public static void Test()
		{
			Console.WriteLine(NumberOfWays(3));
		}
	}
}

