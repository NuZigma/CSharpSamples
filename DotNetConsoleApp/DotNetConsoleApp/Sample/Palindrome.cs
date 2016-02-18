//
//  Palindrome.cs
//
//  Author:
//       Nithin Mohan (nitrix-reloaded)
//
//  Copyright (c) 2016 - NitRiX-Reloaded
//


using System;
using System.Text.RegularExpressions;


namespace DotNetConsoleApp
{
	/*
	 * 
	 * Write a function that checks if a given sentence is a palindrome. 
	 * A palindrome is a word, phrase, verse, or sentence that reads the same backward or forward. 
	 * Only the order of English alphabet letters (A-Z and a-z) should be considered, other characters should be ignored.
	 * Examples: 
		"abccba" = true
		"a man, a plan, a canal, panama" = true
		"aabbcc" = false
		"a quick brown fox" = false

 	*
 	*/
	public static class Palindrome
	{
		public static bool IsPalindrome(string str)
		{


			Regex rgx = new Regex("[^a-zA-Z]");
			str = rgx.Replace(str, "").ToLower();
			string rev = ""; //string [] words

			//Console.WriteLine(str);

			for(int i = str.Length-1; i >= 0; i--)     
			{
				rev += str[i];
			}

			//Console.WriteLine("Reversed - " + rev);

			if(str.ToLower() == rev.ToLower())
			{
				return true;

			}
			else
			{
				return false;
			}

		}


		public static void Test()
		{
			string testString = "Noel sees Leon.";
			Console.WriteLine(String.Format("{0} : Palindrome : {1},", testString, IsPalindrome(testString)));

			testString = "a man, a plan, a canal, panama";

			Console.WriteLine(String.Format("{0} : Palindrome : {1},", testString, IsPalindrome(testString)));
		}

	}
}



