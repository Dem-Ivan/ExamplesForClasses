using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SemplForBinarySerializer
{
	class Program
	{
		static void Main(string[] args)
		{
			string path = @"E:\VS\Подготовка к курсам\TestFiles";
			var clientN1 = new Client("Petr", 323);

			var binFormatter = new BinaryFormatter();
			List<Client> clients = GetClients();

			using (var fileStream = new FileStream($"{path}\\binSerializer.txt", FileMode.OpenOrCreate))
			{
				binFormatter.Serialize(fileStream, clients);
			}

			Console.WriteLine("The object was serialized");

			var deserializedClients = new List<Client>();
			using (var fileStream = new FileStream($"{path}\\binSerializer.txt", FileMode.OpenOrCreate))
			{
				deserializedClients = (List<Client>)binFormatter.Deserialize(fileStream);
			}

			foreach (var client in deserializedClients)
			{
				Console.WriteLine($"client name = {client.Name}, his sum = {client.Sum}");
			}
		}

		private static List<Client> GetClients()
		{
			var random = new Random();
			var clients = new List<Client>();

			for (int i = 0; i < 10; i++)
			{
				clients.Add(new Client("Ivan"+i, random.Next(0, 100)));	
			}

			return clients;
		}
	}

}
