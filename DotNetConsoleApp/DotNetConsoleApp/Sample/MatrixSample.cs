//
//  MatrixSample.cs
//
//  Author:
//       Nithin Mohan (nitrix-reloaded)
//
//  Copyright (c) 2016 - NitRiX-Reloaded
//

using System;

namespace DotNetConsoleApp
{
	public static class MatrixSample
	{
		static int[][] myMatrix ; 
		static int numberOfRows = 0;
		static int numberOfColumns = 0;


		public  static void StartMe()
		{
			Console.WriteLine ("---- START ----/n");
			Console.Write ("Enter number of rows: ");
			Int32.TryParse (Console.ReadLine (), out numberOfRows);


			Console.Write ("Enter number of columns: ");
			Int32.TryParse (Console.ReadLine (), out numberOfColumns);

			Init ();

			bool cont = true;

			//To continue with another search after completion of each search
			while (cont)
			{
				Console.Write ("\nEnter value to search for: ");

				int searchVal = 0;

				Int32.TryParse (Console.ReadLine (), out searchVal);

				Search (searchVal);

				Console.Write ("\nSearch for another or press 'x' to exit:: ");

				cont = Console.ReadKey ().Key != ConsoleKey.X; // checking x is pressed or not
			}

		}

		/* To initialite the matrix */
		private static void Init()
		{

			if (numberOfRows > 0 && numberOfColumns > 0) {

				myMatrix = new int[numberOfRows][]; //using a jagged array to provide flexiblity.

				for (int row = 0; row < numberOfRows; row++) {
					int[] tempArray = new int[numberOfColumns];

					for (int col = 0; col < numberOfColumns; col++) {
						int read = 0;
						Console.Write (String.Format (" Enter value for [{0}], [{1}] :", row+1, col+1));
						Int32.TryParse (Console.ReadLine (), out read);

						tempArray [col] = read;
					}

					myMatrix [row] = tempArray;
				}

			} 
			else {
				Console.WriteLine ("array dimensions are not set!");
			}

			Console.WriteLine ("Your matrix is initialized as:  ");

			for (int row = 0; row < numberOfRows; row++) 
			{
				Console.Write ("\n\t");
				for (int col = 0; col < numberOfColumns; col++) {
					Console.Write (String.Format ("[{0}]\t", myMatrix [row] [col]));
				}
			}

			Console.WriteLine ("\n");
		}

		/* To initiate the search */

		private static void Search(int searchValue)
		{

			bool found = false;
			int lookUpCount = 0;

			if (myMatrix != null && myMatrix.Length > 0) {
				for (int row = 0; row < numberOfRows; row++) {
					for (int col = 0; col < numberOfColumns; col++) {
						lookUpCount++;
						if (myMatrix [row] [col] == searchValue) {

							Console.WriteLine (String.Format ("Item found at [{0}][{1}] with {2} look-ups", row+1, col+1, lookUpCount));
							found = true;
							break;
						}
					}
				} 
			} else {
				Console.WriteLine ("array is empty, please initialize it first!");
			}


			if(!found )
				Console.WriteLine ("Item not found!");
		}


		public static void EndMe()
		{
			myMatrix = null;
			numberOfRows = 0;
			numberOfColumns = 0;
		}

	}
}

