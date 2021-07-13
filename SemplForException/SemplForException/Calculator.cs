using System;
using System.Collections.Generic;
using System.Text;

namespace SemplForException
{
	public class Calculator
	{
		private int[] _resultsMass = new int[10];
		private int _counter;
		public int GetDivision(int a, int b)
		{
			int result = 0;
			try
			{
				result = a / b;

			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine(e.Message);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

			return result;
		}

		public void SaveResult(int result)
		{
			try
			{
				_resultsMass[_counter] = result;
			}
			catch (IndexOutOfRangeException e)
			{
				Console.WriteLine(e.Message);
			}
			
			_counter++;
		}

		public int GetSavedResult(int position)
		{
			return _resultsMass[position];			
		}

	}
}
