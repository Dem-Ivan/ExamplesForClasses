using System;
using System.Collections.Generic;
using System.Text;

namespace OOPprinciples
{
	public class Person 
	{
		public string Name { get; set; }
		public string Phone { get; set; }

	
		public void DisplayData()
		{
			Console.WriteLine($"Name - {Name}, phone - {Phone}");
		}
	}
}
