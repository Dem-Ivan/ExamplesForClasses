using System;
using System.Collections.Generic;

namespace SemplFOrExtension
{
	public static class ListExtensions
	{

		public static List<Client> GetPotentialDebtors(this List<Client> clients)
		{
			var deptorsList = clients.FindAll(c => c.Sum <= 50);

			Console.ForegroundColor = ConsoleColor.Red;
			foreach (var client in deptorsList)
			{
				Console.WriteLine($"Client nam - {client.Name}, sum = {client.Sum}");
			}
			Console.ResetColor();

			return deptorsList;
		}
	}
}
