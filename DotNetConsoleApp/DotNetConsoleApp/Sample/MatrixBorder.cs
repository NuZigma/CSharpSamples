//
//  MatrixBorder.cs
//
//  Author:
//       Nithin Mohan (nitrix-reloaded)
//
//  Copyright (c) 2016 - NitRiX-Reloaded
//
using System;

namespace DotNetConsoleApp
{
	public class MatrixBorder
	{
		public MatrixBorder ()
		{
		}


		public static void Test()
		{

			const int N = 5;
			string[,] items = new string[5,5] {
				{"a", "b", "c", "d", "e"},
				{"f", "-", "-", "-", "g"},
				{"h", "-", "-", "-", "i"},
				{"j", "-", "-", "-", "k"},
				{"l", "m", "n", "o", "p"}

			};

			processNXNBorders (items, 5, 5);
		}

		public static void processNXNBorders(string[,] twoDArray, int dimonesize, int dimtwosize) {
			for (int i = 0; i < dimonesize; i++) {
				if (i == 0 || i == dimonesize-1) {
					// Process entire row
					for (int j = 0; j < dimtwosize; j++) {
						print(twoDArray[i,j]);
					}


				} 
				else {
					// Only first and last elements in this row.
					for (int j = 0; j < dimtwosize; j++) {
						if (j == 0 || j == dimtwosize - 1) {
							print(twoDArray[i, j]);
						}
						else 
						{
							print(" ");
						}
					}



				}

				Console.Write ("\n");
			}
		}

		public static void print(string val)
		{
			
			Console.Write (val);
		}

	}
}

