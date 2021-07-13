using System;
using System.Collections.Generic;
using System.Text;

namespace SemplForGenericType
{
	public class User <T>
	{
		public T UserId { get; set; }

		public void Shift<K>(K a, K b)
		{
			Console.WriteLine("a = " + a + " b = " + b);
			var c = a;
			a = b;
			b = c;

			Console.WriteLine("a = " + a + " b = " + b);
		}

	}
}
