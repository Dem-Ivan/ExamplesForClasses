using System;

namespace SemplForBinarySerializer
{
	[Serializable]
	public class Client
	{
		public string Name { get; set; }
		public int Sum {get; private set;}

		public Client(string name, int sum)
		{
			Name = name;
			Sum = sum;
		}

		public void Addsum(int sum)
		{
			if (sum > 0)
			{
				Sum = Sum + sum;
			}
		}
	}
}
