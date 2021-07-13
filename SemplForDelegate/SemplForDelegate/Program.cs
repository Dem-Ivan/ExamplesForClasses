using System;

namespace SemplForDelegate
{
	class Program
	{
		private delegate int Calk(int f, int g);
		static void Main(string[] args)
		{
			Calk calk = Summ;

			calk += Sub;

			calk(6, 5);

			calk.Invoke(6, 5);

			Calk calk1 = delegate (int s, int p)
			{
				return Sub(s, p);
			};

			calk1(4, 3);

			Calk calk2 = (x , y) => y/x;
			var res = calk2(2, 20);
			Console.WriteLine(res);
		}

		public static int Summ(int x, int y)
		{
			var res = x + y;
			Console.WriteLine(res);
			return res;
		}

		public static int Sub(int a, int b)
		{
			var res = a - b;
			Console.WriteLine(res);
			return res;
		}
	}
}
