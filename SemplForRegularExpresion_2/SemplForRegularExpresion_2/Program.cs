using System;
using System.Text.RegularExpressions;

namespace SemplForRegularExpresion_2
{
	class Program
	{
		static void Main(string[] args)
		{
			string testStr = "В стране Ксанад благословенной," +
				"дворец построил Кублахан." +
				"Там Альф течет поток священный," +
				"скволь мглу пещер бездонных петой," +
				"стекает в сонный океан.";

			Regex regex = new Regex(@"(\w*)ан(\w*)");

			MatchCollection matches = regex.Matches(testStr);

			foreach (var item in matches)
			{
				Console.WriteLine(item);
			}
		}
	}
}
