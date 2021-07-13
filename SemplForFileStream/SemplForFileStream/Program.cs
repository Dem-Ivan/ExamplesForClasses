using System;
using System.IO;

namespace SemplForFileStream
{
	class Program
	{
		static void Main(string[] args)
		{
			string path = @"E:\VS\Подготовка к курсам\TestFiles";
			DirectoryInfo directoryInfo = new DirectoryInfo(path);

			if (!directoryInfo.Exists)
			{
				directoryInfo.Create();
			}

			Console.WriteLine("ВВедите строку для записи в файл: ");
			string text = Console.ReadLine();


			using (FileStream fileStream = new FileStream($"{path}\\test№1.txt", FileMode.OpenOrCreate))
			{
				var array = System.Text.Encoding.Default.GetBytes(text);
				fileStream.Write(array, 0, array.Length);
				Console.WriteLine("Текст записан.");
			}

			using (FileStream fileStream1 = File.OpenRead($"{path}\\test№1.txt"))
			{
				byte[] array = new byte[fileStream1.Length];
				fileStream1.Read(array, 0, array.Length);

				string textFromFile = System.Text.Encoding.Default.GetString(array);
				Console.WriteLine($"Текста из файла -  {textFromFile}");
			}

			Console.ReadLine();
		}

		public static string WriteReader(string text)
		{
			string path = @"E:\VS\Подготовка к курсам\TestFiles";

			using (FileStream fileStream = new FileStream($"{path}\\testForReflection.txt", FileMode.OpenOrCreate))
			{
				var array = System.Text.Encoding.Default.GetBytes(text);
				fileStream.Write(array, 0, array.Length);				
			}

			using (FileStream fileStream1 = File.OpenRead($"{path}\\testForReflection.txt"))
			{
				byte[] array = new byte[fileStream1.Length];
				fileStream1.Read(array, 0, array.Length);

				string textFromFile = System.Text.Encoding.Default.GetString(array);
				return $"Текста из файла -  {textFromFile}";
			}			
		}
	}
}
