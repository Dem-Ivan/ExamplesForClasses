using System;
using System.Collections.Generic;
using System.Text;

namespace SemplForIDisposable
{
	public class Person : IDisposable
	{
		public string Name { get; set; }
		public void Dispose()
		{
			Console.WriteLine($"The {Name} is dispouset");
		}
	}
}
