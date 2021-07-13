using System;

namespace SemplForIDisposable
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Program is starting");

			//Test();
			Test2(0,1);

			Console.WriteLine("Progrm is finish");
		}

		public static void Test(int x , int y )
		{
			
			Person p = null;

			try
			{
				p = new Person() { Name = "Petro" };
				Console.WriteLine($"{p.Name} is not Dispoused");
				int a = y / x;
				
			}
			finally
			{
				Console.WriteLine("finally");
				if (p != null)
				{
					p.Dispose();
				}
			}
		}

		public static void Test2(int x, int y)
		{
			using (var p = new Person() { Name = "Andrei"})
			{
				Console.WriteLine($"{p.Name} is in worcing");
				int a = y / x;

			}
			Console.WriteLine($"Method worc continue");
		}
	}
}
