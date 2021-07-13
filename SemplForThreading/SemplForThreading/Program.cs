using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace SemplForThreading
{
	class Program
	{
		static List<Employee> oldEmployees = new List<Employee>();
		static List<Employee> newEmployees = new List<Employee>();
		static object locker = new object();
		static void Main(string[] args)
		{
			oldEmployees = GetEmploieesList();
			FileDriver fileDriver = new FileDriver(oldEmployees,locker);
			Thread thread = new Thread(fileDriver.FileWriter);
			thread.Start();

			do
			{
				var employee = new Employee();

				Console.WriteLine("Введите имя нового сострудника:");
				employee.Name = Console.ReadLine();

				Console.WriteLine("Введите номер телефона нового сотрудника:");
				employee.Phone = Console.ReadLine();

				newEmployees.Add(employee);

				Console.WriteLine("Для выхода наберите Ok, иначе нажмите Enter");

			} while (Console.ReadLine() != "Ok");
		}

		private static List<Employee> GetEmploieesList()
		{
			var employees = new List<Employee>();
			for (int i = 0; i < 10; i++)
			{
				var employee = new Employee();
				employee.Name = $"Mister_{i}";
				employee.Phone = $"{7783700}i";
				employees.Add(employee);
			}
			return employees;
		}

	}
}
