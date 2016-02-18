//
//  WordCount.cs
//
//  Author:
//       Nithin Mohan (nitrix-reloaded)
//
//  Copyright (c) 2016 - NitRiX-Reloaded
//

using System;
using System.Collections;
using System.Collections.Generic;

namespace DotNetConsoleApp
{
	public static class WordCount
	{
		static WordCount()
		{


		}


		public static void DoWordCount(string paragraph)
		{
			
			String[] words = paragraph.Split (' ');
			Dictionary<string, int> result = new Dictionary<string, int> ();

			for (int i = 0; i < words.Length; i++) {
			
				int iCount = 0; 
				string currentStr =  words [i];

				if (!result.ContainsKey (currentStr)) {
					for (int j = 1; j < words.Length; j++) {

						if (words [i] == words [j])
							iCount++;
					}


					if (i == 0 && iCount == 0)
						iCount++;
					
					result.Add (currentStr, iCount);
				}



			}


			foreach (var item in result.Keys) 
			{
				Console.WriteLine (String.Format (" Word : {0}, Count : {1}", item, result [item]));
			}


			//Console.ReadLine (); 

		}

		public static void Test()
		{
			String paragraph = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. ";

			DoWordCount (paragraph);
		}
	}
}

