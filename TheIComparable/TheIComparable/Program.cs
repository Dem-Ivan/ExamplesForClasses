using System;
using System.Collections.Generic;

namespace TheIComparable
{
	class Program
	{
		static void Main(string[] args)
		{
			var testList = GetTestData();
			
			foreach (var item in testList)
			{
				Console.WriteLine(item.GetSquare());
			}

			Array.Sort(testList);
			
			foreach (var item in testList)
			{
				Console.WriteLine(item.GetSquare());
			}
			Console.ReadKey();
		}

		private static Rectangl[] GetTestData()
		{
			Rectangl[] testData = new Rectangl[15];

			for (int i = 0; i < 15; i++)
			{
				testData[i] = new Rectangl { Name = "Rectangl_" + i, Height = 100/(i+1), Width = 100/(i+1) };
			}

			return testData;
		}
	}
}
