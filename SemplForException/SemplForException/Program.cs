using System;

namespace SemplForException
{
	class Program
	{
		static void Main(string[] args)
		{
			Calculator calculator = new Calculator();


			int result;
			for (int i = 0; i < 11; i++)
			{
				result = calculator.GetDivision(45, i);
				Console.WriteLine($"the resulr = {result}");
				calculator.SaveResult(result);
			}

			for (int i = 0; i < 9; i++)
			{
				Console.WriteLine(calculator.GetSavedResult(i));
			}

			
		}
	}
}
