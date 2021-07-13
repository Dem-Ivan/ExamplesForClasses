using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SemplForRegularExpresion
{
	class Program
	{
		private static List<User> users = new List<User>();
		static void Main(string[] args)
		{
			var patern = "[А-я][а-я]";
			var regex = new Regex(patern);

			do
			{
				Console.WriteLine("Введите имя");
				string name = Console.ReadLine();				

				if (regex.IsMatch(name))
				{
					Console.WriteLine("Введите возраст");
					int age = Convert.ToInt32(Console.ReadLine());

					AddNewUser(name, age);
				}
				else
					Console.WriteLine("Вы ввели не валидное имя!");				

				Console.WriteLine("Введите ok чтобы прервать цикл");				
			}
			while (Console.ReadLine() != "ok");

			foreach (var user in users)
			{
				Console.WriteLine($"User Name - {user.Name}, user age - {user.Age}");
			}
		}

		private static void AddNewUser(string name, int age)
		{
			var user = new User()
			{
				Name = name,
				Age = age
			};

			users.Add(user);
		}
	}
}
