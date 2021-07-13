using System;
using System.Collections.Generic;

namespace List_Dictionary
{
	class Program
	{
		static void Main(string[] args)
		{
			ExamplesList();
			ExampleDictionar();
		}

		public static void ExampleDictionar()
		{
			Dictionary<int, string> testDictionary = new Dictionary<int, string>
			{
				{5, "Sem" },
				{6 , "Pyt"},
				{8, "Ooo"}
			};

			testDictionary.Add(1, "Andru");
			testDictionary.Add(3, "Olga");
			testDictionary.Add(2, "Tom");
			testDictionary.Add(4, "Tom");
			WriteDictionary(testDictionary);

			Console.WriteLine(testDictionary[3]);

			testDictionary[3] = "Kimm";
			WriteDictionary(testDictionary);

			testDictionary.Remove(3);
			WriteDictionary(testDictionary);

			foreach (var item in testDictionary.Values)
			{
				Console.WriteLine(item);
			}
		}
		public static void WriteDictionary(Dictionary<int, string> testDictionary)
		{
			string s = null;

			foreach (var item in testDictionary)
			{
				s = s + item.Key + " : " + item.Value + ",   ";
			}
			Console.WriteLine(s);
			Console.WriteLine("-----");
			s = null;
		}

		public static void WriteList(List<int> testList) 
		{
			string s = null;

			foreach (var item in testList)
			{
				s = s + " " + item;
			}
			Console.WriteLine(s);
			Console.WriteLine("-----");
			s = null;
		}

		public static void ExamplesList()
		{
			List<int> testList = new List<int>() { 1, 2, 3, 3, 4 };

			testList.Add(7);
			WriteList(testList);

			testList.AddRange(new int[] { 5, 15, 5 });
			WriteList(testList);

			testList.Insert(3, 9);
			WriteList(testList);

			testList.Remove(5);
			WriteList(testList);

			testList.Sort();
			WriteList(testList);

			testList.Reverse();
			WriteList(testList);
		}
	}
}
