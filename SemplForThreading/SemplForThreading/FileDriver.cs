using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace SemplForThreading
{
	public class FileDriver
	{
		List<Employee> _employees;
		object _locker;
		public FileDriver(List<Employee> employees, object locker)
		{
			_employees = employees;
			_locker = locker;
		}
		public void FileWriter()
		{
			string path = @"E:\VS\Подготовка к курсам\TestFiles";

			lock (_locker)
			{
				foreach (var employee in _employees)
				{
					using (FileStream fileStream = new FileStream($"{path}\\testForThreading.txt", FileMode.Append))
					{

						string str = $"Name: {employee.Name}, phone: {employee.Phone}.\n";
						var array = System.Text.Encoding.Default.GetBytes(str);
						fileStream.Write(array, 0, array.Length);

					}

					using (FileStream fileStream1 = new FileStream($"{path}\\testForThreading.txt", FileMode.Open))
					{
						byte[] array = new byte[fileStream1.Length];
						fileStream1.Read(array, 0, array.Length);
						string str = System.Text.Encoding.Default.GetString(array);

						Console.ForegroundColor = ConsoleColor.Blue;
						Console.WriteLine(str);
						Console.ResetColor();
					}

					Thread.Sleep(5000);
				}
			}
		}
	}
}
