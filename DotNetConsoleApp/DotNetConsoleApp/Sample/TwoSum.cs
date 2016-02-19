//
//  TwoSum.cs
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
	 Write a function that, given a list and a target sum, returns zero-based indices of any two distinct elements whose sum is equal to the target sum. 
	 If there are no such elements, the function should return null.

			For example, FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12) should return any of the following tuples of indices:

				1, 4 (3 + 9 = 12)
				2, 3 (5 + 7 = 12)
				3, 2 (7 + 5 = 12)
				4, 1 (9 + 3 = 12)

	 *
	 */

	public class TwoSum
	{
		public TwoSum ()
		{
		}


		public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
		{
			var result = from n1 in list
				from n2 in list
					where n1 + n2 == sum
				select new Tuple<int, int>(list.IndexOf(n1), list.IndexOf(n2));
			return result.FirstOrDefault();
		}

		public static void Test()
		{
			Tuple<int, int> indices = FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12);
			Console.WriteLine(indices.Item1 + " " + indices.Item2);
		}

	}
}

