using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace SemplForJSONSerializer
{
	public class Program
	{
		static string path = @"E:\VS\Подготовка к курсам\TestFiles";
		static async Task Main(string[] args)
		{
			

			using (var fileStream = new FileStream($"{path}//client.json", FileMode.OpenOrCreate))
			{
				var client = new Client("Olgaa", 5310);
				await JsonSerializer.SerializeAsync<Client>(fileStream, client);
			}

			using (var fileStream = new FileStream($"{path}//client.json", FileMode.OpenOrCreate))
			{
				var deserializedClient = await JsonSerializer.DeserializeAsync<Client>(fileStream);
				Console.WriteLine($"Client name - {deserializedClient.Name}, client sum = {deserializedClient.Sum}");
			}

			await Serialize(new Client("Semm", 512));
		}

		public static async Task Serialize(Client client)
		{
			using (var fileStream = new FileStream($"{path}//client.json", FileMode.OpenOrCreate))
			{				
				await JsonSerializer.SerializeAsync(fileStream, client);
			}
		}
	}
}
