using System;

namespace Equals_GetHashCode
{
	class Program
	{
		static void Main(string[] args)
		{
			TestEquals();
		}

		public static void TestEquals()
		{
			Figure f1 = new Figure(10, 20);
			Figure f2 = new Figure(15, 15);
			Figure f3 = new Figure(15, 15);
			Figure f4 = f1;

			bool isEqual = f1 == f2;
			Console.WriteLine(isEqual);

			isEqual = f3 == f2;
			Console.WriteLine(isEqual);

			isEqual = f3.Equals(f2);
			Console.WriteLine(isEqual);

			isEqual = f1.Equals(f2);
			Console.WriteLine(isEqual);

			isEqual = f1 == f4;
			Console.WriteLine(isEqual);
		}
	}
}
