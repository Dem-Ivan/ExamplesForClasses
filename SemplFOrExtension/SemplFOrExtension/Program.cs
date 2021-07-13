using System;
using System.Collections.Generic;

namespace SemplFOrExtension
{
	class Program
	{
		static void Main(string[] args)
		{
			var samClients = CtreateClietsList();
			var clientsLow50 = samClients.GetPotentialDebtors();
			
			
		}

		public static List<Client> CtreateClietsList()
		{
			var random = new Random();
			var clients = new List<Client>();

			for (int i = 0; i < 10; i++)
			{
				var client = new Client("Sem", random.Next(0,100));
				clients.Add(client);
			}

			return clients;
		}
	}
}
