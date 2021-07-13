using System;
using System.Collections.Generic;
using System.Text;

namespace SemplForJSONSerializer
{
	public 	class Client
	{
		public string Name { get; set; }
		public int Sum { get;  set; }

		public Client()
		{

		}
		public Client(string name, int sum)
		{
			Name = name;
			Sum = sum;
		}
	}
}
