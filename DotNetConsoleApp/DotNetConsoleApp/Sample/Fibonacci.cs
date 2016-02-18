//
//  Fibonacci.cs
//
//  Author:
//       Nithin Mohan (nitrix-reloaded)
//
//  Copyright (c) 2016 - NitRiX-Reloaded
//

using System;

namespace DotNetConsoleApp
{
	public static class Fibonacci
	{
		static Fibonacci ()
		{
		}

		public static long DoFibonacci(long n)
		{

			long a = 0;
			long b = 1;



			
			for (long i = 0; i < n; i++) {
				long iTemp 	= a;
				a 			= b;
				b 			= iTemp + a;
			}

			return b;
		}

		public static void Test()
		{
			Console.WriteLine ("Fibonacci Series\n");
			for (long i = 0; i < 10; i++) {
				Console.Write (String.Format(@"{0}, ", DoFibonacci (i) ));
			}
		}
	}
}

