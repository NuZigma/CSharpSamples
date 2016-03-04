//
//  Anagrams.cs
//
//  Author:
//       Nithin Mohan (nitrix-reloaded)
//
//  Copyright (c) 2016 - NitRiX-Reloaded
//
using System;
using System.Linq;


namespace DotNetConsoleApp
{
	/*
	 * 
	 * An anagram is a word formed from another by rearranging its letters, using all the original letters exactly once; for example, orchestra can be rearranged into carthorse.

		Write a function that checks if two words are each other's anagrams.

		For example, AreStringsAnagrams("momdad", "dadmom") should return true as arguments are anagrams.

	  *
	  */
	public class Anagrams
	{
		public Anagrams ()
		{
		}

		public static bool AreStringsAnagrams(string a, string b)
		{
			if (String.IsNullOrEmpty(a) || String.IsNullOrEmpty(b))
				return false;
			else if (a.Length != b.Length)
				return false;
			else if (a.Equals(b))
				return true;
			else
				return a.OrderBy(x => x).SequenceEqual(b.OrderBy(x => x));
		}

		public static void Test()
		{
			Console.WriteLine(AreStringsAnagrams("momdad", "dadmom"));
		}
	}
}

