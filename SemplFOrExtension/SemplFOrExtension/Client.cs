using System;
using System.Collections.Generic;
using System.Text;

namespace SemplFOrExtension
{
	public class Client
	{
		public string Name { get; set; }
		public int Sum { get; private set; }

		public Client(string name, int sum)
		{
			Name = name;
			Sum = sum;
		}
		public void AddSum(int sum)
		{
			if (sum > 0)
			{
				Sum = Sum + sum;
			}			
		}

	}
}
